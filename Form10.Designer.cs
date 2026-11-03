namespace Grand_Wingle_Bank
{
    partial class Form10
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.textBoxSortCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.buttonMainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 84);
            this.panel1.TabIndex = 0;
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(639, 34);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(110, 33);
            this.buttonMainMenu.TabIndex = 0;
            this.buttonMainMenu.Text = "Main menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxAmount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonContinue);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxAccountNumber);
            this.panel2.Controls.Add(this.textBoxSortCode);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxLastName);
            this.panel2.Controls.Add(this.textBoxFirstName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 354);
            this.panel2.TabIndex = 1;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(435, 203);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(271, 73);
            this.buttonContinue.TabIndex = 11;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Account Number";
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(565, 116);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(220, 26);
            this.textBoxAccountNumber.TabIndex = 8;
            // 
            // textBoxSortCode
            // 
            this.textBoxSortCode.Location = new System.Drawing.Point(565, 39);
            this.textBoxSortCode.Name = "textBoxSortCode";
            this.textBoxSortCode.Size = new System.Drawing.Size(220, 26);
            this.textBoxSortCode.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sort code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name of payee";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(164, 122);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(220, 26);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(164, 42);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(220, 26);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First name of payee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount to transfer";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(176, 203);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(208, 26);
            this.textBoxAmount.TabIndex = 13;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSortCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}