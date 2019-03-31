create database Contactos;
use Contactos;

CREATE TABLE TiposIdentificacion
(
	idTipoIdentificacion int primary key identity(1,1),
	nombreTipoIdentificacion nvarchar(100) not null
);

CREATE TABLE Contactos
(
	idContacto int primary key identity(1,1),
	nombresContacto nvarchar(150) not null,
	apellidosContacto nvarchar(150) not null,
	telefonosContacto nvarchar(150),
	correoContacto nvarchar(150),
	numeroIdentificacionContacto bigint unique not null,
	idTipoIdentificacion int foreign key references TiposIdentificacion(idTipoIdentificacion),
);