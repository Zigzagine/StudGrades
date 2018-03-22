using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AA
{
    public partial class GroupEdit : Form
    {

        private string ConnectionString = null;

        public GroupEdit()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AA.Properties.Settings.StudTasksDBConnectionString"].ConnectionString;
            InitializeComponent();
        }

        private void GroupEdit_Load(object sender, EventArgs e)
        {
            LoadStud();
            LoadGroup();
            StudentsAll.Columns[2].Visible = false;
            StudentsAll.Columns[1].Width = 60;
            StudentsAll.Columns[0].Width = 115;
        }

        private void LoadStud()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            using (SqlDataAdapter sda = new SqlDataAdapter("Select Student.FIO as [Студент], Groups.GroupName as [Группа], Student.Id from Student, Groups where Student.Group_number = Groups.GroupId order by GroupName, FIO", connection))
            {
                connection.Open();
                DataTable dtt = new DataTable();
                sda.Fill(dtt);
                StudentsAll.DataSource = dtt;
            }
            
        }

        private void LoadGroup()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataSet dst = new DataSet();
            using (SqlDataAdapter sda = new SqlDataAdapter("select * from Groups", connection))
            {
                sda.Fill(dst, "Groups");
                GroupList.DataSource = dst.Tables["Groups"];
                GroupList.DisplayMember = "GroupName";
                GroupList.ValueMember = "GroupId";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sel = StudentsAll.SelectedCells[0].RowIndex;
            int dlt = Int32.Parse(StudentsAll.Rows[sel].Cells[2].Value.ToString());
            SqlConnection connection = new SqlConnection(ConnectionString);
            using (SqlCommand comm = new SqlCommand("delete from dbo.Grades where StudentId = " + dlt, connection))

            {
                connection.Open();
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                connection.Close();
            }
            using (SqlCommand comm = new SqlCommand("delete from dbo.Student where Id = "+dlt, connection))
            
            {
                connection.Open();
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                connection.Close();
            }

            LoadStud();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InputFIO.Text.Length>3)
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                string fio = InputFIO.Text;
                int group = Int32.Parse(GroupList.SelectedValue.ToString());
                using (SqlCommand comm = new SqlCommand("insert into Student (FIO, Group_Number) values (@fio, @group)", connection))
                {
                    connection.Open();
                    comm.Parameters.AddWithValue("@fio", fio);
                    comm.Parameters.AddWithValue("@group", group);
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
                using (SqlCommand comm = new SqlCommand("insert into Grades (StudentId) (select max(Student.Id) from Student)", connection))
                {
                    connection.Open();
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
                LoadStud();
                InputFIO.Text = "";
            }
            else MessageBox.Show("Укажите фамилию и инициалы студента");
        }

        private void ENDbutton_Click(object sender, EventArgs e) => ActiveForm.Dispose();
    }
}
