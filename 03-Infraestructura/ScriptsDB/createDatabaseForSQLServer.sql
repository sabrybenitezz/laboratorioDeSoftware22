CREATE DATABASE venta_de_autos; -- Crea la base de datos "venta_de_autos"

USE venta_de_autos; -- Usa la base de datos recién creada

CREATE TABLE automovil (
    patente VARCHAR(10) PRIMARY KEY,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    precio DECIMAL(10, 2) NOT NULL
);
