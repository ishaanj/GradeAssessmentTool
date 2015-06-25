﻿namespace MathsGradeAssessmentTool.Forms
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
            System.Windows.Forms.Label gTotalWeightedLabel;
            System.Windows.Forms.Label gradeEquivalentLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TeacherTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AddTeacher = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.AddCompetency = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.studentNameComboBox = new System.Windows.Forms.ComboBox();
            this.fKStudentToTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillWithTIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studentCompentencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCompentencyTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentCompentencyTableAdapter();
            this.gTotalWeightedTextBox = new System.Windows.Forms.TextBox();
            this.gradeEquivalentTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mail = new System.Windows.Forms.Button();
            teacherNameLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            gTotalWeightedLabel = new System.Windows.Forms.Label();
            gradeEquivalentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStudentToTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(61, 81);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(81, 13);
            teacherNameLabel.TabIndex = 1;
            teacherNameLabel.Text = "Teacher Name:";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(64, 122);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(78, 13);
            studentNameLabel.TabIndex = 5;
            studentNameLabel.Text = "Student Name:";
            // 
            // gTotalWeightedLabel
            // 
            gTotalWeightedLabel.AutoSize = true;
            gTotalWeightedLabel.Location = new System.Drawing.Point(345, 81);
            gTotalWeightedLabel.Name = "gTotalWeightedLabel";
            gTotalWeightedLabel.Size = new System.Drawing.Size(91, 13);
            gTotalWeightedLabel.TabIndex = 9;
            gTotalWeightedLabel.Text = "GTotal Weighted:";
            // 
            // gradeEquivalentLabel
            // 
            gradeEquivalentLabel.AutoSize = true;
            gradeEquivalentLabel.Location = new System.Drawing.Point(345, 122);
            gradeEquivalentLabel.Name = "gradeEquivalentLabel";
            gradeEquivalentLabel.Size = new System.Drawing.Size(92, 13);
            gradeEquivalentLabel.TabIndex = 11;
            gradeEquivalentLabel.Text = "Grade Equivalent:";
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
            this.tableAdapterManager.StudentCompentencyTableAdapter = null;
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
            this.teacherNameComboBox.Location = new System.Drawing.Point(148, 78);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.teacherNameComboBox.TabIndex = 2;
            this.teacherNameComboBox.SelectedIndexChanged += new System.EventHandler(this.onSelectedIndexChange);
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "Teacher";
            this.teacherBindingSource1.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // AddTeacher
            // 
            this.AddTeacher.BackColor = System.Drawing.Color.White;
            this.AddTeacher.Location = new System.Drawing.Point(67, 14);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Size = new System.Drawing.Size(113, 28);
            this.AddTeacher.TabIndex = 3;
            this.AddTeacher.Text = "Add Teacher";
            this.AddTeacher.UseVisualStyleBackColor = false;
            this.AddTeacher.Click += new System.EventHandler(this.AddTeacher_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.Color.White;
            this.AddStudent.Location = new System.Drawing.Point(245, 13);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(113, 29);
            this.AddStudent.TabIndex = 4;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // AddCompetency
            // 
            this.AddCompetency.BackColor = System.Drawing.Color.White;
            this.AddCompetency.Location = new System.Drawing.Point(445, 14);
            this.AddCompetency.Name = "AddCompetency";
            this.AddCompetency.Size = new System.Drawing.Size(113, 29);
            this.AddCompetency.TabIndex = 5;
            this.AddCompetency.Text = "Add Competency";
            this.AddCompetency.UseVisualStyleBackColor = false;
            this.AddCompetency.Click += new System.EventHandler(this.AddCompetency_Click);
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
            // studentNameComboBox
            // 
            this.studentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentName", true));
            this.studentNameComboBox.DataSource = this.fKStudentToTeacherBindingSource;
            this.studentNameComboBox.DisplayMember = "StudentName";
            this.studentNameComboBox.FormattingEnabled = true;
            this.studentNameComboBox.Location = new System.Drawing.Point(148, 119);
            this.studentNameComboBox.Name = "studentNameComboBox";
            this.studentNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentNameComboBox.TabIndex = 6;
            // 
            // fKStudentToTeacherBindingSource
            // 
            this.fKStudentToTeacherBindingSource.DataMember = "FK_Student_To_Teacher";
            this.fKStudentToTeacherBindingSource.DataSource = this.teacherBindingSource;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.CurrentGrade});
            this.studentDataGridView.DataSource = this.fKStudentToTeacherBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(23, 166);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(522, 243);
            this.studentDataGridView.TabIndex = 7;
            this.studentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SubjectID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn5.HeaderText = "TeacherID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // CurrentGrade
            // 
            this.CurrentGrade.DataPropertyName = "CurrentGrade";
            this.CurrentGrade.HeaderText = "CurrentGrade";
            this.CurrentGrade.Name = "CurrentGrade";
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.BackColor = System.Drawing.Color.White;
            this.addSubjectButton.Location = new System.Drawing.Point(648, 14);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(113, 29);
            this.addSubjectButton.TabIndex = 8;
            this.addSubjectButton.Text = "Add Subject";
            this.addSubjectButton.UseVisualStyleBackColor = false;
            this.addSubjectButton.Click += new System.EventHandler(this.AddSubjectClicked_Clicked);
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillWithTIDToolStripButton
            // 
            this.fillWithTIDToolStripButton.Name = "fillWithTIDToolStripButton";
            this.fillWithTIDToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // studentCompentencyBindingSource
            // 
            this.studentCompentencyBindingSource.DataMember = "StudentCompentency";
            this.studentCompentencyBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // studentCompentencyTableAdapter
            // 
            this.studentCompentencyTableAdapter.ClearBeforeFill = true;
            // 
            // gTotalWeightedTextBox
            // 
            this.gTotalWeightedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentCompentencyBindingSource, "GTotalWeighted", true));
            this.gTotalWeightedTextBox.Location = new System.Drawing.Point(445, 78);
            this.gTotalWeightedTextBox.Name = "gTotalWeightedTextBox";
            this.gTotalWeightedTextBox.ReadOnly = true;
            this.gTotalWeightedTextBox.Size = new System.Drawing.Size(100, 20);
            this.gTotalWeightedTextBox.TabIndex = 10;
            // 
            // gradeEquivalentTextBox
            // 
            this.gradeEquivalentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentCompentencyBindingSource, "GradeEquivalent", true));
            this.gradeEquivalentTextBox.Location = new System.Drawing.Point(445, 119);
            this.gradeEquivalentTextBox.Name = "gradeEquivalentTextBox";
            this.gradeEquivalentTextBox.ReadOnly = true;
            this.gradeEquivalentTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeEquivalentTextBox.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea2.AxisX2.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisY.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(551, 78);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Grades";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(459, 331);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "Grade Chart";
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.Color.White;
            this.mail.Location = new System.Drawing.Point(857, 12);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(112, 30);
            this.mail.TabIndex = 14;
            this.mail.Text = "Send Email";
            this.mail.UseVisualStyleBackColor = false;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // StartTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 422);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.chart1);
            this.Controls.Add(gradeEquivalentLabel);
            this.Controls.Add(this.gradeEquivalentTextBox);
            this.Controls.Add(gTotalWeightedLabel);
            this.Controls.Add(this.gTotalWeightedTextBox);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.studentDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillWithTIDToolStripButton;
        private System.Windows.Forms.BindingSource studentCompentencyBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.StudentCompentencyTableAdapter studentCompentencyTableAdapter;
        private System.Windows.Forms.TextBox gTotalWeightedTextBox;
        private System.Windows.Forms.TextBox gradeEquivalentTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentGrade;
        private System.Windows.Forms.Button mail;

    }
}