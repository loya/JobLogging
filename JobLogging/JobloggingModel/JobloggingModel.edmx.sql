
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 08/01/2013 22:10:56
-- Generated from EDMX file: D:\Users\loya\Documents\Visual Studio 2012\Projects\JobLogging\JobLogging\JobloggingModel\JobloggingModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [JobLogging];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RolePermission_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolePermission] DROP CONSTRAINT [FK_RolePermission_Role];
GO
IF OBJECT_ID(N'[dbo].[FK_RolePermission_Permission]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolePermission] DROP CONSTRAINT [FK_RolePermission_Permission];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleStaff]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_RoleStaff];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[JobOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobOrders];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Permissions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permissions];
GO
IF OBJECT_ID(N'[dbo].[RolePermission]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolePermission];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(10)  NOT NULL,
    [Skin] nvarchar(20)  NULL,
    [RoleID] int  NOT NULL,
    [Sort] int  NULL,
    [JobCount] int  NULL,
    [IsEngineer] bit  NULL,
    [IsActivate] bit  NOT NULL
);
GO

-- Creating table 'JobOrders'
CREATE TABLE [dbo].[JobOrders] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Staffs] nvarchar(max)  NOT NULL,
    [ServiceTag] nvarchar(max)  NOT NULL,
    [CustomerName] nvarchar(30)  NULL,
    [Contact] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [Result] nvarchar(max)  NULL,
    [Memo] nvarchar(max)  NULL,
    [CreateBy] nvarchar(10)  NULL,
    [CreateDate] datetime  NULL,
    [ModifyBy] nvarchar(10)  NULL,
    [ModifyDate] datetime  NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'Permissions'
CREATE TABLE [dbo].[Permissions] (
    [Name] nvarchar(20)  NOT NULL,
    [Text] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolePermission'
CREATE TABLE [dbo].[RolePermission] (
    [Roles_ID] int  NOT NULL,
    [Permissions_Name] nvarchar(20)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'JobOrders'
ALTER TABLE [dbo].[JobOrders]
ADD CONSTRAINT [PK_JobOrders]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Name] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [PK_Permissions]
    PRIMARY KEY CLUSTERED ([Name] ASC);
GO

-- Creating primary key on [Roles_ID], [Permissions_Name] in table 'RolePermission'
ALTER TABLE [dbo].[RolePermission]
ADD CONSTRAINT [PK_RolePermission]
    PRIMARY KEY NONCLUSTERED ([Roles_ID], [Permissions_Name] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Roles_ID] in table 'RolePermission'
ALTER TABLE [dbo].[RolePermission]
ADD CONSTRAINT [FK_RolePermission_Role]
    FOREIGN KEY ([Roles_ID])
    REFERENCES [dbo].[Roles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Permissions_Name] in table 'RolePermission'
ALTER TABLE [dbo].[RolePermission]
ADD CONSTRAINT [FK_RolePermission_Permission]
    FOREIGN KEY ([Permissions_Name])
    REFERENCES [dbo].[Permissions]
        ([Name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RolePermission_Permission'
CREATE INDEX [IX_FK_RolePermission_Permission]
ON [dbo].[RolePermission]
    ([Permissions_Name]);
GO

-- Creating foreign key on [RoleID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_RoleStaff]
    FOREIGN KEY ([RoleID])
    REFERENCES [dbo].[Roles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleStaff'
CREATE INDEX [IX_FK_RoleStaff]
ON [dbo].[Users]
    ([RoleID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------