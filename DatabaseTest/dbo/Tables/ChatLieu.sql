CREATE TABLE [dbo].[ChatLieu] (
    [MaChatLieu]  NVARCHAR (50) NOT NULL,
    [TenChatLieu] NVARCHAR (50) NULL,
    CONSTRAINT [PK_ChatLieu] PRIMARY KEY CLUSTERED ([MaChatLieu] ASC)
);

