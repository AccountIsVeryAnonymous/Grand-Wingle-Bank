namespace Grand_Wingle_Bank
{
    partial class Form5
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.94506F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.05495F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 105);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLogo.BackgroundImage = global::Grand_Wingle_Bank.Properties.Resources.GrandWingleBankLogo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(305, 101);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCreateAccount);
            this.panel2.Controls.Add(this.labelError);
            this.panel2.Controls.Add(this.labelPlace);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.textBoxPlace);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.textBoxDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 251);
            this.panel2.TabIndex = 1;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(350, 157);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(81, 33);
            this.buttonCreateAccount.TabIndex = 7;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(29, 167);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 6;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(29, 112);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(122, 13);
            this.labelPlace.TabIndex = 5;
            this.labelPlace.Text = "Enter an important place";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 62);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Enter an important name";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(29, 13);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(117, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Enter an important date";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(253, 112);
            this.textBoxPlace.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(217, 20);
            this.textBoxPlace.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(253, 62);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(217, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(253, 13);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(217, 20);
            this.textBoxDate.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Form5";
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
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}