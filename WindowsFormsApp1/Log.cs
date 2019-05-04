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
        public Log()
        {
            InitializeComponent();
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
    }
}
