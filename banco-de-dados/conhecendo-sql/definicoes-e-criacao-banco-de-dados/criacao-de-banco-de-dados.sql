create database SUCOS_VENDAS_01

CREATE DATABASE SUCOS_VENDAS_02
ON (NAME = 'SUCOS_VENDAS.DAT', /* Nome do arquivo onde sera armazenado os dados */
	FILENAME = 'C:\TEMP\SUCOS_VENDAS_02.MDF', /* Caminho da pasta */
	SIZE = 10MB, /* Tamanho inicial do banco */
	MAXSIZE = 50MB, /* Tamanho máximo do banco */
	FILEGROWTH = 5MB) /* Taxa de crescimento do banco */
LOG ON /* Arquivo de log */
(NAME = 'SUCOS_VENDAS.LOG', /* Nome do arquivo onde sera armazendo os arquivos de transações, caso desejamos recuperar o estado do banco */
	FILENAME = 'C:\TEMP\SUCOS_VENDAS_02.LDF', /* Caminho da pasta */
	SIZE = 10MB, /* Tamanho inicial do banco */
	MAXSIZE = 50MB, /* Tamanho máximo do banco */
	FILEGROWTH = 5MB); /* Taxa de crescimento do banco */