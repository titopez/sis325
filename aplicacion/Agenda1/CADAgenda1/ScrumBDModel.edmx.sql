
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/19/2012 02:14:59
-- Generated from EDMX file: D:\repositoriosGit\sis325\aplicacion\Agenda1\CADAgenda1\ScrumBDModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_RolesDeUnProyecto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roles] DROP CONSTRAINT [FK_RolesDeUnProyecto];
GO
IF OBJECT_ID(N'[dbo].[FK_HistoriasDeUnProyecto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Historias] DROP CONSTRAINT [FK_HistoriasDeUnProyecto];
GO
IF OBJECT_ID(N'[dbo].[FK_RolesdeTarea]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tareas] DROP CONSTRAINT [FK_RolesdeTarea];
GO
IF OBJECT_ID(N'[dbo].[FK_TareasDeUnaHistoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tareas] DROP CONSTRAINT [FK_TareasDeUnaHistoria];
GO
IF OBJECT_ID(N'[dbo].[FK_TareasDeUnSprint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tareas] DROP CONSTRAINT [FK_TareasDeUnSprint];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Proyectos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proyectos];
GO
IF OBJECT_ID(N'[dbo].[Historias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Historias];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Tareas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tareas];
GO
IF OBJECT_ID(N'[dbo].[Sprints]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sprints];
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

-- Creating table 'Tareas'
CREATE TABLE [dbo].[Tareas] (
    [id_tarea] int IDENTITY(1,1) NOT NULL,
    [Nombre_Tarea] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Horas] int  NOT NULL,
    [Historia_id] int  NOT NULL,
    [Sprint_id] int  NOT NULL,
    [Rol_id] int  NOT NULL
);
GO

-- Creating table 'Sprints'
CREATE TABLE [dbo].[Sprints] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Inicio] datetime  NOT NULL,
    [Duracion] int  NOT NULL,
    [Estado] nvarchar(max)  NULL,
    [Tareas_Pendientes] int  NULL,
    [Horas_Pendientes] int  NULL
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

-- Creating primary key on [id_tarea] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [PK_Tareas]
    PRIMARY KEY CLUSTERED ([id_tarea] ASC);
GO

-- Creating primary key on [id] in table 'Sprints'
ALTER TABLE [dbo].[Sprints]
ADD CONSTRAINT [PK_Sprints]
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

-- Creating foreign key on [Historia_id] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [FK_TareasDeUnaHistoria]
    FOREIGN KEY ([Historia_id])
    REFERENCES [dbo].[Historias]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TareasDeUnaHistoria'
CREATE INDEX [IX_FK_TareasDeUnaHistoria]
ON [dbo].[Tareas]
    ([Historia_id]);
GO

-- Creating foreign key on [Sprint_id] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [FK_TareasDeUnSprint]
    FOREIGN KEY ([Sprint_id])
    REFERENCES [dbo].[Sprints]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TareasDeUnSprint'
CREATE INDEX [IX_FK_TareasDeUnSprint]
ON [dbo].[Tareas]
    ([Sprint_id]);
GO

-- Creating foreign key on [Rol_id] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [FK_ResponsableDeTares]
    FOREIGN KEY ([Rol_id])
    REFERENCES [dbo].[Roles]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ResponsableDeTares'
CREATE INDEX [IX_FK_ResponsableDeTares]
ON [dbo].[Tareas]
    ([Rol_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------