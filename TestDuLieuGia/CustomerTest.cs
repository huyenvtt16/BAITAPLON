using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
namespace TestDuLieuGia
{
    [TestClass]
    public class CustomerTest
    {
        public KhachDTO kh;
        [TestInitialize]
        public void setup()
        {
            this.kh = new KhachDTO("KH01","Khả Di","HCM","0367777");
        }
        [TestMethod]
        public void TestMaNV()
        {
            Assert.AreEqual(kh.MaKhach, "KH01");
        }
        [TestMethod]
        public void TestTenNV()
        {
            Assert.AreEqual(kh.TenKhach, "Khả Di");
        }
        [TestMethod]
        public void TestDiaChi()
        {
            Assert.AreEqual(kh.DiaChi, "HCM");
        }
        [TestMethod]
        public void TestDienThoai()
        {
            Assert.AreEqual(kh.DienThoai, "0367777");
        }
        [TestMethod]
        public void TestMaNV2()
        {
            Assert.AreEqual(kh.MaKhach, "KH02");
        }
    }
}
