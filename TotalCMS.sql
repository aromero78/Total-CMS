/****** Object:  ForeignKey [FK_AliasesContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[Aliases]'))
ALTER TABLE [dbo].[Aliases] DROP CONSTRAINT [FK_AliasesContentItems]
GO
/****** Object:  ForeignKey [FK_PagesAliases]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagesAliases]') AND parent_object_id = OBJECT_ID(N'[dbo].[Aliases]'))
ALTER TABLE [dbo].[Aliases] DROP CONSTRAINT [FK_PagesAliases]
GO
/****** Object:  ForeignKey [FK_CalendarsCalendarEvents]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CalendarsCalendarEvents]') AND parent_object_id = OBJECT_ID(N'[dbo].[CalendarEvents]'))
ALTER TABLE [dbo].[CalendarEvents] DROP CONSTRAINT [FK_CalendarsCalendarEvents]
GO
/****** Object:  ForeignKey [FK_CalendarsFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CalendarsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Calendars]'))
ALTER TABLE [dbo].[Calendars] DROP CONSTRAINT [FK_CalendarsFolders]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesCalendars]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesCalendars]') AND parent_object_id = OBJECT_ID(N'[dbo].[Calendars]'))
ALTER TABLE [dbo].[Calendars] DROP CONSTRAINT [FK_WorkFlowInstancesCalendars]
GO
/****** Object:  ForeignKey [FK_ContentHistoryContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentHistoryContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentHistories]'))
ALTER TABLE [dbo].[ContentHistories] DROP CONSTRAINT [FK_ContentHistoryContentItems]
GO
/****** Object:  ForeignKey [FK_ContentHistoryUsers]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentHistoryUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentHistories]'))
ALTER TABLE [dbo].[ContentHistories] DROP CONSTRAINT [FK_ContentHistoryUsers]
GO
/****** Object:  ForeignKey [FK_ContentItemsObjectTypes]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentItemsObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_ContentItemsObjectTypes]
GO
/****** Object:  ForeignKey [FK_FoldersContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FoldersContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_FoldersContentItems]
GO
/****** Object:  ForeignKey [FK_ObjectXsltSetContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectXsltSetContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_ObjectXsltSetContentItems]
GO
/****** Object:  ForeignKey [FK_UsersContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_UsersContentItems]
GO
/****** Object:  ForeignKey [FK_UsersContentItems1]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersContentItems1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_UsersContentItems1]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] DROP CONSTRAINT [FK_WorkFlowInstancesContentItems]
GO
/****** Object:  ForeignKey [FK_ChildFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ChildFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders] DROP CONSTRAINT [FK_ChildFolders]
GO
/****** Object:  ForeignKey [FK_LanguagesFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LanguagesFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders] DROP CONSTRAINT [FK_LanguagesFolders]
GO
/****** Object:  ForeignKey [FK_WorkflowsFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkflowsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders] DROP CONSTRAINT [FK_WorkflowsFolders]
GO
/****** Object:  ForeignKey [FK_LibraryItemsFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LibraryItemsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[LibraryItems]'))
ALTER TABLE [dbo].[LibraryItems] DROP CONSTRAINT [FK_LibraryItemsFolders]
GO
/****** Object:  ForeignKey [FK_MenuHistoriesMenus]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuHistoriesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuHistories]'))
ALTER TABLE [dbo].[MenuHistories] DROP CONSTRAINT [FK_MenuHistoriesMenus]
GO
/****** Object:  ForeignKey [FK_MenuHistoriesUsers]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuHistoriesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuHistories]'))
ALTER TABLE [dbo].[MenuHistories] DROP CONSTRAINT [FK_MenuHistoriesUsers]
GO
/****** Object:  ForeignKey [FK_AliasesMenuItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesMenuItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuItems]'))
ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_AliasesMenuItems]
GO
/****** Object:  ForeignKey [FK_MenuItemsMenus]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuItemsMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuItems]'))
ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_MenuItemsMenus]
GO
/****** Object:  ForeignKey [FK_AliasesMenus]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_AliasesMenus]
GO
/****** Object:  ForeignKey [FK_MenusFolders]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_MenusFolders]
GO
/****** Object:  ForeignKey [FK_MenusMenus]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_MenusMenus]
GO
/****** Object:  ForeignKey [FK_MenusMenus1]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusMenus1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_MenusMenus1]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesMenus]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_WorkFlowInstancesMenus]
GO
/****** Object:  ForeignKey [FK_MetaDataValueTypesMetaDataTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataValueTypesMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypes]'))
ALTER TABLE [dbo].[MetaDataTypes] DROP CONSTRAINT [FK_MetaDataValueTypesMetaDataTypes]
GO
/****** Object:  ForeignKey [FK_MetaDataTypesToContentItemsContentItems]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypesToContentItemsContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]'))
ALTER TABLE [dbo].[MetaDataTypesToContentItems] DROP CONSTRAINT [FK_MetaDataTypesToContentItemsContentItems]
GO
/****** Object:  ForeignKey [FK_MetaDataTypesToContentItemsMetaDataTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypesToContentItemsMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]'))
ALTER TABLE [dbo].[MetaDataTypesToContentItems] DROP CONSTRAINT [FK_MetaDataTypesToContentItemsMetaDataTypes]
GO
/****** Object:  ForeignKey [FK_MetaDataTypeToFolderFolders]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypeToFolderFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]'))
ALTER TABLE [dbo].[MetaDataTypeToFolders] DROP CONSTRAINT [FK_MetaDataTypeToFolderFolders]
GO
/****** Object:  ForeignKey [FK_MetaDataTypeToFolderMetaDataTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypeToFolderMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]'))
ALTER TABLE [dbo].[MetaDataTypeToFolders] DROP CONSTRAINT [FK_MetaDataTypeToFolderMetaDataTypes]
GO
/****** Object:  ForeignKey [FK_ObjectTypeHistoriesObjectTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypeHistoriesObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypeHistories]'))
ALTER TABLE [dbo].[ObjectTypeHistories] DROP CONSTRAINT [FK_ObjectTypeHistoriesObjectTypes]
GO
/****** Object:  ForeignKey [FK_ObjectTypeHistoriesUsers]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypeHistoriesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypeHistories]'))
ALTER TABLE [dbo].[ObjectTypeHistories] DROP CONSTRAINT [FK_ObjectTypeHistoriesUsers]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesObjectTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypes]'))
ALTER TABLE [dbo].[ObjectTypes] DROP CONSTRAINT [FK_WorkFlowInstancesObjectTypes]
GO
/****** Object:  ForeignKey [FK_ObjectSchemaObjectXsltSets]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectSchemaObjectXsltSets]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectXslts]'))
ALTER TABLE [dbo].[ObjectXslts] DROP CONSTRAINT [FK_ObjectSchemaObjectXsltSets]
GO
/****** Object:  ForeignKey [FK_PermissionsFolders]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions] DROP CONSTRAINT [FK_PermissionsFolders]
GO
/****** Object:  ForeignKey [FK_PermissionsUserRoles]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions] DROP CONSTRAINT [FK_PermissionsUserRoles]
GO
/****** Object:  ForeignKey [FK_PermissionsUsers]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions] DROP CONSTRAINT [FK_PermissionsUsers]
GO
/****** Object:  ForeignKey [FK_AdminElementAdminPages]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdminElementAdminPages]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements] DROP CONSTRAINT [FK_AdminElementAdminPages]
GO
/****** Object:  ForeignKey [FK_ObjectTypesTemplateElements]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypesTemplateElements]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements] DROP CONSTRAINT [FK_ObjectTypesTemplateElements]
GO
/****** Object:  ForeignKey [FK_TemplateElementContentItems]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TemplateElementContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements] DROP CONSTRAINT [FK_TemplateElementContentItems]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesTemplates]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesTemplates]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates] DROP CONSTRAINT [FK_WorkFlowInstancesTemplates]
GO
/****** Object:  ForeignKey [FK_LanguagesUsers]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LanguagesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersSet]'))
ALTER TABLE [dbo].[UsersSet] DROP CONSTRAINT [FK_LanguagesUsers]
GO
/****** Object:  ForeignKey [FK_UsersToUserRolesUserRoles]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersToUserRolesUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersToUserRoles]'))
ALTER TABLE [dbo].[UsersToUserRoles] DROP CONSTRAINT [FK_UsersToUserRolesUserRoles]
GO
/****** Object:  ForeignKey [FK_UsersToUserRolesUsers]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersToUserRolesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersToUserRoles]'))
ALTER TABLE [dbo].[UsersToUserRoles] DROP CONSTRAINT [FK_UsersToUserRolesUsers]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesWorkflows]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesWorkflows]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowInstances]'))
ALTER TABLE [dbo].[WorkFlowInstances] DROP CONSTRAINT [FK_WorkFlowInstancesWorkflows]
GO
/****** Object:  ForeignKey [FK_WorkFlowStepsUserRoles]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps] DROP CONSTRAINT [FK_WorkFlowStepsUserRoles]
GO
/****** Object:  ForeignKey [FK_WorkFlowStepsUsers1]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsUsers1]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps] DROP CONSTRAINT [FK_WorkFlowStepsUsers1]
GO
/****** Object:  ForeignKey [FK_WorkFlowStepsWorkflows]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsWorkflows]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps] DROP CONSTRAINT [FK_WorkFlowStepsWorkflows]
GO
/****** Object:  Table [dbo].[MenuHistories]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MenuHistories]') AND type in (N'U'))
DROP TABLE [dbo].[MenuHistories]
GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MenuItems]') AND type in (N'U'))
DROP TABLE [dbo].[MenuItems]
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Menus]') AND type in (N'U'))
DROP TABLE [dbo].[Menus]
GO
/****** Object:  StoredProcedure [dbo].[contentItemGet]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[contentItemGet]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[contentItemGet]
GO
/****** Object:  Table [dbo].[MetaDataTypesToContentItems]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]') AND type in (N'U'))
DROP TABLE [dbo].[MetaDataTypesToContentItems]
GO
/****** Object:  Table [dbo].[Aliases]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aliases]') AND type in (N'U'))
DROP TABLE [dbo].[Aliases]
GO
/****** Object:  Table [dbo].[TemplateElements]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TemplateElements]') AND type in (N'U'))
DROP TABLE [dbo].[TemplateElements]
GO
/****** Object:  Table [dbo].[ContentHistories]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContentHistories]') AND type in (N'U'))
DROP TABLE [dbo].[ContentHistories]
GO
/****** Object:  StoredProcedure [dbo].[ObjectTypeCheckModifiedDate]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypeCheckModifiedDate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ObjectTypeCheckModifiedDate]
GO
/****** Object:  Table [dbo].[ContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContentItems]') AND type in (N'U'))
DROP TABLE [dbo].[ContentItems]
GO
/****** Object:  StoredProcedure [dbo].[ObjectTypeGet]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypeGet]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ObjectTypeGet]
GO
/****** Object:  Table [dbo].[ObjectTypeHistories]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypeHistories]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectTypeHistories]
GO
/****** Object:  Table [dbo].[CalendarEvents]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CalendarEvents]') AND type in (N'U'))
DROP TABLE [dbo].[CalendarEvents]
GO
/****** Object:  StoredProcedure [dbo].[ObjectTypeSave]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypeSave]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ObjectTypeSave]
GO
/****** Object:  Table [dbo].[ObjectXslts]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectXslts]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectXslts]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Permissions]') AND type in (N'U'))
DROP TABLE [dbo].[Permissions]
GO
/****** Object:  Table [dbo].[Calendars]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Calendars]') AND type in (N'U'))
DROP TABLE [dbo].[Calendars]
GO
/****** Object:  Table [dbo].[ObjectTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypes]') AND type in (N'U'))
DROP TABLE [dbo].[ObjectTypes]
GO
/****** Object:  Table [dbo].[Templates]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Templates]') AND type in (N'U'))
DROP TABLE [dbo].[Templates]
GO
/****** Object:  Table [dbo].[MetaDataTypeToFolders]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]') AND type in (N'U'))
DROP TABLE [dbo].[MetaDataTypeToFolders]
GO
/****** Object:  Table [dbo].[LibraryItems]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LibraryItems]') AND type in (N'U'))
DROP TABLE [dbo].[LibraryItems]
GO
/****** Object:  Table [dbo].[WorkFlowSteps]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]') AND type in (N'U'))
DROP TABLE [dbo].[WorkFlowSteps]
GO
/****** Object:  Table [dbo].[UsersToUserRoles]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsersToUserRoles]') AND type in (N'U'))
DROP TABLE [dbo].[UsersToUserRoles]
GO
/****** Object:  Table [dbo].[WorkFlowInstances]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkFlowInstances]') AND type in (N'U'))
DROP TABLE [dbo].[WorkFlowInstances]
GO
/****** Object:  Table [dbo].[MetaDataTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataTypes]') AND type in (N'U'))
DROP TABLE [dbo].[MetaDataTypes]
GO
/****** Object:  Table [dbo].[Folders]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Folders]') AND type in (N'U'))
DROP TABLE [dbo].[Folders]
GO
/****** Object:  Table [dbo].[UsersSet]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsersSet]') AND type in (N'U'))
DROP TABLE [dbo].[UsersSet]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserRoles]') AND type in (N'U'))
DROP TABLE [dbo].[UserRoles]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Settings]') AND type in (N'U'))
DROP TABLE [dbo].[Settings]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 04/10/2010 18:12:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Languages]') AND type in (N'U'))
DROP TABLE [dbo].[Languages]
GO
/****** Object:  Table [dbo].[MetaDataValueTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataValueTypes]') AND type in (N'U'))
DROP TABLE [dbo].[MetaDataValueTypes]
GO
/****** Object:  Table [dbo].[Workflows]    Script Date: 04/10/2010 18:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Workflows]') AND type in (N'U'))
DROP TABLE [dbo].[Workflows]
GO
/****** Object:  Table [dbo].[Workflows]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Workflows]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Workflows](
	[WorkflowId] [int] NOT NULL,
 CONSTRAINT [PK_Workflows] PRIMARY KEY CLUSTERED 
(
	[WorkflowId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[MetaDataValueTypes]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataValueTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MetaDataValueTypes](
	[MetaDataValueTypeId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_MetaDataValueTypes] PRIMARY KEY CLUSTERED 
(
	[MetaDataValueTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Languages]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Languages](
	[LanguageId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDefault] [bit] NOT NULL,
	[LangId] [int] NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Settings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Settings](
	[SettingId] [int] NOT NULL,
	[LicenceKey] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[SettingId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserRoles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserRoles](
	[UserRoleId] [int] NOT NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsSingleton] [bit] NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[UsersSet]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsersSet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UsersSet](
	[UserId] [int] NOT NULL,
	[FirstName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LastName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UserName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Password] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_UsersSet] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Folders]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Folders]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Folders](
	[FolderId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[InheritPermissions] [bit] NOT NULL,
	[ParentFolderId] [int] NULL,
	[InheritMetaData] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PermissionsId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[WorkflowId] [int] NOT NULL,
	[IsSystemFolder] [bit] NOT NULL,
	[AddCalendarsToWorkflow] [bit] NOT NULL,
	[AddMenusToWorkflow] [bit] NOT NULL,
	[Language_LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_Folders] PRIMARY KEY CLUSTERED 
(
	[FolderId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[MetaDataTypes]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MetaDataTypes](
	[MetaDataTypeId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DefaultValue] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MetaDataValueTypesId] [int] NOT NULL,
 CONSTRAINT [PK_MetaDataTypes] PRIMARY KEY CLUSTERED 
(
	[MetaDataTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[WorkFlowInstances]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkFlowInstances]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[WorkFlowInstances](
	[WorkFlowInstanceId] [int] NOT NULL,
	[WorkflowId] [int] NOT NULL,
	[CurrentStep] [int] NOT NULL,
 CONSTRAINT [PK_WorkFlowInstances] PRIMARY KEY CLUSTERED 
(
	[WorkFlowInstanceId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[UsersToUserRoles]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsersToUserRoles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UsersToUserRoles](
	[UserToUserRoleId] [int] NOT NULL,
	[UserRoleId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_UsersToUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserToUserRoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[WorkFlowSteps]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[WorkFlowSteps](
	[WorkFlowStepId] [int] NOT NULL,
	[WorkflowId] [int] NOT NULL,
	[UserRoleId] [int] NULL,
	[StepOrder] [int] NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_WorkFlowSteps] PRIMARY KEY CLUSTERED 
(
	[WorkFlowStepId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[LibraryItems]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LibraryItems]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LibraryItems](
	[LibraryItemId] [int] NOT NULL,
	[FolderId] [int] NOT NULL,
	[FileUrl] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Desciprtion] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_LibraryItems] PRIMARY KEY CLUSTERED 
(
	[LibraryItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[MetaDataTypeToFolders]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MetaDataTypeToFolders](
	[MetaDataTypeToFolderId] [int] NOT NULL,
	[FolderId] [int] NOT NULL,
	[MetaDataTypeId] [int] NOT NULL,
	[IsRequired] [bit] NOT NULL,
 CONSTRAINT [PK_MetaDataTypeToFolders] PRIMARY KEY CLUSTERED 
(
	[MetaDataTypeToFolderId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Templates]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Templates]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Templates](
	[TemplateId] [int] NOT NULL,
	[Title] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsUserDefined] [bit] NOT NULL,
	[TemplateFileUrl] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WorkFlowInstanceId] [int] NULL,
 CONSTRAINT [PK_Templates] PRIMARY KEY CLUSTERED 
(
	[TemplateId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ObjectTypes]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectTypes](
	[ObjectTypeId] [int] NOT NULL,
	[DataEntryXslt] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DefaultDisplayXslt] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SchemaXml] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Status] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WorkFlowInstanceId] [int] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_ObjectTypes] PRIMARY KEY CLUSTERED 
(
	[ObjectTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Calendars]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Calendars]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Calendars](
	[CalendarId] [int] NOT NULL,
	[FolderId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WorkFlowInstanceId] [int] NULL,
 CONSTRAINT [PK_Calendars] PRIMARY KEY CLUSTERED 
(
	[CalendarId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Permissions]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Permissions](
	[PermissionId] [int] NOT NULL,
	[UserRoleId] [int] NULL,
	[CanReadContent] [bit] NOT NULL,
	[CanAddContent] [bit] NOT NULL,
	[CanDeleteContent] [bit] NOT NULL,
	[CanReadMenus] [bit] NOT NULL,
	[CanAddMenus] [bit] NOT NULL,
	[CanDeleteMenus] [bit] NOT NULL,
	[CanReadFolders] [bit] NOT NULL,
	[CanAddFolders] [bit] NOT NULL,
	[CanDeleteFoldres] [bit] NOT NULL,
	[CanReadCalendars] [bit] NOT NULL,
	[CanAddCalendars] [bit] NOT NULL,
	[CanDeleteCalednars] [bit] NOT NULL,
	[CanEditContent] [bit] NOT NULL,
	[CanEditMenus] [bit] NOT NULL,
	[CanEditFolder] [bit] NOT NULL,
	[CanEditCalendar] [bit] NOT NULL,
	[FolderId] [int] NOT NULL,
	[IsPageAdmin] [bit] NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ObjectXslts]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectXslts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectXslts](
	[ObjectXsltId] [int] NOT NULL,
	[ObjectXsltUri] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ObjectSchemaId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[isValidated] [bit] NOT NULL,
 CONSTRAINT [PK_ObjectXslts] PRIMARY KEY CLUSTERED 
(
	[ObjectXsltId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  StoredProcedure [dbo].[ObjectTypeSave]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypeSave]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ObjectTypeSave]
	@DataEntryXslt varchar(max),
	@Name varchar(250),
	@DefaultDisplayXslt varchar(max),
	@SchemaXml varchar(max)
AS
	insert into ObjectTypes(DataEntryXslt, Name, DefaultDisplayXslt, SchemaXml) 
		values (@DataEntryXslt, @Name, @DefaultDisplayXslt, @SchemaXml)

	SELECT SCOPE_IDENTITY()
' 
END
GO
/****** Object:  Table [dbo].[CalendarEvents]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CalendarEvents]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CalendarEvents](
	[CalendarEventIds] [int] NOT NULL,
	[CalendarId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[iCalSettings] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_CalendarEvents] PRIMARY KEY CLUSTERED 
(
	[CalendarEventIds] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ObjectTypeHistories]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypeHistories]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObjectTypeHistories](
	[ObjectTypeHistoryId] [int] NOT NULL,
	[ObjectTypeId] [int] NOT NULL,
	[SerializedData] [varbinary](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UserId] [int] NOT NULL,
	[VersionNumber] [float] NOT NULL,
	[User_UserId] [int] NOT NULL,
 CONSTRAINT [PK_ObjectTypeHistories] PRIMARY KEY CLUSTERED 
(
	[ObjectTypeHistoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  StoredProcedure [dbo].[ObjectTypeGet]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypeGet]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ObjectTypeGet]
	@ObjectTypeId int
AS
	select * from ObjectTypes a where @ObjectTypeId = a.ObjectTypeId
' 
END
GO
/****** Object:  Table [dbo].[ContentItems]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContentItems]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContentItems](
	[ContentItemId] [int] NOT NULL,
	[ContentHtml] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ContentSummary] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NULL,
	[CreatedByUserId] [int] NOT NULL,
	[ModifiedByUserId] [int] NULL,
	[FolderId] [int] NOT NULL,
	[ContentStatus] [nvarchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ObjectXsltId] [int] NOT NULL,
	[ObjectSchemaId] [int] NOT NULL,
	[ContentDisplayId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[WorkFlowInstanceId] [int] NULL,
 CONSTRAINT [PK_ContentItems] PRIMARY KEY CLUSTERED 
(
	[ContentItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  StoredProcedure [dbo].[ObjectTypeCheckModifiedDate]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObjectTypeCheckModifiedDate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ObjectTypeCheckModifiedDate]
	@ObjectTypeId int
AS
	select top 1 createddate from ObjectTypeHistories where objecttypeid = @ObjectTypeid order by versionnumber desc
' 
END
GO
/****** Object:  Table [dbo].[ContentHistories]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContentHistories]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContentHistories](
	[ContentHistoryId] [int] NOT NULL,
	[ContentItemId] [int] NOT NULL,
	[VersionNumber] [float] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[CreatedByUserId] [int] NOT NULL,
	[SerializedData] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_ContentHistories] PRIMARY KEY CLUSTERED 
(
	[ContentHistoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[TemplateElements]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TemplateElements]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TemplateElements](
	[TemplateElementId] [int] NOT NULL,
	[XsltId] [uniqueidentifier] NOT NULL,
	[TemplateId] [int] NOT NULL,
	[Title] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DynamicParamName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ContentItemId] [int] NULL,
	[ObjectTypeId] [int] NOT NULL,
 CONSTRAINT [PK_TemplateElements] PRIMARY KEY CLUSTERED 
(
	[TemplateElementId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Aliases]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aliases]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Aliases](
	[AliasId] [int] NOT NULL,
	[TemplateId] [int] NOT NULL,
	[Alias] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ContentItemId] [int] NOT NULL,
 CONSTRAINT [PK_Aliases] PRIMARY KEY CLUSTERED 
(
	[AliasId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[MetaDataTypesToContentItems]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MetaDataTypesToContentItems](
	[MetaDataTypesToContentItemId] [int] NOT NULL,
	[MetaDataTypeId] [int] NOT NULL,
	[ContentItemId] [int] NOT NULL,
	[Value] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_MetaDataTypesToContentItems] PRIMARY KEY CLUSTERED 
(
	[MetaDataTypesToContentItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  StoredProcedure [dbo].[contentItemGet]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[contentItemGet]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[contentItemGet]
	@ContentDisplayId int,
	@LangId int = 1033
AS
	declare @ContentItemData as table(
		ContentItemId int,
		Html varchar(max),
		Summary varchar(250),
		DateCreated Datetime,
		DateModified DateTime,
		CreatedByUser int,
		ModifiedByUser int,
		FolderId int,
		ContentStatus varchar(2),
		LangId int,
		ObjectSchemaId int,
		ObjectXsltId int,
		ObjectXslt varchar(max),
		DataEntryXslt varchar(max),
		SchemaXml varchar(max),
		ObjectTypeDescription varchar(max)
	)

	insert into @ContentItemData
	select 
		a.ContentItemId,
		a.ContentHtml,
		a.ContentSummary,
		a.DateCreated,
		a.DateModified,
		a.CreatedByUserId,
		a.ModifiedByUserId,
		a.FolderId,
		a.ContentStatus,
		@LangId,
		a.ObjectSchemaId,
		a.ObjectXsltId,
		b.ObjectXslt,
		c.DataEntryXslt,
		c.SchemaXml,
		d.[Description]

		from contentitems a 

			join ObjectXslts b
			on a.ObjectXsltId = b.ObjectXsltId

			join ObjectSchemas c
			on c.ObjectSchemaId = a.ObjectSchemaId

			join ObjectTypes d
			on d.ObjectTypeId = c.ObjectTypeId

		where a.contentdisplayid = @ContentDisplayId and 
		@LangId in (select b.languageid from folders b where a.folderid = b.folderid)

	select 
		b.MetaDataTypeId, 
		b.MetaDataTypesToContentItemsId, 
		b.Value,
		c.DefaultValue,
		c.MetaDataValueTypesId,
		c.Name as MetaDataTypeName,
		d.Name as MetaDataValueTypeName

		from 
			MetaDataTypesToContentItems b 

			join MetaDataTypes c
			on b.MetaDataTypeId = c.MetaDataTypeId

			join MetaDataValueTypes d
			on c.MetaDataValueTypesId = d.MetaDataValueTypesId

		where b.ContentItemId in (select contentitemid from @ContentItemData)


		
' 
END
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 04/10/2010 18:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Menus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Menus](
	[MenuId] [int] NOT NULL,
	[FolderId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Property] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[OrderId] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ParentMenuId] [int] NOT NULL,
	[RootMenuId] [int] NOT NULL,
	[AliasId] [int] NOT NULL,
	[WorkFlowInstanceId] [int] NULL,
 CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MenuItems]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MenuItems](
	[MenuItemId] [int] NOT NULL,
	[MenuId] [int] NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[OrderId] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[AliasId] [int] NOT NULL,
 CONSTRAINT [PK_MenuItems] PRIMARY KEY CLUSTERED 
(
	[MenuItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[MenuHistories]    Script Date: 04/10/2010 18:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MenuHistories]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MenuHistories](
	[MenuHistoryId] [int] NOT NULL,
	[MenusMenuId] [int] NOT NULL,
	[CreatedByUserId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[SerializedData] [varbinary](max) NOT NULL,
	[VersionNumber] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_MenuHistories] PRIMARY KEY CLUSTERED 
(
	[MenuHistoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  ForeignKey [FK_AliasesContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[Aliases]'))
ALTER TABLE [dbo].[Aliases]  WITH NOCHECK ADD  CONSTRAINT [FK_AliasesContentItems] FOREIGN KEY([ContentItemId])
REFERENCES [dbo].[ContentItems] ([ContentItemId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[Aliases]'))
ALTER TABLE [dbo].[Aliases] CHECK CONSTRAINT [FK_AliasesContentItems]
GO
/****** Object:  ForeignKey [FK_PagesAliases]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagesAliases]') AND parent_object_id = OBJECT_ID(N'[dbo].[Aliases]'))
ALTER TABLE [dbo].[Aliases]  WITH NOCHECK ADD  CONSTRAINT [FK_PagesAliases] FOREIGN KEY([TemplateId])
REFERENCES [dbo].[Templates] ([TemplateId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagesAliases]') AND parent_object_id = OBJECT_ID(N'[dbo].[Aliases]'))
ALTER TABLE [dbo].[Aliases] CHECK CONSTRAINT [FK_PagesAliases]
GO
/****** Object:  ForeignKey [FK_CalendarsCalendarEvents]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CalendarsCalendarEvents]') AND parent_object_id = OBJECT_ID(N'[dbo].[CalendarEvents]'))
ALTER TABLE [dbo].[CalendarEvents]  WITH NOCHECK ADD  CONSTRAINT [FK_CalendarsCalendarEvents] FOREIGN KEY([CalendarId])
REFERENCES [dbo].[Calendars] ([CalendarId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CalendarsCalendarEvents]') AND parent_object_id = OBJECT_ID(N'[dbo].[CalendarEvents]'))
ALTER TABLE [dbo].[CalendarEvents] CHECK CONSTRAINT [FK_CalendarsCalendarEvents]
GO
/****** Object:  ForeignKey [FK_CalendarsFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CalendarsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Calendars]'))
ALTER TABLE [dbo].[Calendars]  WITH NOCHECK ADD  CONSTRAINT [FK_CalendarsFolders] FOREIGN KEY([FolderId])
REFERENCES [dbo].[Folders] ([FolderId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CalendarsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Calendars]'))
ALTER TABLE [dbo].[Calendars] CHECK CONSTRAINT [FK_CalendarsFolders]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesCalendars]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesCalendars]') AND parent_object_id = OBJECT_ID(N'[dbo].[Calendars]'))
ALTER TABLE [dbo].[Calendars]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowInstancesCalendars] FOREIGN KEY([WorkFlowInstanceId])
REFERENCES [dbo].[WorkFlowInstances] ([WorkFlowInstanceId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesCalendars]') AND parent_object_id = OBJECT_ID(N'[dbo].[Calendars]'))
ALTER TABLE [dbo].[Calendars] CHECK CONSTRAINT [FK_WorkFlowInstancesCalendars]
GO
/****** Object:  ForeignKey [FK_ContentHistoryContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentHistoryContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentHistories]'))
ALTER TABLE [dbo].[ContentHistories]  WITH NOCHECK ADD  CONSTRAINT [FK_ContentHistoryContentItems] FOREIGN KEY([ContentItemId])
REFERENCES [dbo].[ContentItems] ([ContentItemId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentHistoryContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentHistories]'))
ALTER TABLE [dbo].[ContentHistories] CHECK CONSTRAINT [FK_ContentHistoryContentItems]
GO
/****** Object:  ForeignKey [FK_ContentHistoryUsers]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentHistoryUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentHistories]'))
ALTER TABLE [dbo].[ContentHistories]  WITH NOCHECK ADD  CONSTRAINT [FK_ContentHistoryUsers] FOREIGN KEY([CreatedByUserId])
REFERENCES [dbo].[UsersSet] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentHistoryUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentHistories]'))
ALTER TABLE [dbo].[ContentHistories] CHECK CONSTRAINT [FK_ContentHistoryUsers]
GO
/****** Object:  ForeignKey [FK_ContentItemsObjectTypes]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentItemsObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems]  WITH NOCHECK ADD  CONSTRAINT [FK_ContentItemsObjectTypes] FOREIGN KEY([ObjectSchemaId])
REFERENCES [dbo].[ObjectTypes] ([ObjectTypeId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContentItemsObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] CHECK CONSTRAINT [FK_ContentItemsObjectTypes]
GO
/****** Object:  ForeignKey [FK_FoldersContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FoldersContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems]  WITH NOCHECK ADD  CONSTRAINT [FK_FoldersContentItems] FOREIGN KEY([FolderId])
REFERENCES [dbo].[Folders] ([FolderId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FoldersContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] CHECK CONSTRAINT [FK_FoldersContentItems]
GO
/****** Object:  ForeignKey [FK_ObjectXsltSetContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectXsltSetContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems]  WITH NOCHECK ADD  CONSTRAINT [FK_ObjectXsltSetContentItems] FOREIGN KEY([ObjectXsltId])
REFERENCES [dbo].[ObjectXslts] ([ObjectXsltId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectXsltSetContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] CHECK CONSTRAINT [FK_ObjectXsltSetContentItems]
GO
/****** Object:  ForeignKey [FK_UsersContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems]  WITH NOCHECK ADD  CONSTRAINT [FK_UsersContentItems] FOREIGN KEY([CreatedByUserId])
REFERENCES [dbo].[UsersSet] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] CHECK CONSTRAINT [FK_UsersContentItems]
GO
/****** Object:  ForeignKey [FK_UsersContentItems1]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersContentItems1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems]  WITH NOCHECK ADD  CONSTRAINT [FK_UsersContentItems1] FOREIGN KEY([ModifiedByUserId])
REFERENCES [dbo].[UsersSet] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersContentItems1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] CHECK CONSTRAINT [FK_UsersContentItems1]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesContentItems]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowInstancesContentItems] FOREIGN KEY([WorkFlowInstanceId])
REFERENCES [dbo].[WorkFlowInstances] ([WorkFlowInstanceId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContentItems]'))
ALTER TABLE [dbo].[ContentItems] CHECK CONSTRAINT [FK_WorkFlowInstancesContentItems]
GO
/****** Object:  ForeignKey [FK_ChildFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ChildFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders]  WITH NOCHECK ADD  CONSTRAINT [FK_ChildFolders] FOREIGN KEY([ParentFolderId])
REFERENCES [dbo].[Folders] ([FolderId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ChildFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders] CHECK CONSTRAINT [FK_ChildFolders]
GO
/****** Object:  ForeignKey [FK_LanguagesFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LanguagesFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders]  WITH NOCHECK ADD  CONSTRAINT [FK_LanguagesFolders] FOREIGN KEY([Language_LanguageId])
REFERENCES [dbo].[Languages] ([LanguageId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LanguagesFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders] CHECK CONSTRAINT [FK_LanguagesFolders]
GO
/****** Object:  ForeignKey [FK_WorkflowsFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkflowsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkflowsFolders] FOREIGN KEY([WorkflowId])
REFERENCES [dbo].[Workflows] ([WorkflowId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkflowsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Folders]'))
ALTER TABLE [dbo].[Folders] CHECK CONSTRAINT [FK_WorkflowsFolders]
GO
/****** Object:  ForeignKey [FK_LibraryItemsFolders]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LibraryItemsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[LibraryItems]'))
ALTER TABLE [dbo].[LibraryItems]  WITH NOCHECK ADD  CONSTRAINT [FK_LibraryItemsFolders] FOREIGN KEY([FolderId])
REFERENCES [dbo].[Folders] ([FolderId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LibraryItemsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[LibraryItems]'))
ALTER TABLE [dbo].[LibraryItems] CHECK CONSTRAINT [FK_LibraryItemsFolders]
GO
/****** Object:  ForeignKey [FK_MenuHistoriesMenus]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuHistoriesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuHistories]'))
ALTER TABLE [dbo].[MenuHistories]  WITH NOCHECK ADD  CONSTRAINT [FK_MenuHistoriesMenus] FOREIGN KEY([MenusMenuId])
REFERENCES [dbo].[Menus] ([MenuId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuHistoriesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuHistories]'))
ALTER TABLE [dbo].[MenuHistories] CHECK CONSTRAINT [FK_MenuHistoriesMenus]
GO
/****** Object:  ForeignKey [FK_MenuHistoriesUsers]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuHistoriesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuHistories]'))
ALTER TABLE [dbo].[MenuHistories]  WITH NOCHECK ADD  CONSTRAINT [FK_MenuHistoriesUsers] FOREIGN KEY([CreatedByUserId])
REFERENCES [dbo].[UsersSet] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuHistoriesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuHistories]'))
ALTER TABLE [dbo].[MenuHistories] CHECK CONSTRAINT [FK_MenuHistoriesUsers]
GO
/****** Object:  ForeignKey [FK_AliasesMenuItems]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesMenuItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuItems]'))
ALTER TABLE [dbo].[MenuItems]  WITH NOCHECK ADD  CONSTRAINT [FK_AliasesMenuItems] FOREIGN KEY([AliasId])
REFERENCES [dbo].[Aliases] ([AliasId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesMenuItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuItems]'))
ALTER TABLE [dbo].[MenuItems] CHECK CONSTRAINT [FK_AliasesMenuItems]
GO
/****** Object:  ForeignKey [FK_MenuItemsMenus]    Script Date: 04/10/2010 18:12:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuItemsMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuItems]'))
ALTER TABLE [dbo].[MenuItems]  WITH NOCHECK ADD  CONSTRAINT [FK_MenuItemsMenus] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menus] ([MenuId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenuItemsMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[MenuItems]'))
ALTER TABLE [dbo].[MenuItems] CHECK CONSTRAINT [FK_MenuItemsMenus]
GO
/****** Object:  ForeignKey [FK_AliasesMenus]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus]  WITH NOCHECK ADD  CONSTRAINT [FK_AliasesMenus] FOREIGN KEY([AliasId])
REFERENCES [dbo].[Aliases] ([AliasId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AliasesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_AliasesMenus]
GO
/****** Object:  ForeignKey [FK_MenusFolders]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus]  WITH NOCHECK ADD  CONSTRAINT [FK_MenusFolders] FOREIGN KEY([FolderId])
REFERENCES [dbo].[Folders] ([FolderId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_MenusFolders]
GO
/****** Object:  ForeignKey [FK_MenusMenus]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus]  WITH NOCHECK ADD  CONSTRAINT [FK_MenusMenus] FOREIGN KEY([ParentMenuId])
REFERENCES [dbo].[Menus] ([MenuId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_MenusMenus]
GO
/****** Object:  ForeignKey [FK_MenusMenus1]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusMenus1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus]  WITH NOCHECK ADD  CONSTRAINT [FK_MenusMenus1] FOREIGN KEY([RootMenuId])
REFERENCES [dbo].[Menus] ([MenuId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MenusMenus1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_MenusMenus1]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesMenus]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowInstancesMenus] FOREIGN KEY([WorkFlowInstanceId])
REFERENCES [dbo].[WorkFlowInstances] ([WorkFlowInstanceId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesMenus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Menus]'))
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_WorkFlowInstancesMenus]
GO
/****** Object:  ForeignKey [FK_MetaDataValueTypesMetaDataTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataValueTypesMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypes]'))
ALTER TABLE [dbo].[MetaDataTypes]  WITH NOCHECK ADD  CONSTRAINT [FK_MetaDataValueTypesMetaDataTypes] FOREIGN KEY([MetaDataValueTypesId])
REFERENCES [dbo].[MetaDataValueTypes] ([MetaDataValueTypeId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataValueTypesMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypes]'))
ALTER TABLE [dbo].[MetaDataTypes] CHECK CONSTRAINT [FK_MetaDataValueTypesMetaDataTypes]
GO
/****** Object:  ForeignKey [FK_MetaDataTypesToContentItemsContentItems]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypesToContentItemsContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]'))
ALTER TABLE [dbo].[MetaDataTypesToContentItems]  WITH NOCHECK ADD  CONSTRAINT [FK_MetaDataTypesToContentItemsContentItems] FOREIGN KEY([ContentItemId])
REFERENCES [dbo].[ContentItems] ([ContentItemId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypesToContentItemsContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]'))
ALTER TABLE [dbo].[MetaDataTypesToContentItems] CHECK CONSTRAINT [FK_MetaDataTypesToContentItemsContentItems]
GO
/****** Object:  ForeignKey [FK_MetaDataTypesToContentItemsMetaDataTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypesToContentItemsMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]'))
ALTER TABLE [dbo].[MetaDataTypesToContentItems]  WITH NOCHECK ADD  CONSTRAINT [FK_MetaDataTypesToContentItemsMetaDataTypes] FOREIGN KEY([MetaDataTypeId])
REFERENCES [dbo].[MetaDataTypes] ([MetaDataTypeId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypesToContentItemsMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypesToContentItems]'))
ALTER TABLE [dbo].[MetaDataTypesToContentItems] CHECK CONSTRAINT [FK_MetaDataTypesToContentItemsMetaDataTypes]
GO
/****** Object:  ForeignKey [FK_MetaDataTypeToFolderFolders]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypeToFolderFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]'))
ALTER TABLE [dbo].[MetaDataTypeToFolders]  WITH NOCHECK ADD  CONSTRAINT [FK_MetaDataTypeToFolderFolders] FOREIGN KEY([FolderId])
REFERENCES [dbo].[Folders] ([FolderId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypeToFolderFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]'))
ALTER TABLE [dbo].[MetaDataTypeToFolders] CHECK CONSTRAINT [FK_MetaDataTypeToFolderFolders]
GO
/****** Object:  ForeignKey [FK_MetaDataTypeToFolderMetaDataTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypeToFolderMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]'))
ALTER TABLE [dbo].[MetaDataTypeToFolders]  WITH NOCHECK ADD  CONSTRAINT [FK_MetaDataTypeToFolderMetaDataTypes] FOREIGN KEY([MetaDataTypeId])
REFERENCES [dbo].[MetaDataTypes] ([MetaDataTypeId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MetaDataTypeToFolderMetaDataTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[MetaDataTypeToFolders]'))
ALTER TABLE [dbo].[MetaDataTypeToFolders] CHECK CONSTRAINT [FK_MetaDataTypeToFolderMetaDataTypes]
GO
/****** Object:  ForeignKey [FK_ObjectTypeHistoriesObjectTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypeHistoriesObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypeHistories]'))
ALTER TABLE [dbo].[ObjectTypeHistories]  WITH NOCHECK ADD  CONSTRAINT [FK_ObjectTypeHistoriesObjectTypes] FOREIGN KEY([ObjectTypeId])
REFERENCES [dbo].[ObjectTypes] ([ObjectTypeId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypeHistoriesObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypeHistories]'))
ALTER TABLE [dbo].[ObjectTypeHistories] CHECK CONSTRAINT [FK_ObjectTypeHistoriesObjectTypes]
GO
/****** Object:  ForeignKey [FK_ObjectTypeHistoriesUsers]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypeHistoriesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypeHistories]'))
ALTER TABLE [dbo].[ObjectTypeHistories]  WITH NOCHECK ADD  CONSTRAINT [FK_ObjectTypeHistoriesUsers] FOREIGN KEY([User_UserId])
REFERENCES [dbo].[UsersSet] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypeHistoriesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypeHistories]'))
ALTER TABLE [dbo].[ObjectTypeHistories] CHECK CONSTRAINT [FK_ObjectTypeHistoriesUsers]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesObjectTypes]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypes]'))
ALTER TABLE [dbo].[ObjectTypes]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowInstancesObjectTypes] FOREIGN KEY([WorkFlowInstanceId])
REFERENCES [dbo].[WorkFlowInstances] ([WorkFlowInstanceId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesObjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectTypes]'))
ALTER TABLE [dbo].[ObjectTypes] CHECK CONSTRAINT [FK_WorkFlowInstancesObjectTypes]
GO
/****** Object:  ForeignKey [FK_ObjectSchemaObjectXsltSets]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectSchemaObjectXsltSets]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectXslts]'))
ALTER TABLE [dbo].[ObjectXslts]  WITH NOCHECK ADD  CONSTRAINT [FK_ObjectSchemaObjectXsltSets] FOREIGN KEY([ObjectSchemaId])
REFERENCES [dbo].[ObjectTypes] ([ObjectTypeId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectSchemaObjectXsltSets]') AND parent_object_id = OBJECT_ID(N'[dbo].[ObjectXslts]'))
ALTER TABLE [dbo].[ObjectXslts] CHECK CONSTRAINT [FK_ObjectSchemaObjectXsltSets]
GO
/****** Object:  ForeignKey [FK_PermissionsFolders]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions]  WITH NOCHECK ADD  CONSTRAINT [FK_PermissionsFolders] FOREIGN KEY([FolderId])
REFERENCES [dbo].[Folders] ([FolderId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsFolders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_PermissionsFolders]
GO
/****** Object:  ForeignKey [FK_PermissionsUserRoles]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions]  WITH NOCHECK ADD  CONSTRAINT [FK_PermissionsUserRoles] FOREIGN KEY([UserRoleId])
REFERENCES [dbo].[UserRoles] ([UserRoleId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_PermissionsUserRoles]
GO
/****** Object:  ForeignKey [FK_PermissionsUsers]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions]  WITH NOCHECK ADD  CONSTRAINT [FK_PermissionsUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersSet] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PermissionsUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Permissions]'))
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_PermissionsUsers]
GO
/****** Object:  ForeignKey [FK_AdminElementAdminPages]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdminElementAdminPages]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements]  WITH NOCHECK ADD  CONSTRAINT [FK_AdminElementAdminPages] FOREIGN KEY([TemplateId])
REFERENCES [dbo].[Templates] ([TemplateId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdminElementAdminPages]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements] CHECK CONSTRAINT [FK_AdminElementAdminPages]
GO
/****** Object:  ForeignKey [FK_ObjectTypesTemplateElements]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypesTemplateElements]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements]  WITH NOCHECK ADD  CONSTRAINT [FK_ObjectTypesTemplateElements] FOREIGN KEY([ObjectTypeId])
REFERENCES [dbo].[ObjectTypes] ([ObjectTypeId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ObjectTypesTemplateElements]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements] CHECK CONSTRAINT [FK_ObjectTypesTemplateElements]
GO
/****** Object:  ForeignKey [FK_TemplateElementContentItems]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TemplateElementContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements]  WITH NOCHECK ADD  CONSTRAINT [FK_TemplateElementContentItems] FOREIGN KEY([ContentItemId])
REFERENCES [dbo].[ContentItems] ([ContentItemId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TemplateElementContentItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[TemplateElements]'))
ALTER TABLE [dbo].[TemplateElements] CHECK CONSTRAINT [FK_TemplateElementContentItems]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesTemplates]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesTemplates]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowInstancesTemplates] FOREIGN KEY([WorkFlowInstanceId])
REFERENCES [dbo].[WorkFlowInstances] ([WorkFlowInstanceId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesTemplates]') AND parent_object_id = OBJECT_ID(N'[dbo].[Templates]'))
ALTER TABLE [dbo].[Templates] CHECK CONSTRAINT [FK_WorkFlowInstancesTemplates]
GO
/****** Object:  ForeignKey [FK_LanguagesUsers]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LanguagesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersSet]'))
ALTER TABLE [dbo].[UsersSet]  WITH NOCHECK ADD  CONSTRAINT [FK_LanguagesUsers] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([LanguageId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LanguagesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersSet]'))
ALTER TABLE [dbo].[UsersSet] CHECK CONSTRAINT [FK_LanguagesUsers]
GO
/****** Object:  ForeignKey [FK_UsersToUserRolesUserRoles]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersToUserRolesUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersToUserRoles]'))
ALTER TABLE [dbo].[UsersToUserRoles]  WITH NOCHECK ADD  CONSTRAINT [FK_UsersToUserRolesUserRoles] FOREIGN KEY([UserRoleId])
REFERENCES [dbo].[UserRoles] ([UserRoleId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersToUserRolesUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersToUserRoles]'))
ALTER TABLE [dbo].[UsersToUserRoles] CHECK CONSTRAINT [FK_UsersToUserRolesUserRoles]
GO
/****** Object:  ForeignKey [FK_UsersToUserRolesUsers]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersToUserRolesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersToUserRoles]'))
ALTER TABLE [dbo].[UsersToUserRoles]  WITH NOCHECK ADD  CONSTRAINT [FK_UsersToUserRolesUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersSet] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UsersToUserRolesUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsersToUserRoles]'))
ALTER TABLE [dbo].[UsersToUserRoles] CHECK CONSTRAINT [FK_UsersToUserRolesUsers]
GO
/****** Object:  ForeignKey [FK_WorkFlowInstancesWorkflows]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesWorkflows]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowInstances]'))
ALTER TABLE [dbo].[WorkFlowInstances]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowInstancesWorkflows] FOREIGN KEY([WorkflowId])
REFERENCES [dbo].[Workflows] ([WorkflowId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowInstancesWorkflows]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowInstances]'))
ALTER TABLE [dbo].[WorkFlowInstances] CHECK CONSTRAINT [FK_WorkFlowInstancesWorkflows]
GO
/****** Object:  ForeignKey [FK_WorkFlowStepsUserRoles]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowStepsUserRoles] FOREIGN KEY([UserRoleId])
REFERENCES [dbo].[UserRoles] ([UserRoleId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsUserRoles]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps] CHECK CONSTRAINT [FK_WorkFlowStepsUserRoles]
GO
/****** Object:  ForeignKey [FK_WorkFlowStepsUsers1]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsUsers1]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowStepsUsers1] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersSet] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsUsers1]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps] CHECK CONSTRAINT [FK_WorkFlowStepsUsers1]
GO
/****** Object:  ForeignKey [FK_WorkFlowStepsWorkflows]    Script Date: 04/10/2010 18:12:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsWorkflows]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps]  WITH NOCHECK ADD  CONSTRAINT [FK_WorkFlowStepsWorkflows] FOREIGN KEY([WorkflowId])
REFERENCES [dbo].[Workflows] ([WorkflowId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WorkFlowStepsWorkflows]') AND parent_object_id = OBJECT_ID(N'[dbo].[WorkFlowSteps]'))
ALTER TABLE [dbo].[WorkFlowSteps] CHECK CONSTRAINT [FK_WorkFlowStepsWorkflows]
GO
