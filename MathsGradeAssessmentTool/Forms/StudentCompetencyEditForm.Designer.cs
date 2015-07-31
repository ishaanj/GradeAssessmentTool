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
            this.studentCompentencyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.studentCompentencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentCompentencyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentCompentencyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCompentencyTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentCompentencyTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.ExportToExcelButton = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.competencyTableAdapter1 = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter();
            this.ImportFromExcelButton = new System.Windows.Forms.Button();
            this.ExportAllStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingNavigator)).BeginInit();
            this.studentCompentencyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // returnToStudentButton
            // 
            this.returnToStudentButton.BackColor = System.Drawing.Color.White;
            this.returnToStudentButton.Location = new System.Drawing.Point(620, 38);
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
            // studentCompentencyBindingNavigator
            // 
            this.studentCompentencyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentCompentencyBindingNavigator.BindingSource = this.studentCompentencyBindingSource;
            this.studentCompentencyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentCompentencyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentCompentencyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentCompentencyBindingNavigatorSaveItem});
            this.studentCompentencyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentCompentencyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentCompentencyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentCompentencyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentCompentencyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentCompentencyBindingNavigator.Name = "studentCompentencyBindingNavigator";
            this.studentCompentencyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentCompentencyBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.studentCompentencyBindingNavigator.TabIndex = 3;
            this.studentCompentencyBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.studentCompentencyDataGridView.Size = new System.Drawing.Size(738, 377);
            this.studentCompentencyDataGridView.TabIndex = 3;
            this.studentCompentencyDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.studentCompentencyDataGridView_CellBeginEdit);
            this.studentCompentencyDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellEndEdit);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompetencyID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CompetencyID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn4.HeaderText = "StudentId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // GradeLevel
            // 
            this.GradeLevel.DataPropertyName = "GradeLevel";
            this.GradeLevel.HeaderText = "GradeLevel";
            this.GradeLevel.Name = "GradeLevel";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "G1";
            this.dataGridViewTextBoxColumn5.HeaderText = "G1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "G2";
            this.dataGridViewTextBoxColumn6.HeaderText = "G2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "G3";
            this.dataGridViewTextBoxColumn7.HeaderText = "G3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "G4";
            this.dataGridViewTextBoxColumn8.HeaderText = "G4";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "G5";
            this.dataGridViewTextBoxColumn9.HeaderText = "G5";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "G6";
            this.dataGridViewTextBoxColumn10.HeaderText = "G6";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "G7";
            this.dataGridViewTextBoxColumn11.HeaderText = "G7";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "G8";
            this.dataGridViewTextBoxColumn12.HeaderText = "G8";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "GTotalWeighted";
            this.dataGridViewTextBoxColumn13.HeaderText = "GTotalWeighted";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "GradeEquivalent";
            this.dataGridViewTextBoxColumn14.HeaderText = "GradeEquivalent";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
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
            this.ExportToExcelButton.Location = new System.Drawing.Point(182, 38);
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
            this.ImportFromExcelButton.Location = new System.Drawing.Point(21, 38);
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
            this.ExportAllStudents.Location = new System.Drawing.Point(474, 38);
            this.ExportAllStudents.Name = "ExportAllStudents";
            this.ExportAllStudents.Size = new System.Drawing.Size(128, 52);
            this.ExportAllStudents.TabIndex = 6;
            this.ExportAllStudents.Text = "Export All Students";
            this.ExportAllStudents.UseVisualStyleBackColor = false;
            this.ExportAllStudents.Click += new System.EventHandler(this.ExportAllStudents_Click);
            // 
            // StudentCompetencyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingNavigator)).EndInit();
            this.studentCompentencyBindingNavigator.ResumeLayout(false);
            this.studentCompentencyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingNavigator studentCompentencyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentCompentencyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentCompentencyDataGridView;
        private System.Windows.Forms.Button ExportToExcelButton;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter competencyTableAdapter1;
        private System.Windows.Forms.Button ImportFromExcelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeLevel;
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
        private System.Windows.Forms.Button ExportAllStudents;
    }
}