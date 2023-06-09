SELECT SUM(QUANTIDADE * [PRE�O]) FROM [ITENS NOTAS FISCAIS]
WHERE NUMERO = 100

CREATE FUNCTION FaturamentoNota (@NUMERO AS INT) RETURNS FLOAT
AS
BEGIN
	DECLARE @FATURAMENTO FLOAT
	SELECT @FATURAMENTO = SUM(QUANTIDADE * [PRE�O]) FROM [ITENS NOTAS FISCAIS]
	WHERE NUMERO = @NUMERO
	RETURN @FATURAMENTO
END


SELECT NUMERO, [dbo].[FaturamentoNota](NUMERO) AS FATURAMENTO FROM [NOTAS FISCAIS]

/* Transforme este script em uma fun��o onde passamos a data como par�metro e retornamos o n�mero de notas. 
Chame esta fun��o de NumeroNotas. Ap�s a sua cria��o, teste seu uso com um SELECT.*/

CREATE FUNCTION NumeroNotas(@DATA AS VARCHAR(20)) RETURNS INT 
AS
BEGIN
	DECLARE @NUMNOTAS INT
	SELECT @NUMNOTAS = COUNT(*) FROM [NOTAS FISCAIS]
		WHERE DATA = @DATA
	RETURN @NUMNOTAS
END

SELECT DATA, [dbo].[NumeroNotas](DATA) AS NOTAS FROM [NOTAS FISCAIS] 

