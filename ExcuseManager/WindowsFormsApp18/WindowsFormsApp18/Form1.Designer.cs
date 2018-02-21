namespace WindowsFormsApp18
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelExcuse = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelLastUsed = new System.Windows.Forms.Label();
            this.labelFileDate = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labelExcuse
            // 
            this.labelExcuse.AutoSize = true;
            this.labelExcuse.Location = new System.Drawing.Point(13, 13);
            this.labelExcuse.Name = "labelExcuse";
            this.labelExcuse.Size = new System.Drawing.Size(42, 13);
            this.labelExcuse.TabIndex = 0;
            this.labelExcuse.Text = "Excuse";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(13, 42);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(42, 13);
            this.labelResults.TabIndex = 1;
            this.labelResults.Text = "Results";
            // 
            // labelLastUsed
            // 
            this.labelLastUsed.AutoSize = true;
            this.labelLastUsed.Location = new System.Drawing.Point(13, 69);
            this.labelLastUsed.Name = "labelLastUsed";
            this.labelLastUsed.Size = new System.Drawing.Size(55, 13);
            this.labelLastUsed.TabIndex = 2;
            this.labelLastUsed.Text = "Last Used";
            // 
            // labelFileDate
            // 
            this.labelFileDate.AutoSize = true;
            this.labelFileDate.Location = new System.Drawing.Point(13, 104);
            this.labelFileDate.Name = "labelFileDate";
            this.labelFileDate.Size = new System.Drawing.Size(49, 13);
            this.labelFileDate.TabIndex = 3;
            this.labelFileDate.Text = "File Date";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(74, 5);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(198, 20);
            this.description.TabIndex = 4;
            this.description.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(74, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 7;
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(12, 136);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(56, 23);
            this.buttonFolder.TabIndex = 8;
            this.buttonFolder.Text = "Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(74, 136);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(58, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(138, 136);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(57, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Enabled = false;
            this.buttonRandom.Location = new System.Drawing.Point(202, 135);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 11;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.labelFileDate);
            this.Controls.Add(this.labelLastUsed);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelExcuse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExcuse;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelLastUsed;
        private System.Windows.Forms.Label labelFileDate;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

