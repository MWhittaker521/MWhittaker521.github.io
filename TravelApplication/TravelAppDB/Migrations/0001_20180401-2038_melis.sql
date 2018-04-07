-- <Migration ID="b70b171e-8370-4536-a79d-52f6722d9aa0" />
GO

PRINT N'Creating [dbo].[UserInfoTable]...';


GO
CREATE TABLE [dbo].[UserInfoTable] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [UserID]    VARCHAR (50) NOT NULL,
    [UserPass]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_UserInfoTable] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[UserInfoTable]...';


GO
ALTER TABLE [dbo].[UserInfoTable]
    ADD CONSTRAINT [DF_UserInfoTable_Id] DEFAULT NULL FOR [Id];


GO
PRINT N'Creating unnamed constraint on [dbo].[UserInfoTable]...';


GO
ALTER TABLE [dbo].[UserInfoTable]
    ADD CONSTRAINT [DF_UserInfoTable_FirstName] DEFAULT NULL FOR [FirstName];


GO
PRINT N'Creating unnamed constraint on [dbo].[UserInfoTable]...';


GO
ALTER TABLE [dbo].[UserInfoTable]
    ADD CONSTRAINT [DF_UserInfoTable_LastName] DEFAULT NULL FOR [LastName];


GO
PRINT N'Creating unnamed constraint on [dbo].[UserInfoTable]...';


GO
ALTER TABLE [dbo].[UserInfoTable]
    ADD CONSTRAINT [DF_UserInfoTable_UserID] DEFAULT NULL FOR [UserID];


GO
PRINT N'Creating unnamed constraint on [dbo].[UserInfoTable]...';


GO
ALTER TABLE [dbo].[UserInfoTable]
    ADD CONSTRAINT [DF_UserInfoTable_UserPass] DEFAULT NULL FOR [UserPass];

