using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    public class Person
    {
        public string name;
        public int money;

        public Person(string name, int money)
        {
            this.name = name;
            this.money = money;
        }

        public void Borrow(Person lender, int money)
        {
            if (lender.money >= money)
            {
                lender.money -= money;
                this.money += money;
            }
        }

        public void Repay(Person lender, int money)
        {
            if (this.money >= money)
            {
                this.money -= money;
                lender.money += money;
            }
        }
    }
}
