CREATE TABLE [dbo].[Users] (
    [UserName] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NULL,
    [Type]     INT          NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserName] ASC)
);

