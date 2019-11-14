CREATE PROCEDURE PASO_A_PASO.deshabilitarProveedor(@prov_id int) AS
BEGIN

DECLARE @user_id_prov int

SET @user_id_prov = (SELECT user_id FROM PASO_A_PASO.Proveedor JOIN PASO_A_PASO.Usuario ON user_id = prov_userId WHERE prov_id=@prov_id)

UPDATE PASO_A_PASO.Usuario SET user_status = 'D' WHERE user_id=@user_id_prov

END