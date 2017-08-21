
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/18/2017 21:49:02
-- Generated from EDMX file: C:\Users\Philip\documents\visual studio 2015\Projects\Urenregistratie\UrenregistratieService\UrenregistratieDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UrenregistratieDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProjectUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AppUsers] DROP CONSTRAINT [FK_ProjectUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_UserTask];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AppUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AppUsers];
GO
IF OBJECT_ID(N'[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects];
GO
IF OBJECT_ID(N'[dbo].[Tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tasks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AppUsers'
CREATE TABLE [dbo].[AppUsers] (
    [Userid] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Project_Projectid] int  NOT NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [Projectid] int IDENTITY(1,1) NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [Taskid] int IDENTITY(1,1) NOT NULL,
    [Hours] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [AppUser_Userid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Userid] in table 'AppUsers'
ALTER TABLE [dbo].[AppUsers]
ADD CONSTRAINT [PK_AppUsers]
    PRIMARY KEY CLUSTERED ([Userid] ASC);
GO

-- Creating primary key on [Projectid] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([Projectid] ASC);
GO

-- Creating primary key on [Taskid] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([Taskid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Project_Projectid] in table 'AppUsers'
ALTER TABLE [dbo].[AppUsers]
ADD CONSTRAINT [FK_ProjectUsers]
    FOREIGN KEY ([Project_Projectid])
    REFERENCES [dbo].[Projects]
        ([Projectid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectUsers'
CREATE INDEX [IX_FK_ProjectUsers]
ON [dbo].[AppUsers]
    ([Project_Projectid]);
GO

-- Creating foreign key on [AppUser_Userid] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Tasks1]
    FOREIGN KEY ([AppUser_Userid])
    REFERENCES [dbo].[AppUsers]
        ([Userid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks1'
CREATE INDEX [IX_FK_Tasks1]
ON [dbo].[Tasks]
    ([AppUser_Userid]);
GO

-- Inserting default project in table 'Projects'.
INSERT INTO [dbo].[Projects] ([Projectid], [ProjectName]) VALUES (1, N'UR-Project')
-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------