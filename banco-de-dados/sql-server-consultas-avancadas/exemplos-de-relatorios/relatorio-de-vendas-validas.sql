SELECT * FROM [TABELA DE CLIENTES]

SELECT * FROM [NOTAS FISCAIS]

SELECT * FROM [ITENS NOTAS FISCAIS]

SELECT TC.CPF, NF.DATA, INF.QUANTIDADE, TC.[VOLUME DE COMPRA] FROM [TABELA DE CLIENTES] TC
INNER JOIN [NOTAS FISCAIS] NF ON TC.CPF = NF.CPF 
INNER JOIN [ITENS NOTAS FISCAIS] INF ON NF.NUMERO = INF.NUMERO

SELECT TC.CPF, CONVERT(VARCHAR, NF.DATA, 120), INF.QUANTIDADE, TC.[VOLUME DE COMPRA] FROM [TABELA DE CLIENTES] TC
INNER JOIN [NOTAS FISCAIS] NF ON TC.CPF = NF.CPF 
INNER JOIN [ITENS NOTAS FISCAIS] INF ON NF.NUMERO = INF.NUMERO

SELECT TC.CPF, SUBSTRING(CONVERT(VARCHAR, NF.DATA, 120),1,7), INF.QUANTIDADE, TC.[VOLUME DE COMPRA] FROM [TABELA DE CLIENTES] TC
INNER JOIN [NOTAS FISCAIS] NF ON TC.CPF = NF.CPF 
INNER JOIN [ITENS NOTAS FISCAIS] INF ON NF.NUMERO = INF.NUMERO


SELECT AUX1.NOME, AUX1.ANO_MES, AUX1.QUANTIDADE_MES,
CASE WHEN AUX1.QUANTIDADE_MES >= AUX1.[VOLUME DE COMPRA] THEN 'VENDA INV�LIDA'
WHEN AUX1.QUANTIDADE_MES < AUX1.[VOLUME DE COMPRA] THEN 'VENDA V�LIDA' 
END AS STATUS
FROM
(SELECT TC.NOME, CQ.ANO_MES, CQ.QUANTIDADE_MES, TC.[VOLUME DE COMPRA]
FROM
(SELECT NF.CPF, SUBSTRING(CONVERT(VARCHAR, NF.DATA, 120),1,7) AS ANO_MES, 
SUM(INF.QUANTIDADE) AS QUANTIDADE_MES
FROM [TABELA DE CLIENTES] TC
INNER JOIN [NOTAS FISCAIS] NF ON TC.CPF = NF.CPF 
INNER JOIN [ITENS NOTAS FISCAIS] INF ON NF.NUMERO = INF.NUMERO
GROUP BY NF.CPF, SUBSTRING(CONVERT(VARCHAR, NF.DATA, 120),1,7)) CQ
INNER JOIN [TABELA DE CLIENTES] TC ON CQ.CPF = TC.CPF ) AUX1



SELECT AUX1.NOME, AUX1.ANO_MES, AUX1.[VOLUME DE COMPRA], AUX1.QUANTIDADE_MES, 
CONVERT(DECIMAL(15,2), ( (AUX1.QUANTIDADE_MES/AUX1.[VOLUME DE COMPRA]) - 1) * 100)  AS VARIACAO, 
CASE WHEN AUX1.QUANTIDADE_MES <= AUX1.[VOLUME DE COMPRA] THEN 'VENDA V�LIDA'
WHEN AUX1.QUANTIDADE_MES > AUX1.[VOLUME DE COMPRA] THEN 'VENDA INV�LIDA'
END AS STATUS_VENDA
FROM 
(SELECT TC.NOME, CQ.ANO_MES, CQ.QUANTIDADE_MES, TC.[VOLUME DE COMPRA]
FROM
(SELECT NF.CPF, SUBSTRING(CONVERT(VARCHAR, NF.[DATA], 120),1,7) AS ANO_MES, 
SUM(INF.QUANTIDADE) AS QUANTIDADE_MES  FROM [NOTAS FISCAIS] NF
INNER JOIN [ITENS NOTAS FISCAIS] INF
ON NF.NUMERO = INF.NUMERO 
GROUP BY NF.CPF, SUBSTRING(CONVERT(VARCHAR, NF.[DATA], 120),1,7)) CQ
INNER JOIN [TABELA DE CLIENTES] TC ON TC.CPF = CQ.CPF) AUX1
WHERE  AUX1.QUANTIDADE_MES > AUX1.[VOLUME DE COMPRA] 
ORDER BY AUX1.NOME, AUX1.ANO_MES
