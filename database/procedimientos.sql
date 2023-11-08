-- Apartado para las clausulas de creacion de procedimientos

-- PROCEDIMIENTO PARA LA BAJA DE EQUIPOS
DELIMITER //

CREATE PROCEDURE darBajaEquipo(
    IN p_imei INT
)
BEGIN

    DECLARE estado VARCHAR(25);
    
    SELECT e.ESTADO INTO estado
    FROM EQUIPO e
    WHERE e.IMEI = p_imei;

    IF estado != 'INHABILITADO' THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'Error: no se puede dar de baja al equipo porque se encuentra asignado.';
    END IF;
    
    INSERT INTO BAJAS_EQUIPOS (IMEI, FECHA_BAJA) 
    VALUES (p_imei, NOW());
    
    DELETE FROM EQUIPO WHERE IMEI = p_imei;

END //

DELIMITER ;

-- PROCEDIMIENTO PARA MIGRAR SIM
DELIMITER //

CREATE PROCEDURE migrarSIM(
    IN p_icc_actual VARCHAR(30), 
    IN p_icc_nueva VARCHAR(30)
    )
BEGIN

    DECLARE estado VARCHAR(25);

    SELECT s.ESTADO INTO estado
    FROM SIM s
    WHERE s.ICC = p_icc_actual;

    IF estado != 'INHABILITADO' THEN 
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: no se puede migrar porque la SIM se encuentra asignada.';
    END IF;

    UPDATE SIM 
    SET ICC = p_icc_nueva
    WHERE ICC = p_icc_actual;

    INSERT INTO MIGRACION_SIM (SIM_SIM_ID, ICC_ACTUAL, ICC_NUEVA, FECHA_MIGRACION)
    SELECT SIM_ID, p_icc_actual, p_icc_nueva, NOW() 
    FROM SIM
    WHERE ICC = p_icc_nueva;

END //

DELIMITER ;

-- PROCEDIMIENTO PARA ASGINAR SIM A EQUIPO
DELIMITER //

CREATE PROCEDURE asignarSIM(
    IN p_icc_sim VARCHAR(30), 
    IN p_imei_equipo INT
)
BEGIN

    DECLARE estado_sim VARCHAR(25);
    DECLARE estado_equipo VARCHAR(25);

    SELECT s.ESTADO INTO estado_sim
    FROM SIM s
    WHERE s.ICC = p_icc_sim;

    SELECT e.ESTADO INTO estado_equipo 
    FROM EQUIPO e
    WHERE e.IMEI = p_imei_equipo;

    IF estado_sim != 'INHABILITADO' THEN 
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: al asignar la SIM (SIM asignada)';
    END IF;

    IF estado_equipo != 'INHABILITADO' THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'Error: al asignar la SIM (Equipo asignado)';
    END IF;

    INSERT INTO ASIGNACION_SIM(EQUIPO_EQUI_ID, SIM_SIM_ID, FECHA_ASIGNACION_SIM)
    SELECT EQUIPO.EQUI_ID, SIM.SIM_ID, NOW()
    FROM EQUIPO 
    INNER JOIN SIM ON EQUIPO.IMEI = p_imei_equipo AND SIM.ICC = p_icc_sim
    LIMIT 1;

    UPDATE EQUIPO 
    SET ESTADO = 'HABILITADO' 
    WHERE IMEI = p_imei_equipo;

    UPDATE SIM
    SET ESTADO = 'HABILITADO'
    WHERE ICC = p_icc_sim;

END//

DELIMITER ;

-- PROCEDIMIENTO PARA DESASIGNAR SIM DE EQUIPO
DELIMITER //
CREATE PROCEDURE desasignarSIM(
    IN p_imei_equipo INT,
    IN p_icc_sim VARCHAR(30)
)
BEGIN
    DECLARE estado_equipo VARCHAR(25);
    
    SELECT ESTADO INTO estado_equipo
    FROM EQUIPO
    WHERE IMEI = p_imei_equipo;

    IF estado_equipo = 'ACTIVADO' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: no se puede desasignar la SIM (equipo asignado a activo).'; 
    END IF;

    DELETE FROM ASIGNACION_SIM
    WHERE EQUIPO_EQUI_ID = (SELECT EQUI_ID FROM EQUIPO WHERE IMEI = p_imei_equipo);
        
    UPDATE SIM SET ESTADO = 'INHABILITADO' 
    WHERE ICC = p_icc_sim;

    UPDATE EQUIPO  SET ESTADO = 'INHABILITADO'
    WHERE IMEI = p_imei_equipo;
  
END//

DELIMITER ;

-- PROCEDIMIENTO PARA ASIGNAR EQUIPO A ACTIVO 
DELIMITER //
CREATE PROCEDURE asignarEquipo(
  IN placa_activo VARCHAR(10),
  IN imei_equipo INT,
  IN plataforma VARCHAR(50),
  IN adquisicion VARCHAR(25)
)
BEGIN

    DECLARE estado_activo VARCHAR(25);
    DECLARE estado_equipo VARCHAR(25);

    SELECT a.ESTADO INTO estado_activo
    FROM ACTIVO a 
    WHERE a.PLACA = placa_activo;

    SELECT e.ESTADO INTO estado_equipo
    FROM EQUIPO e
    WHERE e.IMEI = imei_equipo;

    IF estado_activo != 'INHABILITADO' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: al asignar el activo (activo asignado).';
    END IF;

    IF estado_equipo != 'HABILITADO' THEN 
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: al asignar el activo (equipo asignado a cliente o el equipo no contiene SIM asignada).';
    END IF;

    -- Primero se inserta la asignacion a ASIGNACION_EQUIPO
    INSERT INTO ASIGNACION_EQUIPO(ACTIVO_ACT_ID, EQUIPO_EQUI_ID, ESTADO, FECHA_ASIGNACION_EQUIPO)
    SELECT (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo), AEI.EQUIPO_EQUI_ID, adquisicion, NOW()
    FROM ASIGNACION_SIM AEI
    WHERE AEI.EQUIPO_EQUI_ID = (SELECT EQUI_ID FROM EQUIPO WHERE IMEI = imei_equipo)
    LIMIT 1;

    -- Luego se inserta la asignacion a ASIGNACION_PLATAFORMA
    INSERT INTO ASIGNACION_PLATAFORMA(ACTIVO_ACT_ID, PLATAFORMA_PLAT_ID, FECHA_ASIGNACION)  
    SELECT AE.ACTIVO_ACT_ID,  (SELECT PLAT_ID FROM PLATAFORMA WHERE NOMBRE = plataforma), NOW()
    FROM ASIGNACION_EQUIPO AE 
    WHERE AE.ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo)
    LIMIT 1;

    -- Luego se actualiza el estado del activo y del equipo
    UPDATE EQUIPO SET ESTADO = 'ACTIVADO'
    WHERE IMEI = imei_equipo;

    UPDATE ACTIVO  SET ESTADO = 'HABILITADO'
    WHERE PLACA = placa_activo;

END//
DELIMITER ; 

-- PROCEDIMIENTO PARA DESASIGNAR EQUIPO
DELIMITER //
CREATE PROCEDURE desasignarEquipo(
    IN placa_activo VARCHAR(10),
    IN imei_equipo INT
)
BEGIN

    DECLARE estado VARCHAR(25);
  
    SELECT a.ESTADO INTO estado
    FROM ACTIVO a
    WHERE a.PLACA = placa_activo;

    IF estado = 'ACTIVADO' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: al desasignar el equipo (activo asignado a cliente).';
    END IF;

    -- Eliminamos la asignacion de plataforma
    DELETE FROM ASIGNACION_PLATAFORMA
    WHERE ACTIVO_ACT_ID = (SELECT ACTIVO_ACT_ID FROM ASIGNACION_EQUIPO
    WHERE ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo))
    LIMIT 1;
    
    -- Eliminamos la asignacion de equipo
    DELETE FROM ASIGNACION_EQUIPO 
    WHERE ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo)
    AND EQUIPO_EQUI_ID = (SELECT EQUIPO_EQUI_ID FROM ASIGNACION_SIM 
    WHERE EQUIPO_EQUI_ID = (SELECT EQUI_ID FROM EQUIPO WHERE IMEI = imei_equipo))
    LIMIT 1;
                        
    -- Se cambia los estados del activo y del equipo
    UPDATE ACTIVO SET ESTADO = 'INHABILITADO' 
    WHERE PLACA = placa_activo;
    
    UPDATE EQUIPO SET ESTADO = 'HABILITADO'
    WHERE IMEI = imei_equipo;
        
  
END//

DELIMITER ;


-- PROCEDIMIENTO PARA LA ASIGNACION DE ACTIVOS
DELIMITER //
CREATE PROCEDURE asignarActivo(
    IN nombre_cliente VARCHAR(100),
    IN placa_activo VARCHAR(10)
)
BEGIN

    -- Insertamos a la tabla ASIGNACION:ACTIVO
    INSERT INTO ASIGNACION_ACTIVO(CLIENTE_CLI_ID, ACTIVO_ACT_ID, FECHA) 
    SELECT C.CLI_ID, AE.ACTIVO_ACT_ID, NOW()
    FROM CLIENTE C
    INNER JOIN ASIGNACION_EQUIPO AE ON AE.ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo)
    WHERE C.NOMBRE = nombre_cliente
    LIMIT 1;

    -- Cambiamos el estado del activo
    UPDATE ACTIVO SET ESTADO = 'ACTIVADO' 
    WHERE PLACA = placa_activo;
  
END//

DELIMITER ;

-- PROCEDIMIENTO PARA DESASIGNAR ACTIVOS
DELIMITER //
CREATE PROCEDURE desasignarActivo(
    IN nombre_cliente VARCHAR(100),
    IN placa_activo VARCHAR(10)
)
BEGIN

    DECLARE estado VARCHAR(25);

    SELECT a.ESTADO INTO estado
    FROM ACTIVO a
    WHERE a.PLACA = placa_activo;

    IF estado != 'ACTIVADO' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el activo no ha sido asignado a un cliente.';
    END IF;

    -- Eliminamos el registro de la tabla ASIGNACION_ACTIVO
    DELETE FROM ASIGNACION_ACTIVO
    WHERE CLIENTE_CLI_ID = (SELECT CLI_ID FROM CLIENTE WHERE NOMBRE = nombre_cliente)
    AND ACTIVO_ACT_ID = (SELECT ACTIVO_ACT_ID FROM ASIGNACION_EQUIPO 
                            WHERE ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo))
                            LIMIT 1;
                            
    UPDATE ACTIVO SET ESTADO = 'HABILITADO'
    WHERE PLACA = placa_activo;
  
END//  

DELIMITER ;