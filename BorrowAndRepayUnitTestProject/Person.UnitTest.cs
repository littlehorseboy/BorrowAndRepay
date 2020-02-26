using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorrowAndRepay;

namespace BorrowAndRepayUnitTestProject
{
    [TestClass]
    public class PersonUnitTest
    {
        Person i;
        Person friend;

        public void InitClass()
        {
            i = new Person("�p��", 0);
            friend = new Person("�p��", 10000);
        }

        [TestMethod]
        public void PersonIMoneyZero()
        {
            InitClass();
            Assert.AreEqual(i.Money, 0);
        }

        [TestMethod]
        public void PersonFriendMoneyTenThousand()
        {
            InitClass();
            Assert.AreEqual(friend.Money, 10000);
        }
        
        [TestMethod]
        public void IBorrowFromFriendTenThousand()
        {
            InitClass();
            i.borrow(friend, 10000);
            Assert.AreEqual(i.Money, 10000);
            Assert.AreEqual(friend.Money, 0);
        }

        [TestMethod]
        public void IRepayForFriendTenThousand()
        {
            InitClass();
            i.borrow(friend, 10000);
            i.repay(friend, 10000);
            Assert.AreEqual(i.Money, 0);
            Assert.AreEqual(friend.Money, 10000);
        }

        [TestMethod]
        public void IBorrowFromFriendOverload()
        {
            InitClass();
            i.borrow(friend, 9999999);
            Assert.AreEqual(i.Money, 0);
            Assert.AreEqual(friend.Money, 10000);
        }

        [TestMethod]
        public void IRepayForFriendOverload()
        {
            InitClass();
            i.repay(friend, 9999999);
            Assert.AreEqual(i.Money, 0);
            Assert.AreEqual(friend.Money, 10000);
        }
    }
}
