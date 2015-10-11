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
IF Object_id('SQLOVERS.Pasaje') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.pasaje; 
  END; 

IF Object_id('SQLOVERS.Cliente') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.cliente; 
  END; 

IF Object_id('SQLOVERS.Usuario') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.usuario; 
  END; 

IF Object_id('SQLOVERS.Ruta') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.ruta; 
  END; 

IF Object_id('SQLOVERS.Ciudad') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.ciudad; 
  END; 

IF Object_id('SQLOVERS.tipo_servicio') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.tipo_servicio; 
  END; 

/*     
CREATE TABLES     
*/ 
CREATE TABLE sqlovers.tipo_servicio 
  ( 
     tipo_servicio_id     NUMERIC(3, 0) IDENTITY NOT NULL PRIMARY KEY, 
     tipo_servicio_nombre NVARCHAR(255) 
  ) 

CREATE TABLE sqlovers.ciudad 
  ( 
     ciudad_id     NUMERIC(6, 0) IDENTITY NOT NULL PRIMARY KEY, 
     ciudad_nombre NVARCHAR(255) 
  ) 

CREATE TABLE sqlovers.usuario 
  ( 
     user_username     NVARCHAR(255) NOT NULL PRIMARY KEY, 
     user_password     NVARCHAR(255), 
     user_nro_intentos NUMERIC(18, 0), 
     user_estado       NUMERIC(1, 0), 
     user_rol_id       NUMERIC(18, 0) 
  ); 

CREATE TABLE sqlovers.cliente 
  ( 
     cli_nombre    NVARCHAR(255), 
     cli_apellido  NVARCHAR(255), 
     cli_dni       NUMERIC(18, 0) NOT NULL PRIMARY KEY, 
     cli_dir       NVARCHAR(255), 
     cli_telefono  NUMERIC(18, 0), 
     cli_mail      NVARCHAR(255), 
     cli_fecha_nac DATETIME, 
     cli_username  NVARCHAR(255) FOREIGN KEY REFERENCES 
     sqlovers.usuario(user_username) 
  ); 

CREATE TABLE sqlovers.pasaje 
  ( 
     pasaje_codigo      NUMERIC(18, 0) NOT NULL PRIMARY KEY, 
     pasaje_precio      NUMERIC(18, 2), 
     pasaje_fechacompra DATETIME, 
     cli_dni            NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.cliente(cli_dni) 
  ) 

CREATE TABLE sqlovers.ruta 
  ( 
     ruta_id                NUMERIC(18, 0) NOT NULL IDENTITY PRIMARY KEY, 
     ruta_ciudad_origen     NUMERIC(6, 0) FOREIGN KEY REFERENCES 
     sqlovers.ciudad(ciudad_id), 
     ruta_ciudad_destino    NUMERIC(6, 0) FOREIGN KEY REFERENCES 
     sqlovers.ciudad(ciudad_id), 
     ruta_tipo_servicio     NUMERIC(3, 0) FOREIGN KEY REFERENCES 
     sqlovers.tipo_servicio(tipo_servicio_id), 
     ruta_precio_basepasaje NUMERIC(18, 0), 
     ruta_precio_basekg     NUMERIC(18, 0) 
  ) 

/*    
FILL TABLES    
*/ 
INSERT INTO sqlovers.tipo_servicio 
            (tipo_servicio_nombre) 
SELECT DISTINCT tipo_servicio 
FROM   gd_esquema.maestra 

INSERT INTO sqlovers.ciudad 
            (ciudad_nombre) 
SELECT DISTINCT ruta_ciudad_origen 
FROM   gd_esquema.maestra 

INSERT INTO sqlovers.ruta 
            (ruta_precio_basekg, 
             ruta_ciudad_destino, 
             ruta_ciudad_origen, 
             ruta_precio_basepasaje, 
             ruta_tipo_servicio) 
SELECT DISTINCT (SELECT Max(ruta_precio_basekg) 
                 FROM   gd_esquema.maestra m2 
                 WHERE  m2.ruta_ciudad_destino = m1.ruta_ciudad_destino 
                        AND m2.ruta_ciudad_origen = m1.ruta_ciudad_origen 
                        AND m2.tipo_servicio = m1.tipo_servicio) AS 
                Ruta_Precio_BaseKG, 
                (SELECT ciudad_id 
                 FROM   sqlovers.ciudad 
                 WHERE  ruta_ciudad_destino = ciudad.ciudad_nombre), 
                (SELECT ciudad_id 
                 FROM   sqlovers.ciudad 
                 WHERE  ruta_ciudad_origen = ciudad.ciudad_nombre), 
                (SELECT Max(ruta_precio_basepasaje) 
                 FROM   gd_esquema.maestra m2 
                 WHERE  m2.ruta_ciudad_destino = m1.ruta_ciudad_destino 
                        AND m2.ruta_ciudad_origen = m1.ruta_ciudad_origen 
                        AND m2.tipo_servicio = m1.tipo_servicio) AS 
                Ruta_Precio_BasePasaje, 
                (SELECT tipo_servicio_id 
                 FROM   sqlovers.tipo_servicio 
                 WHERE  tipo_servicio = tipo_servicio_nombre) 
FROM   [GD2C2015].[gd_esquema].[maestra] m1 
WHERE  m1.ruta_ciudad_destino != m1.ruta_ciudad_origen 

INSERT INTO sqlovers.usuario 
            (user_username, 
             user_password, 
             user_nro_intentos, 
             user_estado, 
             user_rol_id) 
SELECT Lower(Replace(cli_nombre, ' ', '.') + '.' 
             + Replace(cli_apellido, ' ', '.') 
             + CONVERT(VARCHAR(20), cli_dni)), 
       Hashbytes('SHA2_256', CONVERT(VARCHAR(20), cli_dni)), 
       0, 
       1, 
       NULL 
FROM   (SELECT cli_nombre, 
               cli_apellido, 
               cli_dni, 
               cli_dir, 
               cli_telefono, 
               cli_mail, 
               cli_fecha_nac, 
               Row_number() 
                 OVER ( 
                   partition BY cli_dni 
                   ORDER BY cli_dni) AS RowNumber 
        FROM   gd_esquema.maestra) AS a 
WHERE  a.rownumber = 1 

INSERT INTO sqlovers.cliente 
            (cli_nombre, 
             cli_apellido, 
             cli_dni, 
             cli_dir, 
             cli_telefono, 
             cli_mail, 
             cli_fecha_nac, 
             cli_username) 
SELECT cli_nombre, 
       cli_apellido, 
       cli_dni, 
       cli_dir, 
       cli_telefono, 
       cli_mail, 
       cli_fecha_nac, 
       Lower(Replace(cli_nombre, ' ', '.') + '.' 
             + Replace(cli_apellido, ' ', '.') 
             + CONVERT(VARCHAR(20), cli_dni)) 
FROM   (SELECT cli_nombre, 
               cli_apellido, 
               cli_dni, 
               cli_dir, 
               cli_telefono, 
               cli_mail, 
               cli_fecha_nac, 
               Row_number() 
                 OVER ( 
                   partition BY cli_dni 
                   ORDER BY cli_dni) AS RowNumber 
        FROM   gd_esquema.maestra) AS a 
WHERE  a.rownumber = 1 

--INSERT INTO sqlovers.usuario(cli_dni, cli_usuario, cli_password)  
--VALUES (00000000, 'admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')  
INSERT INTO sqlovers.pasaje 
            (pasaje_codigo, 
             pasaje_precio, 
             pasaje_fechacompra, 
             cli_dni) 
SELECT pasaje_codigo, 
       pasaje_precio, 
       pasaje_fechacompra, 
       cli_dni 
FROM   gd_esquema.maestra 
WHERE  pasaje_codigo != 0 