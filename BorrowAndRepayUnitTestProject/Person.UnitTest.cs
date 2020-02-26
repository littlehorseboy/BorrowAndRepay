using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorrowAndRepay;

namespace BorrowAndRepayUnitTestProject
{
    [TestClass]
    public class PersonUnitTest
    {
        readonly Person i = new Person("小明", 0);
        readonly Person friend = new Person("小華", 10000);

        [TestMethod]
        public void PersonIMoneyZero()
        {
            Assert.AreEqual(i.Money, 0);
        }

        [TestMethod]
        public void PersonFriendMoneyTenThousand()
        {
            Assert.AreEqual(friend.Money, 10000);
        }
        
        [TestMethod]
        public void IBorrowFromFriendTenThousand()
        {
            i.borrow(friend, 10000);
            Assert.AreEqual(i.Money, 10000);
            Assert.AreEqual(friend.Money, 0);
        }

        [TestMethod]
        public void IRepayForFriendTenThousand()
        {
            i.repay(friend, 10000);
            Assert.AreEqual(i.Money, 0);
            Assert.AreEqual(friend.Money, 10000);
        }

        [TestMethod]
        public void IBorrowFromFriendOverload()
        {
            i.borrow(friend, 9999999);
            Assert.AreEqual(i.Money, 0);
            Assert.AreEqual(friend.Money, 10000);
        }

        [TestMethod]
        public void IRepayForFriendOverload()
        {
            i.repay(friend, 9999999);
            Assert.AreEqual(i.Money, 0);
            Assert.AreEqual(friend.Money, 10000);
        }
    }
}
