namespace MathsGradeAssessmentTool.Forms
{
    partial class CompentencyPointerCalculationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ticks = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.pointer = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competency Score:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ticks
            // 
            this.ticks.Location = new System.Drawing.Point(407, 127);
            this.ticks.Name = "ticks";
            this.ticks.Size = new System.Drawing.Size(100, 20);
            this.ticks.TabIndex = 2;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(366, 168);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "Find Pointer";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // pointer
            // 
            this.pointer.Location = new System.Drawing.Point(351, 197);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(100, 20);
            this.pointer.TabIndex = 5;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(594, 41);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(126, 49);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back To Main Page";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CompentencyPointerCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.ticks);
            this.Controls.Add(this.label1);
            this.Name = "CompentencyPointerCalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pointer Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ticks;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox pointer;
        private System.Windows.Forms.Button Back;
    }
}