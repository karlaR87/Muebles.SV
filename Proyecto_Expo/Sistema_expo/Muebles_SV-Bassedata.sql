
CREATE DATABASE Mueble_SV;
USE Mueble_SV;

CREATE TABLE Usuarios(
id_user INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
user_name VARCHAR (30) NOT NULL,
contraseña VARCHAR (30) NOT NULL,
tipo_de_usuario varchar (30) NOT NULL
);

DESCRIBE Usuarios;

CREATE TABLE Materiales_Secundario(
Nombre_de_MaterialSe VARCHAR (30) NOT NULL,
ID_Material_Se VARCHAR (30) PRIMARY KEY NOT NULL,
Precio_MateriaSe varchar (30) NOT NULL
);
##

CREATE TABLE Materiales_prim(
Nombre_de_MaterialPr VARCHAR (30) NOT NULL,
ID_Material_Pr VARCHAR (30) PRIMARY KEY NOT NULL,
Precio_MaterialpR varchar (30) NOT NULL
);



CREATE TABLE Catalogo(
Nombre_de_producto VARCHAR (30) NOT NULL,
ID_producto VARCHAR (30) PRIMARY KEY NOT NULL,
ID_Material_Pr VARCHAR (30),
CONSTRAINT FK_IDMaterialPr
FOREIGN KEY (ID_Material_Pr) 
REFERENCES Materiales_prim(ID_Material_Pr),
ID_Material_Se VARCHAR (30),
CONSTRAINT FK_IDMaterialSe
FOREIGN KEY (ID_Material_Se) 
REFERENCES Materiales_Secundario(ID_Material_Se),
Precio_de_mano_de_obra_bruto float (30) NOT NULL
);

