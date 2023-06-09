CREATE FUNCTION EnderecoCompleto
(@ENDERECO VARCHAR(100), @CIDADE VARCHAR(50), @ESTADO VARCHAR(50), @CEP VARCHAR(20))
RETURNS VARCHAR(250)
AS
BEGIN
	DECLARE @ENDERECO_COMPLETO VARCHAR(250)
	SET @ENDERECO_COMPLETO = @ENDERECO + '-' + @CIDADE + '-' + @ESTADO + '-' + @CEP 
	RETURN @ENDERECO_COMPLETO
END

SELECT CPF, [dbo].[EnderecoCompleto]([ENDERECO 1], CIDADE, ESTADO, CEP) AS END_COMPLETO 
FROM [TABELA DE CLIENTES]

ALTER FUNCTION EnderecoCompleto
(@ENDERECO VARCHAR(100), @CIDADE VARCHAR(50), @ESTADO VARCHAR(50), @CEP VARCHAR(20))
RETURNS VARCHAR(250)
AS
BEGIN
	DECLARE @ENDERECO_COMPLETO VARCHAR(250)
	SET @ENDERECO_COMPLETO = @ENDERECO + ',' + @CIDADE + ',' + @ESTADO + ',' + @CEP 
	RETURN @ENDERECO_COMPLETO
END

/* Ela tamb�m retorna o n�mero de notas entre duas datas. Modifique a fun��o FuncTabelaNotas para 
que utilize esta consulta acima. */

ALTER FUNCTION [dbo].[FuncTabelaNotas](@DATA_INICIAL DATE, @DATA_FINAL DATE) RETURNS TABLE
AS

	RETURN SELECT DATA, COUNT(*) AS NUMERO FROM [NOTAS FISCAIS] 
    WHERE DATA >= @DATA_INICIAL AND DATA <= @DATA_FINAL
	GROUP BY DATA

SELECT * FROM [dbo].[FuncTabelaNotas]('20170101', '20170110')


