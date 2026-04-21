USE Proyecto_BD;

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Apellido NVARCHAR(50) NOT NULL,
    DNI NVARCHAR(20) UNIQUE NOT NULL,
    Contraseña NVARCHAR(200) NOT NULL,
    IdiomaId INT NULL,   -- Relación con Idiomas
    PerfilId INT NULL,   -- Relación con Perfiles
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE Perfiles (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(200)
);

CREATE TABLE Idiomas (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50) NOT NULL,
    Cultura NVARCHAR(10) NOT NULL
);

CREATE TABLE Bitacora (
    Id INT PRIMARY KEY IDENTITY,
    UsuarioId INT NOT NULL,
    FechaHora DATETIME NOT NULL DEFAULT GETDATE(),
    Evento NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(200) NOT NULL
);
ALTER TABLE Usuarios
ADD CONSTRAINT FK_Usuarios_Perfiles FOREIGN KEY (PerfilId) REFERENCES Perfiles(Id);

ALTER TABLE Usuarios
ADD CONSTRAINT FK_Usuarios_Idiomas FOREIGN KEY (IdiomaId) REFERENCES Idiomas(Id);

ALTER TABLE Bitacora
ADD CONSTRAINT FK_Bitacora_Usuarios FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id);
