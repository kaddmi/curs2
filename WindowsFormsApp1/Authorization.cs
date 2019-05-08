using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Authorization : Form
    {
        public string role;
        public SecureString pwd = new SecureString();

        public string login;
        public string fio;
        public bool ex = true;
        public Authorization()
        {

            InitializeComponent();
            textBox1.Select();
            textBox1.Text = "user1";
            textBox2.Text = "password1";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string command1 = "select count(*) from master.dbo.syslogins where name='" + textBox1.Text + "'";
                    SqlCommand myCommand1 = new SqlCommand(command1, connection);
                    object number = myCommand1.ExecuteScalar();
                    if (number.ToString() == "0")
                    {
                        MessageBox.Show("Нет пользователя с таким логином");
                    }
                    else
                    {
                        string command2 =  "SELECT count(*) FROM sys.sql_logins WHERE PWDCOMPARE('" + textBox2.Text + "', password_hash)=1 and name='" + textBox1.Text + "'";                       
                        SqlCommand command = new SqlCommand(command2, connection);
                        number = command.ExecuteScalar();
                        if (number.ToString() != "1")
                        {
                            MessageBox.Show("Неправильный пароль");
                        }
                        else
                        {
                            foreach (char c in textBox2.Text)
                                pwd.AppendChar(c);
                            string command3 = "exec sp_helpuser '" + textBox1.Text + "'";
                            command = new SqlCommand(command3, connection);
                            SqlDataReader reader = command.ExecuteReader();
                            bool f = true;
                            if (reader.HasRows)
                            {
                                while (reader.Read() && f)
                                {
                                    login = reader.GetString(0);
                                    role = reader.GetString(1);
                                    f = false;
                                }
                            }                           
                            this.Hide();
                            Form1 form1 = new Form1
                            {
                                Owner = this
                            };
                            form1.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Внесите в поле логин своё ФИО");
                return;
            }
            else
            {
                role = "читатель";
                login = "reader";
                fio = textBox1.Text;
                foreach (char c in "password")
                    pwd.AppendChar(c);
            }
            this.Hide();
            this.Opacity = 0;
            this.Enabled = false;
            Form1 form1 = new Form1
            {
                Owner = this
            };
            form1.Show();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ex)
                Application.Exit();
        }

    }
}
