using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DocumentFormat.OpenXml;
using ExportToExcel;

namespace AA
{
    public partial class Mainform : Form
    {
        private SqlConnection connection;
        private string ConnectionString = null;
        private string sql;
        public int code;
        public Mainform()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AA.Properties.Settings.StudTasksDBConnectionString"].ConnectionString;
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Ffff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.database1DataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter.Fill(this.database1DataSet.Grades);
            PopStudents();
            PopGrades();
            ColWid();
        }

        private void ColWid()
        {
            for(int i = 1; i < studGrid.Columns.Count; i++)
            {
                studGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            studGrid.Columns[0].ReadOnly = true;
            studGrid.Columns[studGrid.Columns.Count-1].ReadOnly = true;
        }

        private void PopStudents()
        {
            using (connection = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("select * from Groups", connection))
                {
                    DataSet dst = new DataSet();
                    adapter.Fill(dst, "Groups");
                    connection.Open();
                    groupsBox.DataSource = dst.Tables["Groups"];
                    groupsBox.DisplayMember = "GroupName";
                    groupsBox.ValueMember = "GroupID";
                }

            }

        }

        private void PopGrades()
        {
            code = groupsBox.SelectedIndex + 1;
            refresh(code);
        }

      

        public void refresh(int code)
        {
            
            using (connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    sql = "select S.FIO as [ФИО], G.Grade1 as [Балл 1], G.Grade2 as [Балл 2], G.Grade3 as [Балл 3], G.Grade4 as [Балл 4], G.Grade5 as [Балл 5], G.Grade6 as [Балл 6], (Grade1+Grade2+Grade3+Grade4+Grade5+Grade6) as [Итого] from Student S, Grades G where G.StudentId = S.Id and S.Group_number = " + code + " order by FIO";
                    using (SqlDataAdapter sda = new SqlDataAdapter(sql, connection))
                    {
                        connection.Open();
                        System.Data.DataTable studTable = new System.Data.DataTable();
                        sda.Fill(studTable);
                        studGrid.DataSource = studTable;
                        connection.Close();
                    }

                }
                catch (Exception)
                {

                }
            }
        }

        
        private void AddInGrid()
        {
            this.database1DataSet.AcceptChanges();
        }

        
        private void studGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.ColumnIndex;
            int m = e.RowIndex;
            DataGridViewCell ron = studGrid.Rows[m].Cells[0];
            string _name = ron.Value.ToString();

            int val = Int32.Parse(studGrid.SelectedCells[0].Value.ToString());
            if (val < 9)
            {
                TableChange(n, val, _name);
            }
        }

        private void TableChange(int coli, int val, string surn)
        {
            using (connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string que = "update [Grades] set Grade" + coli + " = " + val + " where StudentId= (select Student.Id from Student where Student.FIO=@surn)";
                SqlCommand scom = new SqlCommand(que, connection);
                scom.Parameters.AddWithValue("@val", val);
                scom.Parameters.AddWithValue("@grade", "Grade" + coli);
                scom.Parameters.AddWithValue("@surn", surn);
                scom.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void studGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex > 0) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                }
                
            }
        }

        private void studGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(studGrid_KeyPress);
        }

        private void studGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            double wa = char.GetNumericValue(e.KeyChar);
            if (!char.IsControl(e.KeyChar)
 && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
            else
            {
                if (e.KeyChar.Equals('9'))
                {
                    e.Handled = true;
                }
            }

        }

        private void Export()
        {
           
        }

        private DataSet CreateSampleData(SqlDataAdapter dset)
        {
            DataSet theSet = new DataSet();
            DataTable theTable = new DataTable();
            dset.Fill(theTable);
            theSet.Tables.Add(theTable);
            return theSet;
        }

        public void CreateExcelDoc()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, connection);
            DataSet dst = CreateSampleData(sda); //new DataSet();
            SaveFileDialog savef = new SaveFileDialog();
            savef.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            savef.FilterIndex = 1;
            if (savef.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    CreateExcelFile.CreateExcelDocument(dst, savef.FileName);
                    if (ToOpen(savef.FileName) == DialogResult.Yes)
                        System.Diagnostics.Process.Start(savef.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            
        }

        public DialogResult ToOpen(string file)
        {
            return MessageBox.Show("Файл " + file + " успешно создан. Открыть его?", "Таблица Excel создана", MessageBoxButtons.YesNo);
        }

        private void studGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void groupsBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopGrades();
        }
        

        private void фФФФToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportMenu_Click(object sender, EventArgs e)
        {
        }
        
        
        private void Edit_Click(object sender, EventArgs e)
        {
            GroupEdit GE = new GroupEdit();
            GE.Show();
        }

        private void Ffff_Activated(object sender, EventArgs e)
        {
            PopGrades();
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            AddInGrid();
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateExcelDoc();
        }

        private void studGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void studGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PopGrades();
        }
    }
}