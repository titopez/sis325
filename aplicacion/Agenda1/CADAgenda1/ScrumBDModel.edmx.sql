
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/17/2012 18:56:35
-- Generated from EDMX file: D:\Universidad\SIS 325\Practicas\Proyecto SCRUM\Sergio\Agenda1\CADAgenda1\ScrumBDModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ScrumBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_HistoriasDeUnProyecto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Historias] DROP CONSTRAINT [FK_HistoriasDeUnProyecto];
GO
IF OBJECT_ID(N'[dbo].[FK_RolesDeUnProyecto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roles] DROP CONSTRAINT [FK_RolesDeUnProyecto];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Historias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Historias];
GO
IF OBJECT_ID(N'[dbo].[Proyectos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proyectos];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Proyectos'
CREATE TABLE [dbo].[Proyectos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(60)  NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFinalizacion] datetime  NOT NULL,
    [Objetivo] nvarchar(max)  NOT NULL,
    [CajaTiempo] int  NOT NULL,
    [Necesidad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Historias'
CREATE TABLE [dbo].[Historias] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Prioridad] int  NOT NULL,
    [Habilitado] bit  NOT NULL,
    [Proyecto_id] int  NOT NULL,
    [Cantidad_Horas] int  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [id] int IDENTITY(1,1) NOT NULL,
    [NombreCompleto] nvarchar(max)  NOT NULL,
    [Responsabilidad] nvarchar(max)  NOT NULL,
    [ResponsabilidadSecundaria] nvarchar(max)  NOT NULL,
    [Proyecto_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Proyectos'
ALTER TABLE [dbo].[Proyectos]
ADD CONSTRAINT [PK_Proyectos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Historias'
ALTER TABLE [dbo].[Historias]
ADD CONSTRAINT [PK_Historias]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Proyecto_id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [FK_RolesDeUnProyecto]
    FOREIGN KEY ([Proyecto_id])
    REFERENCES [dbo].[Proyectos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RolesDeUnProyecto'
CREATE INDEX [IX_FK_RolesDeUnProyecto]
ON [dbo].[Roles]
    ([Proyecto_id]);
GO

-- Creating foreign key on [Proyecto_id] in table 'Historias'
ALTER TABLE [dbo].[Historias]
ADD CONSTRAINT [FK_HistoriasDeUnProyecto]
    FOREIGN KEY ([Proyecto_id])
    REFERENCES [dbo].[Proyectos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HistoriasDeUnProyecto'
CREATE INDEX [IX_FK_HistoriasDeUnProyecto]
ON [dbo].[Historias]
    ([Proyecto_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------