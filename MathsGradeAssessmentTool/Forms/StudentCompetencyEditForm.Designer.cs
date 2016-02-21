namespace MathsGradeAssessmentTool.Forms
{
    partial class StudentCompetencyEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCompetencyEditForm));
            this.returnToStudentButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCompentencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.studentCompentencyDataGridView = new System.Windows.Forms.DataGridView();
            this.GradeLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCompentencyTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentCompentencyTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.ExportToExcelButton = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.competencyTableAdapter1 = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter();
            this.ImportFromExcelButton = new System.Windows.Forms.Button();
            this.ExportAllStudents = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentCompentencyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentCompentencyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.competencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competencyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingNavigator)).BeginInit();
            this.studentCompentencyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnToStudentButton
            // 
            this.returnToStudentButton.BackColor = System.Drawing.Color.White;
            this.returnToStudentButton.Location = new System.Drawing.Point(747, 38);
            this.returnToStudentButton.Name = "returnToStudentButton";
            this.returnToStudentButton.Size = new System.Drawing.Size(130, 52);
            this.returnToStudentButton.TabIndex = 2;
            this.returnToStudentButton.Text = "Return to Student";
            this.returnToStudentButton.UseVisualStyleBackColor = false;
            this.returnToStudentButton.Click += new System.EventHandler(this.returnToStudentButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentCompId";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentCompId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // studentCompentencyBindingSource
            // 
            this.studentCompentencyBindingSource.DataMember = "StudentCompentency";
            this.studentCompentencyBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // mathsToolDatabaseDataSet
            // 
            this.mathsToolDatabaseDataSet.DataSetName = "MathsToolDatabaseDataSet";
            this.mathsToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentCompentencyDataGridView
            // 
            this.studentCompentencyDataGridView.AutoGenerateColumns = false;
            this.studentCompentencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentCompentencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.GradeLevel,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.studentCompentencyDataGridView.DataSource = this.studentCompentencyBindingSource;
            this.studentCompentencyDataGridView.Location = new System.Drawing.Point(12, 132);
            this.studentCompentencyDataGridView.Name = "studentCompentencyDataGridView";
            this.studentCompentencyDataGridView.Size = new System.Drawing.Size(590, 377);
            this.studentCompentencyDataGridView.TabIndex = 3;
            this.studentCompentencyDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.studentCompentencyDataGridView_CellBeginEdit);
            this.studentCompentencyDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellEndEdit);
            // 
            // GradeLevel
            // 
            this.GradeLevel.DataPropertyName = "GradeLevel";
            this.GradeLevel.HeaderText = "Level";
            this.GradeLevel.Name = "GradeLevel";
            // 
            // studentCompentencyTableAdapter
            // 
            this.studentCompentencyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencyTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentCompentencyTableAdapter = this.studentCompentencyTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.BackColor = System.Drawing.Color.White;
            this.ExportToExcelButton.Location = new System.Drawing.Point(154, 38);
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(139, 52);
            this.ExportToExcelButton.TabIndex = 4;
            this.ExportToExcelButton.Text = "Export to Excel";
            this.ExportToExcelButton.UseVisualStyleBackColor = false;
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
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
            // competencyTableAdapter1
            // 
            this.competencyTableAdapter1.ClearBeforeFill = true;
            // 
            // ImportFromExcelButton
            // 
            this.ImportFromExcelButton.BackColor = System.Drawing.Color.White;
            this.ImportFromExcelButton.Location = new System.Drawing.Point(12, 38);
            this.ImportFromExcelButton.Name = "ImportFromExcelButton";
            this.ImportFromExcelButton.Size = new System.Drawing.Size(136, 52);
            this.ImportFromExcelButton.TabIndex = 5;
            this.ImportFromExcelButton.Text = "Import from Excel";
            this.ImportFromExcelButton.UseVisualStyleBackColor = false;
            this.ImportFromExcelButton.Click += new System.EventHandler(this.ImportFromExcelButton_Click);
            // 
            // ExportAllStudents
            // 
            this.ExportAllStudents.BackColor = System.Drawing.Color.White;
            this.ExportAllStudents.Location = new System.Drawing.Point(299, 38);
            this.ExportAllStudents.Name = "ExportAllStudents";
            this.ExportAllStudents.Size = new System.Drawing.Size(128, 52);
            this.ExportAllStudents.TabIndex = 6;
            this.ExportAllStudents.Text = "Export All Students";
            this.ExportAllStudents.UseVisualStyleBackColor = false;
            this.ExportAllStudents.Click += new System.EventHandler(this.ExportAllStudents_Click);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // studentCompentencyBindingNavigatorSaveItem
            // 
            this.studentCompentencyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentCompentencyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentCompentencyBindingNavigatorSaveItem.Image")));
            this.studentCompentencyBindingNavigatorSaveItem.Name = "studentCompentencyBindingNavigatorSaveItem";
            this.studentCompentencyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentCompentencyBindingNavigatorSaveItem.Text = "Save Data";
            this.studentCompentencyBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentCompentencyBindingNavigatorSaveItem_Click);
            // 
            // studentCompentencyBindingNavigator
            // 
            this.studentCompentencyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentCompentencyBindingNavigator.BindingSource = this.studentCompentencyBindingSource;
            this.studentCompentencyBindingNavigator.CountItem = null;
            this.studentCompentencyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentCompentencyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentCompentencyBindingNavigatorSaveItem});
            this.studentCompentencyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentCompentencyBindingNavigator.MoveFirstItem = null;
            this.studentCompentencyBindingNavigator.MoveLastItem = null;
            this.studentCompentencyBindingNavigator.MoveNextItem = null;
            this.studentCompentencyBindingNavigator.MovePreviousItem = null;
            this.studentCompentencyBindingNavigator.Name = "studentCompentencyBindingNavigator";
            this.studentCompentencyBindingNavigator.PositionItem = null;
            this.studentCompentencyBindingNavigator.Size = new System.Drawing.Size(897, 25);
            this.studentCompentencyBindingNavigator.TabIndex = 3;
            this.studentCompentencyBindingNavigator.Text = "bindingNavigator1";
            // 
            // competencyBindingSource
            // 
            this.competencyBindingSource.AllowNew = true;
            this.competencyBindingSource.DataMember = "Competency";
            this.competencyBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "GradeEquivalent";
            this.dataGridViewTextBoxColumn14.HeaderText = "Estimated Level";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "GTotalWeighted";
            this.dataGridViewTextBoxColumn13.HeaderText = "L Total Weighted";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "G8";
            this.dataGridViewTextBoxColumn12.HeaderText = "L8";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "G7";
            this.dataGridViewTextBoxColumn11.HeaderText = "L7";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "G6";
            this.dataGridViewTextBoxColumn10.HeaderText = "L6";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "G5";
            this.dataGridViewTextBoxColumn9.HeaderText = "L5";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "G4";
            this.dataGridViewTextBoxColumn8.HeaderText = "L4";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "G3";
            this.dataGridViewTextBoxColumn7.HeaderText = "L3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "G2";
            this.dataGridViewTextBoxColumn6.HeaderText = "L2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "G1";
            this.dataGridViewTextBoxColumn5.HeaderText = "L1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn4.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompetencyID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Competency ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // competencyDataGridView
            // 
            this.competencyDataGridView.AutoGenerateColumns = false;
            this.competencyDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.competencyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.competencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn15});
            this.competencyDataGridView.DataSource = this.competencyBindingSource;
            this.competencyDataGridView.Location = new System.Drawing.Point(636, 132);
            this.competencyDataGridView.Name = "competencyDataGridView";
            this.competencyDataGridView.ReadOnly = true;
            this.competencyDataGridView.Size = new System.Drawing.Size(241, 220);
            this.competencyDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompetencyID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Competency ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CompetencyName";
            this.dataGridViewTextBoxColumn15.HeaderText = "Competency Name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // StudentCompetencyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 561);
            this.Controls.Add(this.competencyDataGridView);
            this.Controls.Add(this.ExportAllStudents);
            this.Controls.Add(this.ImportFromExcelButton);
            this.Controls.Add(this.ExportToExcelButton);
            this.Controls.Add(this.studentCompentencyDataGridView);
            this.Controls.Add(this.studentCompentencyBindingNavigator);
            this.Controls.Add(this.returnToStudentButton);
            this.Name = "StudentCompetencyEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Competency";
            this.Load += new System.EventHandler(this.StudentCompetencyEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingNavigator)).EndInit();
            this.studentCompentencyBindingNavigator.ResumeLayout(false);
            this.studentCompentencyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToStudentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetencyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MathsToolDatabaseDataSet mathsToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentCompentencyBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.StudentCompentencyTableAdapter studentCompentencyTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView studentCompentencyDataGridView;
        private System.Windows.Forms.Button ExportToExcelButton;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter competencyTableAdapter1;
        private System.Windows.Forms.Button ImportFromExcelButton;
        private System.Windows.Forms.Button ExportAllStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeLevel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton studentCompentencyBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator studentCompentencyBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridView competencyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        public System.Windows.Forms.BindingSource competencyBindingSource;
    }
}