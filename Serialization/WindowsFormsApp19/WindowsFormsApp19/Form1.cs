using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        Guy joe;
        public Form1()
        {
            InitializeComponent();
            joe = new Guy();
            joe.Name = "Joe";
        }

        private void saveJoe_Click(object sender, EventArgs e)
        {
            using(Stream output = File.Create("Guy_File.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, joe);
            }
        }

        private void loadJoe_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Guy_File.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                joe=(Guy)bf.Deserialize(input);
            }
        }
    }
}
