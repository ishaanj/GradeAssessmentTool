namespace MathsGradeAssessmentTool.Forms
{
    partial class CompentencyEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompentencyEditForm));
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.competencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competencyTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.competencyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.competencyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.competencyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingNavigator)).BeginInit();
            this.competencyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mathsToolDatabaseDataSet
            // 
            this.mathsToolDatabaseDataSet.DataSetName = "MathsToolDatabaseDataSet";
            this.mathsToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencyTableAdapter = this.competencyTableAdapter;
            this.tableAdapterManager.StudentCompentencyTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // competencyBindingNavigator
            // 
            this.competencyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.competencyBindingNavigator.BindingSource = this.competencyBindingSource;
            this.competencyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.competencyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.competencyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.competencyBindingNavigatorSaveItem});
            this.competencyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.competencyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.competencyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.competencyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.competencyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.competencyBindingNavigator.Name = "competencyBindingNavigator";
            this.competencyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.competencyBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.competencyBindingNavigator.TabIndex = 0;
            this.competencyBindingNavigator.Text = "bindingNavigator1";
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
            // competencyBindingNavigatorSaveItem
            // 
            this.competencyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.competencyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("competencyBindingNavigatorSaveItem.Image")));
            this.competencyBindingNavigatorSaveItem.Name = "competencyBindingNavigatorSaveItem";
            this.competencyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.competencyBindingNavigatorSaveItem.Text = "Save Data";
            this.competencyBindingNavigatorSaveItem.Click += new System.EventHandler(this.competencyBindingNavigatorSaveItem_Click);
            // 
            // competencyDataGridView
            // 
            this.competencyDataGridView.AutoGenerateColumns = false;
            this.competencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.competencyDataGridView.DataSource = this.competencyBindingSource;
            this.competencyDataGridView.Location = new System.Drawing.Point(126, 111);
            this.competencyDataGridView.Name = "competencyDataGridView";
            this.competencyDataGridView.Size = new System.Drawing.Size(346, 240);
            this.competencyDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CompetencyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CompetencyID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompetencyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompetencyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompetencyWeightage";
            this.dataGridViewTextBoxColumn3.HeaderText = "CompetencyWeightage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(619, 29);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(126, 47);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back To Main Page";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CompentencyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.competencyDataGridView);
            this.Controls.Add(this.competencyBindingNavigator);
            this.Name = "CompentencyEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compentency Details ";
            this.Load += new System.EventHandler(this.CompentencyEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingNavigator)).EndInit();
            this.competencyBindingNavigator.ResumeLayout(false);
            this.competencyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MathsToolDatabaseDataSet mathsToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource competencyBindingSource;
        private MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter competencyTableAdapter;
        private MathsToolDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator competencyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton competencyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView competencyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button Back;
    }
}