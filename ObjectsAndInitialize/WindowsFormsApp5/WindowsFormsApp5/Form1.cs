using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };

            bob = new Guy() { Cash = 100, Name = "Bob" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank>=10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank has no money");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {bob.GiveCash(5);
            joe.ReceiveCash(5);
            
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {joe.GiveCash(4);
            bob.ReceiveCash(4);
            
            UpdateForm();
        }
    }
}
