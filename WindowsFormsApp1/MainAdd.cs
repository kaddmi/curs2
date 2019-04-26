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
    public partial class MainAdd : Form
    {
        SqlCredential cred;
        string curTable;
        public MainAdd(string currTable, SqlCredential credd)
        {
            InitializeComponent();
            curTable = currTable;
            cred = credd;
            Add();
        }

        private void Add()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Credential = cred;
            using (connection)
            {
                try
                {
                    connection.Open();
                    string com1 = "";
                    string com2 = "";
                    string com3 = "";
                    switch (curTable)
                    {
                        case "Статья":
                            {
                                //stPanel.Location = new Point(401, 72);
                                stPanel.Visible = true;
                                com1 = "select Код, ФИО from Сотрудник";
                                com2 = "select Код, Номер from НомерГазеты";
                                com3 = "select Код, Название from Рубрика";
                                combBox(stNames, "Сотрудник", "ФИО", com1, connection);
                                combBox(stNumbers, "НомерГазеты", "Номер", com2, connection);
                                combBox(stR, "Рубрика", "Название", com3, connection);
                                sotr.Visible = true;
                                nom.Visible = true;
                                rubr.Visible = true;
                            }
                            break;
                        case "Заказчик":
                            zPanel.Location = new Point(3, 42);
                            zPanel.Visible = true;
                            break;
                        case "Договор":
                            {
                             //   dogPanel.Location = new Point(401, 72);
                                dogPanel.Visible = true;
                                com1 = "select Код, Название from Заказчик";
                                combBox(dogZak, "Заказчик", "Название", com1, connection);
                                zak.Visible = true;
                            }
                            break;
                        case "Реклама":
                            {
                              //  reklPanel.Location = new Point(401, 72);
                                reklPanel.Visible = true;
                                com1 = "select Код, Номер from НомерГазеты";
                                com2 = "select Код, ТекстРекламы from Договор";
                                combBox(reklNumber, "НомерГазеты", "Номер", com1, connection, "Номер");
                                combBox(reklText, "Догoвор", "ТекстРекламы", com2, connection, "ТекстРекламы");
                                nom.Visible = true;
                                dog.Visible = true;
                            }
                            break;
                        case "Рубрика":
                            rPanel.Location = new Point(3, 42);
                            rPanel.Visible = true;
                            break;
                        case "Сотрудник":
                            sotrPanel.Location = new Point(3, 42);
                            sotrPanel.Visible = true;
                            break;
                        case "НомерГазеты":
                            newspPanel.Location = new Point(3, 42);
                            newspPanel.Visible = true;
                            break;
                        case "Объявление":
                            {
                              //  obPanel.Location = new Point(401, 72);
                                obPanel.Visible = true;
                                com1 = "select Код, Номер from НомерГазеты";
                                combBox(obNumber, "НомерГазеты", "Номер", com1, connection);
                                nom.Location = new Point(3, 42);
                                nom.Visible = true;
                            }
                            break;
                        case "Фото":
                            {
                              //  photoPanel.Location = new Point(401, 72);
                                photoPanel.Visible = true;
                                com1 = "select Код, ФИО from Сотрудник";
                                com2 = "select Код, Номер from НомерГазеты where Код in (select КодВыпуска from Статья)";
                                combBox(photoName, "Сотрудник", "ФИО", com1, connection);
                                combBox(photoNumber, "НомерГазеты", "Номер", com2, connection);
                                stat.Visible = true;
                                sotr.Visible = true;
                            }
                            break;
                        case "Отзыв":
                            {
                             //   otzPanel.Location = new Point(401, 72);
                                otzPanel.Visible = true;
                                com1 = "select Код, Номер from НомерГазеты where Код in (select КодВыпуска from Статья)";
                                combBox(otzNumber, "НомерГазеты", "Номер", com1, connection);
                                stat.Location = new Point(3, 42);
                                stat.Visible = true;
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void combBox(ComboBox cb, string table, string dispMember, string com1, SqlConnection connection, string valM = "Код")
        {
            SqlDataAdapter da2 = new SqlDataAdapter(com1, connection);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, table);
            cb.DisplayMember = dispMember;
            cb.ValueMember = valM;
            cb.DataSource = ds2.Tables[table];
        }

        private void Add(string command)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Credential = cred;
            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlCommand myCommand = new SqlCommand(command, connection);
                    int number = myCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void stAdd_Click(object sender, EventArgs e)
        {
            if (stType.Text == "" || stTitle.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                if (stTitle.Text == "")
                    stTitle.Focus();
                if (stType.Text == "")
                    stType.Focus();
                return;
            }
            else
            {
                string command = "insert into Статья values ('" + stType.Text + "', '" + stTitle.Text + "', " + stNames.SelectedValue.ToString() + ", " + stNumbers.SelectedValue.ToString() + ", " + stR.SelectedValue.ToString() + ")";
                Add(command);
                stTitle.Clear();
                stType.Clear();
            }
        }

        private void zAdd_Click(object sender, EventArgs e)
        {
            if (zakName.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                zakName.Focus();
                return;
            }
            else
            {
                string command = "insert into Заказчик(Название) values ('" + zakName.Text + "')";
                Add(command);
                zakName.Clear();
            }
        }

        private void rAdd_Click(object sender, EventArgs e)
        {
            if (rName.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                rName.Focus();
                return;
            }
            else
            {
                string command = "insert into Рубрика values ('" + rName.Text + "')";
                Add(command);
                rName.Clear();
            }
        }

        private void sotrAdd_Click(object sender, EventArgs e)
        {
            if (sotrName.Text == "" || sotrDol.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                if (sotrName.Text == "")
                    sotrName.Focus();
                if (sotrDol.Text == "")
                    sotrDol.Focus();
                return;
            }
            else
            {
                string command = "insert into Сотрудник(ФИО, Должность, ДатаУвольнения) values ('" + sotrName.Text + "', '" + sotrDol.Text + "', null)";
                Add(command);
                sotrName.Clear();
                sotrDol.Clear();
            }
        }

        private void newspAdd_Click(object sender, EventArgs e)
        {
            if (newspNumber.Text == "" || newspPrice.Text == "" || nomKol.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                if (newspNumber.Text == "")
                    newspNumber.Focus();
                if (newspPrice.Text == "")
                    newspPrice.Focus();
                if (nomKol.Text == "")
                    nomKol.Focus();
                return;
            }
            else
            {
                string command = "insert into НомерГазеты values ('" + newspNumber.Text + "', '" + newspPrice.Text + "', '" + newspDate.Value + "', " + nomKol.Text + ")";
                Add(command);
                newspNumber.Clear();
                newspPrice.Clear();
                nomKol.Clear();
            }
        }

        private void photoAdd_Click(object sender, EventArgs e)
        {
            if (photoF.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                photoF.Focus();
                return;
            }
            else
            {
                string command = "insert into Фото values ('" + photoF.Text + "', " + photoName.SelectedValue.ToString() + ", " + photoTitle.SelectedValue.ToString() + ",'" + photoDate.Value + "')";
                Add(command);
                photoF.Clear();
            }
        }

        private void obAdd_Click(object sender, EventArgs e)
        {
            if (obText.Text == "" || obZak.Text == "" || obCat.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                if (obText.Text == "")
                    obText.Focus();
                if (obZak.Text == "")
                    obZak.Focus();
                if (obCat.Text == "")
                    obCat.Focus();
                return;
            }
            else
            {
                string command = "insert into Объявление values (" + obNumber.SelectedValue.ToString() + ", '" + obCat.Text + "', '" + obZak.Text + "','" + obText.Text + "')";
                Add(command);
                obText.Clear();
                obZak.Clear();
                obCat.Clear();
            }
        }

        private void otzAdd_Click(object sender, EventArgs e)
        {
            int i;
            if (otz.Checked)
                i = 1;
            else i = 0;
            if (otzText.Text == "" || otzName.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                if (otzText.Text == "")
                    otzText.Focus();
                if (otzName.Text == "")
                    otzName.Focus();
                return;
            }
            else
            {
                string command = "insert into Отзыв values ('" + otzName.Text + "', " + otzTitle.SelectedValue.ToString() + ", " + i + ",'" + otzText.Text + "', '" + otzDate.Value + "')";
                Add(command);
                otzText.Clear();
                otzName.Clear();
            }
        }

        public void reklAdd_Click(object sender, EventArgs e)
        {
            string command = "insert into Перечень_реклам (НомерВыпуска, ТекстРекламы) values (" + reklNumber.SelectedValue.ToString() + ", '" + reklText.SelectedValue.ToString() + "')";
            Add(command);
        }

        private void dogAdd_Click(object sender, EventArgs e)
        {
            if (dogText.Text == "" || dogPrice.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK);
                if (dogText.Text == "")
                    dogText.Focus();
                if (dogPrice.Text == "")
                    dogPrice.Focus();
                return;
            }
            else
            {
                string command = "insert into Договор values (" + dogZak.SelectedValue.ToString() + ", '" + dogDate.Value + "','" + dogDateB.Value + "', '" + dogDateE.Value + "', " + dogPrice.Text + ",'" + dogText.Text + "')";
                Add(command);
                dogText.Clear();
                dogPrice.Clear();
            }
        }

        private void otzNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string com1 = "";
                    com1 = "select Код, Заголовок from Статья where КодВыпуска=" + otzNumber.SelectedValue.ToString();
                    combBox(otzTitle, "Статья", "Заголовок", com1, connection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void photoNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string com1 = "";
                    com1 = "select Код, Заголовок from Статья where КодВыпуска=" + photoNumber.SelectedValue.ToString();
                    combBox(photoTitle, "Статья", "Заголовок", com1, connection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Dog_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Договор", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
               
            }
        }

        private void Nom_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("НомерГазеты", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                
            }
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Статья", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
               
            }
        }

        private void Zak_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Заказчик", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                
            }
        }

        private void Rubr_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Рубрика", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                
            }
        }

        private void Sotr_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Сотрудник", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                
            }
        }

        private void dogPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(".")) | e.KeyChar == '\b')
                return;
            else
                e.Handled = true;
        }
    }
}
