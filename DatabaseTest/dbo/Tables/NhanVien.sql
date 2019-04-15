CREATE TABLE [dbo].[NhanVien] (
    [MaNhanVien]  NVARCHAR (10) NOT NULL,
    [TenNhanVien] NVARCHAR (50) NULL,
    [GioiTinh]    NVARCHAR (10) NULL,
    [DiaChi]      NVARCHAR (50) NULL,
    [DienThoai]   NVARCHAR (15) NULL,
    [NgaySinh]    DATETIME      NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED ([MaNhanVien] ASC)
);

