﻿namespace MathsGradeAssessmentTool.Forms
{
    partial class StudentDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetailsForm));
            this.Back = new System.Windows.Forms.Button();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.selectStudentAndSeeCompetencies = new System.Windows.Forms.Button();
            this.competencyTableAdapter1 = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter();
            this.studentCompentencyTableAdapter1 = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentCompentencyTableAdapter();
            this.studentCompentencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeEquivalentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTotalWeightedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCompetencyDataAdapter = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.SubjectTableAdapter();
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TeacherTableAdapter();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompetencyDataAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(740, 44);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(113, 47);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back To Main Page";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = null;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = null;
            this.studentBindingNavigator.MoveLastItem = null;
            this.studentBindingNavigator.MoveNextItem = null;
            this.studentBindingNavigator.MovePreviousItem = null;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = null;
            this.studentBindingNavigator.Size = new System.Drawing.Size(950, 25);
            this.studentBindingNavigator.TabIndex = 3;
            this.studentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // mathsToolDatabaseDataSet
            // 
            this.mathsToolDatabaseDataSet.DataSetName = "MathsToolDatabaseDataSet";
            this.mathsToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click_2);
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.CurrentGrade});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(46, 44);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(544, 505);
            this.studentDataGridView.TabIndex = 3;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Student ID";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Subject ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Teacher ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // CurrentGrade
            // 
            this.CurrentGrade.DataPropertyName = "CurrentGrade";
            this.CurrentGrade.HeaderText = "Current Level";
            this.CurrentGrade.Name = "CurrentGrade";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencyTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentCompentencyTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // selectStudentAndSeeCompetencies
            // 
            this.selectStudentAndSeeCompetencies.BackColor = System.Drawing.Color.White;
            this.selectStudentAndSeeCompetencies.Location = new System.Drawing.Point(740, 97);
            this.selectStudentAndSeeCompetencies.Name = "selectStudentAndSeeCompetencies";
            this.selectStudentAndSeeCompetencies.Size = new System.Drawing.Size(113, 50);
            this.selectStudentAndSeeCompetencies.TabIndex = 4;
            this.selectStudentAndSeeCompetencies.Text = "See Student Competencies";
            this.selectStudentAndSeeCompetencies.UseVisualStyleBackColor = false;
            this.selectStudentAndSeeCompetencies.Click += new System.EventHandler(this.selectStudentAndSeeCompetencies_Click);
            // 
            // competencyTableAdapter1
            // 
            this.competencyTableAdapter1.ClearBeforeFill = true;
            // 
            // studentCompentencyTableAdapter1
            // 
            this.studentCompentencyTableAdapter1.ClearBeforeFill = true;
            // 
            // studentCompentencyBindingSource
            // 
            this.studentCompentencyBindingSource.DataMember = "StudentCompentency";
            this.studentCompentencyBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // gradeLevelDataGridViewTextBoxColumn
            // 
            this.gradeLevelDataGridViewTextBoxColumn.DataPropertyName = "GradeLevel";
            this.gradeLevelDataGridViewTextBoxColumn.HeaderText = "GradeLevel";
            this.gradeLevelDataGridViewTextBoxColumn.Name = "gradeLevelDataGridViewTextBoxColumn";
            this.gradeLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeEquivalentDataGridViewTextBoxColumn
            // 
            this.gradeEquivalentDataGridViewTextBoxColumn.DataPropertyName = "GradeEquivalent";
            this.gradeEquivalentDataGridViewTextBoxColumn.HeaderText = "GradeEquivalent";
            this.gradeEquivalentDataGridViewTextBoxColumn.Name = "gradeEquivalentDataGridViewTextBoxColumn";
            this.gradeEquivalentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gTotalWeightedDataGridViewTextBoxColumn
            // 
            this.gTotalWeightedDataGridViewTextBoxColumn.DataPropertyName = "GTotalWeighted";
            this.gTotalWeightedDataGridViewTextBoxColumn.HeaderText = "GTotalWeighted";
            this.gTotalWeightedDataGridViewTextBoxColumn.Name = "gTotalWeightedDataGridViewTextBoxColumn";
            this.gTotalWeightedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // g8DataGridViewTextBoxColumn
            // 
            this.g8DataGridViewTextBoxColumn.DataPropertyName = "G8";
            this.g8DataGridViewTextBoxColumn.HeaderText = "G8";
            this.g8DataGridViewTextBoxColumn.Name = "g8DataGridViewTextBoxColumn";
            this.g8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // g7DataGridViewTextBoxColumn
            // 
            this.g7DataGridViewTextBoxColumn.DataPropertyName = "G7";
            this.g7DataGridViewTextBoxColumn.HeaderText = "G7";
            this.g7DataGridViewTextBoxColumn.Name = "g7DataGridViewTextBoxColumn";
            this.g7DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // g6DataGridViewTextBoxColumn
            // 
            this.g6DataGridViewTextBoxColumn.DataPropertyName = "G6";
            this.g6DataGridViewTextBoxColumn.HeaderText = "G6";
            this.g6DataGridViewTextBoxColumn.Name = "g6DataGridViewTextBoxColumn";
            this.g6DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // g5DataGridViewTextBoxColumn
            // 
            this.g5DataGridViewTextBoxColumn.DataPropertyName = "G5";
            this.g5DataGridViewTextBoxColumn.HeaderText = "G5";
            this.g5DataGridViewTextBoxColumn.Name = "g5DataGridViewTextBoxColumn";
            this.g5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // g4DataGridViewTextBoxColumn
            // 
            this.g4DataGridViewTextBoxColumn.DataPropertyName = "G4";
            this.g4DataGridViewTextBoxColumn.HeaderText = "G4";
            this.g4DataGridViewTextBoxColumn.Name = "g4DataGridViewTextBoxColumn";
            this.g4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // g3DataGridViewTextBoxColumn
            // 
            this.g3DataGridViewTextBoxColumn.DataPropertyName = "G3";
            this.g3DataGridViewTextBoxColumn.HeaderText = "G3";
            this.g3DataGridViewTextBoxColumn.Name = "g3DataGridViewTextBoxColumn";
            this.g3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // g2DataGridViewTextBoxColumn
            // 
            this.g2DataGridViewTextBoxColumn.DataPropertyName = "G2";
            this.g2DataGridViewTextBoxColumn.HeaderText = "G2";
            this.g2DataGridViewTextBoxColumn.Name = "g2DataGridViewTextBoxColumn";
            this.g2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // g1DataGridViewTextBoxColumn
            // 
            this.g1DataGridViewTextBoxColumn.DataPropertyName = "G1";
            this.g1DataGridViewTextBoxColumn.HeaderText = "G1";
            this.g1DataGridViewTextBoxColumn.Name = "g1DataGridViewTextBoxColumn";
            this.g1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // competencyIDDataGridViewTextBoxColumn
            // 
            this.competencyIDDataGridViewTextBoxColumn.DataPropertyName = "CompetencyID";
            this.competencyIDDataGridViewTextBoxColumn.HeaderText = "CompetencyID";
            this.competencyIDDataGridViewTextBoxColumn.Name = "competencyIDDataGridViewTextBoxColumn";
            this.competencyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCompetencyDataAdapter
            // 
            this.studentCompetencyDataAdapter.AllowUserToAddRows = false;
            this.studentCompetencyDataAdapter.AllowUserToDeleteRows = false;
            this.studentCompetencyDataAdapter.AutoGenerateColumns = false;
            this.studentCompetencyDataAdapter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentCompetencyDataAdapter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competencyIDDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.g1DataGridViewTextBoxColumn,
            this.g2DataGridViewTextBoxColumn,
            this.g3DataGridViewTextBoxColumn,
            this.g4DataGridViewTextBoxColumn,
            this.g5DataGridViewTextBoxColumn,
            this.g6DataGridViewTextBoxColumn,
            this.g7DataGridViewTextBoxColumn,
            this.g8DataGridViewTextBoxColumn,
            this.gTotalWeightedDataGridViewTextBoxColumn,
            this.gradeEquivalentDataGridViewTextBoxColumn,
            this.gradeLevelDataGridViewTextBoxColumn});
            this.studentCompetencyDataAdapter.DataSource = this.studentCompentencyBindingSource;
            this.studentCompetencyDataAdapter.Location = new System.Drawing.Point(610, 389);
            this.studentCompetencyDataAdapter.Name = "studentCompetencyDataAdapter";
            this.studentCompetencyDataAdapter.ReadOnly = true;
            this.studentCompetencyDataAdapter.Size = new System.Drawing.Size(243, 160);
            this.studentCompetencyDataAdapter.TabIndex = 6;
            this.studentCompetencyDataAdapter.Visible = false;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.AutoGenerateColumns = false;
            this.subjectDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.subjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.subjectDataGridView.DataSource = this.subjectBindingSource;
            this.subjectDataGridView.Location = new System.Drawing.Point(610, 152);
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.ReadOnly = true;
            this.subjectDataGridView.Size = new System.Drawing.Size(243, 220);
            this.subjectDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subject Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Subject ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // teacherDataGridView
            // 
            this.teacherDataGridView.AutoGenerateColumns = false;
            this.teacherDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.teacherDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.teacherDataGridView.DataSource = this.teacherBindingSource;
            this.teacherDataGridView.Location = new System.Drawing.Point(610, 389);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.ReadOnly = true;
            this.teacherDataGridView.Size = new System.Drawing.Size(244, 165);
            this.teacherDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Teacher ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TeacherName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Teacher Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // StudentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 569);
            this.Controls.Add(this.teacherDataGridView);
            this.Controls.Add(this.subjectDataGridView);
            this.Controls.Add(this.studentCompetencyDataAdapter);
            this.Controls.Add(this.selectStudentAndSeeCompetencies);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.studentBindingNavigator);
            this.Controls.Add(this.Back);
            this.Name = "StudentDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompetencyDataAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MathsToolDatabaseDataSet mathsToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Button selectStudentAndSeeCompetencies;
        private MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter competencyTableAdapter1;
        private MathsToolDatabaseDataSetTableAdapters.StudentCompentencyTableAdapter studentCompentencyTableAdapter1;
        private System.Windows.Forms.BindingSource studentCompentencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeEquivalentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTotalWeightedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView studentCompetencyDataAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridView subjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}