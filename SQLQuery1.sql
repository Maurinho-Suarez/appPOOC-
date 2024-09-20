create database registro1
use registro1
create table users(
DNI int(8) not null,
pass varchar(8) not null,
nombre varchar(30) not null,
email varchar(25) not null,
telefono int(15) not null
)

create procedure alta_users(
@DNI int(8),
@pass varchar(8),
@nombre varchar(30),
@email varchar(25),
@telefono int(15)
)
as
insert into users
values (@DNI,@pass,@nombre,@email,@telefono)
go

create procedure ver_usuers(
@DNI int(8)
)
as
select * from users
where DNI=@DNI
go

