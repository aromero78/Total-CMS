
-- --------------------------------------------------
-- Date Created: 04/15/2010 00:32:46
-- Generated from EDMX file: C:\Documents and Settings\Anthony\Total-CMS\TotalCMSLib\TotalCMS.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
SET ANSI_NULLS ON;
GO

USE [TotalCMS]
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]')
GO

-- --------------------------------------------------
-- Dropping existing FK constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsersContentItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_UsersContentItems]
GO
IF OBJECT_ID(N'[dbo].[FK_UsersContentItems1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_UsersContentItems1]
GO
IF OBJECT_ID(N'[dbo].[FK_UsersToUserRolesUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersToUserRoles] DROP CONSTRAINT [FK_UsersToUserRolesUsers]
GO
IF OBJECT_ID(N'[dbo].[FK_FoldersContentItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_FoldersContentItems]
GO
IF OBJECT_ID(N'[dbo].[FK_LanguagesUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersSet] DROP CONSTRAINT [FK_LanguagesUsers]
GO
IF OBJECT_ID(N'[dbo].[FK_LanguagesFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Folders] DROP CONSTRAINT [FK_LanguagesFolders]
GO
IF OBJECT_ID(N'[dbo].[FK_CalendarsFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Calendars] DROP CONSTRAINT [FK_CalendarsFolders]
GO
IF OBJECT_ID(N'[dbo].[FK_CalendarsCalendarEvents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CalendarEvents] DROP CONSTRAINT [FK_CalendarsCalendarEvents]
GO
IF OBJECT_ID(N'[dbo].[FK_MenusFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_MenusFolders]
GO
IF OBJECT_ID(N'[dbo].[FK_MenuItemsMenus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_MenuItemsMenus]
GO
IF OBJECT_ID(N'[dbo].[FK_LibraryItemsFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LibraryItems] DROP CONSTRAINT [FK_LibraryItemsFolders]
GO
IF OBJECT_ID(N'[dbo].[FK_UsersToUserRolesUserRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersToUserRoles] DROP CONSTRAINT [FK_UsersToUserRolesUserRoles]
GO
IF OBJECT_ID(N'[dbo].[FK_AdminElementAdminPages]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TemplateElements] DROP CONSTRAINT [FK_AdminElementAdminPages]
GO
IF OBJECT_ID(N'[dbo].[FK_PagesAliases]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aliases] DROP CONSTRAINT [FK_PagesAliases]
GO
IF OBJECT_ID(N'[dbo].[FK_ChildFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Folders] DROP CONSTRAINT [FK_ChildFolders]
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionsUserRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permissions] DROP CONSTRAINT [FK_PermissionsUserRoles]
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionsFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permissions] DROP CONSTRAINT [FK_PermissionsFolders]
GO
IF OBJECT_ID(N'[dbo].[FK_MetaDataTypeToFolderFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MetaDataTypeToFolders] DROP CONSTRAINT [FK_MetaDataTypeToFolderFolders]
GO
IF OBJECT_ID(N'[dbo].[FK_MetaDataTypeToFolderMetaDataTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MetaDataTypeToFolders] DROP CONSTRAINT [FK_MetaDataTypeToFolderMetaDataTypes]
GO
IF OBJECT_ID(N'[dbo].[FK_MetaDataValueTypesMetaDataTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MetaDataTypes] DROP CONSTRAINT [FK_MetaDataValueTypesMetaDataTypes]
GO
IF OBJECT_ID(N'[dbo].[FK_MetaDataTypesToContentItemsMetaDataTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MetaDataTypesToContentItems] DROP CONSTRAINT [FK_MetaDataTypesToContentItemsMetaDataTypes]
GO
IF OBJECT_ID(N'[dbo].[FK_MetaDataTypesToContentItemsContentItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MetaDataTypesToContentItems] DROP CONSTRAINT [FK_MetaDataTypesToContentItemsContentItems]
GO
IF OBJECT_ID(N'[dbo].[FK_ContentHistoryContentItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContentHistories] DROP CONSTRAINT [FK_ContentHistoryContentItems]
GO
IF OBJECT_ID(N'[dbo].[FK_ContentHistoryUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContentHistories] DROP CONSTRAINT [FK_ContentHistoryUsers]
GO
IF OBJECT_ID(N'[dbo].[FK_AliasesContentItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aliases] DROP CONSTRAINT [FK_AliasesContentItems]
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectXsltSetContentItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_ObjectXsltSetContentItems]
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectSchemaObjectXsltSets]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectXslts] DROP CONSTRAINT [FK_ObjectSchemaObjectXsltSets]
GO
IF OBJECT_ID(N'[dbo].[FK_MenusMenus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_MenusMenus]
GO
IF OBJECT_ID(N'[dbo].[FK_MenusMenus1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_MenusMenus1]
GO
IF OBJECT_ID(N'[dbo].[FK_ContentItemsObjectTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_ContentItemsObjectTypes]
GO
IF OBJECT_ID(N'[dbo].[FK_TemplateElementContentItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TemplateElements] DROP CONSTRAINT [FK_TemplateElementContentItems]
GO
IF OBJECT_ID(N'[dbo].[FK_AliasesMenuItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_AliasesMenuItems]
GO
IF OBJECT_ID(N'[dbo].[FK_AliasesMenus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_AliasesMenus]
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectTypesTemplateElements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TemplateElements] DROP CONSTRAINT [FK_ObjectTypesTemplateElements]
GO
IF OBJECT_ID(N'[dbo].[FK_WorkflowsFolders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Folders] DROP CONSTRAINT [FK_WorkflowsFolders]
GO
IF OBJECT_ID(N'[dbo].[FK_WorkFlowStepsWorkflows]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkFlowSteps] DROP CONSTRAINT [FK_WorkFlowStepsWorkflows]
GO
IF OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesWorkflows]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkFlowInstances] DROP CONSTRAINT [FK_WorkFlowInstancesWorkflows]
GO
IF OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesContentItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_WorkFlowInstancesContentItems]
GO
IF OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesObjectTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectTypes] DROP CONSTRAINT [FK_WorkFlowInstancesObjectTypes]
GO
IF OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesCalendars]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Calendars] DROP CONSTRAINT [FK_WorkFlowInstancesCalendars]
GO
IF OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesTemplates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Templates] DROP CONSTRAINT [FK_WorkFlowInstancesTemplates]
GO
IF OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesMenus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_WorkFlowInstancesMenus]
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectTypeHistoriesObjectTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectTypeHistories] DROP CONSTRAINT [FK_ObjectTypeHistoriesObjectTypes]
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectTypeHistoriesUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectTypeHistories] DROP CONSTRAINT [FK_ObjectTypeHistoriesUsers]
GO
IF OBJECT_ID(N'[dbo].[FK_MenuHistoriesMenus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuHistories] DROP CONSTRAINT [FK_MenuHistoriesMenus]
GO
IF OBJECT_ID(N'[dbo].[FK_MenuHistoriesUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuHistories] DROP CONSTRAINT [FK_MenuHistoriesUsers]
GO
IF OBJECT_ID(N'[dbo].[FK_UserRolesToWorkFlowStepsUserRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserRolesToWorkFlowSteps] DROP CONSTRAINT [FK_UserRolesToWorkFlowStepsUserRoles]
GO
IF OBJECT_ID(N'[dbo].[FK_UserRolesToWorkFlowStepsWorkFlowSteps]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserRolesToWorkFlowSteps] DROP CONSTRAINT [FK_UserRolesToWorkFlowStepsWorkFlowSteps]
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ContentItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContentItems];
GO
IF OBJECT_ID(N'[dbo].[UserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserRoles];
GO
IF OBJECT_ID(N'[dbo].[UsersToUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersToUserRoles];
GO
IF OBJECT_ID(N'[dbo].[Folders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Folders];
GO
IF OBJECT_ID(N'[dbo].[LibraryItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LibraryItems];
GO
IF OBJECT_ID(N'[dbo].[Menus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menus];
GO
IF OBJECT_ID(N'[dbo].[MenuItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuItems];
GO
IF OBJECT_ID(N'[dbo].[Calendars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Calendars];
GO
IF OBJECT_ID(N'[dbo].[CalendarEvents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CalendarEvents];
GO
IF OBJECT_ID(N'[dbo].[Aliases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aliases];
GO
IF OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaDataTypesToContentItems];
GO
IF OBJECT_ID(N'[dbo].[MetaDataTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaDataTypes];
GO
IF OBJECT_ID(N'[dbo].[Languages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Languages];
GO
IF OBJECT_ID(N'[dbo].[UsersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersSet];
GO
IF OBJECT_ID(N'[dbo].[Templates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Templates];
GO
IF OBJECT_ID(N'[dbo].[TemplateElements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TemplateElements];
GO
IF OBJECT_ID(N'[dbo].[Permissions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permissions];
GO
IF OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaDataTypeToFolders];
GO
IF OBJECT_ID(N'[dbo].[MetaDataValueTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaDataValueTypes];
GO
IF OBJECT_ID(N'[dbo].[ContentHistories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContentHistories];
GO
IF OBJECT_ID(N'[dbo].[ObjectTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectTypes];
GO
IF OBJECT_ID(N'[dbo].[ObjectXslts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectXslts];
GO
IF OBJECT_ID(N'[dbo].[Settings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Settings];
GO
IF OBJECT_ID(N'[dbo].[ObjectTypeHistories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectTypeHistories];
GO
IF OBJECT_ID(N'[dbo].[Workflows]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Workflows];
GO
IF OBJECT_ID(N'[dbo].[WorkFlowSteps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkFlowSteps];
GO
IF OBJECT_ID(N'[dbo].[WorkFlowInstances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkFlowInstances];
GO
IF OBJECT_ID(N'[dbo].[MenuHistories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuHistories];
GO
IF OBJECT_ID(N'[dbo].[UserRolesToWorkFlowSteps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserRolesToWorkFlowSteps];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ContentItems'
CREATE TABLE [dbo].[ContentItems] (
    [ContentItemId] int  NOT NULL,
    [ContentHtml] nvarchar(max)  NOT NULL,
    [ContentSummary] nvarchar(250)  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [DateModified] datetime  NULL,
    [CreatedByUserId] int  NOT NULL,
    [ModifiedByUserId] int  NULL,
    [FolderId] int  NOT NULL,
    [ContentStatus] nvarchar(2)  NOT NULL,
    [ObjectXsltId] int  NOT NULL,
    [ObjectSchemaId] int  NOT NULL,
    [ContentDisplayId] int  NOT NULL,
    [IsActive] bit  NOT NULL,
    [WorkFlowInstanceId] int  NULL
);
GO
-- Creating table 'UserRoles'
CREATE TABLE [dbo].[UserRoles] (
    [UserRoleId] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [IsSingleton] bit  NOT NULL
);
GO
-- Creating table 'UsersToUserRoles'
CREATE TABLE [dbo].[UsersToUserRoles] (
    [UserToUserRoleId] int  NOT NULL,
    [UserRoleId] int  NOT NULL,
    [UserId] int  NOT NULL
);
GO
-- Creating table 'Folders'
CREATE TABLE [dbo].[Folders] (
    [FolderId] int  NOT NULL,
    [LanguageId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [InheritPermissions] bit  NOT NULL,
    [ParentFolderId] int  NULL,
    [InheritMetaData] bit  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [DateModified] nvarchar(max)  NULL,
    [PermissionsId] int  NOT NULL,
    [IsActive] bit  NOT NULL,
    [WorkflowId] int  NOT NULL,
    [IsSystemFolder] bit  NOT NULL,
    [AddCalendarsToWorkflow] bit  NOT NULL,
    [AddMenusToWorkflow] bit  NOT NULL,
    [Language_LanguageId] int  NOT NULL
);
GO
-- Creating table 'LibraryItems'
CREATE TABLE [dbo].[LibraryItems] (
    [LibraryItemId] int  NOT NULL,
    [FolderId] int  NOT NULL,
    [FileUrl] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Desciprtion] nvarchar(max)  NOT NULL
);
GO
-- Creating table 'Menus'
CREATE TABLE [dbo].[Menus] (
    [MenuId] int  NOT NULL,
    [FolderId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Property] nvarchar(max)  NOT NULL,
    [OrderId] nvarchar(max)  NOT NULL,
    [ParentMenuId] int  NOT NULL,
    [RootMenuId] int  NOT NULL,
    [AliasId] int  NOT NULL,
    [WorkFlowInstanceId] int  NULL
);
GO
-- Creating table 'MenuItems'
CREATE TABLE [dbo].[MenuItems] (
    [MenuItemId] int  NOT NULL,
    [MenuId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [OrderId] nvarchar(max)  NOT NULL,
    [AliasId] int  NOT NULL
);
GO
-- Creating table 'Calendars'
CREATE TABLE [dbo].[Calendars] (
    [CalendarId] int  NOT NULL,
    [FolderId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [WorkFlowInstanceId] int  NULL
);
GO
-- Creating table 'CalendarEvents'
CREATE TABLE [dbo].[CalendarEvents] (
    [CalendarEventIds] int  NOT NULL,
    [CalendarId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [iCalSettings] nvarchar(max)  NOT NULL
);
GO
-- Creating table 'Aliases'
CREATE TABLE [dbo].[Aliases] (
    [AliasId] int  NOT NULL,
    [TemplateId] int  NOT NULL,
    [Alias] nvarchar(max)  NOT NULL,
    [IsActive] bit  NOT NULL,
    [ContentItemId] int  NOT NULL
);
GO
-- Creating table 'MetaDataTypesToContentItems'
CREATE TABLE [dbo].[MetaDataTypesToContentItems] (
    [MetaDataTypesToContentItemId] int  NOT NULL,
    [MetaDataTypeId] int  NOT NULL,
    [ContentItemId] int  NOT NULL,
    [Value] nvarchar(max)  NULL
);
GO
-- Creating table 'MetaDataTypes'
CREATE TABLE [dbo].[MetaDataTypes] (
    [MetaDataTypeId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DefaultValue] nvarchar(max)  NOT NULL,
    [MetaDataValueTypesId] int  NOT NULL
);
GO
-- Creating table 'Languages'
CREATE TABLE [dbo].[Languages] (
    [LanguageId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [IsActive] bit  NOT NULL,
    [IsDefault] bit  NOT NULL,
    [LangId] int  NOT NULL
);
GO
-- Creating table 'UsersSet'
CREATE TABLE [dbo].[UsersSet] (
    [UserId] int  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [UserName] nvarchar(50)  NOT NULL,
    [Password] nvarchar(50)  NOT NULL,
    [LanguageId] int  NOT NULL
);
GO
-- Creating table 'Templates'
CREATE TABLE [dbo].[Templates] (
    [TemplateId] int  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [IsUserDefined] bit  NOT NULL,
    [TemplateFileUrl] nvarchar(max)  NOT NULL,
    [WorkFlowInstanceId] int  NULL
);
GO
-- Creating table 'TemplateElements'
CREATE TABLE [dbo].[TemplateElements] (
    [TemplateElementId] int  NOT NULL,
    [XsltId] uniqueidentifier  NOT NULL,
    [TemplateId] int  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DynamicParamName] nvarchar(max)  NULL,
    [ContentItemId] int  NULL,
    [ObjectTypeId] int  NOT NULL
);
GO
-- Creating table 'Permissions'
CREATE TABLE [dbo].[Permissions] (
    [PermissionId] int  NOT NULL,
    [UserRoleId] int  NOT NULL,
    [CanReadContent] bit  NOT NULL,
    [CanAddContent] bit  NOT NULL,
    [CanDeleteContent] bit  NOT NULL,
    [CanReadMenus] bit  NOT NULL,
    [CanAddMenus] bit  NOT NULL,
    [CanDeleteMenus] bit  NOT NULL,
    [CanReadFolders] bit  NOT NULL,
    [CanAddFolders] bit  NOT NULL,
    [CanDeleteFoldres] bit  NOT NULL,
    [CanReadCalendars] bit  NOT NULL,
    [CanAddCalendars] bit  NOT NULL,
    [CanDeleteCalednars] bit  NOT NULL,
    [CanEditContent] bit  NOT NULL,
    [CanEditMenus] bit  NOT NULL,
    [CanEditFolder] bit  NOT NULL,
    [CanEditCalendar] bit  NOT NULL,
    [FolderId] int  NOT NULL,
    [CanReadPages] bit  NOT NULL,
    [CanEditPages] nvarchar(max)  NOT NULL,
    [CanAddPages] nvarchar(max)  NOT NULL,
    [CanDeletePages] nvarchar(max)  NOT NULL
);
GO
-- Creating table 'MetaDataTypeToFolders'
CREATE TABLE [dbo].[MetaDataTypeToFolders] (
    [MetaDataTypeToFolderId] int  NOT NULL,
    [FolderId] int  NOT NULL,
    [MetaDataTypeId] int  NOT NULL,
    [IsRequired] bit  NOT NULL
);
GO
-- Creating table 'MetaDataValueTypes'
CREATE TABLE [dbo].[MetaDataValueTypes] (
    [MetaDataValueTypeId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO
-- Creating table 'ContentHistories'
CREATE TABLE [dbo].[ContentHistories] (
    [ContentHistoryId] int  NOT NULL,
    [ContentItemId] int  NOT NULL,
    [VersionNumber] float  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [CreatedByUserId] int  NOT NULL,
    [SerializedData] varbinary(max)  NOT NULL
);
GO
-- Creating table 'ObjectTypes'
CREATE TABLE [dbo].[ObjectTypes] (
    [ObjectTypeId] int  NOT NULL,
    [DataEntryXslt] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DefaultDisplayXslt] nvarchar(max)  NOT NULL,
    [SchemaXml] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [WorkFlowInstanceId] int  NULL,
    [IsActive] bit  NOT NULL
);
GO
-- Creating table 'ObjectXslts'
CREATE TABLE [dbo].[ObjectXslts] (
    [ObjectXsltId] int  NOT NULL,
    [ObjectXsltUri] nvarchar(max)  NOT NULL,
    [ObjectSchemaId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [isValidated] bit  NOT NULL
);
GO
-- Creating table 'Settings'
CREATE TABLE [dbo].[Settings] (
    [SettingId] int  NOT NULL,
    [LicenceKey] nvarchar(max)  NOT NULL
);
GO
-- Creating table 'ObjectTypeHistories'
CREATE TABLE [dbo].[ObjectTypeHistories] (
    [ObjectTypeHistoryId] int  NOT NULL,
    [ObjectTypeId] int  NOT NULL,
    [SerializedData] varbinary(max)  NOT NULL,
    [CreatedDate] datetime  NOT NULL,
    [UserId] int  NOT NULL,
    [VersionNumber] float  NOT NULL,
    [User_UserId] int  NOT NULL
);
GO
-- Creating table 'Workflows'
CREATE TABLE [dbo].[Workflows] (
    [WorkflowId] int  NOT NULL
);
GO
-- Creating table 'WorkFlowSteps'
CREATE TABLE [dbo].[WorkFlowSteps] (
    [WorkFlowStepId] int  NOT NULL,
    [WorkflowId] int  NOT NULL,
    [StepOrder] int  NOT NULL
);
GO
-- Creating table 'WorkFlowInstances'
CREATE TABLE [dbo].[WorkFlowInstances] (
    [WorkFlowInstanceId] int  NOT NULL,
    [WorkflowId] int  NOT NULL,
    [CurrentStep] int  NOT NULL,
    [IsComplete] bit  NOT NULL
);
GO
-- Creating table 'MenuHistories'
CREATE TABLE [dbo].[MenuHistories] (
    [MenuHistoryId] int  NOT NULL,
    [MenusMenuId] int  NOT NULL,
    [CreatedByUserId] int  NOT NULL,
    [CreatedDate] datetime  NOT NULL,
    [SerializedData] varbinary(max)  NOT NULL,
    [VersionNumber] nvarchar(max)  NOT NULL
);
GO
-- Creating table 'UserRolesToWorkFlowSteps'
CREATE TABLE [dbo].[UserRolesToWorkFlowSteps] (
    [UserRolesToWorkFlowStepId] int  NOT NULL,
    [UserRolesUserRoleId] int  NOT NULL,
    [WorkFlowStepsWorkFlowStepId] int  NOT NULL,
    [IsApprover] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all Primary Key Constraints
-- --------------------------------------------------

-- Creating primary key on [ContentItemId] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems] WITH NOCHECK 
ADD CONSTRAINT [PK_ContentItems]
    PRIMARY KEY CLUSTERED ([ContentItemId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [UserRoleId] in table 'UserRoles'
ALTER TABLE [dbo].[UserRoles] WITH NOCHECK 
ADD CONSTRAINT [PK_UserRoles]
    PRIMARY KEY CLUSTERED ([UserRoleId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [UserToUserRoleId] in table 'UsersToUserRoles'
ALTER TABLE [dbo].[UsersToUserRoles] WITH NOCHECK 
ADD CONSTRAINT [PK_UsersToUserRoles]
    PRIMARY KEY CLUSTERED ([UserToUserRoleId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [FolderId] in table 'Folders'
ALTER TABLE [dbo].[Folders] WITH NOCHECK 
ADD CONSTRAINT [PK_Folders]
    PRIMARY KEY CLUSTERED ([FolderId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [LibraryItemId] in table 'LibraryItems'
ALTER TABLE [dbo].[LibraryItems] WITH NOCHECK 
ADD CONSTRAINT [PK_LibraryItems]
    PRIMARY KEY CLUSTERED ([LibraryItemId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [MenuId] in table 'Menus'
ALTER TABLE [dbo].[Menus] WITH NOCHECK 
ADD CONSTRAINT [PK_Menus]
    PRIMARY KEY CLUSTERED ([MenuId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [MenuItemId] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems] WITH NOCHECK 
ADD CONSTRAINT [PK_MenuItems]
    PRIMARY KEY CLUSTERED ([MenuItemId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [CalendarId] in table 'Calendars'
ALTER TABLE [dbo].[Calendars] WITH NOCHECK 
ADD CONSTRAINT [PK_Calendars]
    PRIMARY KEY CLUSTERED ([CalendarId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [CalendarEventIds] in table 'CalendarEvents'
ALTER TABLE [dbo].[CalendarEvents] WITH NOCHECK 
ADD CONSTRAINT [PK_CalendarEvents]
    PRIMARY KEY CLUSTERED ([CalendarEventIds] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [AliasId] in table 'Aliases'
ALTER TABLE [dbo].[Aliases] WITH NOCHECK 
ADD CONSTRAINT [PK_Aliases]
    PRIMARY KEY CLUSTERED ([AliasId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [MetaDataTypesToContentItemId] in table 'MetaDataTypesToContentItems'
ALTER TABLE [dbo].[MetaDataTypesToContentItems] WITH NOCHECK 
ADD CONSTRAINT [PK_MetaDataTypesToContentItems]
    PRIMARY KEY CLUSTERED ([MetaDataTypesToContentItemId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [MetaDataTypeId] in table 'MetaDataTypes'
ALTER TABLE [dbo].[MetaDataTypes] WITH NOCHECK 
ADD CONSTRAINT [PK_MetaDataTypes]
    PRIMARY KEY CLUSTERED ([MetaDataTypeId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [LanguageId] in table 'Languages'
ALTER TABLE [dbo].[Languages] WITH NOCHECK 
ADD CONSTRAINT [PK_Languages]
    PRIMARY KEY CLUSTERED ([LanguageId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [UserId] in table 'UsersSet'
ALTER TABLE [dbo].[UsersSet] WITH NOCHECK 
ADD CONSTRAINT [PK_UsersSet]
    PRIMARY KEY CLUSTERED ([UserId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [TemplateId] in table 'Templates'
ALTER TABLE [dbo].[Templates] WITH NOCHECK 
ADD CONSTRAINT [PK_Templates]
    PRIMARY KEY CLUSTERED ([TemplateId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [TemplateElementId] in table 'TemplateElements'
ALTER TABLE [dbo].[TemplateElements] WITH NOCHECK 
ADD CONSTRAINT [PK_TemplateElements]
    PRIMARY KEY CLUSTERED ([TemplateElementId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [PermissionId] in table 'Permissions'
ALTER TABLE [dbo].[Permissions] WITH NOCHECK 
ADD CONSTRAINT [PK_Permissions]
    PRIMARY KEY CLUSTERED ([PermissionId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [MetaDataTypeToFolderId] in table 'MetaDataTypeToFolders'
ALTER TABLE [dbo].[MetaDataTypeToFolders] WITH NOCHECK 
ADD CONSTRAINT [PK_MetaDataTypeToFolders]
    PRIMARY KEY CLUSTERED ([MetaDataTypeToFolderId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [MetaDataValueTypeId] in table 'MetaDataValueTypes'
ALTER TABLE [dbo].[MetaDataValueTypes] WITH NOCHECK 
ADD CONSTRAINT [PK_MetaDataValueTypes]
    PRIMARY KEY CLUSTERED ([MetaDataValueTypeId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [ContentHistoryId] in table 'ContentHistories'
ALTER TABLE [dbo].[ContentHistories] WITH NOCHECK 
ADD CONSTRAINT [PK_ContentHistories]
    PRIMARY KEY CLUSTERED ([ContentHistoryId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [ObjectTypeId] in table 'ObjectTypes'
ALTER TABLE [dbo].[ObjectTypes] WITH NOCHECK 
ADD CONSTRAINT [PK_ObjectTypes]
    PRIMARY KEY CLUSTERED ([ObjectTypeId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [ObjectXsltId] in table 'ObjectXslts'
ALTER TABLE [dbo].[ObjectXslts] WITH NOCHECK 
ADD CONSTRAINT [PK_ObjectXslts]
    PRIMARY KEY CLUSTERED ([ObjectXsltId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [SettingId] in table 'Settings'
ALTER TABLE [dbo].[Settings] WITH NOCHECK 
ADD CONSTRAINT [PK_Settings]
    PRIMARY KEY CLUSTERED ([SettingId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [ObjectTypeHistoryId] in table 'ObjectTypeHistories'
ALTER TABLE [dbo].[ObjectTypeHistories] WITH NOCHECK 
ADD CONSTRAINT [PK_ObjectTypeHistories]
    PRIMARY KEY CLUSTERED ([ObjectTypeHistoryId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [WorkflowId] in table 'Workflows'
ALTER TABLE [dbo].[Workflows] WITH NOCHECK 
ADD CONSTRAINT [PK_Workflows]
    PRIMARY KEY CLUSTERED ([WorkflowId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [WorkFlowStepId] in table 'WorkFlowSteps'
ALTER TABLE [dbo].[WorkFlowSteps] WITH NOCHECK 
ADD CONSTRAINT [PK_WorkFlowSteps]
    PRIMARY KEY CLUSTERED ([WorkFlowStepId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [WorkFlowInstanceId] in table 'WorkFlowInstances'
ALTER TABLE [dbo].[WorkFlowInstances] WITH NOCHECK 
ADD CONSTRAINT [PK_WorkFlowInstances]
    PRIMARY KEY CLUSTERED ([WorkFlowInstanceId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [MenuHistoryId] in table 'MenuHistories'
ALTER TABLE [dbo].[MenuHistories] WITH NOCHECK 
ADD CONSTRAINT [PK_MenuHistories]
    PRIMARY KEY CLUSTERED ([MenuHistoryId] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [UserRolesToWorkFlowStepId] in table 'UserRolesToWorkFlowSteps'
ALTER TABLE [dbo].[UserRolesToWorkFlowSteps] WITH NOCHECK 
ADD CONSTRAINT [PK_UserRolesToWorkFlowSteps]
    PRIMARY KEY CLUSTERED ([UserRolesToWorkFlowStepId] ASC)
    ON [PRIMARY]
GO

-- --------------------------------------------------
-- Creating all Foreign Key Constraints
-- --------------------------------------------------

-- Creating foreign key on [CreatedByUserId] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems] WITH NOCHECK 
ADD CONSTRAINT [FK_UsersContentItems]
    FOREIGN KEY ([CreatedByUserId])
    REFERENCES [dbo].[UsersSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ModifiedByUserId] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems] WITH NOCHECK 
ADD CONSTRAINT [FK_UsersContentItems1]
    FOREIGN KEY ([ModifiedByUserId])
    REFERENCES [dbo].[UsersSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [UserId] in table 'UsersToUserRoles'
ALTER TABLE [dbo].[UsersToUserRoles] WITH NOCHECK 
ADD CONSTRAINT [FK_UsersToUserRolesUsers]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UsersSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [FolderId] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems] WITH NOCHECK 
ADD CONSTRAINT [FK_FoldersContentItems]
    FOREIGN KEY ([FolderId])
    REFERENCES [dbo].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [LanguageId] in table 'UsersSet'
ALTER TABLE [dbo].[UsersSet] WITH NOCHECK 
ADD CONSTRAINT [FK_LanguagesUsers]
    FOREIGN KEY ([LanguageId])
    REFERENCES [dbo].[Languages]
        ([LanguageId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [Language_LanguageId] in table 'Folders'
ALTER TABLE [dbo].[Folders] WITH NOCHECK 
ADD CONSTRAINT [FK_LanguagesFolders]
    FOREIGN KEY ([Language_LanguageId])
    REFERENCES [dbo].[Languages]
        ([LanguageId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [FolderId] in table 'Calendars'
ALTER TABLE [dbo].[Calendars] WITH NOCHECK 
ADD CONSTRAINT [FK_CalendarsFolders]
    FOREIGN KEY ([FolderId])
    REFERENCES [dbo].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [CalendarId] in table 'CalendarEvents'
ALTER TABLE [dbo].[CalendarEvents] WITH NOCHECK 
ADD CONSTRAINT [FK_CalendarsCalendarEvents]
    FOREIGN KEY ([CalendarId])
    REFERENCES [dbo].[Calendars]
        ([CalendarId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [FolderId] in table 'Menus'
ALTER TABLE [dbo].[Menus] WITH NOCHECK 
ADD CONSTRAINT [FK_MenusFolders]
    FOREIGN KEY ([FolderId])
    REFERENCES [dbo].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [MenuId] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems] WITH NOCHECK 
ADD CONSTRAINT [FK_MenuItemsMenus]
    FOREIGN KEY ([MenuId])
    REFERENCES [dbo].[Menus]
        ([MenuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [FolderId] in table 'LibraryItems'
ALTER TABLE [dbo].[LibraryItems] WITH NOCHECK 
ADD CONSTRAINT [FK_LibraryItemsFolders]
    FOREIGN KEY ([FolderId])
    REFERENCES [dbo].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [UserRoleId] in table 'UsersToUserRoles'
ALTER TABLE [dbo].[UsersToUserRoles] WITH NOCHECK 
ADD CONSTRAINT [FK_UsersToUserRolesUserRoles]
    FOREIGN KEY ([UserRoleId])
    REFERENCES [dbo].[UserRoles]
        ([UserRoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [TemplateId] in table 'TemplateElements'
ALTER TABLE [dbo].[TemplateElements] WITH NOCHECK 
ADD CONSTRAINT [FK_AdminElementAdminPages]
    FOREIGN KEY ([TemplateId])
    REFERENCES [dbo].[Templates]
        ([TemplateId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [TemplateId] in table 'Aliases'
ALTER TABLE [dbo].[Aliases] WITH NOCHECK 
ADD CONSTRAINT [FK_PagesAliases]
    FOREIGN KEY ([TemplateId])
    REFERENCES [dbo].[Templates]
        ([TemplateId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ParentFolderId] in table 'Folders'
ALTER TABLE [dbo].[Folders] WITH NOCHECK 
ADD CONSTRAINT [FK_ChildFolders]
    FOREIGN KEY ([ParentFolderId])
    REFERENCES [dbo].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [UserRoleId] in table 'Permissions'
ALTER TABLE [dbo].[Permissions] WITH NOCHECK 
ADD CONSTRAINT [FK_PermissionsUserRoles]
    FOREIGN KEY ([UserRoleId])
    REFERENCES [dbo].[UserRoles]
        ([UserRoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [FolderId] in table 'Permissions'
ALTER TABLE [dbo].[Permissions] WITH NOCHECK 
ADD CONSTRAINT [FK_PermissionsFolders]
    FOREIGN KEY ([FolderId])
    REFERENCES [dbo].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [FolderId] in table 'MetaDataTypeToFolders'
ALTER TABLE [dbo].[MetaDataTypeToFolders] WITH NOCHECK 
ADD CONSTRAINT [FK_MetaDataTypeToFolderFolders]
    FOREIGN KEY ([FolderId])
    REFERENCES [dbo].[Folders]
        ([FolderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [MetaDataTypeId] in table 'MetaDataTypeToFolders'
ALTER TABLE [dbo].[MetaDataTypeToFolders] WITH NOCHECK 
ADD CONSTRAINT [FK_MetaDataTypeToFolderMetaDataTypes]
    FOREIGN KEY ([MetaDataTypeId])
    REFERENCES [dbo].[MetaDataTypes]
        ([MetaDataTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [MetaDataValueTypesId] in table 'MetaDataTypes'
ALTER TABLE [dbo].[MetaDataTypes] WITH NOCHECK 
ADD CONSTRAINT [FK_MetaDataValueTypesMetaDataTypes]
    FOREIGN KEY ([MetaDataValueTypesId])
    REFERENCES [dbo].[MetaDataValueTypes]
        ([MetaDataValueTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [MetaDataTypeId] in table 'MetaDataTypesToContentItems'
ALTER TABLE [dbo].[MetaDataTypesToContentItems] WITH NOCHECK 
ADD CONSTRAINT [FK_MetaDataTypesToContentItemsMetaDataTypes]
    FOREIGN KEY ([MetaDataTypeId])
    REFERENCES [dbo].[MetaDataTypes]
        ([MetaDataTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ContentItemId] in table 'MetaDataTypesToContentItems'
ALTER TABLE [dbo].[MetaDataTypesToContentItems] WITH NOCHECK 
ADD CONSTRAINT [FK_MetaDataTypesToContentItemsContentItems]
    FOREIGN KEY ([ContentItemId])
    REFERENCES [dbo].[ContentItems]
        ([ContentItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ContentItemId] in table 'ContentHistories'
ALTER TABLE [dbo].[ContentHistories] WITH NOCHECK 
ADD CONSTRAINT [FK_ContentHistoryContentItems]
    FOREIGN KEY ([ContentItemId])
    REFERENCES [dbo].[ContentItems]
        ([ContentItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [CreatedByUserId] in table 'ContentHistories'
ALTER TABLE [dbo].[ContentHistories] WITH NOCHECK 
ADD CONSTRAINT [FK_ContentHistoryUsers]
    FOREIGN KEY ([CreatedByUserId])
    REFERENCES [dbo].[UsersSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ContentItemId] in table 'Aliases'
ALTER TABLE [dbo].[Aliases] WITH NOCHECK 
ADD CONSTRAINT [FK_AliasesContentItems]
    FOREIGN KEY ([ContentItemId])
    REFERENCES [dbo].[ContentItems]
        ([ContentItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ObjectXsltId] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems] WITH NOCHECK 
ADD CONSTRAINT [FK_ObjectXsltSetContentItems]
    FOREIGN KEY ([ObjectXsltId])
    REFERENCES [dbo].[ObjectXslts]
        ([ObjectXsltId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ObjectSchemaId] in table 'ObjectXslts'
ALTER TABLE [dbo].[ObjectXslts] WITH NOCHECK 
ADD CONSTRAINT [FK_ObjectSchemaObjectXsltSets]
    FOREIGN KEY ([ObjectSchemaId])
    REFERENCES [dbo].[ObjectTypes]
        ([ObjectTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ParentMenuId] in table 'Menus'
ALTER TABLE [dbo].[Menus] WITH NOCHECK 
ADD CONSTRAINT [FK_MenusMenus]
    FOREIGN KEY ([ParentMenuId])
    REFERENCES [dbo].[Menus]
        ([MenuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [RootMenuId] in table 'Menus'
ALTER TABLE [dbo].[Menus] WITH NOCHECK 
ADD CONSTRAINT [FK_MenusMenus1]
    FOREIGN KEY ([RootMenuId])
    REFERENCES [dbo].[Menus]
        ([MenuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ObjectSchemaId] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems] WITH NOCHECK 
ADD CONSTRAINT [FK_ContentItemsObjectTypes]
    FOREIGN KEY ([ObjectSchemaId])
    REFERENCES [dbo].[ObjectTypes]
        ([ObjectTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ContentItemId] in table 'TemplateElements'
ALTER TABLE [dbo].[TemplateElements] WITH NOCHECK 
ADD CONSTRAINT [FK_TemplateElementContentItems]
    FOREIGN KEY ([ContentItemId])
    REFERENCES [dbo].[ContentItems]
        ([ContentItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [AliasId] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems] WITH NOCHECK 
ADD CONSTRAINT [FK_AliasesMenuItems]
    FOREIGN KEY ([AliasId])
    REFERENCES [dbo].[Aliases]
        ([AliasId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [AliasId] in table 'Menus'
ALTER TABLE [dbo].[Menus] WITH NOCHECK 
ADD CONSTRAINT [FK_AliasesMenus]
    FOREIGN KEY ([AliasId])
    REFERENCES [dbo].[Aliases]
        ([AliasId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ObjectTypeId] in table 'TemplateElements'
ALTER TABLE [dbo].[TemplateElements] WITH NOCHECK 
ADD CONSTRAINT [FK_ObjectTypesTemplateElements]
    FOREIGN KEY ([ObjectTypeId])
    REFERENCES [dbo].[ObjectTypes]
        ([ObjectTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkflowId] in table 'Folders'
ALTER TABLE [dbo].[Folders] WITH NOCHECK 
ADD CONSTRAINT [FK_WorkflowsFolders]
    FOREIGN KEY ([WorkflowId])
    REFERENCES [dbo].[Workflows]
        ([WorkflowId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkflowId] in table 'WorkFlowSteps'
ALTER TABLE [dbo].[WorkFlowSteps] WITH NOCHECK 
ADD CONSTRAINT [FK_WorkFlowStepsWorkflows]
    FOREIGN KEY ([WorkflowId])
    REFERENCES [dbo].[Workflows]
        ([WorkflowId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkflowId] in table 'WorkFlowInstances'
ALTER TABLE [dbo].[WorkFlowInstances] WITH NOCHECK 
ADD CONSTRAINT [FK_WorkFlowInstancesWorkflows]
    FOREIGN KEY ([WorkflowId])
    REFERENCES [dbo].[Workflows]
        ([WorkflowId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkFlowInstanceId] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems] WITH NOCHECK 
ADD CONSTRAINT [FK_WorkFlowInstancesContentItems]
    FOREIGN KEY ([WorkFlowInstanceId])
    REFERENCES [dbo].[WorkFlowInstances]
        ([WorkFlowInstanceId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkFlowInstanceId] in table 'ObjectTypes'
ALTER TABLE [dbo].[ObjectTypes] WITH NOCHECK 
ADD CONSTRAINT [FK_WorkFlowInstancesObjectTypes]
    FOREIGN KEY ([WorkFlowInstanceId])
    REFERENCES [dbo].[WorkFlowInstances]
        ([WorkFlowInstanceId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkFlowInstanceId] in table 'Calendars'
ALTER TABLE [dbo].[Calendars] WITH NOCHECK 
ADD CONSTRAINT [FK_WorkFlowInstancesCalendars]
    FOREIGN KEY ([WorkFlowInstanceId])
    REFERENCES [dbo].[WorkFlowInstances]
        ([WorkFlowInstanceId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkFlowInstanceId] in table 'Templates'
ALTER TABLE [dbo].[Templates] WITH NOCHECK 
ADD CONSTRAINT [FK_WorkFlowInstancesTemplates]
    FOREIGN KEY ([WorkFlowInstanceId])
    REFERENCES [dbo].[WorkFlowInstances]
        ([WorkFlowInstanceId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkFlowInstanceId] in table 'Menus'
ALTER TABLE [dbo].[Menus] WITH NOCHECK 
ADD CONSTRAINT [FK_WorkFlowInstancesMenus]
    FOREIGN KEY ([WorkFlowInstanceId])
    REFERENCES [dbo].[WorkFlowInstances]
        ([WorkFlowInstanceId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [ObjectTypeId] in table 'ObjectTypeHistories'
ALTER TABLE [dbo].[ObjectTypeHistories] WITH NOCHECK 
ADD CONSTRAINT [FK_ObjectTypeHistoriesObjectTypes]
    FOREIGN KEY ([ObjectTypeId])
    REFERENCES [dbo].[ObjectTypes]
        ([ObjectTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [User_UserId] in table 'ObjectTypeHistories'
ALTER TABLE [dbo].[ObjectTypeHistories] WITH NOCHECK 
ADD CONSTRAINT [FK_ObjectTypeHistoriesUsers]
    FOREIGN KEY ([User_UserId])
    REFERENCES [dbo].[UsersSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [MenusMenuId] in table 'MenuHistories'
ALTER TABLE [dbo].[MenuHistories] WITH NOCHECK 
ADD CONSTRAINT [FK_MenuHistoriesMenus]
    FOREIGN KEY ([MenusMenuId])
    REFERENCES [dbo].[Menus]
        ([MenuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [CreatedByUserId] in table 'MenuHistories'
ALTER TABLE [dbo].[MenuHistories] WITH NOCHECK 
ADD CONSTRAINT [FK_MenuHistoriesUsers]
    FOREIGN KEY ([CreatedByUserId])
    REFERENCES [dbo].[UsersSet]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [UserRolesUserRoleId] in table 'UserRolesToWorkFlowSteps'
ALTER TABLE [dbo].[UserRolesToWorkFlowSteps] WITH NOCHECK 
ADD CONSTRAINT [FK_UserRolesToWorkFlowStepsUserRoles]
    FOREIGN KEY ([UserRolesUserRoleId])
    REFERENCES [dbo].[UserRoles]
        ([UserRoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [WorkFlowStepsWorkFlowStepId] in table 'UserRolesToWorkFlowSteps'
ALTER TABLE [dbo].[UserRolesToWorkFlowSteps] WITH NOCHECK 
ADD CONSTRAINT [FK_UserRolesToWorkFlowStepsWorkFlowSteps]
    FOREIGN KEY ([WorkFlowStepsWorkFlowStepId])
    REFERENCES [dbo].[WorkFlowSteps]
        ([WorkFlowStepId])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------