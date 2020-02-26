using Microsoft.VisualStudio.TestTools.UnitTesting;
using BorrowAndRepay;

namespace BorrowAndRepayUnitTestProject
{
    [TestClass]
    public class PersonUnitTest
    {
        readonly Person i = new Person("�p��", 0);
        readonly Person friend = new Person("�p��", 10000);

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
    }
}
