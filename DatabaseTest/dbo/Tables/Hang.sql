CREATE TABLE [dbo].[Hang] (
    [MaHang]     NVARCHAR (50)  NOT NULL,
    [TenHang]    NVARCHAR (50)  NULL,
    [MaChatLieu] NVARCHAR (50)  NULL,
    [SoLuong]    FLOAT (53)     NULL,
    [DonGiaNhap] FLOAT (53)     NULL,
    [DonGiaBan]  FLOAT (53)     NULL,
    [Anh]        NVARCHAR (200) NULL,
    [GhiChu]     NVARCHAR (200) NULL,
    [NgayXuatHD] DATETIME       NULL,
    CONSTRAINT [PK_Hang] PRIMARY KEY CLUSTERED ([MaHang] ASC),
    CONSTRAINT [FK_Hang_ChatLieu] FOREIGN KEY ([MaChatLieu]) REFERENCES [dbo].[ChatLieu] ([MaChatLieu])
);

