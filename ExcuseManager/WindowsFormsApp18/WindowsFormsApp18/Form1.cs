using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = dateTimePicker1.Value;
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result==DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                buttonSave.Enabled = true;
                buttonOpen.Enabled = true;
                buttonRandom.Enabled = true;
                buttonFolder.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(description.Text)||String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please specify an excuse and a result",
                    "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Excuse files (*excuse)|*.excuse|All files (*.*)|*.*";
            saveFileDialog1.FileName = description.Text+".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result==DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Excuse files (*excuse)|*.excuse|All files (*.*)|*.*";
                openFileDialog1.FileName = description.Text + ".excuse";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result==DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result=MessageBox.Show("The current excuse has not been saved. Continiue?",
                    "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result==DialogResult.No)
                {
                    return false;
                }
            }
            return true;
            
            
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.textBox2.Text = currentExcuse.Results;
                this.dateTimePicker1.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    textBox3.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
                else
                {
                    this.Text="Excuse Manager*";
                }
                this.formChanged = changed;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = textBox2.Text;
            UpdateForm(true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dateTimePicker1.Value;
            UpdateForm(true);
        }
    }
}
