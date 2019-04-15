CREATE TABLE [dbo].[ChiTietHDBan] (
    [MaHDBan]   NVARCHAR (30) NOT NULL,
    [MaHang]    NVARCHAR (50) NOT NULL,
    [SoLuong]   FLOAT (53)    NULL,
    [ThanhTien] FLOAT (53)    NULL,
    CONSTRAINT [PK_ChiTietHDBan] PRIMARY KEY CLUSTERED ([MaHDBan] ASC, [MaHang] ASC),
    CONSTRAINT [FK_ChiTietHDBan_Hang] FOREIGN KEY ([MaHang]) REFERENCES [dbo].[Hang] ([MaHang]),
    CONSTRAINT [FK_ChiTietHDBan_HDBan] FOREIGN KEY ([MaHDBan]) REFERENCES [dbo].[HDBan] ([MaHDBan])
);

