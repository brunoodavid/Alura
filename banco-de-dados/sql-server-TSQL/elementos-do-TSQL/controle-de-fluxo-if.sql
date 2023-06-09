IF OBJECT_ID('TABELA_TESTE', 'U') IS NOT NULL
BEGIN
	DROP TABLE TABELA_TESTE 
END
CREATE TABLE TABELA_TESTE(ID VARCHAR(10))

SELECT GETDATE()
SELECT DATENAME(WEEKDAY, DATEADD(DAY, 4, GETDATE()))

DECLARE @DIA_SEMANA VARCHAR(20)
DECLARE @NUMERO_DIAS INT

SET @NUMERO_DIAS = 10
SET @DIA_SEMANA = DATENAME(WEEKDAY, DATEADD(DAY, @NUMERO_DIAS, GETDATE()))
PRINT @DIA_SEMANA
IF @DIA_SEMANA = 'Sunday' OR @DIA_SEMANA = 'Saturday'
	PRINT 'Este dia � fim de semana'
ELSE
	PRINT 'Este dia � dia da semana'


/*Crie um script que, baseado em uma data, conte o n�mero de notas fiscais. 
Se houver mais de 70 notas, exiba a mensagem "Muita nota". 
Se n�o, exiba a mensagem "Pouca nota". Exiba tamb�m o n�mero de notas.*/


DECLARE @NUMNOTAS INT
SELECT @NUMNOTAS = COUNT(*) FROM [NOTAS FISCAIS] 
    WHERE DATA = '20170202'
PRINT @NUMNOTAS

IF @NUMNOTAS > 70 
	PRINT 'Muita nota'
ELSE 
	PRINT 'Pouca nota'


SELECT SUM([LIMITE DE CREDITO]) FROM [TABELA DE CLIENTES] WHERE BAIRRO = 'Jardins' 

SELECT * FROM [TABELA DE CLIENTES]

DECLARE @LIMITE_MAXIMO FLOAT
DECLARE @LIMITE_ATUAL FLOAT
DECLARE @BAIRRO VARCHAR(20)

SET @BAIRRO = 'Jardins'
SET @LIMITE_MAXIMO = 500000
SELECT @LIMITE_ATUAL = SUM([LIMITE DE CREDITO]) FROM [TABELA DE CLIENTES] WHERE BAIRRO = @BAIRRO
IF @LIMITE_MAXIMO <= (SELECT SUM([LIMITE DE CREDITO]) FROM [TABELA DE CLIENTES] WHERE BAIRRO = @BAIRRO)
BEGIN
	PRINT 'Valor estourou. N�o � poss�vel abrir novos cr�ditos'
END
ELSE
BEGIN
	PRINT 'Valor n�o estourou. � poss�vel abrir novos cr�ditos'
END