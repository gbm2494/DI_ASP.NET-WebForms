CREATE TABLE Persona(nombre varchar(45), cedula varchar(10) PRIMARY KEY, apellido1 varchar(45), apellido2 varchar(45));

CREATE TABLE Telefono(cedulaP varchar(10) FOREIGN KEY REFERENCES Persona(cedula), numero varchar(10), PRIMARY KEY(cedulaP, numero));