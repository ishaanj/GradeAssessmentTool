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
            this.competencyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.competencyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.competencyDataGridView = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.competencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathsToolDatabaseDataSet = new MathsGradeAssessmentTool.MathsToolDatabaseDataSet();
            this.competencyTableAdapter = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.CompetencyTableAdapter();
            this.tableAdapterManager = new MathsGradeAssessmentTool.MathsToolDatabaseDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingNavigator)).BeginInit();
            this.competencyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // competencyBindingNavigator
            // 
            this.competencyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.competencyBindingNavigator.BindingSource = this.competencyBindingSource;
            this.competencyBindingNavigator.CountItem = null;
            this.competencyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.competencyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.competencyBindingNavigatorSaveItem});
            this.competencyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.competencyBindingNavigator.MoveFirstItem = null;
            this.competencyBindingNavigator.MoveLastItem = null;
            this.competencyBindingNavigator.MoveNextItem = null;
            this.competencyBindingNavigator.MovePreviousItem = null;
            this.competencyBindingNavigator.Name = "competencyBindingNavigator";
            this.competencyBindingNavigator.PositionItem = null;
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.SubjectID,
            this.dataGridViewTextBoxColumn2});
            this.competencyDataGridView.DataSource = this.competencyBindingSource;
            this.competencyDataGridView.Location = new System.Drawing.Point(126, 111);
            this.competencyDataGridView.Name = "competencyDataGridView";
            this.competencyDataGridView.Size = new System.Drawing.Size(342, 240);
            this.competencyDataGridView.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(619, 29);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(126, 47);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back To Main Page";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // competencyBindingSource
            // 
            this.competencyBindingSource.DataMember = "Competency";
            this.competencyBindingSource.DataSource = this.mathsToolDatabaseDataSet;
            // 
            // mathsToolDatabaseDataSet
            // 
            this.mathsToolDatabaseDataSet.DataSetName = "MathsToolDatabaseDataSet";
            this.mathsToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CompetencyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CompetencyID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "SubjectID";
            this.SubjectID.Name = "SubjectID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompetencyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompetencyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // CompentencyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.competencyDataGridView);
            this.Controls.Add(this.competencyBindingNavigator);
            this.Name = "CompentencyEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compentency Details ";
            this.Load += new System.EventHandler(this.CompentencyEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingNavigator)).EndInit();
            this.competencyBindingNavigator.ResumeLayout(false);
            this.competencyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsToolDatabaseDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton competencyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView competencyDataGridView;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}