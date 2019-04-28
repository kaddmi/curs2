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
    public partial class Filter : Form
    {
        public SqlCommand command = new SqlCommand();
        public string list;
        public string list2 = "";
        bool f = false;
        string index;
        public string sql;
        public Filter()
        {
            InitializeComponent();

        }
        public Filter(string i)
        {
            InitializeComponent();
            f = true;
            index = i;
        }

        public void combBox(ComboBox cb, string table, string dispMember, string com1, SqlConnection connection)
        {
            SqlDataAdapter da2 = new SqlDataAdapter(com1, connection);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, table);
            cb.DisplayMember = dispMember;
            cb.ValueMember = dispMember;
            cb.DataSource = ds2.Tables[table];
        }

        private void func(SqlConnection connection, string ind)
        {
            string com1;
            switch (ind)
            {
                case "Суммарная информация по статье в выпуске":
                    {
                        switch (listBox1.SelectedItem.ToString())
                        {
                            case "Номер выпуска газеты":
                                {
                                    label1.Text = "Номер выпуска газеты";
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, Номер from НомерГазеты";
                                    combBox(comboBox1, "НомерГазеты", "Номер", com1, connection);
                                    this.Size = new Size(338, 264);
                                    button1.Location = new Point(86, 184);
                                }
                                break;
                            case "Вид отзыва":
                                {
                                    label1.Text = "Вид отзыва";
                                    checkBox1.Visible = true;
                                    this.Size = new Size(338, 264);
                                    checkBox1.Location = new Point(55, 140);
                                    button1.Location = new Point(86, 184);
                                }
                                break;
                            case "Номер выпуска газеты и вид отзыва":
                                {
                                    label1.Text = "Номер выпуска газеты";
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, Номер from НомерГазеты";
                                    combBox(comboBox1, "НомерГазеты", "Номер", com1, connection);
                                    label2.Visible = true;
                                    label2.Text = "Вид отзыва";
                                    checkBox1.Location = new Point(55, 209);
                                    checkBox1.Visible = true;
                                    button1.Location = new Point(85, 250);
                                    this.Size = new Size(350, 328);
                                }
                                break;
                        }
                    }
                    break;
                case "Рейтинг читателей по отзывам":
                    {
                        label1.Text = "Год отзыва";
                        comboBox1.DataSource = null;
                        comboBox1.Visible = true;
                        com1 = "select distinct YEAR(ДатаОтзыва) as ДатаОтзыва from Отзыв";
                        combBox(comboBox1, "Отзыв", "ДатаОтзыва", com1, connection);
                        button1.Location = new Point(86, 184);

                    }
                    break;
            }
        }

        private void funcB(string ind)
        {
            switch (ind)
            {
                case "Суммарная информация по статье в выпуске":
                    {
                        switch (listBox1.SelectedItem.ToString())
                        {
                            case "Номер выпуска газеты":
                                {
                                    sql = "select Заголовок, НомерВыпуска, КоличествоОтзывов from СуммарнаяИнформацияПоСтатьеВВыпуске(" + comboBox1.SelectedValue.ToString() + ", default)";
                                    list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                                }
                                break;
                            case "Вид отзыва":
                                {
                                    int i = 0;
                                    string s = "Похвальный отзыв";
                                    if (checkBox1.Checked)
                                    {
                                        i = 1;
                                        s = "Жалоба";
                                    }                                      
                                    sql = "select Заголовок, НомерВыпуска, КоличествоОтзывов from СуммарнаяИнформацияПоСтатьеВВыпуске(default, " + i + ")";
                                    list = listBox1.SelectedItem.ToString() + " = " + s;
                                }
                                break;
                            case "Номер выпуска газеты и вид отзыва":
                                {
                                    int i = 0;
                                    string s = "Похвальный отзыв";
                                    if (checkBox1.Checked)
                                    {
                                        i = 1;
                                        s = "Жалоба";
                                    }
                                    sql = "select Заголовок, НомерВыпуска, КоличествоОтзывов from СуммарнаяИнформацияПоСтатьеВВыпуске(" + comboBox1.SelectedValue.ToString() + ", " + i + ")";
                                    list = "Номер выпуска = " + comboBox1.SelectedValue.ToString();
                                    list2 = "Вид отзыва = " + s;
                                }
                                break;
                        }
                    }
                    break;
                case "Рейтинг читателей по отзывам":
                    {
                        SqlParameter value = new SqlParameter
                        {
                            ParameterName = "@y",
                            Value = comboBox1.SelectedValue.ToString()
                        };
                        command.Parameters.Add(value);
                        list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                    }
                    break;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            checkBox1.Visible = false;
            if (listBox1.SelectedItem == null)
                return;
            label1.Visible = true;
            label1.Text = listBox1.SelectedItem.ToString();
            button1.Visible = true;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string com1 = "";
                    string com2 = "";
                    if (!f)
                    {
                        switch (listBox1.SelectedItem.ToString())
                        {
                            case "Номер выпуска газеты":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, Номер from НомерГазеты";
                                    combBox(comboBox1, "НомерГазеты", "Номер", com1, connection);
                                    SqlParameter column = new SqlParameter
                                    {
                                        ParameterName = "@column",
                                        Value = "НомерГазеты.Номер"
                                    };
                                    if (!command.Parameters.Contains("@column"))
                                        command.Parameters.Add(column);
                                }
                                break;
                            case "Название рубрики":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, Название from Рубрика";
                                    combBox(comboBox1, "Рубрика", "Название", com1, connection);
                                    SqlParameter column = new SqlParameter
                                    {
                                        ParameterName = "@column",
                                        Value = "Рубрика.Название"
                                    };
                                    if (!command.Parameters.Contains("@column"))
                                        command.Parameters.Add(column);
                                }
                                break;
                            case "ФИО сотрудника":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, ФИО from Сотрудник";
                                    combBox(comboBox1, "Сотрудник", "ФИО", com1, connection);
                                    SqlParameter column = new SqlParameter
                                    {
                                        ParameterName = "@column",
                                        Value = "Сотрудник.ФИО"
                                    };
                                    if (!command.Parameters.Contains("@column"))
                                        command.Parameters.Add(column);
                                }
                                break;
                            case "Номер выпуска и название рубрики":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    comboBox2.Visible = true;
                                    label1.Text = "Номер выпуска газеты";
                                    label2.Visible = true;
                                    label2.Text = "Название рубрики";
                                    com1 = "select Код, Номер from НомерГазеты";
                                    combBox(comboBox1, "НомерГазеты", "Номер", com1, connection);
                                    com2 = "select Код, Название from Рубрика";
                                    combBox(comboBox2, "Рубрика", "Название", com2, connection);
                                    button1.Location = new Point(85, 250);
                                    this.Size = new Size(350, 328);
                                }
                                break;
                            case "Название заказчика":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, Название from Заказчик";
                                    combBox(comboBox1, "Заказчик", "Название", com1, connection);
                                    SqlParameter column = new SqlParameter
                                    {
                                        ParameterName = "@column",
                                        Value = "Заказчик.Название"
                                    };
                                    if (!command.Parameters.Contains("@column"))
                                        command.Parameters.Add(column);
                                }
                                break;
                            case "Дата действия договора":
                                {
                                    dateTimePicker1.Visible = true;
                                }
                                break;
                            case "Должность":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, Должность from Сотрудник";
                                    combBox(comboBox1, "Сотрудник", "Должность", com1, connection);
                                }
                                break;
                            case "Год":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select distinct YEAR(Дата) as Дата from НомерГазеты";
                                    combBox(comboBox1, "НомерГазеты", "Дата", com1, connection);
                                }
                                break;
                            case "Название категории":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, Категория from Объявление";
                                    combBox(comboBox1, "Объявление", "Категория", com1, connection);
                                    SqlParameter column = new SqlParameter
                                    {
                                        ParameterName = "@column",
                                        Value = "Объявление.Категория"
                                    };
                                    if (!command.Parameters.Contains("@column"))
                                        command.Parameters.Add(column);
                                }
                                break;
                            case "Жалоба или похвальный отзыв":
                                {
                                    checkBox1.Visible = true;
                                    SqlParameter column = new SqlParameter
                                    {
                                        ParameterName = "@column",
                                        Value = "Отзыв.Жалоба"
                                    };
                                    if (!command.Parameters.Contains("@column"))
                                        command.Parameters.Add(column);
                                }
                                break;
                            case "Заголовок статьи":
                                {
                                    comboBox1.DataSource = null;
                                    comboBox1.Visible = true;
                                    com1 = "select Код, Заголовок from Статья";
                                    combBox(comboBox1, "Статья", "Заголовок", com1, connection);
                                    SqlParameter column = new SqlParameter
                                    {
                                        ParameterName = "@column",
                                        Value = "Статья.Заголовок"
                                    };
                                    if (!command.Parameters.Contains("@column"))
                                        command.Parameters.Add(column);
                                }
                                break;
                        }
                    }
                    if (f)
                    {
                        func(connection, index);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!f)
            {
                switch (listBox1.SelectedItem.ToString())
                {
                    case "Номер выпуска газеты":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueI",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                        }
                        break;
                    case "Название рубрики":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueC",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                        }
                        break;
                    case "ФИО сотрудника":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueC",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                        }
                        break;
                    case "Номер выпуска и название рубрики":
                        {
                            SqlParameter value1 = new SqlParameter
                            {
                                ParameterName = "@valueI",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value1);
                            list = "Номер выпуска = " + comboBox1.SelectedValue.ToString();
                            SqlParameter value2 = new SqlParameter
                            {
                                ParameterName = "@vyp_rubr",
                                Value = comboBox2.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value2);
                            list2 = "Название рубрики = " + comboBox2.SelectedValue.ToString();
                        }
                        break;
                    case "Название заказчика":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueC",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                        }
                        break;
                    case "Дата действия договора":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueDB",
                                Value = dateTimePicker1.Value.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + dateTimePicker1.Value.ToString();
                        }
                        break;
                    case "Должность":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueC",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                        }
                        break;
                    case "Год":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueD",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                        }
                        break;
                    case "Название категории":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueC",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                        }
                        break;
                    case "Жалоба или похвальный отзыв":
                        {
                            int i = 0;
                            string s = "Похвальный отзыв";
                            if (checkBox1.Checked)
                            {
                                i = 1;
                                s = "Жалоба";
                            }
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueI",
                                Value = i.ToString()
                            };
                            command.Parameters.Add(value);
                            list = s;
                        }
                        break;
                    case "Заголовок статьи":
                        {
                            SqlParameter value = new SqlParameter
                            {
                                ParameterName = "@valueC",
                                Value = comboBox1.SelectedValue.ToString()
                            };
                            command.Parameters.Add(value);
                            list = listBox1.SelectedItem.ToString() + " = " + comboBox1.SelectedValue.ToString();
                        }
                        break;
                }
            }
            if (f)
            {
                funcB(index);
            }
        }
        


    }
}
