using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    public class Person
    {
        public string Name;
        public int Money;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public void Borrow(Person lender, int money)
        {
            if (lender.Money >= money)
            {
                lender.Money -= money;
                Money += money;
            }
        }

        public void Repay(Person lender, int money)
        {
            if (Money >= money)
            {
                Money -= money;
                lender.Money += money;
            }
        }
    }
}
