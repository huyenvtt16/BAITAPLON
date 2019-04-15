CREATE TABLE [dbo].[HDBan] (
    [MaHDBan]    NVARCHAR (30) NOT NULL,
    [MaNhanVien] NVARCHAR (10) NULL,
    [NgayBan]    DATETIME      NULL,
    [MaKhach]    NVARCHAR (10) NULL,
    CONSTRAINT [PK_HDBan] PRIMARY KEY CLUSTERED ([MaHDBan] ASC),
    CONSTRAINT [FK_HDBan_Khach] FOREIGN KEY ([MaKhach]) REFERENCES [dbo].[Khach] ([MaKhach]),
    CONSTRAINT [FK_HDBan_NhanVien] FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanVien] ([MaNhanVien])
);

