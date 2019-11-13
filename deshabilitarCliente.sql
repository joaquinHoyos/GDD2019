CREATE PROCEDURE PASO_A_PASO.deshabilitarCliente(@clie_id int) AS
BEGIN

DECLARE @user_id_del_cliente int

SET @user_id_del_cliente = (SELECT user_id FROM PASO_A_PASO.Cliente JOIN PASO_A_PASO.Usuario ON user_id = clie_userId WHERE clie_id=@clie_id)

UPDATE PASO_A_PASO.Usuario SET user_status = 'D' WHERE user_id=@user_id_del_cliente

END