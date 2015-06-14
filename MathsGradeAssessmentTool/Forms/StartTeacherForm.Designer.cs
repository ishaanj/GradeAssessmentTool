namespace MathsGradeAssessmentTool.Forms
{
    partial class StartTeacherForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label teacherNameLabel;
            System.Windows.Forms.Label studentNameLabel;
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TeacherTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.AddTeacher = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.AddCompetency = new System.Windows.Forms.Button();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.studentNameComboBox = new System.Windows.Forms.ComboBox();
            this.fKStudentToTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            teacherNameLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStudentToTeacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(259, 84);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(81, 13);
            teacherNameLabel.TabIndex = 1;
            teacherNameLabel.Text = "Teacher Name:";
            // 
            // mathsToolDatabaseDataSet
            // 
            this.mathsToolDatabaseDataSet.DataSetName = "MathsToolDatabaseDataSet";
            this.mathsToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencyTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherName", true));
            this.teacherNameComboBox.DataSource = this.teacherBindingSource1;
            this.teacherNameComboBox.DisplayMember = "TeacherName";
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Location = new System.Drawing.Point(346, 81);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.teacherNameComboBox.TabIndex = 2;
            this.teacherNameComboBox.SelectedIndexChanged += new System.EventHandler(this.onSelectedIndexChange);
            // 
            // AddTeacher
            // 
            this.AddTeacher.Location = new System.Drawing.Point(639, 36);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Size = new System.Drawing.Size(113, 31);
            this.AddTeacher.TabIndex = 3;
            this.AddTeacher.Text = "Add Teacher";
            this.AddTeacher.UseVisualStyleBackColor = true;
            this.AddTeacher.Click += new System.EventHandler(this.AddTeacher_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(639, 73);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(113, 29);
            this.AddStudent.TabIndex = 4;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // AddCompetency
            // 
            this.AddCompetency.Location = new System.Drawing.Point(639, 109);
            this.AddCompetency.Name = "AddCompetency";
            this.AddCompetency.Size = new System.Drawing.Size(113, 29);
            this.AddCompetency.TabIndex = 5;
            this.AddCompetency.Text = "Add Competency";
            this.AddCompetency.UseVisualStyleBackColor = true;
            this.AddCompetency.Click += new System.EventHandler(this.AddCompetency_Click);
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "Teacher";
            this.teacherBindingSource1.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(262, 125);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(78, 13);
            studentNameLabel.TabIndex = 5;
            studentNameLabel.Text = "Student Name:";
            // 
            // studentNameComboBox
            // 
            this.studentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentName", true));
            this.studentNameComboBox.FormattingEnabled = true;
            this.studentNameComboBox.Location = new System.Drawing.Point(346, 122);
            this.studentNameComboBox.Name = "studentNameComboBox";
            this.studentNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentNameComboBox.TabIndex = 6;
            // 
            // fKStudentToTeacherBindingSource
            // 
            this.fKStudentToTeacherBindingSource.DataMember = "FK_Student_To_Teacher";
            this.fKStudentToTeacherBindingSource.DataSource = this.teacherBindingSource;
            // 
            // StartTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(studentNameLabel);
            this.Controls.Add(this.studentNameComboBox);
            this.Controls.Add(this.AddCompetency);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.AddTeacher);
            this.Controls.Add(teacherNameLabel);
            this.Controls.Add(this.teacherNameComboBox);
            this.Name = "StartTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Teacher";
            this.Load += new System.EventHandler(this.StartTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStudentToTeacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MathsToolDatabaseDataSet mathsToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox teacherNameComboBox;
        private System.Windows.Forms.Button AddTeacher;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button AddCompetency;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ComboBox studentNameComboBox;
        private System.Windows.Forms.BindingSource fKStudentToTeacherBindingSource;

    }
}