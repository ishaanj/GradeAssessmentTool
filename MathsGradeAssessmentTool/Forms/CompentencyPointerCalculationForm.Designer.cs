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
            this.label2 = new System.Windows.Forms.Label();
            this.ticks = new System.Windows.Forms.TextBox();
            this.outof = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.pointer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of ticks(Competency Score):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OutOf:";
            // 
            // ticks
            // 
            this.ticks.Location = new System.Drawing.Point(407, 127);
            this.ticks.Name = "ticks";
            this.ticks.Size = new System.Drawing.Size(100, 20);
            this.ticks.TabIndex = 2;
            // 
            // outof
            // 
            this.outof.Location = new System.Drawing.Point(407, 161);
            this.outof.Name = "outof";
            this.outof.Size = new System.Drawing.Size(100, 20);
            this.outof.TabIndex = 3;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(366, 205);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "Find Pointer";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // pointer
            // 
            this.pointer.Location = new System.Drawing.Point(366, 252);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(100, 20);
            this.pointer.TabIndex = 5;
            // 
            // CompentencyPointerCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.outof);
            this.Controls.Add(this.ticks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompentencyPointerCalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pointer Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ticks;
        private System.Windows.Forms.TextBox outof;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox pointer;
    }
}