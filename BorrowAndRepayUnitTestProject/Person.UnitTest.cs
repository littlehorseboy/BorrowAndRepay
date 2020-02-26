using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorrowAndRepay;

namespace BorrowAndRepayUnitTestProject
{
    [TestClass]
    public class PersonUnitTest
    {
        Person XiaoMing;
        Person XiaoHua;

        public void InitClass()
        {
            XiaoMing = new Person("小明", 0);
            XiaoHua = new Person("小華", 10000);
        }

        [TestMethod]
        public void XiaoMingMoneyZero()
        {
            InitClass();
            Assert.AreEqual(XiaoMing.Money, 0);
        }

        [TestMethod]
        public void XiaoHuaMoneyTenThousand()
        {
            InitClass();
            Assert.AreEqual(XiaoHua.Money, 10000);
        }
        
        [TestMethod]
        public void XiaoMingBorrowFromXiaoHuaTenThousand()
        {
            InitClass();
            XiaoMing.Borrow(XiaoHua, 10000);
            Assert.AreEqual(XiaoMing.Money, 10000);
            Assert.AreEqual(XiaoHua.Money, 0);
        }

        [TestMethod]
        public void XiaoMingRepayForXiaoHuaTenThousand()
        {
            InitClass();
            XiaoMing.Borrow(XiaoHua, 10000);
            XiaoMing.Repay(XiaoHua, 10000);
            Assert.AreEqual(XiaoMing.Money, 0);
            Assert.AreEqual(XiaoHua.Money, 10000);
        }

        [TestMethod]
        public void XiaoMingBorrowFromXiaoHuaOverload()
        {
            InitClass();
            XiaoMing.Borrow(XiaoHua, 9999999);
            Assert.AreEqual(XiaoMing.Money, 0);
            Assert.AreEqual(XiaoHua.Money, 10000);
        }

        [TestMethod]
        public void XiaoMingRepayForXiaoHuaOverload()
        {
            InitClass();
            XiaoMing.Repay(XiaoHua, 9999999);
            Assert.AreEqual(XiaoMing.Money, 0);
            Assert.AreEqual(XiaoHua.Money, 10000);
        }
    }
}
