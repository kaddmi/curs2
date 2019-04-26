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
                    connection.Open();
                    string curTable = listBox1.SelectedItem.ToString();
                    switch (curTable)
                    {
                        case "Номер газеты":
                            command = "select * from НомерГазетыLog";                           
                            break;
                        case "Рубрика":
                             command = "select * from РубрикаLog";
                             break;
                        case "Сотрудник":
                            command = "select * from СотрудникLog";
                            break;
                    }
                    SqlCommand myCommand = new SqlCommand(command, connection);
                    SqlDataReader dr = myCommand.ExecuteReader();
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
    }
}
