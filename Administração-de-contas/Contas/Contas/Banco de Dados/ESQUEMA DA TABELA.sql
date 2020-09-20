
/*
ESQUEMA DAS TABELAS CONTA,CREDOR,PAGAMENTO

*/

DROP TABLE PESSOA,CONTA,CREDOR,PAGAMENTO


---------------------------------------------------TABELA CONTA------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[CONTA](
	[idCONTA] [varchar](100) PRIMARY KEY NOT NULL,
	[idPESSOA] [int] NOT NULL,
	[idCREDOR] [int] NOT NULL,
	[PERIODO] [date] NOT NULL,
	[VENCIMENTO] [date] NOT NULL,
	[VALOR] [money] NOT NULL
	)

	go
-------------------------------------------------------TABELA DE CREDOR-------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[CREDOR](
	[idCREDOR] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[NOME] [varchar](100) NOT NULL,
	[COMENTARIO] [varchar](1) NOT NULL,
	[TIPOCREDOR] [char](8) NULL
	)
	go
-------------------------------------------------TABELA DE PAGAMENTO------------------------------------------------------

CREATE TABLE [dbo].[PAGAMENTO](
	[idPAGAMENTO] [varchar](50) PRIMARY KEY  NOT NULL,
	[idCREDOR] [int] NOT NULL,
	[idCONTA] [varchar](100) NOT NULL,
	[DATAPAGAMENTO] [datetime] NOT NULL,
	[IDPESSOA] [int] NULL
)
-----------------------------------------TABELA DE PESSOAS-----------------------------------------------------------------------------
CREATE TABLE [dbo].[PESSOA] (
    [idPESSOA]       INT       PRIMARY KEY   IDENTITY (1, 1) NOT NULL,
    [NOME]           VARCHAR (20)  NOT NULL ,
    [SOBRENOME]      VARCHAR (100) NOT NULL,
    [SEXO]           CHAR (1)      NOT NULL,
    [DATANASCIMENTO] DATE   NOT NULL,
    DATACADASTRO DATETIME ,
    ATUALIZACAODADOS DATETIME 
)

ALTER TABLE CREDOR
ADD EMAIL VARCHAR(50),TELEFONE CHAR(11)



ALTER TABLE CREDOR
ALTER COLUMN 

SELECT*FROM PESSOA