namespace Grand_Wingle_Bank
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.68493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.31507F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 365);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 106);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLogo.BackgroundImage = global::Grand_Wingle_Bank.Properties.Resources.GrandWingleBankLogo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(311, 102);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Location = new System.Drawing.Point(490, 45);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(50, 21);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxLastName);
            this.panel2.Controls.Add(this.labelLastName);
            this.panel2.Controls.Add(this.buttonContinue);
            this.panel2.Controls.Add(this.textBoxDOB);
            this.panel2.Controls.Add(this.labelDOB);
            this.panel2.Controls.Add(this.labelFirstName);
            this.panel2.Controls.Add(this.textBoxFirstName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 247);
            this.panel2.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(275, 110);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(213, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(31, 110);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(103, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Enter your last name";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(34, 183);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(56, 19);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Location = new System.Drawing.Point(275, 146);
            this.textBoxDOB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(213, 20);
            this.textBoxDOB.TabIndex = 3;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(31, 146);
            this.labelDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(227, 13);
            this.labelDOB.TabIndex = 2;
            this.labelDOB.Text = "Enter date of birth in the format DD/MM/YYYY";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(31, 75);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(103, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Enter your first name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(275, 75);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(213, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 365);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}