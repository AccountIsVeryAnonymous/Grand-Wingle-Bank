namespace Grand_Wingle_Bank
{
    partial class Form8
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
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.textBoxWarning = new System.Windows.Forms.TextBox();
            this.comboBoxDetails = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.87432F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.12569F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonMainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 109);
            this.panel1.TabIndex = 0;
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(481, 27);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(79, 22);
            this.buttonMainMenu.TabIndex = 0;
            this.buttonMainMenu.Text = "Main menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonContinue);
            this.panel2.Controls.Add(this.textBoxWarning);
            this.panel2.Controls.Add(this.comboBoxDetails);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxPerson);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 249);
            this.panel2.TabIndex = 1;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(201, 174);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(80, 26);
            this.buttonContinue.TabIndex = 6;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // textBoxWarning
            // 
            this.textBoxWarning.Location = new System.Drawing.Point(19, 147);
            this.textBoxWarning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWarning.Name = "textBoxWarning";
            this.textBoxWarning.Size = new System.Drawing.Size(410, 20);
            this.textBoxWarning.TabIndex = 5;
            // 
            // comboBoxDetails
            // 
            this.comboBoxDetails.FormattingEnabled = true;
            this.comboBoxDetails.Location = new System.Drawing.Point(347, 111);
            this.comboBoxDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDetails.Name = "comboBoxDetails";
            this.comboBoxDetails.Size = new System.Drawing.Size(82, 21);
            this.comboBoxDetails.TabIndex = 4;
            this.comboBoxDetails.SelectedIndexChanged += new System.EventHandler(this.comboBoxDetails_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "How did you obtain their sort code and account number";
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(347, 55);
            this.comboBoxPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(82, 21);
            this.comboBoxPerson.TabIndex = 2;
            this.comboBoxPerson.SelectedIndexChanged += new System.EventHandler(this.comboBoxPerson_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Who would you like to pay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scam check before the transaction";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::Grand_Wingle_Bank.Properties.Resources.GrandWingleBankLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.ComboBox comboBoxDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWarning;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}