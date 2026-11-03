namespace Grand_Wingle_Bank
{
    partial class Form12
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxPasscode = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
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
            this.buttonMainMenu.Location = new System.Drawing.Point(643, 41);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(110, 27);
            this.buttonMainMenu.TabIndex = 0;
            this.buttonMainMenu.Text = "Main menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCreate);
            this.panel2.Controls.Add(this.textBoxPasscode);
            this.panel2.Controls.Add(this.textBoxUserID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 354);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your user ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please enter your passcode";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(416, 76);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(263, 26);
            this.textBoxUserID.TabIndex = 2;
            // 
            // textBoxPasscode
            // 
            this.textBoxPasscode.Location = new System.Drawing.Point(416, 159);
            this.textBoxPasscode.Name = "textBoxPasscode";
            this.textBoxPasscode.Size = new System.Drawing.Size(263, 26);
            this.textBoxPasscode.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(259, 243);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(179, 41);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create WingleSaver";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxPasscode;
        private System.Windows.Forms.TextBox textBoxUserID;
    }
}