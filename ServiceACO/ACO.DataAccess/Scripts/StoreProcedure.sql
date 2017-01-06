CREATE PROCEDURE [dbo].[Insert_Cliente]
	@Dni nvarchar(8),
	@Nombre nvarchar(100),
	@Apellido nvarchar(100),
	@Direccion nvarchar(50),
	@Email nvarchar(50)
AS    
BEGIN
	INSERT INTO 
		Cliente (Dni, Nombre, Apellido, Direccion, Email)
	VALUES 
		(@Dni, @Nombre, @Apellido, @Direccion, @Email);

	SELECT SCOPE_IDENTITY();
END

GO

CREATE PROCEDURE [dbo].[Delete_Cliente]
	@id int
AS    
BEGIN
	DELETE FROM Cliente
	WHERE 
		Id = @id;
END