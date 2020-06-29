using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorrowAndRepay;

namespace BorrowAndRepayUnitTestProject
{
    [TestClass]
    public class PersonUnitTest
    {
        Person XiaoMing;
        Person XiaoHua;

        [TestInitialize]
        public void InitClass()
        {
            XiaoMing = new Person("小明", 0);
            XiaoHua = new Person("小華", 10000);
        }

        [TestMethod]
        public void XiaoMingMoneyZero()
        {
            Assert.AreEqual(XiaoMing.money, 0);
        }

        [TestMethod]
        public void XiaoHuaMoneyTenThousand()
        {
            Assert.AreEqual(XiaoHua.money, 10000);
        }
        
        [TestMethod]
        public void XiaoMingBorrowFromXiaoHuaTenThousand()
        {
            XiaoMing.Borrow(XiaoHua, 10000);
            Assert.AreEqual(XiaoMing.money, 10000);
            Assert.AreEqual(XiaoHua.money, 0);
        }

        [TestMethod]
        public void XiaoMingRepayForXiaoHuaTenThousand()
        {
            XiaoMing.Borrow(XiaoHua, 10000);
            XiaoMing.Repay(XiaoHua, 10000);
            Assert.AreEqual(XiaoMing.money, 0);
            Assert.AreEqual(XiaoHua.money, 10000);
        }

        [TestMethod]
        public void XiaoMingBorrowFromXiaoHuaOverload()
        {
            XiaoMing.Borrow(XiaoHua, 9999999);
            Assert.AreEqual(XiaoMing.money, 0);
            Assert.AreEqual(XiaoHua.money, 10000);
        }

        [TestMethod]
        public void XiaoMingRepayForXiaoHuaOverload()
        {
            XiaoMing.Repay(XiaoHua, 9999999);
            Assert.AreEqual(XiaoMing.money, 0);
            Assert.AreEqual(XiaoHua.money, 10000);
        }
    }
}
