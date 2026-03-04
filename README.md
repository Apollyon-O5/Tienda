# Tienda
Proyecto de una tienda de pokemones para programación II

****
###Script de la base de datos
```
CREATE DATABASE TiendaPokemon;
GO

USE TiendaPokemon;

CREATE TABLE Transaccion (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Fecha DATETIME DEFAULT GETDATE(),
    SaldoInicial INT
);

CREATE TABLE PokemonComprado (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TransaccionId INT,
    Nombre NVARCHAR(100),
    Precio INT,
    FOREIGN KEY (TransaccionId) REFERENCES Transaccion(Id)
);
```
