using System.ComponentModel;

namespace MathsGradeAssessmentTool.Forms
{
    partial class StartTeacherForm
    {
        ///Hi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.mailFromBox = new System.Windows.Forms.TextBox();
            this.mailFromPwdBox = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.competencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competencyTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter();
            this.AddSchoolButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SchoolComboBox = new System.Windows.Forms.ComboBox();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.SchoolTableAdapter();
            this.teacherBox = new System.Windows.Forms.TextBox();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.schoolBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unlockButton = new System.Windows.Forms.Button();
            this.lockButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passkey = new System.Windows.Forms.TextBox();
            this.bldLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAverageGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(52, 148);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(81, 13);
            teacherNameLabel.TabIndex = 1;
            teacherNameLabel.Text = "Teacher Name:";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(55, 189);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(78, 13);
            studentNameLabel.TabIndex = 5;
            studentNameLabel.Text = "Student Name:";
            // 
            // gTotalWeightedLabel
            // 
            gTotalWeightedLabel.AutoSize = true;
            gTotalWeightedLabel.Location = new System.Drawing.Point(398, 148);
            gTotalWeightedLabel.Name = "gTotalWeightedLabel";
            gTotalWeightedLabel.Size = new System.Drawing.Size(154, 13);
            gTotalWeightedLabel.TabIndex = 9;
            gTotalWeightedLabel.Text = "Student Total Weighted Score:";
            // 
            // gradeEquivalentLabel
            // 
            gradeEquivalentLabel.AutoSize = true;
            gradeEquivalentLabel.Location = new System.Drawing.Point(420, 189);
            gradeEquivalentLabel.Name = "gradeEquivalentLabel";
            gradeEquivalentLabel.Size = new System.Drawing.Size(129, 13);
            gradeEquivalentLabel.TabIndex = 11;
            gradeEquivalentLabel.Text = "Student Level Equivalent:";
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
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentCompentencyTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.BackColor = System.Drawing.Color.White;
            this.teacherNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherName", true));
            this.teacherNameComboBox.DataSource = this.teacherBindingSource1;
            this.teacherNameComboBox.DisplayMember = "TeacherName";
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Location = new System.Drawing.Point(139, 145);
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
            this.AddStudent.Location = new System.Drawing.Point(301, 14);
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
            this.AddCompetency.Location = new System.Drawing.Point(545, 14);
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
            this.studentNameComboBox.BackColor = System.Drawing.Color.White;
            this.studentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentName", true));
            this.studentNameComboBox.DataSource = this.fKStudentToTeacherBindingSource;
            this.studentNameComboBox.DisplayMember = "StudentName";
            this.studentNameComboBox.FormattingEnabled = true;
            this.studentNameComboBox.Location = new System.Drawing.Point(139, 186);
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
            this.CurrentGrade,
            this.StudentAverageGrade});
            this.studentDataGridView.DataSource = this.fKStudentToTeacherBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(14, 233);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(644, 243);
            this.studentDataGridView.TabIndex = 7;
            this.studentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.BackColor = System.Drawing.Color.White;
            this.addSubjectButton.Location = new System.Drawing.Point(812, 14);
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
            this.gTotalWeightedTextBox.Location = new System.Drawing.Point(558, 145);
            this.gTotalWeightedTextBox.Name = "gTotalWeightedTextBox";
            this.gTotalWeightedTextBox.ReadOnly = true;
            this.gTotalWeightedTextBox.Size = new System.Drawing.Size(100, 20);
            this.gTotalWeightedTextBox.TabIndex = 10;
            // 
            // gradeEquivalentTextBox
            // 
            this.gradeEquivalentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentCompentencyBindingSource, "GradeEquivalent", true));
            this.gradeEquivalentTextBox.Location = new System.Drawing.Point(558, 186);
            this.gradeEquivalentTextBox.Name = "gradeEquivalentTextBox";
            this.gradeEquivalentTextBox.ReadOnly = true;
            this.gradeEquivalentTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeEquivalentTextBox.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea3.AxisX2.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisY.Interval = 1D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "StudentYear";
            legend3.Title = "StudentYear";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(664, 145);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "StudentYear";
            series5.Name = "Grades";
            series5.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "StudentYear";
            series6.Name = "Previous Year";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(555, 331);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "Grade Chart";
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.Color.White;
            this.mail.Location = new System.Drawing.Point(53, 158);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(112, 30);
            this.mail.TabIndex = 14;
            this.mail.Text = "Send Email";
            this.mail.UseVisualStyleBackColor = false;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // mailFromBox
            // 
            this.mailFromBox.Location = new System.Drawing.Point(98, 47);
            this.mailFromBox.Name = "mailFromBox";
            this.mailFromBox.Size = new System.Drawing.Size(100, 20);
            this.mailFromBox.TabIndex = 15;
            // 
            // mailFromPwdBox
            // 
            this.mailFromPwdBox.Location = new System.Drawing.Point(98, 89);
            this.mailFromPwdBox.Name = "mailFromPwdBox";
            this.mailFromPwdBox.PasswordChar = '*';
            this.mailFromPwdBox.Size = new System.Drawing.Size(100, 20);
            this.mailFromPwdBox.TabIndex = 16;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(19, 47);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(49, 13);
            this.lb1.TabIndex = 17;
            this.lb1.Text = "Email ID:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(19, 92);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(56, 13);
            this.lb2.TabIndex = 18;
            this.lb2.Text = "Password:";
            // 
            // competencyBindingSource
            // 
            this.competencyBindingSource.DataMember = "Competency";
            this.competencyBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // competencyTableAdapter
            // 
            this.competencyTableAdapter.ClearBeforeFill = true;
            // 
            // AddSchoolButton
            // 
            this.AddSchoolButton.BackColor = System.Drawing.Color.White;
            this.AddSchoolButton.Location = new System.Drawing.Point(1061, 14);
            this.AddSchoolButton.Name = "AddSchoolButton";
            this.AddSchoolButton.Size = new System.Drawing.Size(108, 29);
            this.AddSchoolButton.TabIndex = 19;
            this.AddSchoolButton.Text = "Add Schools";
            this.AddSchoolButton.UseVisualStyleBackColor = false;
            this.AddSchoolButton.Click += new System.EventHandler(this.AddSchoolButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "School Name:";
            // 
            // SchoolComboBox
            // 
            this.SchoolComboBox.BackColor = System.Drawing.Color.White;
            this.SchoolComboBox.DataSource = this.schoolBindingSource;
            this.SchoolComboBox.DisplayMember = "SchoolName";
            this.SchoolComboBox.FormattingEnabled = true;
            this.SchoolComboBox.Location = new System.Drawing.Point(139, 102);
            this.SchoolComboBox.Name = "SchoolComboBox";
            this.SchoolComboBox.Size = new System.Drawing.Size(121, 21);
            this.SchoolComboBox.TabIndex = 21;
            this.SchoolComboBox.SelectedIndexChanged += new System.EventHandler(this.SchoolComboBox_SelectedIndexChanged);
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "School";
            this.schoolBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // teacherBox
            // 
            this.teacherBox.Location = new System.Drawing.Point(558, 105);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.ReadOnly = true;
            this.teacherBox.Size = new System.Drawing.Size(100, 20);
            this.teacherBox.TabIndex = 22;
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Location = new System.Drawing.Point(398, 108);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(154, 13);
            this.teacherLabel.TabIndex = 23;
            this.teacherLabel.Text = "Teacher Average Grade Level:";
            // 
            // schoolBox
            // 
            this.schoolBox.Location = new System.Drawing.Point(266, 102);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.ReadOnly = true;
            this.schoolBox.Size = new System.Drawing.Size(100, 20);
            this.schoolBox.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unlockButton);
            this.groupBox1.Controls.Add(this.lockButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passkey);
            this.groupBox1.Controls.Add(this.mailFromBox);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.mailFromPwdBox);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Location = new System.Drawing.Point(1064, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 352);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Controls";
            // 
            // unlockButton
            // 
            this.unlockButton.Location = new System.Drawing.Point(123, 297);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(75, 23);
            this.unlockButton.TabIndex = 22;
            this.unlockButton.Text = "Unlock";
            this.unlockButton.UseVisualStyleBackColor = true;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // lockButton
            // 
            this.lockButton.Location = new System.Drawing.Point(22, 297);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(75, 23);
            this.lockButton.TabIndex = 21;
            this.lockButton.Text = "Lock";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Form Passkey:";
            // 
            // passkey
            // 
            this.passkey.Location = new System.Drawing.Point(98, 247);
            this.passkey.Name = "passkey";
            this.passkey.PasswordChar = '*';
            this.passkey.Size = new System.Drawing.Size(100, 20);
            this.passkey.TabIndex = 19;
            // 
            // bldLabel
            // 
            this.bldLabel.AutoSize = true;
            this.bldLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bldLabel.Location = new System.Drawing.Point(12, 530);
            this.bldLabel.Name = "bldLabel";
            this.bldLabel.Size = new System.Drawing.Size(36, 13);
            this.bldLabel.TabIndex = 26;
            this.bldLabel.Text = "Build: ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Subject ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Teacher ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // CurrentGrade
            // 
            this.CurrentGrade.DataPropertyName = "CurrentGrade";
            this.CurrentGrade.HeaderText = "Current Level";
            this.CurrentGrade.Name = "CurrentGrade";
            // 
            // StudentAverageGrade
            // 
            this.StudentAverageGrade.DataPropertyName = "StudentAverageGrade";
            this.StudentAverageGrade.HeaderText = "Estimated Level Average";
            this.StudentAverageGrade.Name = "StudentAverageGrade";
            // 
            // StartTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 561);
            this.Controls.Add(this.bldLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.schoolBox);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.teacherBox);
            this.Controls.Add(this.SchoolComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSchoolButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button mail;
        private System.Windows.Forms.TextBox mailFromBox;
        private System.Windows.Forms.TextBox mailFromPwdBox;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.BindingSource competencyBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter competencyTableAdapter;
        private System.Windows.Forms.Button AddSchoolButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SchoolComboBox;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.SchoolTableAdapter schoolTableAdapter;
        private System.Windows.Forms.TextBox teacherBox;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.TextBox schoolBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passkey;
        private System.Windows.Forms.Label bldLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAverageGrade;

    }
}