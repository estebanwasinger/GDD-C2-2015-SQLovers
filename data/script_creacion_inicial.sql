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
 

IF Object_id('SQLOVERS.aeronave') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.AERONAVE; 
  END; 

IF Object_id('SQLOVERS.tipo_servicio') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.TIPO_SERVICIO; 
  END; 

IF Object_id('SQLOVERS.LLEGADA_DESTINO') IS NOT NULL 
  BEGIN 
      DROP TABLE sqlovers.LLEGADA_DESTINO; 
  END; 


IF Object_id('SQLOVERS.UpdateIntentos') IS NOT NULL 
  BEGIN 
      DROP PROCEDURE sqlovers.updateintentos; 
  END; 

IF Object_id('SQLOVERS.TIPO_BAJA') IS NOT NULL 
  BEGIN 
      DROP TABLE SQLOVERS.TIPO_BAJA; 
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

CREATE TABLE sqlovers.AERONAVE 
  ( 
     aeronave_matricula      NVARCHAR(255) PRIMARY KEY NOT NULL, 
     aeronave_modelo         NVARCHAR(255), 
     aeronave_kg_disponibles NUMERIC(18, 0), 
     aeronave_fecha_alta     DATETIME NULL,
     aeronave_fabricante     NVARCHAR(255), 
     aeronave_tipo_servicio  NUMERIC(3, 0) FOREIGN KEY REFERENCES 
     sqlovers.TIPO_SERVICIO(tipo_servicio_id),
     aeronave_but_vent numeric(18,0),
     aeronave_but_pasill numeric(18,0),
	 aeronave_fecha_vueltaFS datetime,
	 aeronave_estado numeric(3,0) FOREIGN KEY REFERENCES SQLOVERS.TIPO_BAJA(tipo_baja_id)

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
	 ciudad_estado bit 
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
	 ruta_estado BIT,
     ruta_tipo_servicio     NUMERIC(3, 0) FOREIGN KEY REFERENCES
     sqlovers.TIPO_SERVICIO(tipo_servicio_id) 
  ) 

CREATE TABLE sqlovers.VUELO 
  ( 
     vuelo_id                     NUMERIC(18, 0) IDENTITY PRIMARY KEY, 
     vuelo_fecha_salida           DATETIME, 
     vuelo_fecha_llegada          DATETIME, 
     vuelo_fecha_llegada_estimada DATETIME,
	 vuelo_cancelado              bit NOT NULL,
     vuelo_aeronave_id            NVARCHAR(255) FOREIGN KEY REFERENCES 
     sqlovers.AERONAVE(aeronave_matricula), 
     vuelo_ruta_id                NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.RUTA(ruta_id) 
  ) 

CREATE TABLE sqlovers.PASAJE 
  ( 
     pasaje_codigo      NUMERIC(18, 0) NOT NULL PRIMARY KEY, 
     pasaje_precio      NUMERIC(18, 2), 
     pasaje_fechacompra DATETIME, 
     cli_dni            NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.CLIENTE(cli_dni), 
     pasaje_vuelo_id    NUMERIC(18, 0) FOREIGN KEY REFERENCES 
     sqlovers.VUELO(vuelo_id) 
  ) 

CREATE TABLE sqlovers.LLEGADA_DESTINO 
  ( 
     llegada_codigo      NUMERIC(18, 0) NOT NULL PRIMARY KEY, 
     llegada_matricula   NVARCHAR(255) FOREIGN KEY REFERENCES 
     sqlovers.AERONAVE(aeronave_matricula),      
     llegada_horaArrivo  DATETIME,
     llegada_origen      NUMERIC(6, 0) FOREIGN KEY REFERENCES 
     sqlovers.CIUDAD(ciudad_id),
     llegada_destino     NUMERIC(6, 0) FOREIGN KEY REFERENCES 
     sqlovers.CIUDAD(ciudad_id)  
  )

CREATE TABLE SQLOVERS.TIPO_BAJA
(
tipo_baja_id NUMERIC(3, 0) IDENTITY NOT NULL PRIMARY KEY,
tipo_baja_detalle NVARCHAR(255),  
)


/*          
FILL TABLES          
*/ 

INSERT INTO sqlovers.TIPO_BAJA (tipo_baja_detalle) values
('Baja Fuera de Servicio'),
('Baja Definitiva')

INSERT INTO sqlovers.ROL 
            (rol_name, 
             rol_activo) 
VALUES     ('Admin', 
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
FROM   [GD2C2015].[gd_esquema].[MAESTRA], SQLOVERS.TIPO_SERVICIO ts 
Where Tipo_Servicio = ts.tipo_servicio_nombre

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
            (ciudad_nombre, ciudad_estado) 
SELECT DISTINCT ruta_ciudad_origen, 1 
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
FROM   [GD2C2015].[gd_esquema].[MAESTRA] m1, SQLOVERS.CIUDAD c1, SQLOVERS.CIUDAD c2, SQLOVERS.TIPO_SERVICIO ts
WHERE  m1.ruta_ciudad_destino != m1.ruta_ciudad_origen 
AND c1.ciudad_nombre = m1.Ruta_Ciudad_Destino
AND c2.ciudad_nombre = m1.Ruta_Ciudad_Origen
AND ts.tipo_servicio_nombre = m1.Tipo_Servicio
GROUP BY c1.ciudad_id, c2.ciudad_id, m1.Ruta_Ciudad_Destino, m1.Ruta_Ciudad_Origen, m1.Tipo_Servicio, ts.tipo_servicio_id

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

INSERT INTO sqlovers.FUNCIONALIDAD (funcionalidad_desc) values
('Login y Seguridad'),
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
INSERT INTO sqlovers.PASAJE 
            (pasaje_codigo, 
             pasaje_precio, 
             pasaje_fechacompra, 
             cli_dni, 
             pasaje_vuelo_id) 
SELECT pasaje_codigo, 
       pasaje_precio, 
       pasaje_fechacompra, 
       cli_dni, 
       v.vuelo_id 
FROM   gd_esquema.MAESTRA m, 
       sqlovers.VUELO v 
WHERE  pasaje_precio > 0 
       AND pasaje_codigo != 0 
       AND m.aeronave_matricula = v.vuelo_aeronave_id 
       AND m.fechasalida = v.vuelo_fecha_salida 
       AND m.fechallegada = v.vuelo_fecha_llegada 
       AND m.fecha_llegada_estimada = v.vuelo_fecha_llegada_estimada 

INSERT INTO sqlovers.VUELO 
            (vuelo_fecha_llegada, 
             vuelo_fecha_llegada_estimada, 
             vuelo_fecha_salida, 
             vuelo_aeronave_id, 
             vuelo_ruta_id) 
SELECT DISTINCT fechallegada, 
                fecha_llegada_estimada, 
                m.fechasalida, 
                m.aeronave_matricula, 
                r.ruta_id 
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

create procedure SQLOVERS.SP_CARGAR_BUTACAS
AS

declare @aeronaves table(aeronave_id int IDENTITY,aeronave_mat nvarchar(255))
insert into @aeronaves
select aeronave_matricula from SQLOVERS.aeronave


declare @var int = 1;

while @var<= (select  COUNT(*) from @aeronaves)
Begin
declare @matri nvarchar(255) = (select aeronave_mat from @aeronaves where aeronave_id = @var)

update sqlovers.aeronave set aeronave_but_pasill = (select sum(butaca_piso) from SQLOVERS.butaca
where butaca_aeronave like @matri and butaca_tipo like 'pasillo')
where aeronave_matricula like @matri

update sqlovers.aeronave set aeronave_but_vent = (select sum(butaca_piso) from SQLOVERS.butaca
where butaca_aeronave like @matri and butaca_tipo like 'Ventanilla')
where aeronave_matricula like @matri

set @var = @var + 1;
end;
GO

execute SQLOVERS.SP_CARGAR_BUTACAS
GO

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

  /****** Object:  StoredProcedure [SQLOVERS].[reemplazar_vuelo]    Script Date: 11/26/2015 10:02:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [SQLOVERS].[reemplazar_vuelo](@aeronave_id nvarchar(255),@vuelo_id numeric(18,0))
as
declare @fecha_salida datetime = (select vuelo_fecha_salida from SQLOVERS.VUELO where vuelo_id = @vuelo_id)

IF((select count(*)  from SQLOVERS.VUELO where vuelo_aeronave_id like @aeronave_id and vuelo_fecha_salida = @fecha_salida ) <= 0 )
BEGIN
UPDATE SQLOVERS.VUELO set  vuelo_aeronave_id = @aeronave_id where vuelo_id = @vuelo_id
END
ELSE SELECT 0
GO

--FUNCIONES

/****** Object:  UserDefinedFunction [SQLOVERS].[validar_fechaSalida]    Script Date: 11/26/2015 10:04:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 create function [SQLOVERS].[validar_fechaSalida](@aeronave_id nvarchar(255),@fechaSalida datetime)
 returns bit
 as
 begin
 declare @retorno numeric(3,0)= (select count(*)  from SQLOVERS.VUELO where vuelo_aeronave_id like @aeronave_id and vuelo_fecha_salida = @fechaSalida )

 if(@retorno=0)
 begin
 set @retorno=1
 end
 else set @retorno=0
 return @retorno
 end;

GO

/****** Object:  UserDefinedFunction [SQLOVERS].[estadoAeronave]    Script Date: 11/26/2015 10:05:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 CREATE FUNCTION [SQLOVERS].[estadoAeronave](@aeronave_matricula nvarchar(255))
 returns int
as
begin
declare @retorno int

if((select aeronave_estado from SQLOVERS.AERONAVE where aeronave_matricula like @aeronave_matricula) is null)
begin
 set @retorno = 3;
 end
 else  set @retorno =(select aeronave_estado from SQLOVERS.AERONAVE where aeronave_matricula like @aeronave_matricula)
 return @retorno
 end;

GO