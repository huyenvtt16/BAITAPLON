using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
namespace TestDuLieuGia
{
    [TestClass]
    public class UsersTest
    {
        public LoginDTO dn;
        [TestInitialize]
        public void setup()
        {
            dn = new LoginDTO("ABC","09081998");
        }
        //true
        [TestMethod]
        public void TestUser1()
        {
            Assert.AreEqual(dn.UserName,"ABC");
        }
        //true
        [TestMethod]
        public void TestUser2()
        {
            Assert.AreEqual(dn.Password, "09081997");
        }
        //failse
        [TestMethod]
        public void TestUser3()
        {
            Assert.AreEqual(dn.UserName, "");
        }
        //failse
        [TestMethod]
        public void TestUser4()
        {
            Assert.AreEqual(dn.Password, "");
        }
        //fail do user không đúng
        [TestMethod]
        public void TestUser5()
        {
            Assert.AreEqual(dn.UserName, "Anh");
        }
        //fail do pass sai
        [TestMethod]
        public void TestUser6()
        {
            Assert.AreEqual(dn.Password, "09081998");
        }
        //fail do user có khoảng trống
        [TestMethod]
        public void TestUser7()
        {
            Assert.AreEqual(dn.UserName, "An h");
        }
        //fail do pass không khớp
        [TestMethod]
        public void TestUser8()
        {
            Assert.AreEqual(dn.Password, "0908_1997");
        }
        //true
        [TestMethod]
        public void TestUser9()
        {
            Assert.IsNotNull("user nhập hợp lệ");
        }
        [TestMethod]
        //failse do user không rỗng
        public void TestUser10()
        {
            Assert.IsNull(dn.UserName, "user nhập không hợp lệ");
        }

    }
}
