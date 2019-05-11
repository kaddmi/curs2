using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Func : Form
    {
        public Func()
        {
            InitializeComponent();
        }

        private void SumInfoAboutStatya()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string  sql = "select Заголовок, НомерВыпуска, КоличествоОтзывов from СуммарнаяИнформацияПоСтатьеВВыпуске(default, default)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader dr = command.ExecuteReader();
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

        private void CountStatya()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    List<int> count = new List<int>();
                    List<string> fio = new List<string>();
                    connection.Open();
                    string sql = "select * from КоличествоСтатейСделанныхСотрудником() order by Количество desc";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {                       
                        while (reader.Read())
                        {
                            fio.Add(reader.GetString(0));
                            count.Add(reader.GetInt32(1));
                        }
                    }
                    string[] x1 = new string[fio.Count];
                    int[] y1 = new int[fio.Count];
                    for (int i = 0; i < fio.Count; i++)
                    {
                        x1[i] = fio[i];                     
                        y1[i] = count[i];
                    }
                    chart1.Titles[0].Text = "Количество статей сделанных сотрудниками";
                    chart1.ChartAreas[0].AxisX.Title = "ФИО сотрудника";
                    chart1.ChartAreas[0].AxisY.Title = "Количество статей";
                    chart1.Series[0].IsVisibleInLegend = false;
                    chart1.Series[0].ChartType = SeriesChartType.Bar;
                    chart1.Series[0].Color = Color.Empty;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    chart1.Series[0].Points.DataBindXY(x1, y1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Revenue()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    List<SqlMoney> rev = new List<SqlMoney>();
                    List<int> year = new List<int>();
                    connection.Open();
                    string sql = "ВыручкаПоГодам";
                    SqlCommand command = new SqlCommand(sql, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            year.Add(reader.GetInt32(0));
                            rev.Add(reader.GetSqlMoney(1));
                        }
                    }
                    string[] x1 = new string[year.Count];
                    double[] y1 = new double[year.Count];
                    for (int i = 0; i < year.Count; i++)
                    {
                        x1[i] = year[i].ToString();
                        y1[i] = rev[i].ToDouble();
                    }
                    
                    chart1.Titles[0].Text = "График изменения выручки";
                    chart1.Series[0].IsVisibleInLegend = false;
                    chart1.ChartAreas[0].AxisX.Title = "Год";
                    chart1.ChartAreas[0].AxisY.Title = "Выручка";
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].Color = Color.Coral;
                    chart1.Series[0].BorderWidth = 2;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    chart1.Series[0].Points.DataBindXY(x1, y1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ReaderRating()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    int sumP = 0;
                    int sumN = 0;
                    connection.Open();
                    string sql = "РейтингПоОтзывам";
                    SqlCommand command = new SqlCommand(sql, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sumP += reader.GetInt32(2);
                            sumN += reader.GetInt32(3);
                        }
                    }
                    List<int> y = new List<int>
                    {
                        sumP,
                        sumN
                    };
                    List<string> x = new List<string>
                    {
                        "положительные",
                        "отрицательные"
                    };
                    chart1.Titles[0].Text = "Распределение по отзывам";
                    chart1.ChartAreas[0].AxisX.Title = "Год";
                    chart1.ChartAreas[0].AxisY.Title = "Выручка";
                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    chart1.Series[0].IsVisibleInLegend = true;                   
                    chart1.Series[0].Points.DataBindXY(x,y);
                    chart1.Series[0].Points[0].Color = Color.Turquoise;
                    chart1.Series[0].Points[1].Color = Color.Crimson;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AdRating()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string sql = "Объявления";
                    SqlCommand command = new SqlCommand(sql, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlDataReader dr = command.ExecuteReader();
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
        
        private void SumDog()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string sql = 
                        "declare @result money " +
                        "execute @result=СуммаДоговоров '" + dateTimePicker1.Value.ToString() + "', '" + dateTimePicker2.Value.ToString() + "' " +
                        "select @result";
                    SqlCommand command = new SqlCommand(sql, connection);
                    object count = command.ExecuteScalar();
                    label3.Visible = true;
                    textBox1.Visible = true;
                    textBox1.Text = count.ToString();
                    if (textBox1.Text == "")
                        textBox1.Text = "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Stazh()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string sql = "Стаж";
                    SqlCommand command = new SqlCommand(sql, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlDataReader dr = command.ExecuteReader();
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

        private void Statistics()
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                if (textBox2.Text == "")
                    textBox2.Focus();
                if (textBox3.Text == "")
                    textBox3.Focus();
                return;
            }
            else
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                using (connection)
                {
                    try
                    {
                        connection.Open();
                        string sql = "Статистика";
                        SqlCommand command = new SqlCommand(sql, connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        SqlParameter yB = new SqlParameter
                        {
                            ParameterName = "@yB",
                            Value = textBox2.Text
                        };
                        command.Parameters.Add(yB);
                        SqlParameter yE = new SqlParameter
                        {
                            ParameterName = "@yE",
                            Value = textBox3.Text
                        };
                        command.Parameters.Add(yE);
                        SqlDataReader dr = command.ExecuteReader();
                        dataGridView1.Visible = true;
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
        }

        private void DogPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(".")) | e.KeyChar == '\b')
                return;
            else
                e.Handled = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            this.AcceptButton = button1;
            textBox3.Visible = false;
            dataGridView1.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            chart1.Visible = false;
            this.AcceptButton = button1;
            if (listBox1.SelectedItem == null)
                return;
            switch (listBox1.SelectedItem.ToString())
            {
                case "Суммарная информация по статье в выпуске":
                    dataGridView1.Visible = true;
                    richTextBox1.Visible = true;
                    button1.Visible = true;
                    SumInfoAboutStatya();
                    this.Size = new Size(795, 650);
                    break;
                case "Количество статей сотрудника":
                    CountStatya();
                    this.AcceptButton = null;
                    chart1.Visible = true;
                    this.AcceptButton = null;
                    this.Size = new Size(448, 585);
                    break;
                case "Выручка с выпусков по годам":
                    Revenue();
                    chart1.Visible = true;
                    this.AcceptButton = null;
                    this.Size = new Size(448, 585);
                    break;
                case "Рейтинг читателей по отзывам":
                    chart1.Visible = true;
                    button1.Visible = true;
                    richTextBox1.Visible = true;
                    ReaderRating();
                    this.Size = new Size(730, 585);
                    break;
                case "Сумма по договорам за период":
                    button2.Visible = true;
                    this.AcceptButton = button2;
                    label1.Visible = true;
                    label1.Text = "Дата начала периода";
                    label2.Text = "Дата конца периода";
                    label2.Visible = true;
                  //  dateTimePicker1.Select();
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = true;
                    this.Size = new Size(656, 245);
                    break;
                case "Количество объявлений по категориям":
                    dataGridView1.Visible = true;
                    button1.Visible = true;
                    richTextBox1.Visible = true;
                    AdRating();
                    this.Size = new Size(647, 488);
                    break;
                case "Стаж работников":
                    dataGridView1.Visible = true;
                    this.AcceptButton = null;
                    Stazh();
                    this.AcceptButton = null;
                    this.Size = new Size(448, 488);
                    break;
                case "Статистика по увольнению и найму сотрудников":                 
                    button2.Visible = true;
                    this.AcceptButton = button2;
                    label1.Visible = true;
                    this.AcceptButton = button2;
                    label2.Visible = true;
                    label1.Text = "Год начала периода";
                   // textBox2.Select();
                    label2.Text = "Год конца периода";
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    this.Size = new Size(659, 488);
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            Filter filterDialog = new Filter(listBox1.SelectedItem.ToString());
            filterDialog.comboBox2.Visible = false;
            filterDialog.comboBox1.Visible = false;
            filterDialog.label1.Visible = false;
            filterDialog.label2.Visible = false;
            if (listBox1.SelectedItem == null)
                return;
            switch (listBox1.SelectedItem.ToString())
            {
                case "Суммарная информация по статье в выпуске":
                    filterDialog.listBox1.Items.Add("Номер выпуска газеты");
                    filterDialog.listBox1.Items.Add("Вид отзыва");
                    filterDialog.listBox1.Items.Add("Номер выпуска газеты и вид отзыва");
                    break;
                case "Рейтинг читателей по отзывам":
                    filterDialog.listBox1.Items.Add("Год");
                    break;
                case "Количество объявлений по категориям":
                    filterDialog.listBox1.Items.Add("Номер выпуска газеты");
                    break;
            }
            if (filterDialog.ShowDialog(this) == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                using (connection)
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        if (listBox1.SelectedItem.ToString() == "Суммарная информация по статье в выпуске")
                        {
                            command = new SqlCommand(filterDialog.sql, connection);
                            SqlDataReader dr = command.ExecuteReader();
                            dt.Load(dr);
                        }                           
                        if (listBox1.SelectedItem.ToString() == "Рейтинг читателей по отзывам")
                        {
                            chart1.Visible = false;
                            dataGridView1.Visible = true;
                            string sqlExpression = "РейтингПоОтзывам";
                            filterDialog.command.CommandText = sqlExpression;
                            filterDialog.command.Connection = connection;
                            filterDialog.command.CommandType = CommandType.StoredProcedure;
                            SqlDataReader dr = filterDialog.command.ExecuteReader();
                            dt.Load(dr);
                        }
                        if (listBox1.SelectedItem.ToString() == "Количество объявлений по категориям")
                        {
                            string sqlExpression = "Объявления";
                            filterDialog.command.CommandText = sqlExpression;
                            filterDialog.command.Connection = connection;
                            filterDialog.command.CommandType = CommandType.StoredProcedure;
                            SqlDataReader dr = filterDialog.command.ExecuteReader();
                            dt.Load(dr);
                        }
                        dataGridView1.DataSource = dt.DefaultView;
                        richTextBox1.Visible = true;
                        richTextBox1.Text = filterDialog.list + "\n" + filterDialog.list2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //filterDialog.Dispose();
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            switch (listBox1.SelectedItem.ToString())
            {               
                case "Сумма по договорам за период":
                    SumDog();
                    break;              
                case "Статистика по увольнению и найму сотрудников":
                    Statistics();
                    break;

            }
        }

        private void Func_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Opacity = 100;
            Owner.Enabled = true;
        }
    }
}
