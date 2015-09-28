USE gd2c2015; 

IF NOT EXISTS (SELECT schema_name 
               FROM   information_schema.schemata 
               WHERE  schema_name = 'SQLOVERS') 
  BEGIN 
      EXEC Sp_executesql 
        N'CREATE SCHEMA SQLOVERS' 
  END 

/*  
DROP ALL THE TABLES!!!  
*/ 
IF Object_id('SQLOVERS.Usuario') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.usuario; 
  END; 

/*  
CREATE TABLES  
*/ 
CREATE TABLE sqlovers.usuario 
  ( 
     cli_nombre    NVARCHAR(255), 
     cli_apellido  NVARCHAR(255), 
     cli_dni       NUMERIC(18, 0), 
     cli_dir       NVARCHAR(255), 
     cli_telefono  NUMERIC(18, 0), 
     cli_mail      NVARCHAR(255), 
     cli_fecha_nac DATETIME, 
     CONSTRAINT pk_usuario PRIMARY KEY (cli_nombre, cli_apellido, cli_dni) 
  ); 

/* 
FILL TABLES 
*/ 
INSERT INTO sqlovers.usuario 
            (cli_nombre, 
             cli_apellido, 
             cli_dni, 
             cli_dir, 
             cli_telefono, 
             cli_mail, 
             cli_fecha_nac) 
SELECT DISTINCT cli_nombre, 
                cli_apellido, 
                cli_dni, 
                cli_dir, 
                cli_telefono, 
                cli_mail, 
                cli_fecha_nac 
FROM   gd_esquema.maestra
