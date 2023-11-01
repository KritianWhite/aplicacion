-- Apartado para las clausulas de creacion de procedimientos

-- PROCEDIMIENTO PARA LA BAJA DE EQUIPOS
DELIMITER //

CREATE PROCEDURE darBajaEquipo(
    IN p_imei INT
)
BEGIN 
    DECLARE fecha_baja DATETIME;
  
    SELECT NOW() INTO fecha_baja;
    
    INSERT INTO BAJAS_EQUIPOS (IMEI, FECHA_BAJA) 
    VALUES (p_imei, fecha_baja);

    DELETE FROM EQUIPO 
    WHERE IMEI = p_imei;

END //

DELIMITER ;

-- PROCEDIMIENTO PARA MIGRAR SIM
DELIMITER //

CREATE PROCEDURE migrarSIM(
    IN p_icc_actual VARCHAR(30), 
    IN p_icc_nueva VARCHAR(30)
    )
BEGIN
    UPDATE SIM 
    SET ICC = p_icc_nueva
    WHERE ICC = p_icc_actual;
    
    INSERT INTO MIGRACION_SIM (SIM_SIM_ID, ICC_ACTUAL, ICC_NUEVA, FECHA_MIGRACION)
    SELECT SIM_ID, p_icc_actual, p_icc_nueva, NOW() 
    FROM SIM
    WHERE ICC = p_icc_nueva;

END //

DELIMITER ;