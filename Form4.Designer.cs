namespace Grand_Wingle_Bank
{
    partial class Form4
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
            this.textBoxWingleSaver = new System.Windows.Forms.TextBox();
            this.textBoxWingleAccount = new System.Windows.Forms.TextBox();
            this.buttonViewWingleSaver = new System.Windows.Forms.Button();
            this.buttonViewWingleAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textBoxWingleSaver);
            this.panel1.Controls.Add(this.textBoxWingleAccount);
            this.panel1.Controls.Add(this.buttonViewWingleSaver);
            this.panel1.Controls.Add(this.buttonViewWingleAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 442);
            this.panel1.TabIndex = 0;
            // 
            // textBoxWingleSaver
            // 
            this.textBoxWingleSaver.Location = new System.Drawing.Point(64, 198);
            this.textBoxWingleSaver.Multiline = true;
            this.textBoxWingleSaver.Name = "textBoxWingleSaver";
            this.textBoxWingleSaver.Size = new System.Drawing.Size(482, 68);
            this.textBoxWingleSaver.TabIndex = 5;
            this.textBoxWingleSaver.Text = "WingleSaver";
            // 
            // textBoxWingleAccount
            // 
            this.textBoxWingleAccount.Location = new System.Drawing.Point(64, 57);
            this.textBoxWingleAccount.Multiline = true;
            this.textBoxWingleAccount.Name = "textBoxWingleAccount";
            this.textBoxWingleAccount.Size = new System.Drawing.Size(482, 68);
            this.textBoxWingleAccount.TabIndex = 4;
            this.textBoxWingleAccount.Text = "WingleAccount";
            // 
            // buttonViewWingleSaver
            // 
            this.buttonViewWingleSaver.Location = new System.Drawing.Point(604, 198);
            this.buttonViewWingleSaver.Name = "buttonViewWingleSaver";
            this.buttonViewWingleSaver.Size = new System.Drawing.Size(122, 37);
            this.buttonViewWingleSaver.TabIndex = 1;
            this.buttonViewWingleSaver.Text = "View";
            this.buttonViewWingleSaver.UseVisualStyleBackColor = true;
            // 
            // buttonViewWingleAccount
            // 
            this.buttonViewWingleAccount.Location = new System.Drawing.Point(604, 52);
            this.buttonViewWingleAccount.Name = "buttonViewWingleAccount";
            this.buttonViewWingleAccount.Size = new System.Drawing.Size(122, 37);
            this.buttonViewWingleAccount.TabIndex = 0;
            this.buttonViewWingleAccount.Text = "View";
            this.buttonViewWingleAccount.UseVisualStyleBackColor = true;
            this.buttonViewWingleAccount.Click += new System.EventHandler(this.buttonViewWingleAccount_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 104);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(436, 97);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(770, 35);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(84, 34);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonViewWingleAccount;
        private System.Windows.Forms.Button buttonViewWingleSaver;
        private System.Windows.Forms.TextBox textBoxWingleSaver;
        private System.Windows.Forms.TextBox textBoxWingleAccount;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}