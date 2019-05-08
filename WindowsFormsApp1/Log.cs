using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Log : Form
    {
        string what;
        public Log(string s)
        {
            InitializeComponent();
            what = s;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string command = "";
            using (connection)
            {
                try
                {
                    button2.Visible = false;
                    button2.Enabled = true;
                    connection.Open();
                    string curTable = listBox1.SelectedItem.ToString();
                    switch (curTable)
                    {
                        case "Номер газеты":
                            command = "select * from НомерГазетыLog order by idLog desc";
                            break;
                        case "Рубрика":
                            button2.Visible = true;
                            command = "select * from РубрикаLog order by idLog desc";
                            break;
                        case "Сотрудник":
                            command = "select * from СотрудникLog order by idLog desc";
                            break;
                    }
                    SqlCommand myCommand = new SqlCommand(command, connection);
                    SqlDataReader dr = myCommand.ExecuteReader();
                    if (!dr.HasRows)
                        button2.Enabled = false;
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt.DefaultView;
                    dataGridView1.Columns["idLog"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Log_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Opacity = 100;
            Owner.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string sql = "ОтменаПоследнегоВЛоге";
                    SqlCommand comm = new SqlCommand(sql, connection);
                    int number = comm.ExecuteNonQuery();
                    ListBox1_SelectedIndexChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Log_Shown(object sender, EventArgs e)
        {
            switch (what)
            {
                case "u":
                    {
                        dataGridView1.AllowUserToDeleteRows = true;
                        listBox1.Visible = false;
                        button2.Visible = false;
                        button1.Visible = false;
                        dataGridView1.Location = new Point(12, 12);
                        dataGridView1.Size = new Size(449, 301);
                        this.Size = dataGridView1.Size;
                        dataGridView1.BorderStyle = BorderStyle.None;
                        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
                        SqlConnection connection = new SqlConnection(connectionString);
                        using (connection)
                        {
                            try
                            {
                                connection.Open();
                                string sql = "ПользователиИРоли";
                                SqlCommand comm = new SqlCommand(sql, connection);
                                SqlDataReader dr = comm.ExecuteReader();
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                dataGridView1.DataSource = dt.DefaultView;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                    }
                    break;
            }
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    DialogResult result;
                    string command = "";
                    string login = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Имя"].Value.ToString();
                    if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Роль"].Value.ToString() != "системный администратор")
                    {
                        result = MessageBox.Show("Вы уверены, что хотите удалить имя входа и пользователя?", "Удаление", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            command = "drop login " + login;
                            SqlCommand myCommand = new SqlCommand(command, connection);
                            int number = myCommand.ExecuteNonQuery();
                            command = "drop user " + login;
                            myCommand = new SqlCommand(command, connection);
                            number = myCommand.ExecuteNonQuery();
                        }
                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                        e.Cancel = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    e.Cancel = true;
                }
            }
        }
    }
}
