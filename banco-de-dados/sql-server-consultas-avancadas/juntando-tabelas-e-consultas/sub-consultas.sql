SELECT NOME, BAIRRO FROM [TABELA DE CLIENTES]

SELECT NOME, BAIRRO FROM [TABELA DE CLIENTES] 
WHERE BAIRRO IN (SELECT BAIRRO FROM [TABELA DE VENDEDORES])

SELECT EMBALAGEM, MAX([PRE�O DE LISTA]) FROM [TABELA DE PRODUTOS] GROUP BY EMBALAGEM

SELECT NOVA_CONSULTA.EMBALAGEM, NOVA_CONSULTA.MAX_PRECO
FROM(SELECT EMBALAGEM, MAX([PRE�O DE LISTA]) AS MAX_PRECO FROM [TABELA DE PRODUTOS] GROUP BY EMBALAGEM)
NOVA_CONSULTA
WHERE NOVA_CONSULTA.MAX_PRECO <= 5

SELECT CPF, COUNT(*) FROM [NOTAS FISCAIS]
WHERE YEAR(DATA) = 2016
GROUP BY CPF
HAVING COUNT(*) > 2000

SELECT NOVA_CONSULTA.CPF, NOVA_CONSULTA.MAX_NOTASFISCAIS
FROM(SELECT CPF, COUNT(*) AS MAX_NOTASFISCAIS FROM [NOTAS FISCAIS] 
WHERE YEAR(DATA) = 2016 GROUP BY CPF) NOVA_CONSULTA
WHERE NOVA_CONSULTA.MAX_NOTASFISCAIS > 2000

SELECT X.CPF, X.CONTADOR FROM 
(SELECT CPF, COUNT(*) AS CONTADOR FROM [NOTAS FISCAIS]
WHERE YEAR(DATA) = 2016
GROUP BY CPF) X WHERE X.CONTADOR > 2000