namespace AA
{
    partial class GroupEdit
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
            this.StudentsAll = new System.Windows.Forms.DataGridView();
            this.DelButton = new System.Windows.Forms.Button();
            this.gradeBaseDataSet1 = new AA.GradeBaseDataSet();
            this.InputFIO = new System.Windows.Forms.TextBox();
            this.GroupList = new System.Windows.Forms.ListBox();
            this.gradeBaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ENDbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBaseDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsAll
            // 
            this.StudentsAll.AllowUserToAddRows = false;
            this.StudentsAll.AllowUserToDeleteRows = false;
            this.StudentsAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsAll.Location = new System.Drawing.Point(12, 12);
            this.StudentsAll.Name = "StudentsAll";
            this.StudentsAll.RowHeadersVisible = false;
            this.StudentsAll.Size = new System.Drawing.Size(195, 201);
            this.StudentsAll.TabIndex = 0;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(12, 225);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(195, 23);
            this.DelButton.TabIndex = 1;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gradeBaseDataSet1
            // 
            this.gradeBaseDataSet1.DataSetName = "Database1DataSet";
            this.gradeBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InputFIO
            // 
            this.InputFIO.Location = new System.Drawing.Point(214, 30);
            this.InputFIO.Name = "InputFIO";
            this.InputFIO.Size = new System.Drawing.Size(100, 20);
            this.InputFIO.TabIndex = 2;
            // 
            // GroupList
            // 
            this.GroupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupList.FormattingEnabled = true;
            this.GroupList.ItemHeight = 20;
            this.GroupList.Location = new System.Drawing.Point(214, 74);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(100, 84);
            this.GroupList.TabIndex = 3;
            // 
            // gradeBaseDataSet1BindingSource
            // 
            this.gradeBaseDataSet1BindingSource.DataSource = this.gradeBaseDataSet1;
            this.gradeBaseDataSet1BindingSource.Position = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(213, 164);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 29);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО студента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Группа:";
            // 
            // ENDbutton
            // 
            this.ENDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ENDbutton.Location = new System.Drawing.Point(214, 199);
            this.ENDbutton.Name = "ENDbutton";
            this.ENDbutton.Size = new System.Drawing.Size(100, 49);
            this.ENDbutton.TabIndex = 7;
            this.ENDbutton.Text = "OK";
            this.ENDbutton.UseVisualStyleBackColor = true;
            this.ENDbutton.Click += new System.EventHandler(this.ENDbutton_Click);
            // 
            // GroupEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 260);
            this.Controls.Add(this.ENDbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.InputFIO);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.StudentsAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GroupEdit";
            this.Load += new System.EventHandler(this.GroupEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBaseDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsAll;
        private System.Windows.Forms.Button DelButton;
        private GradeBaseDataSet gradeBaseDataSet1;
        private System.Windows.Forms.TextBox InputFIO;
        private System.Windows.Forms.ListBox GroupList;
        private System.Windows.Forms.BindingSource gradeBaseDataSet1BindingSource;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ENDbutton;
    }
}