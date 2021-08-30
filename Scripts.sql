IF OBJECT_ID ('dbo.Curso') IS NOT NULL
BEGIN
	IF (SELECT COUNT(*) FROM Curso) = 0
		BEGIN
			INSERT INTO dbo.Curso (Nombre, NumeroCreditos)
			VALUES ('CURSO AVANZADO .NET CORE', 5)

			INSERT INTO dbo.Curso (Nombre, NumeroCreditos)
			VALUES ('CURSO AVANZADO ANGULAR', 4)


			INSERT INTO dbo.Curso (Nombre, NumeroCreditos)
			VALUES ('CURSO AVANZADO INGLES', 3)


			INSERT INTO dbo.Curso (Nombre, NumeroCreditos)
			VALUES ('CURSO AVANZADO SQL', 5)


			INSERT INTO dbo.Curso (Nombre, NumeroCreditos)
			VALUES ('CURSO AVANZADO JQUERY', 5)
		END
END
GO



