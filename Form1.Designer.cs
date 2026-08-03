namespace Grand_Wingle_Bank
{
    partial class Form1
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
            this.buttonSignup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelPasscode = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxPasscode = new System.Windows.Forms.TextBox();
            this.labelSignup = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
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
            this.panel1.Controls.Add(this.labelSignup);
            this.panel1.Controls.Add(this.buttonSignup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 84);
            this.panel1.TabIndex = 0;
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSignup.Location = new System.Drawing.Point(653, 42);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(100, 25);
            this.buttonSignup.TabIndex = 0;
            this.buttonSignup.Text = "Sign up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxPasscode);
            this.panel2.Controls.Add(this.textBoxUserID);
            this.panel2.Controls.Add(this.labelPasscode);
            this.panel2.Controls.Add(this.labelUserID);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 354);
            this.panel2.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(573, 131);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(119, 70);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(52, 16);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "User ID";
            // 
            // labelPasscode
            // 
            this.labelPasscode.AutoSize = true;
            this.labelPasscode.Location = new System.Drawing.Point(122, 158);
            this.labelPasscode.Name = "labelPasscode";
            this.labelPasscode.Size = new System.Drawing.Size(69, 16);
            this.labelPasscode.TabIndex = 2;
            this.labelPasscode.Text = "Passcode";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(249, 70);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserID.TabIndex = 3;
            // 
            // textBoxPasscode
            // 
            this.textBoxPasscode.Location = new System.Drawing.Point(249, 158);
            this.textBoxPasscode.Name = "textBoxPasscode";
            this.textBoxPasscode.Size = new System.Drawing.Size(100, 22);
            this.textBoxPasscode.TabIndex = 4;
            // 
            // labelSignup
            // 
            this.labelSignup.AutoSize = true;
            this.labelSignup.BackColor = System.Drawing.SystemColors.Control;
            this.labelSignup.Location = new System.Drawing.Point(650, 23);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(103, 16);
            this.labelSignup.TabIndex = 1;
            this.labelSignup.Text = "No account yet?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelSignup;
        private System.Windows.Forms.TextBox textBoxPasscode;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelPasscode;
        private System.Windows.Forms.Label labelUserID;
    }
}

