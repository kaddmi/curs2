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
        public bool deleteB = false;
        public bool editB = false;
        public bool addB = false;
        public SecureString pwd = new SecureString();

        public string login = "Гость";
        public Authorization()
        {

            InitializeComponent();
            button2.Select();
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
                    string command1 = "select count(*) from users where Логин='" + textBox1.Text + "'";
                    SqlCommand myCommand1 = new SqlCommand(command1, connection);
                    object number = myCommand1.ExecuteScalar();
                    if (number.ToString() != "1")
                    {
                        MessageBox.Show("Нет пользователя с таким логином");
                    }
                    else
                    {
                        string command2 = "select Удаление, Редактирование, Добавление from users where Логин='" + textBox1.Text + "' and Пароль='" + textBox2.Text + "'";
                        SqlCommand command = new SqlCommand(command2, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            foreach (char c in textBox2.Text)
                                pwd.AppendChar(c);
                            while (reader.Read())
                            {
                                deleteB = reader.GetBoolean(0);
                                editB = reader.GetBoolean(1);
                                addB = reader.GetBoolean(2);                              
                            }
                            login = textBox1.Text;
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Owner = this;
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный пароль");
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
            this.Hide();
            Form1 form1 = new Form1();
            form1.Owner = this;
            form1.Show();
            foreach (char c in "password")
                pwd.AppendChar(c);
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
