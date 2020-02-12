
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/26/2019 10:42:19
-- Generated from EDMX file: c:\users\kr5291\documents\visual studio 2015\Projects\ConsoleApplication1_BORRAR\ConsoleApplication1_BORRAR\DatabaseFirst.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Borrar_DB_EDMX];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Table_22_Table_Borrar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Table_22] DROP CONSTRAINT [FK_Table_22_Table_Borrar];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Borrar_Table_Borrar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Table_Borrar] DROP CONSTRAINT [FK_Table_Borrar_Table_Borrar];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Table_22]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table_22];
GO
IF OBJECT_ID(N'[dbo].[Table_Borrar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table_Borrar];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Table_22'
CREATE TABLE [dbo].[Table_22] (
    [col1] nchar(10)  NULL,
    [pk1] bigint IDENTITY(1,1) NOT NULL,
    [fk_pk1] bigint  NULL
);
GO

-- Creating table 'Table_Borrar'
CREATE TABLE [dbo].[Table_Borrar] (
    [MyColumn] nvarchar(50)  NULL,
    [pk1] bigint IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [pk1] in table 'Table_22'
ALTER TABLE [dbo].[Table_22]
ADD CONSTRAINT [PK_Table_22]
    PRIMARY KEY CLUSTERED ([pk1] ASC);
GO

-- Creating primary key on [pk1] in table 'Table_Borrar'
ALTER TABLE [dbo].[Table_Borrar]
ADD CONSTRAINT [PK_Table_Borrar]
    PRIMARY KEY CLUSTERED ([pk1] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [fk_pk1] in table 'Table_22'
ALTER TABLE [dbo].[Table_22]
ADD CONSTRAINT [FK_Table_22_Table_Borrar]
    FOREIGN KEY ([fk_pk1])
    REFERENCES [dbo].[Table_Borrar]
        ([pk1])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_22_Table_Borrar'
CREATE INDEX [IX_FK_Table_22_Table_Borrar]
ON [dbo].[Table_22]
    ([fk_pk1]);
GO

-- Creating foreign key on [pk1] in table 'Table_Borrar'
ALTER TABLE [dbo].[Table_Borrar]
ADD CONSTRAINT [FK_Table_Borrar_Table_Borrar]
    FOREIGN KEY ([pk1])
    REFERENCES [dbo].[Table_Borrar]
        ([pk1])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------