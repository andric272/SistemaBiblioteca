CREATE DATABASE BibliotecaBD;
GO

USE BibliotecaBD;
GO

CREATE TABLE Libro
(
    IdLibro INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(150) NOT NULL,
    Autor NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL
);
GO

INSERT INTO Libro (Titulo, Autor, Precio, Stock) VALUES
('Cien años de soledad', 'Gabriel García Márquez', 80.00, 10),
('Don Quijote de la Mancha', 'Miguel de Cervantes', 95.50, 6),
('El principito', 'Antoine de Saint-Exupéry', 45.00, 15),
('Ficciones', 'Jorge Luis Borges', 60.00, 8),
('Rayuela', 'Julio Cortázar', 70.00, 5);
GO

CREATE PROCEDURE dbo.usp_listarLibros
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdLibro, Titulo, Autor, Precio, Stock
    FROM Libro
    ORDER BY Titulo ASC;
END;
GO