-- # tabelas que valem para a conex�o vigente, ou seja, quando a conex�o for fechada ou desligada, a tabela some.
-- ## tabelas que valem para v�rias conex�es, que somente ser�o apagadas quando dermos um logoff ou o servi�o do sql for parado.
-- @tabelas que valem para o procedimento que est� sendo executado, ou seja, por um trecho de c�gido.

CREATE TABLE #TABELA01 (ID VARCHAR(10) NULL, NOME VARCHAR(200) NULL)
INSERT INTO #TABELA01 (ID, NOME) VALUES ('1', 'JO�O')
SELECT * FROM #TABELA01

-- TABELA TEMPORARIA


DECLARE @LIMITE_MINIMO INT, @LIMITE_MAXIMO INT, @CONTADOR_NOTAS INT
DECLARE @TABELA_NUMEROS TABLE ([NUMEROS] INT, [STATUS] VARCHAR(200))

SET @LIMITE_MINIMO = 98
SET @LIMITE_MAXIMO = 101

WHILE @LIMITE_MINIMO <= @LIMITE_MAXIMO
BEGIN
	SELECT @CONTADOR_NOTAS = COUNT(*) FROM [NOTAS FISCAIS] WHERE [NUMERO] = @LIMITE_MINIMO
	IF @CONTADOR_NOTAS > 0
		INSERT INTO @TABELA_NUMEROS (NUMEROS, STATUS) VALUES(@LIMITE_MINIMO, '� nota fiscal')
	ELSE
		INSERT INTO @TABELA_NUMEROS (NUMEROS, STATUS) VALUES(@LIMITE_MINIMO, 'N�o � nota fiscal')
	SET @LIMITE_MINIMO = @LIMITE_MINIMO + 1
	
END

SELECT * FROM @TABELA_NUMEROS