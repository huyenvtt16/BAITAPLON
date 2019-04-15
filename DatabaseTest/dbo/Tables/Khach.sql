CREATE TABLE [dbo].[Khach] (
    [MaKhach]   NVARCHAR (10) NOT NULL,
    [TenKhach]  NVARCHAR (50) NULL,
    [DiaChi]    NVARCHAR (50) NULL,
    [DienThoai] NVARCHAR (15) NULL,
    CONSTRAINT [PK_Khach] PRIMARY KEY CLUSTERED ([MaKhach] ASC)
);

