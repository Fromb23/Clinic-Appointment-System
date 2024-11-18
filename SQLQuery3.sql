CREATE TABLE [dbo].[Users] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (50)   NULL,
    [password] VARCHAR (50)   NULL,
    [fullName] NVARCHAR (100) DEFAULT ('Unknown') NOT NULL,
    [contact]  NVARCHAR (50)  DEFAULT ('Unknown') NOT NULL,
    [gender]   NVARCHAR (10)  DEFAULT ('Unknown') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([fullName] ASC)
);

