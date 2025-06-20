/*
   quarta-feira, 8 de janeiro de 202513:32:57
   Usuário: sa
   Servidor: localhost\SQLEXPRESS
   Banco de Dados: ilis
   Aplicativo: 
*/

/* Para impedir possíveis problemas de perda de dados, analise este script detalhadamente antes de executá-lo fora do contexto do designer de banco de dados.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Paciente
	(
	Id int NOT NULL AUTO_INCREMENT,
	Nome varchar(50) NOT NULL,
	Sobrenome varchar(50) NOT NULL,
	RG varchar(50) NULL,
	CPF varchar(50) NOT NULL,
	CNS varchar(50) NULL,
	Endereco varchar(200) NULL,
	Bairro varchar(100) NULL,
	CEP varchar(50) NULL,
	Cidade varchar(50) NULL,
	DtaNascimento varchar(50) NULL,
	Sexo char(1) NULL,
	Preferencial bit NULL,
	CodAcesso varchar(50) NULL,
	Telefone varchar(50) NULL,
	Email varchar(50) NULL,
	Celular varchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Paciente ADD CONSTRAINT
	PK_Paciente PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Paciente SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
