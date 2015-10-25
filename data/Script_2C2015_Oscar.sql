USE GD2C2015_TEST; 

IF NOT EXISTS (SELECT schema_name 
               FROM   information_schema.schemata 
               WHERE  schema_name = 'SQLOVERS') 
  BEGIN 
      EXEC Sp_executesql 
        N'CREATE SCHEMA SQLOVERS' 
  END 


USE GD2C2015_TEST
GO

CREATE TABLE sqlovers.USUARIO 
  ( 
     user_username     NVARCHAR(255) NOT NULL PRIMARY KEY, 
     user_password     NVARCHAR(255), 
     user_nro_intentos NUMERIC(18, 0), 
     user_estado       bit,  -- tiene que ser booleano este campo
     user_rol_id       NUMERIC(18, 0) 
  ); 



-- agregar usuario admin con la password ya hasheada

INSERT INTO SQLOVERS.Usuario VALUES 
('admin', 'E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7', 0, 1,0); -- el ultimo parametro es 0 xq todaviano no esta definido el id de rol


-- SP para actualizar fallidos

CREATE PROCEDURE SQLOVERS.[updateIntentos](@intentos_login numeric(18, 0),@nombre varchar(25) )
AS BEGIN
  IF(@intentos_login = 3)
	BEGIN
	  UPDATE SQLOVERS.Usuario SET user_estado=0, user_nro_intentos=@intentos_login WHERE user_username=@nombre
	END
  ELSE
	BEGIN
	  UPDATE SQLOVERS.Usuario set user_nro_intentos=@intentos_login WHERE user_username=@nombre
	END
END

GO

--agrego columna a la tabla aeronaves para la baja

alter table SQLOVERS.VUELO ADD vuelo_estado bit NULL

alter table SQLOVERS.AERONAVE ADD aeronave_baja bit NULL

