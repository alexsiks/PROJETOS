﻿CREATE TABLE [dbo].[PESSOA] (
    [idPESSOA]       INT           IDENTITY (1, 1) NOT NULL,
    [NOME]           VARCHAR (20)  NOT NULL ,
    [SOBRENOME]      VARCHAR (100) NOT NULL,
    [SEXO]           CHAR (1)      NOT NULL,
    [DATANASCIMENTO] VARCHAR(20)  NOT NULL,
    CONSTRAINT [PK__PESSOA__5C1FD06C7F60ED59] PRIMARY KEY CLUSTERED ([idPESSOA] ASC)
);

