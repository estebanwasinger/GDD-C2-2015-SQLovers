﻿USE gd2c2015; 

IF NOT EXISTS (SELECT schema_name 
               FROM   information_schema.SCHEMATA 
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
      DROP TABLE sqlovers.PASAJE; 
  END; 

IF Object_id('SQLOVERS.encomienda') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.ENCOMIENDA; 
  END; 

IF Object_id('SQLOVERS.LLEGADA_DESTINO') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.LLEGADA_DESTINO; 
  END; 

IF Object_id('SQLOVERS.Vuelo') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.VUELO; 
  END; 

IF Object_id('SQLOVERS.Cliente') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.CLIENTE; 
  END; 

IF Object_id('SQLOVERS.Usuario') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.USUARIO; 
  END; 

IF Object_id('SQLOVERS.funcionalidad_rol') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.FUNCIONALIDAD_ROL; 
  END; 

IF Object_id('SQLOVERS.Rol') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.ROL; 
  END; 

IF Object_id('SQLOVERS.Funcionalidad') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.FUNCIONALIDAD; 
  END; 

IF Object_id('SQLOVERS.Ruta') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.RUTA; 
  END; 

IF Object_id('SQLOVERS.butaca') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.BUTACA; 
  END; 

IF Object_id('SQLOVERS.Ciudad') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.CIUDAD; 
  END; 

IF Object_id('SQLOVERS.aeronave_bajas') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.AERONAVE_BAJAS; 
  END; 

IF Object_id('SQLOVERS.aeronave') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.AERONAVE; 
  END; 

IF Object_id('SQLOVERS.tipo_servicio') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.TIPO_SERVICIO; 
  END; 

IF Object_id('SQLOVERS.TIPO_BAJA') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.TIPO_BAJA; 
  END; 

/*              
DROP ALL THE FUNCTIONS AND PROCEDURES!!!              
*/ 
IF Object_id('SQLOVERS.UpdateIntentos') IS NOT NULL 
  BEGIN 
      DROP PROCEDURE sqlovers.updateintentos; 
  END; 

IF Object_id('SQLOVERS.SP_CARGAR_BUTACAS') IS NOT NULL 
  BEGIN 
      DROP PROCEDURE sqlovers.sp_cargar_butacas; 
  END; 

IF Object_id('SQLOVERS.reemplazar_vuelo') IS NOT NULL 
  BEGIN 
      DROP PROCEDURE sqlovers.reemplazar_vuelo; 
  END; 

IF Object_id('SQLOVERS.validar_fechaSalida') IS NOT NULL 
  BEGIN 
      DROP FUNCTION sqlovers.validar_fechasalida; 
  END; 

IF Object_id('SQLOVERS.estadoAeronave') IS NOT NULL 
  BEGIN 
      DROP FUNCTION sqlovers.estadoaeronave; 
  END; 

IF Object_id('SQLOVERS.existeRuta') IS NOT NULL 
  BEGIN 
      DROP FUNCTION sqlovers.existeruta; 
  END; 

IF Object_id('SQLOVERS.Cantidadkgdisponibles') IS NOT NULL 
  BEGIN 
      DROP FUNCTION sqlovers.cantidadkgdisponibles; 
  END; 

IF Object_id('SQLOVERS.darBajaTecnica') IS NOT NULL 
  BEGIN 
      DROP PROCEDURE sqlovers.darbajatecnica; 
  END; 

IF Object_id('SQLOVERS.EXISTE_VUELO') IS NOT NULL 
  BEGIN 
      DROP FUNCTION sqlovers.existe_vuelo; 
  END; 

IF Object_id('SQLOVERS.Butacasdisponibles') IS NOT NULL 
  BEGIN 
      DROP FUNCTION sqlovers.Butacasdisponibles; 
  END; 

/*              
CREATE TABLES              
*/ 
CREATE TABLE sqlovers.ROL 
  ( 
     rol_id     NUMERIC(3, 0) IDENTITY NOT NULL PRIMARY KEY, 
     rol_name   NVARCHAR(255), 
     rol_activo BINARY 
  ) 

CREATE TABLE sqlovers.FUNCIONALIDAD 
  ( 
     funcionalidad_id   NUMERIC(3, 0) IDENTITY NOT NULL PRIMARY KEY, 
     funcionalidad_desc NVARCHAR(255) 
  ) 

CREATE TABLE sqlovers.FUNCIONALIDAD_ROL 
  ( 
     rol_id           NUMERIC(3, 0) FOREIGN KEY REFERENCES sqlovers.ROL(rol_id), 
     funcionalidad_id NUMERIC(3, 0) FOREIGN KEY REFERENCES 
     sqlovers.FUNCIONALIDAD(funcionalidad_id) 
  ) 

CREATE TABLE sqlovers.TIPO_SERVICIO 
  ( 
     tipo_servicio_id     NUMERIC(3, 0) IDENTITY NOT NULL PRIMARY KEY, 
     tipo_servicio_nombre NVARCHAR(255) 
  ) 

CREATE TABLE sqlovers.TIPO_BAJA 
  ( 
     tipo_baja_id      NUMERIC(3, 0) IDENTITY NOT NULL PRIMARY KEY, 
     tipo_baja_detalle NVARCHAR(255), 
  ) 

CREATE TABLE sqlovers.AERONAVE 
  ( 
     aeronave_matricula            NVARCHAR(255) PRIMARY KEY NOT NULL, 
     aeronave_modelo               NVARCHAR(255), 
     aeronave_kg_disponibles       NUMERIC(18, 0), 
     aeronave_fecha_alta           DATETIME NULL, 
     aeronave_fabricante           NVARCHAR(255), 
     aeronave_tipo_servicio        NUMERIC(3, 0) FOREIGN KEY REFERENCES 
     sqlovers.TIPO_SERVICIO(tipo_servicio_id), 
     aeronave_but_vent             NUMERIC(18, 0), 
     aeronave_but_pasill           NUMERIC(18, 0), 
     aeronave_fecha_bajadefinitiva DATETIME, 
     aeronave_estado               NUMERIC(3, 0) FOREIGN KEY REFERENCES 
     sqlovers.TIPO_BAJA(tipo_baja_id) 
  ) 

CREATE TABLE sqlovers.AERONAVE_BAJAS 
  ( 
     aeronave_baja_id                NUMERIC(18, 0) IDENTITY(1, 1) NOT NULL 
     PRIMARY KEY, 
     aeronave_baja_fecha_vueltafs    DATETIME, 
     aeronave_baja_fecha_bajatecnica DATETIME, 
     aeronave_matricula              NVARCHAR(255) FOREIGN KEY REFERENCES 
     sqlovers.AERONAVE(aeronave_matricula) 
  ) 

CREATE TABLE sqlovers.BUTACA 
  ( 
     butaca_nro      NUMERIC(18, 0), 
     butaca_tipo     NVARCHAR(255), 
     butaca_piso     NUMERIC(18, 0), 
     butaca_aeronave NVARCHAR(255) FOREIGN KEY REFERENCES 
     sqlovers.AERONAVE(aeronave_matricula), 
     CONSTRAINT pk_butaca_aeronave PRIMARY KEY (butaca_nro, butaca_aeronave) 
  ) 

CREATE TABLE sqlovers.CIUDAD 
  ( 
     ciudad_id     NUMERIC(6, 0) IDENTITY NOT NULL PRIMARY KEY, 
     ciudad_nombre NVARCHAR(255), 
     ciudad_estado BIT 
  ) 

CREATE TABLE sqlovers.USUARIO 
  ( 
     user_username     NVARCHAR(255) NOT NULL PRIMARY KEY, 
     user_password     NVARCHAR(255), 
     user_nro_intentos NUMERIC(18, 0), 
     user_estado       BIT, 
     user_rol_id       NUMERIC(3, 0) FOREIGN KEY REFERENCES sqlovers.ROL(rol_id) 
  ); 

CREATE TABLE sqlovers.CLIENTE 
  ( 
     cli_nombre    NVARCHAR(255), 
     cli_apellido  NVARCHAR(255), 
     cli_dni       NUMERIC(18, 0) NOT NULL PRIMARY KEY, 
     cli_dir       NVARCHAR(255), 
     cli_telefono  NUMERIC(18, 0), 
     cli_mail      NVARCHAR(255), 
     cli_fecha_nac DATETIME, 
     cli_username  NVARCHAR(255) FOREIGN KEY REFERENCES 
     sqlovers.USUARIO(user_username) 
  ); 

CREATE TABLE sqlovers.RUTA 
  ( 
     ruta_id                NUMERIC(18, 0) NOT NULL IDENTITY PRIMARY KEY, 
     ruta_ciudad_origen     NUMERIC(6, 0) FOREIGN KEY REFERENCES 
     sqlovers.CIUDAD(ciudad_id), 
     ruta_ciudad_destino    NUMERIC(6, 0) FOREIGN KEY REFERENCES 
     sqlovers.CIUDAD(ciudad_id), 
     ruta_precio_basepasaje NUMERIC(18, 0), 
     ruta_precio_basekg     NUMERIC(18, 0), 
     ruta_estado            BIT, 
     ruta_tipo_servicio     NUMERIC(3, 0) FOREIGN KEY REFERENCES 
     sqlovers.TIPO_SERVICIO(tipo_servicio_id) 
  ) 

CREATE TABLE sqlovers.VUELO 
  ( 
     vuelo_id                     NUMERIC(18, 0) IDENTITY PRIMARY KEY, 
     vuelo_fecha_salida           DATETIME, 
     vuelo_fecha_llegada          DATETIME, 
     vuelo_fecha_llegada_estimada DATETIME, 
     vuelo_cancelado              BIT NOT NULL, 
     vuelo_aeronave_id            NVARCHAR(255) FOREIGN KEY REFERENCES 
     sqlovers.AERONAVE(aeronave_matricula), 
     vuelo_ruta_id                NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.RUTA(ruta_id) 
  ) 

CREATE TABLE sqlovers.ENCOMIENDA 
  ( 
     encomienda_id           INT PRIMARY KEY IDENTITY, 
     encomienda_kg           INT, 
     encomienda_cliente_dni  NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.CLIENTE(cli_dni), 
     encomienda_vuelo_id     NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.VUELO(vuelo_id), 
     encomienda_precio_total INT 
  ) 

CREATE TABLE sqlovers.PASAJE 
  ( 
     pasaje_codigo      NUMERIC(18, 0) IDENTITY NOT NULL PRIMARY KEY, 
     pasaje_precio      NUMERIC(18, 2), 
     pasaje_fechacompra DATETIME, 
     cli_dni            NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.CLIENTE(cli_dni), 
     pasaje_vuelo_id    NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.VUELO(vuelo_id), 
     pasaje_cancelado   BIT NOT NULL,
	 pasaje_butaca_nro NUMERIC(3,0) 
  ) 

CREATE TABLE sqlovers.LLEGADA_DESTINO 
  ( 
     llegada_codigo     NUMERIC(18, 0) IDENTITY NOT NULL PRIMARY KEY, 
     llegada_matricula  NVARCHAR(255) FOREIGN KEY REFERENCES 
     sqlovers.AERONAVE(aeronave_matricula), 
     llegada_horaarrivo DATETIME, 
     llegada_origen     NUMERIC(6, 0) FOREIGN KEY REFERENCES 
     sqlovers.CIUDAD(ciudad_id), 
     llegada_destino    NUMERIC(6, 0) FOREIGN KEY REFERENCES 
     sqlovers.CIUDAD(ciudad_id), 
     llegada_vuelo_id   NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.VUELO(vuelo_id), 
  ) 

/*             
FILL TABLES             
*/ 
INSERT INTO sqlovers.TIPO_BAJA 
            (tipo_baja_detalle) 
VALUES      ('Baja Fuera de Servicio'), 
            ('Baja Definitiva') 

INSERT INTO sqlovers.ROL 
            (rol_name, 
             rol_activo) 
VALUES      ('Admin', 
             1), 
            ('User', 
             1) 

INSERT INTO sqlovers.TIPO_SERVICIO 
            (tipo_servicio_nombre) 
SELECT DISTINCT tipo_servicio 
FROM   gd_esquema.MAESTRA 

INSERT INTO sqlovers.AERONAVE 
            (aeronave_matricula, 
             aeronave_modelo, 
             aeronave_fabricante, 
             aeronave_kg_disponibles, 
             aeronave_tipo_servicio) 
SELECT DISTINCT aeronave_matricula, 
                aeronave_modelo, 
                aeronave_fabricante, 
                aeronave_kg_disponibles, 
                ts.tipo_servicio_id 
FROM   [GD2C2015].[gd_esquema].[MAESTRA], 
       sqlovers.TIPO_SERVICIO ts 
WHERE  tipo_servicio = ts.tipo_servicio_nombre 

INSERT INTO sqlovers.BUTACA 
            (butaca_nro, 
             butaca_piso, 
             butaca_tipo, 
             butaca_aeronave) 
SELECT DISTINCT butaca_nro, 
                butaca_piso, 
                butaca_tipo, 
                aeronave_matricula 
FROM   [GD2C2015].[gd_esquema].[MAESTRA] 
WHERE  butaca_nro != 0 

INSERT INTO sqlovers.CIUDAD 
            (ciudad_nombre, 
             ciudad_estado) 
SELECT DISTINCT ruta_ciudad_origen, 
                1 
FROM   gd_esquema.MAESTRA 

INSERT INTO sqlovers.RUTA 
            (ruta_precio_basekg, 
             ruta_ciudad_destino, 
             ruta_ciudad_origen, 
             ruta_precio_basepasaje, 
             ruta_tipo_servicio, 
             ruta_estado) 
SELECT Max(m1.ruta_precio_basekg), 
       c1.ciudad_id, 
       c2.ciudad_id, 
       Max(m1.ruta_precio_basepasaje), 
       ts.tipo_servicio_id, 
       1 
FROM   [GD2C2015].[gd_esquema].[MAESTRA] m1, 
       sqlovers.CIUDAD c1, 
       sqlovers.CIUDAD c2, 
       sqlovers.TIPO_SERVICIO ts 
WHERE  m1.ruta_ciudad_destino != m1.ruta_ciudad_origen 
       AND c1.ciudad_nombre = m1.ruta_ciudad_destino 
       AND c2.ciudad_nombre = m1.ruta_ciudad_origen 
       AND ts.tipo_servicio_nombre = m1.tipo_servicio 
GROUP  BY c1.ciudad_id, 
          c2.ciudad_id, 
          m1.ruta_ciudad_destino, 
          m1.ruta_ciudad_origen, 
          m1.tipo_servicio, 
          ts.tipo_servicio_id 

INSERT INTO sqlovers.USUARIO 
            (user_username, 
             user_password, 
             user_nro_intentos, 
             user_estado, 
             user_rol_id) 
SELECT Lower(Replace(cli_nombre, ' ', '.') + '.' 
             + Replace(cli_apellido, ' ', '.') 
             + CONVERT(VARCHAR(20), cli_dni)), 
       '', 
       0, 
       1, 
       2 
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
        FROM   gd_esquema.MAESTRA) AS a 
WHERE  a.rownumber = 1 

INSERT INTO sqlovers.CLIENTE 
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
        FROM   gd_esquema.MAESTRA) AS a 
WHERE  a.rownumber = 1 

INSERT INTO sqlovers.FUNCIONALIDAD 
            (funcionalidad_desc) 
VALUES      ('Login y Seguridad'), 
            ('Registro de usuario'), 
            ('ABM Ciudades'), 
            ('ABM Ruta Aerea'), 
            ('ABM Aeronaves'), 
            ('Generar viaje'), 
            ('Registro de llegada a destino'), 
            ('Compra pasaje / encomienda'), 
            ('Cancelación / devolución de pasaje'), 
            ('Consulta de millas'), 
            ('Canje de millas'), 
            ('Listado estadístico') 

--INSERT INTO sqlovers.usuario(cli_dni, cli_usuario, cli_password)         
--VALUES (00000000, 'admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')   

INSERT INTO sqlovers.VUELO 
            (vuelo_fecha_llegada, 
             vuelo_fecha_llegada_estimada, 
             vuelo_fecha_salida, 
             vuelo_aeronave_id, 
             vuelo_ruta_id, 
             vuelo_cancelado) 
SELECT DISTINCT fechallegada, 
                fecha_llegada_estimada, 
                m.fechasalida, 
                m.aeronave_matricula, 
                r.ruta_id, 
                0 
FROM   [GD2C2015].[gd_esquema].[MAESTRA] m, 
       sqlovers.RUTA r, 
       sqlovers.CIUDAD c, 
       sqlovers.CIUDAD c2 
WHERE  pasaje_precio > 0 
       AND pasaje_codigo != 0 
       AND c.ciudad_id = r.ruta_ciudad_destino 
       AND c2.ciudad_id = r.ruta_ciudad_origen 
       AND m.ruta_ciudad_destino = c.ciudad_nombre 
       AND m.ruta_ciudad_origen = c2.ciudad_nombre 

-- agregar usuario admin con la password ya hasheada       
INSERT INTO sqlovers.USUARIO 
VALUES      ('admin', 
             'E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7', 
             0, 
             1, 
             1); 

go 
SET IDENTITY_INSERT sqlovers.pasaje ON 

INSERT INTO sqlovers.pasaje 
            (pasaje_codigo, 
             pasaje_precio, 
             pasaje_fechacompra, 
             cli_dni, 
             pasaje_vuelo_id, 
             pasaje_cancelado,
			 pasaje_butaca_nro) 
SELECT pasaje_codigo, 
       pasaje_precio, 
       pasaje_fechacompra, 
       cli_dni, 
       (SELECT TOP 1 v.vuelo_id 
        FROM   sqlovers.vuelo v 
        WHERE  v.vuelo_fecha_llegada = m.fechallegada 
               AND v.vuelo_fecha_llegada_estimada = m.fecha_llegada_estimada 
               AND v.vuelo_fecha_salida = m.fechasalida 
               AND v.vuelo_aeronave_id = m.aeronave_matricula), 
       0,
	   Butaca_Nro 
FROM   [GD2C2015].[gd_esquema].[maestra] m 
WHERE  pasaje_codigo != 0 

SET IDENTITY_INSERT sqlovers.pasaje OFF 
SET IDENTITY_INSERT sqlovers.encomienda ON 

INSERT INTO sqlovers.ENCOMIENDA 
            (encomienda_id, 
             encomienda_kg, 
             encomienda_cliente_dni, 
             encomienda_vuelo_id, 
             encomienda_precio_total) 
SELECT m.paquete_codigo, 
       m.paquete_kg, 
       m.cli_dni, 
       (SELECT TOP 1 v.vuelo_id 
        FROM   sqlovers.VUELO v 
        WHERE  v.vuelo_fecha_llegada = m.fechallegada 
               AND v.vuelo_fecha_llegada_estimada = m.fecha_llegada_estimada 
               AND v.vuelo_fecha_salida = m.fechasalida 
               AND v.vuelo_aeronave_id = m.aeronave_matricula), 
       m.paquete_precio 
FROM   gd2c2015.gd_esquema.MAESTRA m 
WHERE  m.paquete_codigo != 0 

SET IDENTITY_INSERT sqlovers.encomienda OFF 

go 

CREATE PROCEDURE sqlovers.Sp_cargar_butacas 
AS 
    DECLARE @aeronaves TABLE 
      ( 
         aeronave_id  INT IDENTITY, 
         aeronave_mat NVARCHAR(255) 
      ) 

    INSERT INTO @aeronaves 
    SELECT aeronave_matricula 
    FROM   sqlovers.AERONAVE 

    DECLARE @var INT = 1; 

    WHILE @var <= (SELECT Count(*) 
                   FROM   @aeronaves) 
      BEGIN 
          DECLARE @matri NVARCHAR(255) = (SELECT aeronave_mat 
             FROM   @aeronaves 
             WHERE  aeronave_id = @var) 

          UPDATE sqlovers.AERONAVE 
          SET    aeronave_but_pasill = (SELECT Sum(butaca_piso) 
                                        FROM   sqlovers.BUTACA 
                                        WHERE  butaca_aeronave LIKE @matri 
                                               AND butaca_tipo LIKE 'pasillo') 
          WHERE  aeronave_matricula LIKE @matri 

          UPDATE sqlovers.AERONAVE 
          SET    aeronave_but_vent = (SELECT Sum(butaca_piso) 
                                      FROM   sqlovers.BUTACA 
                                      WHERE  butaca_aeronave LIKE @matri 
                                             AND butaca_tipo LIKE 'Ventanilla') 
          WHERE  aeronave_matricula LIKE @matri 

          SET @var = @var + 1; 
      END; 

go 

EXECUTE sqlovers.Sp_cargar_butacas 

go 

CREATE PROCEDURE sqlovers.[Updateintentos](@intentos_login NUMERIC(18, 0), 
                                           @nombre         VARCHAR(25)) 
AS 
  BEGIN 
      IF( @intentos_login = 3 ) 
        BEGIN 
            UPDATE sqlovers.USUARIO 
            SET    user_estado = 0, 
                   user_nro_intentos = @intentos_login 
            WHERE  user_username = @nombre 
        END 
      ELSE 
        BEGIN 
            UPDATE sqlovers.USUARIO 
            SET    user_nro_intentos = @intentos_login 
            WHERE  user_username = @nombre 
        END 
  END 

/****** Object:  StoredProcedure [SQLOVERS].[darBajaTecnica]    Script Date: 12/4/2015 5:18:02 PM ******/ 
SET ansi_nulls ON 

go 

SET quoted_identifier ON 

go 

CREATE PROCEDURE [SQLOVERS].[Darbajatecnica] (@matricula    NVARCHAR(255), 
                                              @fechaBaja    DATETIME, 
                                              @fechaRegreso DATETIME) 
AS 
    UPDATE sqlovers.AERONAVE 
    SET    aeronave_estado = 1 
    WHERE  aeronave_matricula LIKE @matricula 

    INSERT sqlovers.AERONAVE_BAJAS 
    VALUES (@fechaRegreso, 
            @fechaBaja, 
            @matricula) 

go 

/****** Object:  StoredProcedure [SQLOVERS].[reemplazar_vuelo]    Script Date: 11/26/2015 10:02:15 PM ******/ 
SET ansi_nulls ON 

go 

SET quoted_identifier ON 

go 

CREATE PROCEDURE [SQLOVERS].[Reemplazar_vuelo](@aeronave_id NVARCHAR(255), 
                                               @vuelo_id    NUMERIC(18, 0)) 
AS 
    DECLARE @fecha_salida DATETIME = (SELECT vuelo_fecha_salida 
       FROM   sqlovers.VUELO 
       WHERE  vuelo_id = @vuelo_id) 

    IF( (SELECT Count(*) 
         FROM   sqlovers.VUELO 
         WHERE  vuelo_aeronave_id LIKE @aeronave_id 
                AND vuelo_fecha_salida = @fecha_salida) <= 0 ) 
      BEGIN 
          UPDATE sqlovers.VUELO 
          SET    vuelo_aeronave_id = @aeronave_id 
          WHERE  vuelo_id = @vuelo_id 
      END 
    ELSE 
      SELECT 0 

go 

--FUNCIONES   
/****** Object:  UserDefinedFunction [SQLOVERS].[validar_fechaSalida]    Script Date: 11/26/2015 10:04:28 PM ******/ 
SET ansi_nulls ON 

go 

SET quoted_identifier ON 

go 

CREATE FUNCTION [SQLOVERS].[Validar_fechasalida](@aeronave_id NVARCHAR(255), 
                                                 @fechaSalida DATETIME) 
returns BIT 
AS 
  BEGIN 
      DECLARE @retorno NUMERIC(3, 0)= (SELECT Count(*) 
         FROM   sqlovers.VUELO 
         WHERE  vuelo_aeronave_id LIKE @aeronave_id 
                AND vuelo_fecha_salida = @fechaSalida) 

      IF( @retorno = 0 ) 
        BEGIN 
            SET @retorno=1 
        END 
      ELSE 
        SET @retorno=0 

      RETURN @retorno 
  END; 

go 

/****** Object:  UserDefinedFunction [SQLOVERS].[estadoAeronave]    Script Date: 11/26/2015 10:05:15 PM ******/ 
SET ansi_nulls ON 

go 

SET quoted_identifier ON 

go 

CREATE FUNCTION [SQLOVERS].[Estadoaeronave](@aeronave_matricula NVARCHAR(255)) 
returns INT 
AS 
  BEGIN 
      DECLARE @retorno INT 

      IF( (SELECT aeronave_estado 
           FROM   sqlovers.AERONAVE 
           WHERE  aeronave_matricula LIKE @aeronave_matricula) IS NULL ) 
        BEGIN 
            SET @retorno = 3; 
        END 
      ELSE 
        SET @retorno =(SELECT aeronave_estado 
                       FROM   sqlovers.AERONAVE 
                       WHERE  aeronave_matricula LIKE @aeronave_matricula) 

      RETURN @retorno 
  END; 

go 

CREATE FUNCTION sqlovers.Existeruta(@ciudad_origen  INT, 
                                    @ciudad_destino INT) 
returns BIT 
AS 
  BEGIN 
      DECLARE @return BIT 

      IF( (SELECT Count(*) 
           FROM   RUTA 
           WHERE  ruta_ciudad_destino = @ciudad_destino 
                  AND ruta_ciudad_origen = @ciudad_origen) > 0 ) 
        SET @return = 1 
      ELSE 
        SET @return = 0 

      RETURN @return 
  END; 

go 

CREATE FUNCTION sqlovers.Existe_vuelo(@fechaSalida DATETIME, 
                                      @matricula   NVARCHAR(255)) 
returns BIT 
AS 
  BEGIN 
      DECLARE @resultado BIT 

      IF( (SELECT Count(*) 
           FROM   sqlovers.VUELO 
           WHERE  vuelo_fecha_salida = @fechaSalida 
                  AND vuelo_aeronave_id LIKE @matricula) = 0 ) 
        BEGIN 
            SET @resultado = 0 
        END 
      ELSE 
        SET @resultado = 1 

      RETURN @resultado 
  END; 

go 

CREATE FUNCTION sqlovers.Cantidadkgdisponibles(@vuelo_id INT) 
returns INT 
AS 
  BEGIN 
      DECLARE @kg_disponibles INT; 

      SET @kg_disponibles = (SELECT ( a.aeronave_kg_disponibles - 
                                      Sum(e.encomienda_kg) ) 
                             FROM   gd2c2015.sqlovers.VUELO v, 
                                    sqlovers.AERONAVE a, 
                                    sqlovers.ENCOMIENDA e 
                             WHERE  v.vuelo_aeronave_id = a.aeronave_matricula 
                                    AND e.encomienda_vuelo_id = @vuelo_id 
                                    AND v.vuelo_id = @vuelo_id 
                             GROUP  BY v.vuelo_id, 
                                       a.aeronave_kg_disponibles) 

      RETURN @kg_disponibles 
  END;

  GO

CREATE FUNCTION sqlovers.Butacasdisponibles(@vuelo_id INT) 
returns @butacasDisponibles TABLE ( 
  butaca_nro  NUMERIC(18, 0), 
  butaca_tipo NVARCHAR(255), 
  butaca_piso NUMERIC(18, 0)) 
AS 
  BEGIN 
      INSERT @butacasDisponibles 
      SELECT b.butaca_nro, 
		     b.butaca_tipo, 
             b.butaca_piso           
      FROM   sqlovers.butaca b 
             LEFT OUTER JOIN sqlovers.pasaje p 
                          ON b.butaca_nro = p.pasaje_butaca_nro 
                             AND p.pasaje_vuelo_id = @vuelo_id, 
             sqlovers.vuelo v 
      WHERE  b.butaca_aeronave = v.vuelo_aeronave_id 
             AND v.vuelo_id = @vuelo_id 
             AND pasaje_butaca_nro IS NULL 

      RETURN 
  END; 
  GO
  SELECT * FROM SQLOVERS.Butacasdisponibles(18)