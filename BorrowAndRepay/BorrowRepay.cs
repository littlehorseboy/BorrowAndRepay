﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class BorrowRepay : Form
    {
        Person me, friend;
        readonly int myMoney = 0;
        readonly int friendMoney = 10000;
        readonly int borrowMoney = 1000;

        public BorrowRepay()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            me = new Person(myNameInput.Text, myMoney);
            friend = new Person(friendNameInput.Text, friendMoney);

            setEnabled();

            myNameLabel.Text = me.name;
            friendNameLabel.Text = friend.name;

            borrowButton.Text = $"跟 {friend.name} 借 ${borrowMoney.ToString()}";
            repayButton.Text = $"還給 {friend.name} ${borrowMoney.ToString()}";
        }

        private void setEnabled()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag == null)
                {
                    continue;
                }

                if (control.Tag.ToString() == "namesForm")
                {
                    control.Enabled = false;
                }

                if (control.Tag.ToString() == "borrowButtons")
                {
                    control.Enabled = true;
                }
            }
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            me.Borrow(friend, borrowMoney);
            this.UpdateMoney();
        }

        private void RepayButton_Click(object sender, EventArgs e)
        {
            me.Repay(friend, borrowMoney);
            this.UpdateMoney();
        }

        private void UpdateMoney()
        {
            myMoneyLabel.Text = me.money.ToString();
            friendMoneyLabel.Text = friend.money.ToString();
        }
    }
}
