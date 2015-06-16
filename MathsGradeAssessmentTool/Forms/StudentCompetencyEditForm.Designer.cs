﻿namespace MathsGradeAssessmentTool.Forms
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
            this.returnToStudentButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCompentencyTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.StudentCompentencyTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.competencyTableAdapter1 = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter();
            this.studentCompIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingNavigator)).BeginInit();
            this.studentCompentencyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompentencyDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.studentCompentencyBindingNavigator.TabIndex = 0;
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
            this.studentCompIdDataGridViewTextBoxColumn,
            this.StudentId,
            this.competencyIDDataGridViewTextBoxColumn,
            this.g1DataGridViewTextBoxColumn,
            this.g2DataGridViewTextBoxColumn,
            this.g3DataGridViewTextBoxColumn,
            this.g4DataGridViewTextBoxColumn,
            this.g5DataGridViewTextBoxColumn,
            this.g6DataGridViewTextBoxColumn,
            this.g7DataGridViewTextBoxColumn,
            this.g8DataGridViewTextBoxColumn});
            this.studentCompentencyDataGridView.DataSource = this.studentCompentencyBindingSource;
            this.studentCompentencyDataGridView.Location = new System.Drawing.Point(12, 111);
            this.studentCompentencyDataGridView.Name = "studentCompentencyDataGridView";
            this.studentCompentencyDataGridView.Size = new System.Drawing.Size(751, 408);
            this.studentCompentencyDataGridView.TabIndex = 1;
            this.studentCompentencyDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.studentCompentencyDataGridView_CellFormatting);
            // 
            // returnToStudentButton
            // 
            this.returnToStudentButton.Location = new System.Drawing.Point(544, 29);
            this.returnToStudentButton.Name = "returnToStudentButton";
            this.returnToStudentButton.Size = new System.Drawing.Size(130, 52);
            this.returnToStudentButton.TabIndex = 2;
            this.returnToStudentButton.Text = "Return to Student";
            this.returnToStudentButton.UseVisualStyleBackColor = true;
            this.returnToStudentButton.Click += new System.EventHandler(this.returnToStudentButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentCompId";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentCompId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // studentCompentencyTableAdapter
            // 
            this.studentCompentencyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencyTableAdapter = null;
            this.tableAdapterManager.StudentCompentencyTableAdapter = this.studentCompentencyTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // competencyTableAdapter1
            // 
            this.competencyTableAdapter1.ClearBeforeFill = true;
            // 
            // studentCompIdDataGridViewTextBoxColumn
            // 
            this.studentCompIdDataGridViewTextBoxColumn.DataPropertyName = "StudentCompId";
            this.studentCompIdDataGridViewTextBoxColumn.HeaderText = "StudentCompId";
            this.studentCompIdDataGridViewTextBoxColumn.Name = "studentCompIdDataGridViewTextBoxColumn";
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // competencyIDDataGridViewTextBoxColumn
            // 
            this.competencyIDDataGridViewTextBoxColumn.DataPropertyName = "CompetencyID";
            this.competencyIDDataGridViewTextBoxColumn.HeaderText = "CompetencyID";
            this.competencyIDDataGridViewTextBoxColumn.Name = "competencyIDDataGridViewTextBoxColumn";
            // 
            // g1DataGridViewTextBoxColumn
            // 
            this.g1DataGridViewTextBoxColumn.DataPropertyName = "G1";
            this.g1DataGridViewTextBoxColumn.HeaderText = "G1";
            this.g1DataGridViewTextBoxColumn.Name = "g1DataGridViewTextBoxColumn";
            // 
            // g2DataGridViewTextBoxColumn
            // 
            this.g2DataGridViewTextBoxColumn.DataPropertyName = "G2";
            this.g2DataGridViewTextBoxColumn.HeaderText = "G2";
            this.g2DataGridViewTextBoxColumn.Name = "g2DataGridViewTextBoxColumn";
            // 
            // g3DataGridViewTextBoxColumn
            // 
            this.g3DataGridViewTextBoxColumn.DataPropertyName = "G3";
            this.g3DataGridViewTextBoxColumn.HeaderText = "G3";
            this.g3DataGridViewTextBoxColumn.Name = "g3DataGridViewTextBoxColumn";
            // 
            // g4DataGridViewTextBoxColumn
            // 
            this.g4DataGridViewTextBoxColumn.DataPropertyName = "G4";
            this.g4DataGridViewTextBoxColumn.HeaderText = "G4";
            this.g4DataGridViewTextBoxColumn.Name = "g4DataGridViewTextBoxColumn";
            // 
            // g5DataGridViewTextBoxColumn
            // 
            this.g5DataGridViewTextBoxColumn.DataPropertyName = "G5";
            this.g5DataGridViewTextBoxColumn.HeaderText = "G5";
            this.g5DataGridViewTextBoxColumn.Name = "g5DataGridViewTextBoxColumn";
            // 
            // g6DataGridViewTextBoxColumn
            // 
            this.g6DataGridViewTextBoxColumn.DataPropertyName = "G6";
            this.g6DataGridViewTextBoxColumn.HeaderText = "G6";
            this.g6DataGridViewTextBoxColumn.Name = "g6DataGridViewTextBoxColumn";
            // 
            // g7DataGridViewTextBoxColumn
            // 
            this.g7DataGridViewTextBoxColumn.DataPropertyName = "G7";
            this.g7DataGridViewTextBoxColumn.HeaderText = "G7";
            this.g7DataGridViewTextBoxColumn.Name = "g7DataGridViewTextBoxColumn";
            // 
            // g8DataGridViewTextBoxColumn
            // 
            this.g8DataGridViewTextBoxColumn.DataPropertyName = "G8";
            this.g8DataGridViewTextBoxColumn.HeaderText = "G8";
            this.g8DataGridViewTextBoxColumn.Name = "g8DataGridViewTextBoxColumn";
            // 
            // StudentCompetencyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.returnToStudentButton);
            this.Controls.Add(this.studentCompentencyDataGridView);
            this.Controls.Add(this.studentCompentencyBindingNavigator);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button returnToStudentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetencyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter competencyTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCompIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn competencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn g8DataGridViewTextBoxColumn;
    }
}