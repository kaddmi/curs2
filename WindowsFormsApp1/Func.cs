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
                    MessageBox.Show(ex.Message + ex.TargetSite);
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
                    chart1.Series[0].IsValueShownAsLabel = true;
                    chart1.Series[0].Points.DataBindXY(x1, y1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
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
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.Visible = true;
                    button1.Visible = true;
                    chart1.Visible = false;
                    SumInfoAboutStatya();
                    break;
                case 1:
                    dataGridView1.Visible = false;
                    button1.Visible = false;
                    CountStatya();
                    chart1.Visible = true;
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
          //  SqlConnection connection = new SqlConnection(connectionString);
            Filter filterDialog = new Filter(listBox1.SelectedIndex);
            filterDialog.comboBox2.Visible = false;
            filterDialog.comboBox1.Visible = false;
            filterDialog.label1.Visible = false;
            filterDialog.label2.Visible = false;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    filterDialog.listBox1.Items.Add("Номер выпуска газеты");
                    filterDialog.listBox1.Items.Add("Вид отзыва");
                    filterDialog.listBox1.Items.Add("Номер выпуска газеты и вид отзыва");
                    break;
            }
            if (filterDialog.ShowDialog(this) == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                using (connection)
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(filterDialog.sql, connection);
                        SqlDataReader dr = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt.DefaultView;
                        richTextBox1.Visible = true;
                        richTextBox1.Text = filterDialog.list + "\n" + filterDialog.list2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.TargetSite);
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
