using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    class LabelBouncer
    {
        public Label myLabel;
        public bool GoingForward = true;
        public void Move()
        {
            if (myLabel!=null)
            {
                if (GoingForward==true)
                {
                    myLabel.Left += 5;
                    if (myLabel.Left>=myLabel.Parent.Width-myLabel.Width)
                    {
                        GoingForward = false;
                    }
                }
                else
                {
                    myLabel.Left -= 5;
                    if (myLabel.Left<=0)
                    {
                        GoingForward = true;
                    }
                }
            }
        }
    }
}
