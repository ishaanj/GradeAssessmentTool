namespace MathsGradeAssessmentTool.Forms
{
    partial class SchoolEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolEditForm));
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.SchoolTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.schoolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.schoolBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.schoolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnToMainScreen = new System.Windows.Forms.Button();
            this.EmportExportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingNavigator)).BeginInit();
            this.schoolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mathsToolDatabaseDataSet
            // 
            this.mathsToolDatabaseDataSet.DataSetName = "MathsToolDatabaseDataSet";
            this.mathsToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencyTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = this.schoolTableAdapter;
            this.tableAdapterManager.StudentCompentencyTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // schoolBindingNavigator
            // 
            this.schoolBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.schoolBindingNavigator.BindingSource = this.schoolBindingSource;
            this.schoolBindingNavigator.CountItem = null;
            this.schoolBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.schoolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.schoolBindingNavigatorSaveItem});
            this.schoolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.schoolBindingNavigator.MoveFirstItem = null;
            this.schoolBindingNavigator.MoveLastItem = null;
            this.schoolBindingNavigator.MoveNextItem = null;
            this.schoolBindingNavigator.MovePreviousItem = null;
            this.schoolBindingNavigator.Name = "schoolBindingNavigator";
            this.schoolBindingNavigator.PositionItem = null;
            this.schoolBindingNavigator.Size = new System.Drawing.Size(299, 25);
            this.schoolBindingNavigator.TabIndex = 0;
            this.schoolBindingNavigator.Text = "bindingNavigator1";
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
            // schoolBindingNavigatorSaveItem
            // 
            this.schoolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.schoolBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("schoolBindingNavigatorSaveItem.Image")));
            this.schoolBindingNavigatorSaveItem.Name = "schoolBindingNavigatorSaveItem";
            this.schoolBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.schoolBindingNavigatorSaveItem.Text = "Save Data";
            this.schoolBindingNavigatorSaveItem.Click += new System.EventHandler(this.schoolBindingNavigatorSaveItem_Click);
            // 
            // schoolDataGridView
            // 
            this.schoolDataGridView.AutoGenerateColumns = false;
            this.schoolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schoolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.schoolDataGridView.DataSource = this.schoolBindingSource;
            this.schoolDataGridView.Location = new System.Drawing.Point(22, 107);
            this.schoolDataGridView.Name = "schoolDataGridView";
            this.schoolDataGridView.Size = new System.Drawing.Size(245, 327);
            this.schoolDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SchoolID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SchoolID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SchoolName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SchoolName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ReturnToMainScreen
            // 
            this.ReturnToMainScreen.BackColor = System.Drawing.Color.White;
            this.ReturnToMainScreen.Location = new System.Drawing.Point(150, 49);
            this.ReturnToMainScreen.Name = "ReturnToMainScreen";
            this.ReturnToMainScreen.Size = new System.Drawing.Size(117, 52);
            this.ReturnToMainScreen.TabIndex = 2;
            this.ReturnToMainScreen.Text = "Return to Main Screen";
            this.ReturnToMainScreen.UseVisualStyleBackColor = false;
            this.ReturnToMainScreen.Click += new System.EventHandler(this.ReturnToMainScreen_Click);
            // 
            // EmportExportBtn
            // 
            this.EmportExportBtn.BackColor = System.Drawing.Color.White;
            this.EmportExportBtn.Location = new System.Drawing.Point(22, 49);
            this.EmportExportBtn.Name = "EmportExportBtn";
            this.EmportExportBtn.Size = new System.Drawing.Size(94, 52);
            this.EmportExportBtn.TabIndex = 3;
            this.EmportExportBtn.Text = "Import/Export";
            this.EmportExportBtn.UseVisualStyleBackColor = false;
            this.EmportExportBtn.Click += new System.EventHandler(this.EmportExportBtn_Click);
            // 
            // SchoolEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 439);
            this.Controls.Add(this.EmportExportBtn);
            this.Controls.Add(this.ReturnToMainScreen);
            this.Controls.Add(this.schoolDataGridView);
            this.Controls.Add(this.schoolBindingNavigator);
            this.Name = "SchoolEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Details";
            this.Load += new System.EventHandler(this.SchoolEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingNavigator)).EndInit();
            this.schoolBindingNavigator.ResumeLayout(false);
            this.schoolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MathsToolDatabaseDataSet mathsToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.SchoolTableAdapter schoolTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator schoolBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton schoolBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView schoolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button ReturnToMainScreen;
        private System.Windows.Forms.Button EmportExportBtn;
    }
}