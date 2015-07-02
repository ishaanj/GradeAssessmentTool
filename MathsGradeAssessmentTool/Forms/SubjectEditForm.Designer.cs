namespace MathsGradeAssessmentTool.Forms
{
    partial class SubjectEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectEditForm));
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.SubjectTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.subjectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.subjectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnToMainScreenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingNavigator)).BeginInit();
            this.subjectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mathsToolDatabaseDataSet
            // 
            this.mathsToolDatabaseDataSet.DataSetName = "MathsToolDatabaseDataSet";
            this.mathsToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencyTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentCompentencyTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = this.subjectTableAdapter;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // subjectBindingNavigator
            // 
            this.subjectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjectBindingNavigator.BindingSource = this.subjectBindingSource;
            this.subjectBindingNavigator.CountItem = null;
            this.subjectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.subjectBindingNavigatorSaveItem});
            this.subjectBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjectBindingNavigator.MoveFirstItem = null;
            this.subjectBindingNavigator.MoveLastItem = null;
            this.subjectBindingNavigator.MoveNextItem = null;
            this.subjectBindingNavigator.MovePreviousItem = null;
            this.subjectBindingNavigator.Name = "subjectBindingNavigator";
            this.subjectBindingNavigator.PositionItem = null;
            this.subjectBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.subjectBindingNavigator.TabIndex = 0;
            this.subjectBindingNavigator.Text = "bindingNavigator1";
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
            // subjectBindingNavigatorSaveItem
            // 
            this.subjectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjectBindingNavigatorSaveItem.Image")));
            this.subjectBindingNavigatorSaveItem.Name = "subjectBindingNavigatorSaveItem";
            this.subjectBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.subjectBindingNavigatorSaveItem.Text = "Save Data";
            this.subjectBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjectBindingNavigatorSaveItem_Click);
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.AutoGenerateColumns = false;
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.subjectDataGridView.DataSource = this.subjectBindingSource;
            this.subjectDataGridView.Location = new System.Drawing.Point(147, 114);
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.Size = new System.Drawing.Size(346, 221);
            this.subjectDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SubjectID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SubjectMaxScore";
            this.dataGridViewTextBoxColumn4.HeaderText = "SubjectMaxScore";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // returnToMainScreenButton
            // 
            this.returnToMainScreenButton.BackColor = System.Drawing.Color.White;
            this.returnToMainScreenButton.Location = new System.Drawing.Point(578, 28);
            this.returnToMainScreenButton.Name = "returnToMainScreenButton";
            this.returnToMainScreenButton.Size = new System.Drawing.Size(141, 47);
            this.returnToMainScreenButton.TabIndex = 2;
            this.returnToMainScreenButton.Text = "Return to Main Screen";
            this.returnToMainScreenButton.UseVisualStyleBackColor = false;
            this.returnToMainScreenButton.Click += new System.EventHandler(this.onReturnToMainScreen);
            // 
            // SubjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.returnToMainScreenButton);
            this.Controls.Add(this.subjectDataGridView);
            this.Controls.Add(this.subjectBindingNavigator);
            this.Name = "SubjectEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject Details";
            this.Load += new System.EventHandler(this.SubjectEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingNavigator)).EndInit();
            this.subjectBindingNavigator.ResumeLayout(false);
            this.subjectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MathsToolDatabaseDataSet mathsToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton subjectBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView subjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button returnToMainScreenButton;
    }
}