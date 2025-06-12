USE LABORATORIO_PRESENCIAL
GO
CREATE TABLE CLIENTE (
ID INT IDENTITY (1,1)  NOT NULL,
NOMBRE VARCHAR(32) NOT NULL,
PRIMER_APELLIDO VARCHAR(32) NOT NULL,
SEGUNDO_APELLIDO VARCHAR(32),
TELEFONO INT NOT NULL,
CORREO VARCHAR (255) NOT NULL,
DIRECCION VARCHAR(255) NOT NULL,
FECHA_DE_REGISTRO DATETIME NOT NULL,
FECHA_DE_MODIFICACION DATETIME NULL,
ESTADO BIT NOT NULL
);
INSERT INTO CLIENTE (NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, TELEFONO, CORREO, DIRECCION, FECHA_DE_REGISTRO, FECHA_DE_MODIFICACION, ESTADO)
VALUES 
('Juan', 'Pérez', 'Gómez', 88881234, 'juan.perez@example.com', 'Av. Central 123', GETDATE(), NULL, 1),
('María', 'López', 'Martínez', 88882345, 'maria.lopez@example.com', 'Calle 45 #10-23', GETDATE(), NULL, 1),
('Carlos', 'Rodríguez', NULL, 88883456, 'carlos.rod@example.com', 'Residencial Norte, casa 5', GETDATE(), NULL, 0),
('Ana', 'Morales', 'Vega', 88884567, 'ana.morales@example.com', 'Zona Sur, bloque A', GETDATE(), NULL, 1),
('Luis', 'Jiménez', 'Torres', 88885678, 'luis.jimenez@example.com', 'Colonia San Juan, lote 3', GETDATE(), NULL, 1),
('Sofía', 'Castro', NULL, 88886789, 'sofia.castro@example.com', 'Barrio El Carmen', GETDATE(), NULL, 0),
('Miguel', 'González', 'Ramírez', 88887890, 'miguel.gonzalez@example.com', 'Calle 6, esquina 3', GETDATE(), NULL, 1),
('Laura', 'Sánchez', 'Díaz', 88888901, 'laura.sanchez@example.com', 'Apartamentos Brisa del Mar', GETDATE(), NULL, 1),
('Pedro', 'Vargas', NULL, 88889012, 'pedro.vargas@example.com', 'Zona Industrial, Edif. B', GETDATE(), NULL, 1),
('Daniela', 'Rojas', 'Fernández', 88880123, 'daniela.rojas@example.com', 'San Pedro, Edif. El Roble', GETDATE(), NULL, 0);


SELECT * FROM CLIENTE;


USE LABORATORIO_PRESENCIAL
GO
CREATE TABLE INVENTARIO (
ID INT IDENTITY (1,1) NOT NULL,
CODIGO_DE_REPUESTO VARCHAR(4) NOT NU	LL,
NOMBRE_DE_REPUESTO VARCHAR(100) NOT NULL,
MARCA_DE_REPUESTO VARCHAR(100) NOT NULL,
VEHICULO VARCHAR(100) NOT NULL,
MODELO VARCHAR(100) NOT NULL,
ANIO INT NOT NULL,
CANTIDAD INT NOT NULL,
FECHA_DE_REGISTRO DATETIME NOT NULL,
FECHA_DE_MODIFICACION DATETIME NULL,
ESTADO BIT NOT NULL
);

SELECT * FROM INVENTARIO;

INSERT INTO dbo.INVENTARIO (
     CODIGO_DE_REPUESTO, NOMBRE_DE_REPUESTO, MARCA_DE_REPUESTO,
    VEHICULO, MODELO, ANIO, CANTIDAD,
    FECHA_DE_REGISTRO, FECHA_DE_MODIFICACION, ESTADO
) VALUES 
( 'D004', 'Pastillas de freno', 'Brembo', 'Honda Civic', 'EX', 2017, 25, '2024-06-04', NULL, 1),
( 'E005', 'Amortiguador', 'Monroe', 'Mazda 3', 'Touring', 2019, 8, '2024-06-05', '2024-06-06', 1),
( 'F006', 'Filtro de combustible', 'Fram', 'Kia Rio', 'LX', 2014, 12, '2024-06-06', NULL, 0),
( 'G007', 'Batería', 'ACDelco', 'Ford Fiesta', 'SE', 2020, 5, '2024-06-07', NULL, 1),
( 'H008', 'Aceite de motor 10W-40', 'Castrol', 'Chevrolet Aveo', 'LT', 2013, 30, '2024-06-08', NULL, 1),
('I009', 'Filtro de cabina', 'Mahle', 'Volkswagen Jetta', 'Trendline', 2016, 18, '2024-06-09', NULL, 1),
( 'J010', 'Correa de distribución', 'Dayco', 'Peugeot 208', 'Allure', 2018, 6, '2024-06-10', NULL, 0),
( 'K011', 'Termostato', 'Behr', 'Renault Logan', 'Expression', 2015, 7, '2024-06-11', '2024-06-12', 1),
( 'L012', 'Sensor de oxígeno', 'Denso', 'Subaru Impreza', 'AWD', 2017, 9, '2024-06-12', NULL, 1),
( 'M013', 'Limpiaparabrisas', 'Valeo', 'Toyota Yaris', 'LE', 2021, 22, '2024-06-13', NULL, 1);


