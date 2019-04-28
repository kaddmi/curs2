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
    public partial class Статистика : Form
    {
        string role;
        public Статистика(string role)
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
                    string sql = "КоличествоСтатейСделанныхСотрудником";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.CommandType = CommandType.StoredProcedure;
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
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.CommandType = CommandType.StoredProcedure;
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

        private void readerRating()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string sql = "РейтингПоОтзывам";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.CommandType = CommandType.StoredProcedure;                 
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


        /*  public void f()
          {
              Filter filterDialog = new Filter();
              filterDialog.comboBox2.Visible = false;
              filterDialog.comboBox1.Visible = false;
              filterDialog.label1.Visible = false;
              filterDialog.label2.Visible = false;

              if (checkBox1.Checked == true)
              {
                  filterDialog.listBox1.Items.Clear();
                  string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
                  SqlConnection connection = new SqlConnection(connectionString);
                  switch (curTable)
                  {
                      case "Статья":
                          {
                              filterDialog.listBox1.Items.Add("Номер выпуска газеты");
                              filterDialog.listBox1.Items.Add("Название рубрики");
                              filterDialog.listBox1.Items.Add("ФИО сотрудника");
                              filterDialog.listBox1.Items.Add("Номер выпуска и название рубрики");
                          }
                          break;
                      case "Договор":
                          {
                              filterDialog.listBox1.Items.Add("Название заказчика");
                              filterDialog.listBox1.Items.Add("Дата действия договора");
                          }
                          break;
                      case "Реклама":
                          {
                              filterDialog.listBox1.Items.Add("Номер выпуска газеты");
                          }
                          break;
                      case "Сотрудник":
                          {
                              filterDialog.listBox1.Items.Add("Должность");
                          }
                          break;
                      case "НомерГазеты":
                          {
                              filterDialog.listBox1.Items.Add("Год");
                          }
                          break;
                      case "Объявление":
                          {
                              filterDialog.listBox1.Items.Add("Номер выпуска газеты");
                              filterDialog.listBox1.Items.Add("Название категории");
                          }
                          break;
                      case "Фото":
                          {
                              filterDialog.listBox1.Items.Add("Номер выпуска газеты");
                              filterDialog.listBox1.Items.Add("ФИО сотрудника");
                          }
                          break;
                      case "Отзыв":
                          {
                              filterDialog.listBox1.Items.Add("Жалоба или похвальный отзыв");
                              filterDialog.listBox1.Items.Add("Заголовок статьи");
                          }
                          break;
                  }
                  if (filterDialog.ShowDialog(this) == DialogResult.OK)
                  {
                      connection = new SqlConnection(connectionString);
                      using (connection)
                      {
                          try
                          {
                              connection.Open();
                              string sqlExpression = "Filter";
                              filterDialog.command.CommandText = sqlExpression;
                              filterDialog.command.Connection = connection;
                              filterDialog.command.CommandType = CommandType.StoredProcedure;
                              SqlParameter table = new SqlParameter
                              {
                                  ParameterName = "@table",
                                  Value = curTable
                              };
                              filterDialog.command.Parameters.Add(table);
                              SqlDataReader dr = filterDialog.command.ExecuteReader();
                              DataTable dt = new DataTable();
                              dt.Load(dr);
                              dataGridView1.DataSource = dt.DefaultView;
                              dataGridView1.Columns["Код"].Visible = false;
                              changeFilter.Visible = true;
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
                  else
                      checkBox1.Checked = false;
              }
              else
              {
                  // listBox1_SelectedIndexChanged(sender, e);
                  checkBox1.Checked = false;
                  MainEdit_Shown(sender, e);
              }
          }*/

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Visible = false;
            switch (listBox1.SelectedItem.ToString())
            {
                case "Суммарная информация по статье в выпуске":
                    dataGridView1.Visible = true;
                    richTextBox1.Visible = true;
                    button1.Visible = true;
                    chart1.Visible = false;
                    SumInfoAboutStatya();
                    this.Size = new Size(647, 488);
                    break;
                case "Количество статей сотрудника":
                    dataGridView1.Visible = false;
                    button1.Visible = false;
                    CountStatya();
                    chart1.Visible = true;
                    this.Size = new Size(448, 585);
                    break;
                case "Выручка с выпусков по годам":
                    dataGridView1.Visible = false;
                    button1.Visible = false;
                    Revenue();
                    chart1.Visible = true;
                    this.Size = new Size(448, 585);
                    break;
                case "Рейтинг читателей по отзывам":
                    dataGridView1.Visible = true;
                    button1.Visible = true;
                    chart1.Visible = false;
                    richTextBox1.Visible = true;
                    readerRating();
                    this.Size = new Size(730, 488);
                    break;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
          //  SqlConnection connection = new SqlConnection(connectionString);
            Filter filterDialog = new Filter(listBox1.SelectedItem.ToString());
            filterDialog.comboBox2.Visible = false;
            filterDialog.comboBox1.Visible = false;
            filterDialog.label1.Visible = false;
            filterDialog.label2.Visible = false;
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
                            string sqlExpression = "РейтингПоОтзывам";
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
    }
}
