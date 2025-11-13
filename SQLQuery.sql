CREATE DATABASE practica;

USE practica;

create table Productos
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Marca nvarchar (100),
Precio float,
Stock int
)

insert into Productos
values
('Gaseosa','3 litros','marcacola',7.5,24),
('Chocolate','Tableta 100 gramos','iberica',12.5,36)

SELECT * FROM Product;

CREATE PROC selectProducts 
	AS
		SELECT * FROM Product;
go

EXEC selectProducts;

create proc InsertProduct
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int
as
insert into product values (@nombre,@descrip,@marca,@precio,@stock)
go

create proc deleteProduct
@idpro int
as
delete from product where Id=@idpro
go

create proc updateProduct
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int,
@id int
as
update product set Nombre=@nombre, Descripcion=@descrip, Marca=@marca,
Precio=@precio, Stock=@stock where Id=@id
go