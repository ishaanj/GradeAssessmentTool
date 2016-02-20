﻿namespace MathsGradeAssessmentTool.Forms
{
    partial class TeacherDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDetailsForm));
            this.Back = new System.Windows.Forms.Button();
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TeacherTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.teacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.teacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.SchoolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherAverageGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.SchoolTableAdapter();
            this.schoolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingNavigator)).BeginInit();
            this.teacherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(670, 39);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(117, 42);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back To Main Page";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
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
            // teacherBindingNavigator
            // 
            this.teacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teacherBindingNavigator.BindingSource = this.teacherBindingSource;
            this.teacherBindingNavigator.CountItem = null;
            this.teacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.teacherBindingNavigatorSaveItem});
            this.teacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teacherBindingNavigator.MoveFirstItem = null;
            this.teacherBindingNavigator.MoveLastItem = null;
            this.teacherBindingNavigator.MoveNextItem = null;
            this.teacherBindingNavigator.MovePreviousItem = null;
            this.teacherBindingNavigator.Name = "teacherBindingNavigator";
            this.teacherBindingNavigator.PositionItem = null;
            this.teacherBindingNavigator.Size = new System.Drawing.Size(797, 25);
            this.teacherBindingNavigator.TabIndex = 3;
            this.teacherBindingNavigator.Text = "bindingNavigator1";
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
            // teacherBindingNavigatorSaveItem
            // 
            this.teacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherBindingNavigatorSaveItem.Image")));
            this.teacherBindingNavigatorSaveItem.Name = "teacherBindingNavigatorSaveItem";
            this.teacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.teacherBindingNavigatorSaveItem.Text = "Save Data";
            this.teacherBindingNavigatorSaveItem.Click += new System.EventHandler(this.teacherBindingNavigatorSaveItem_Click_2);
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AutoGenerateColumns = false;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.TeacherAverageGrade});
            this.teacherDataGridView.DataSource = this.teacherBindingSource;
            this.teacherDataGridView.Location = new System.Drawing.Point(12, 39);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.Size = new System.Drawing.Size(444, 490);
            this.teacherDataGridView.TabIndex = 3;
            // 
            // SchoolID
            // 
            this.SchoolID.DataPropertyName = "SchoolID";
            this.SchoolID.HeaderText = "School ID";
            this.SchoolID.Name = "SchoolID";
            // 
            // TeacherAverageGrade
            // 
            this.TeacherAverageGrade.DataPropertyName = "TeacherAverageGrade";
            this.TeacherAverageGrade.HeaderText = "Teacher\'s Average Grade";
            this.TeacherAverageGrade.Name = "TeacherAverageGrade";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeacherName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Teacher Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Teacher ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // schoolDataGridView
            // 
            this.schoolDataGridView.AutoGenerateColumns = false;
            this.schoolDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.schoolDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schoolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schoolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.schoolDataGridView.DataSource = this.schoolBindingSource;
            this.schoolDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.schoolDataGridView.Location = new System.Drawing.Point(543, 100);
            this.schoolDataGridView.Name = "schoolDataGridView";
            this.schoolDataGridView.ReadOnly = true;
            this.schoolDataGridView.Size = new System.Drawing.Size(244, 220);
            this.schoolDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SchoolID";
            this.dataGridViewTextBoxColumn3.HeaderText = "School ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SchoolName";
            this.dataGridViewTextBoxColumn4.HeaderText = "School Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // TeacherDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 561);
            this.Controls.Add(this.schoolDataGridView);
            this.Controls.Add(this.teacherDataGridView);
            this.Controls.Add(this.teacherBindingNavigator);
            this.Controls.Add(this.Back);
            this.Name = "TeacherDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Details";
            this.Load += new System.EventHandler(this.TeacherDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingNavigator)).EndInit();
            this.teacherBindingNavigator.ResumeLayout(false);
            this.teacherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MathsToolDatabaseDataSet mathsToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teacherBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton teacherBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherAverageGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.SchoolTableAdapter schoolTableAdapter;
        private System.Windows.Forms.DataGridView schoolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}