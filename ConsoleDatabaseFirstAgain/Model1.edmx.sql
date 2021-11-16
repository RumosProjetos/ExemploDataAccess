
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/16/2021 21:12:37
-- Generated from EDMX file: C:\Dev\Rumos\ExemploDataAccess\ConsoleDatabaseFirstAgain\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PessoaTelefones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TelefonesSet] DROP CONSTRAINT [FK_PessoaTelefones];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PessoaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet];
GO
IF OBJECT_ID(N'[dbo].[TelefonesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TelefonesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PessoaSet'
CREATE TABLE [dbo].[PessoaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [DataNascimento] nvarchar(max)  NOT NULL,
    [ECasadoCom_Id] int  NOT NULL
);
GO

-- Creating table 'TelefonesSet'
CREATE TABLE [dbo].[TelefonesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [Pessoa_Id] int  NOT NULL
);
GO

-- Creating table 'ProdutoSet'
CREATE TABLE [dbo].[ProdutoSet] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'PessoaProduto'
CREATE TABLE [dbo].[PessoaProduto] (
    [Pessoa_Id] int  NOT NULL,
    [Produto_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [PK_PessoaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TelefonesSet'
ALTER TABLE [dbo].[TelefonesSet]
ADD CONSTRAINT [PK_TelefonesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProdutoSet'
ALTER TABLE [dbo].[ProdutoSet]
ADD CONSTRAINT [PK_ProdutoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Pessoa_Id], [Produto_Id] in table 'PessoaProduto'
ALTER TABLE [dbo].[PessoaProduto]
ADD CONSTRAINT [PK_PessoaProduto]
    PRIMARY KEY CLUSTERED ([Pessoa_Id], [Produto_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Pessoa_Id] in table 'TelefonesSet'
ALTER TABLE [dbo].[TelefonesSet]
ADD CONSTRAINT [FK_PessoaTelefones]
    FOREIGN KEY ([Pessoa_Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaTelefones'
CREATE INDEX [IX_FK_PessoaTelefones]
ON [dbo].[TelefonesSet]
    ([Pessoa_Id]);
GO

-- Creating foreign key on [ECasadoCom_Id] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [FK_PessoaPessoa]
    FOREIGN KEY ([ECasadoCom_Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaPessoa'
CREATE INDEX [IX_FK_PessoaPessoa]
ON [dbo].[PessoaSet]
    ([ECasadoCom_Id]);
GO

-- Creating foreign key on [Pessoa_Id] in table 'PessoaProduto'
ALTER TABLE [dbo].[PessoaProduto]
ADD CONSTRAINT [FK_PessoaProduto_Pessoa]
    FOREIGN KEY ([Pessoa_Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Produto_Id] in table 'PessoaProduto'
ALTER TABLE [dbo].[PessoaProduto]
ADD CONSTRAINT [FK_PessoaProduto_Produto]
    FOREIGN KEY ([Produto_Id])
    REFERENCES [dbo].[ProdutoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaProduto_Produto'
CREATE INDEX [IX_FK_PessoaProduto_Produto]
ON [dbo].[PessoaProduto]
    ([Produto_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------