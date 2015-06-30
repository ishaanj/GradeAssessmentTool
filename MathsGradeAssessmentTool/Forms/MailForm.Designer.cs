namespace MathsGradeAssessmentTool.Forms
{
    partial class MailForm
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
            this.addFileButton = new System.Windows.Forms.Button();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailToBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mailSub = new System.Windows.Forms.TextBox();
            this.mailBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addFileButton
            // 
            this.addFileButton.BackColor = System.Drawing.Color.White;
            this.addFileButton.Location = new System.Drawing.Point(335, 225);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(143, 39);
            this.addFileButton.TabIndex = 0;
            this.addFileButton.Text = "Add Files";
            this.addFileButton.UseVisualStyleBackColor = false;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // sendMailButton
            // 
            this.sendMailButton.BackColor = System.Drawing.Color.White;
            this.sendMailButton.Location = new System.Drawing.Point(278, 343);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(262, 67);
            this.sendMailButton.TabIndex = 1;
            this.sendMailButton.Text = "Send Email";
            this.sendMailButton.UseVisualStyleBackColor = false;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Send Email To: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // mailToBox
            // 
            this.mailToBox.Location = new System.Drawing.Point(319, 45);
            this.mailToBox.Name = "mailToBox";
            this.mailToBox.Size = new System.Drawing.Size(209, 20);
            this.mailToBox.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Added file:";
            // 
            // fileBox
            // 
            this.fileBox.BackColor = System.Drawing.Color.White;
            this.fileBox.Location = new System.Drawing.Point(319, 285);
            this.fileBox.Name = "fileBox";
            this.fileBox.ReadOnly = true;
            this.fileBox.Size = new System.Drawing.Size(321, 20);
            this.fileBox.TabIndex = 6;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(667, 28);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 52);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Return to Main Screen";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Message:";
            // 
            // mailSub
            // 
            this.mailSub.Location = new System.Drawing.Point(319, 90);
            this.mailSub.Name = "mailSub";
            this.mailSub.Size = new System.Drawing.Size(209, 20);
            this.mailSub.TabIndex = 10;
            this.mailSub.Text = "Student Report in Excel";
            // 
            // mailBody
            // 
            this.mailBody.Location = new System.Drawing.Point(319, 133);
            this.mailBody.Multiline = true;
            this.mailBody.Name = "mailBody";
            this.mailBody.Size = new System.Drawing.Size(268, 71);
            this.mailBody.TabIndex = 11;
            this.mailBody.Text = "Excel sheet for student report";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mailBody);
            this.Controls.Add(this.mailSub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mailToBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMailButton);
            this.Controls.Add(this.addFileButton);
            this.Name = "MailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailToBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mailSub;
        private System.Windows.Forms.TextBox mailBody;
    }
}