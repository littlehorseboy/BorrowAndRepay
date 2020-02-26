using System;
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
    public partial class Form1 : Form
    {
        Person i, friend;

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            i = new Person(myNameInput.Text, 0);
            friend = new Person(friendNameInput.Text, 200000);

            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            submitButton.Enabled = false;

            borrowButton.Enabled = false;
            repayButton.Enabled = false;
        }
    }
}
