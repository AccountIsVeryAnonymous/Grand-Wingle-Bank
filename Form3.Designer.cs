namespace Grand_Wingle_Bank
{
    partial class Form3
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
            this.labelSignup = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxErrorMessage = new System.Windows.Forms.TextBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.labelSignup);
            this.panel1.Controls.Add(this.buttonSignup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 65);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(7, 3);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(290, 62);
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelSignup
            // 
            this.labelSignup.AutoSize = true;
            this.labelSignup.BackColor = System.Drawing.SystemColors.Control;
            this.labelSignup.Location = new System.Drawing.Point(487, 23);
            this.labelSignup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(86, 13);
            this.labelSignup.TabIndex = 3;
            this.labelSignup.Text = "No account yet?";
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSignup.Location = new System.Drawing.Point(489, 36);
            this.buttonSignup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(75, 22);
            this.buttonSignup.TabIndex = 2;
            this.buttonSignup.Text = "Sign up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxQuestion);
            this.panel2.Controls.Add(this.textBoxErrorMessage);
            this.panel2.Controls.Add(this.buttonContinue);
            this.panel2.Controls.Add(this.textBoxAnswer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 282);
            this.panel2.TabIndex = 1;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(51, 83);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(191, 20);
            this.textBoxQuestion.TabIndex = 6;
            // 
            // textBoxErrorMessage
            // 
            this.textBoxErrorMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxErrorMessage.Location = new System.Drawing.Point(51, 21);
            this.textBoxErrorMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxErrorMessage.Name = "textBoxErrorMessage";
            this.textBoxErrorMessage.Size = new System.Drawing.Size(381, 20);
            this.textBoxErrorMessage.TabIndex = 5;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(51, 147);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(85, 19);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(356, 83);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(76, 20);
            this.textBoxAnswer.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSignup;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxErrorMessage;
        private System.Windows.Forms.TextBox textBoxQuestion;
    }
}