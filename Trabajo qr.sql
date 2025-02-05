CREATE DATABASE bodega;
USE bodega;
-- Equipos electronicos
CREATE TABLE productos(
IdProd int auto_increment primary key,
CodProd varchar(8) null,
TipoProd varchar(50) null,
MarcaProd varchar(25) null,
UbicacionProd varchar(8) null,
NomProd varchar(50) null,
GarantiaProd int null,
PrecioProd decimal(10,2) null,
CantProd int null
);
select * from productos;
CREATE TABLE clientes(
IdCli int auto_increment primary key,
CedCli varchar(10) null,
NomCli varchar(50) null,
ApeCli varchar(50) null,
TelfCli varchar(10) null,
DirectCli varchar(255) null
);
select * from clientes;
drop database bodega;