SELECT DISTINCT BAIRRO FROM [TABELA DE CLIENTES]

SELECT DISTINCT BAIRRO FROM [TABELA DE VENDEDORES]

SELECT DISTINCT BAIRRO FROM [TABELA DE CLIENTES]
UNION
SELECT DISTINCT BAIRRO FROM [TABELA DE VENDEDORES]

SELECT DISTINCT BAIRRO FROM [TABELA DE CLIENTES]
UNION ALL
SELECT DISTINCT BAIRRO FROM [TABELA DE VENDEDORES]

SELECT DISTINCT BAIRRO, NOME, 'CLIENTE' FROM [TABELA DE CLIENTES]
UNION ALL
SELECT DISTINCT BAIRRO, NOME, 'VENDEDOR'FROM [TABELA DE VENDEDORES]
