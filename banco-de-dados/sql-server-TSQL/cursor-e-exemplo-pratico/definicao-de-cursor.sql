DECLARE @NOME VARCHAR(200)
DECLARE CURSOR1 CURSOR FOR SELECT TOP 4 NOME FROM [TABELA DE CLIENTES]
OPEN CURSOR1
FETCH NEXT FROM CURSOR1 INTO @NOME
WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT @NOME
	FETCH NEXT FROM CURSOR1 INTO @NOME
END
CLOSE CURSOR1
DEALLOCATE CURSOR1

DECLARE @LIMITECREDITO FLOAT
DECLARE @LIMITECREDITOACUM FLOAT
DECLARE CURSOR2 CURSOR FOR SELECT [LIMITE DE CREDITO] 
    FROM [TABELA DE CLIENTES]
SET @LIMITECREDITOACUM = 0
OPEN CURSOR2
FETCH NEXT FROM CURSOR2 INTO @LIMITECREDITO
WHILE @@FETCH_STATUS = 0
BEGIN
    SET @LIMITECREDITOACUM = @LIMITECREDITOACUM + 
        @LIMITECREDITO
    FETCH NEXT FROM CURSOR2 INTO @LIMITECREDITO
END
CLOSE CURSOR2
DEALLOCATE CURSOR2
PRINT @LIMITECREDITOACUM