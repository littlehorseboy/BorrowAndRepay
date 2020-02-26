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
        public void PersonIMoneyZero()
        {
            InitClass();
            Assert.AreEqual(XiaoMing.Money, 0);
        }

        [TestMethod]
        public void PersonFriendMoneyTenThousand()
        {
            InitClass();
            Assert.AreEqual(XiaoHua.Money, 10000);
        }
        
        [TestMethod]
        public void IBorrowFromFriendTenThousand()
        {
            InitClass();
            XiaoMing.borrow(XiaoHua, 10000);
            Assert.AreEqual(XiaoMing.Money, 10000);
            Assert.AreEqual(XiaoHua.Money, 0);
        }

        [TestMethod]
        public void IRepayForFriendTenThousand()
        {
            InitClass();
            XiaoMing.borrow(XiaoHua, 10000);
            XiaoMing.repay(XiaoHua, 10000);
            Assert.AreEqual(XiaoMing.Money, 0);
            Assert.AreEqual(XiaoHua.Money, 10000);
        }

        [TestMethod]
        public void IBorrowFromFriendOverload()
        {
            InitClass();
            XiaoMing.borrow(XiaoHua, 9999999);
            Assert.AreEqual(XiaoMing.Money, 0);
            Assert.AreEqual(XiaoHua.Money, 10000);
        }

        [TestMethod]
        public void IRepayForFriendOverload()
        {
            InitClass();
            XiaoMing.repay(XiaoHua, 9999999);
            Assert.AreEqual(XiaoMing.Money, 0);
            Assert.AreEqual(XiaoHua.Money, 10000);
        }
    }
}
