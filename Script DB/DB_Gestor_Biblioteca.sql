CREATE DATABASE DB_GESTOR_DE_BIBLIOTECA;

USE DB_GESTOR_DE_BIBLIOTECA;

CREATE TABLE Usuarios (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    DNI NVARCHAR(10) NOT NULL UNIQUE,
    Telefono NVARCHAR(15),
    Email NVARCHAR(100) NOT NULL,
    Imagen NVARCHAR(255), 
    Suspendido BIT DEFAULT 0
);
GO
CREATE TABLE Libros (
    ID INT PRIMARY KEY IDENTITY,
    Titulo NVARCHAR(255) NOT NULL,
    Autor NVARCHAR(255),
    Imagen NVARCHAR(255),
    Stock INT NOT NULL DEFAULT 0,
    Fecha_Publicacion DATE
);
GO
CREATE TABLE Prestamos (
    ID INT PRIMARY KEY IDENTITY,
    ID_Usuario INT NOT NULL,
    ID_Libro INT NOT NULL,
    Fecha_Prestamo DATETIME NOT NULL,
    Fecha_Devolucion DATETIME NOT NULL,
    Devuelto BIT DEFAULT 0,
    CONSTRAINT FK_Prestamo_Usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID),
    CONSTRAINT FK_Prestamo_Libro FOREIGN KEY (ID_Libro) REFERENCES Libros(ID)
);
GO
CREATE TABLE Suspensiones (
    ID INT PRIMARY KEY IDENTITY,
    ID_Usuario INT NOT NULL,
    Fecha_Suspension DATETIME NOT NULL,
    CONSTRAINT FK_Suspension_Usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID)
);

INSERT INTO Usuarios (Nombre, Apellido, DNI, Telefono, Email, Imagen, Suspendido)
VALUES 
('Tony', 'Stark', '12345678', '111-1111', 'tony.stark@avengers.com', 'ImagenesUsuarios/tony_stark.png', 0),
('Steve', 'Rogers', '87654321', '222-2222', 'steve.rogers@avengers.com', 'ImagenesUsuarios/steve_rogers.png', 0),
('Natasha', 'Romanoff', '23456789', '333-3333', 'natasha.romanoff@shield.com', 'ImagenesUsuarios/natasha_romanoff.png', 0),
('Bruce', 'Banner', '34567890', '444-4444', 'bruce.banner@avengers.com', 'ImagenesUsuarios/bruce_banner.png', 0),
('Thor', 'Odinson', '45678901', '555-5555', 'thor.odinson@asgard.com', 'ImagenesUsuarios/thor_odinson.png', 1),
('Clint', 'Barton', '56789012', '666-6666', 'clint.barton@avengers.com', 'ImagenesUsuarios/clint_barton.png', 0),
('Peter', 'Parker', '67890123', '777-7777', 'peter.parker@dailybugle.com', 'ImagenesUsuarios/peter_parker.jpeg', 0),
('Wanda', 'Maximoff', '78901234', '888-8888', 'wanda.maximoff@avengers.com', 'ImagenesUsuarios/wanda_maximoff.png', 0),
('Stephen', 'Strange', '89012345', '999-9999', 'stephen.strange@sorcerersupreme.com', 'ImagenesUsuarios/stephen_strange.png', 0),
('Carol', 'Danvers', '90123456', '000-0000', 'carol.danvers@spaceforce.com', 'ImagenesUsuarios/carol_danvers.png', 0);

