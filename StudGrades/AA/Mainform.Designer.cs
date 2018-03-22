namespace AA
{
    partial class Mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new AA.GradeBaseDataSet();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new AA.Database1DataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new AA.Database1DataSetTableAdapters.TableAdapterManager();
            this.gradesTableAdapter = new AA.Database1DataSetTableAdapters.GradesTableAdapter();
            this.groupsTableAdapter = new AA.Database1DataSetTableAdapters.GroupsTableAdapter();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studGrid = new System.Windows.Forms.DataGridView();
            this.groupsBox = new System.Windows.Forms.ComboBox();
            this.gradeStudentByIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeStudentByIdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupByIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeStudentByIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeStudentByIdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupByIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.database1DataSet;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GradesTableAdapter = this.gradesTableAdapter;
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = AA.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.database1DataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportMenu,
            this.Edit,
            this.SaveMenu});
            this.Menu.Name = "Menu";
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Click += new System.EventHandler(this.фФФФToolStripMenuItem_Click);
            // 
            // ExportMenu
            // 
            this.ExportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.ExportMenu.Name = "ExportMenu";
            resources.ApplyResources(this.ExportMenu, "ExportMenu");
            this.ExportMenu.Click += new System.EventHandler(this.ExportMenu_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            resources.ApplyResources(this.excelToolStripMenuItem, "excelToolStripMenuItem");
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            resources.ApplyResources(this.Edit, "Edit");
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            resources.ApplyResources(this.SaveMenu, "SaveMenu");
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // studGrid
            // 
            this.studGrid.AllowUserToAddRows = false;
            this.studGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.studGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.studGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.studGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.studGrid.GridColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.studGrid, "studGrid");
            this.studGrid.MultiSelect = false;
            this.studGrid.Name = "studGrid";
            this.studGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studGrid.RowHeadersVisible = false;
            this.studGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.studGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrid_CellContentClick);
            this.studGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrid_CellEndEdit);
            this.studGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrid_CellValidated);
            this.studGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.studGrid_CellValidating);
            this.studGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrid_CellValueChanged);
            this.studGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.studGrid_EditingControlShowing);
            this.studGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studGrid_KeyPress);
            // 
            // groupsBox
            // 
            this.groupsBox.FormattingEnabled = true;
            resources.ApplyResources(this.groupsBox, "groupsBox");
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.SelectionChangeCommitted += new System.EventHandler(this.groupsBox_SelectionChangeCommitted);
            // 
            // gradeStudentByIdBindingSource
            // 
            this.gradeStudentByIdBindingSource.DataMember = "Grade_Student_By_Id";
            this.gradeStudentByIdBindingSource.DataSource = this.studentBindingSource;
            // 
            // gradeStudentByIdBindingSource1
            // 
            this.gradeStudentByIdBindingSource1.DataMember = "Grade_Student_By_Id";
            this.gradeStudentByIdBindingSource1.DataSource = this.studentBindingSource;
            // 
            // groupByIdBindingSource
            // 
            this.groupByIdBindingSource.DataMember = "GroupById";
            this.groupByIdBindingSource.DataSource = this.groupsBindingSource;
            // 
            // Ffff
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.groupsBox);
            this.Controls.Add(this.studGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Ffff";
            this.Activated += new System.EventHandler(this.Ffff_Activated);
            this.Load += new System.EventHandler(this.Ffff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeStudentByIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeStudentByIdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupByIdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GradeBaseDataSet database1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private Database1DataSetTableAdapters.GradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.BindingSource gradeStudentByIdBindingSource;
        private Database1DataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource gradeStudentByIdBindingSource1;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.BindingSource groupByIdBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private new System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem ExportMenu;
        private System.Windows.Forms.DataGridView studGrid;
        private System.Windows.Forms.ComboBox groupsBox;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
    }
}

