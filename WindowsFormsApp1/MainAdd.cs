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
        string r;
        string log;
        int k = 0;
        public bool ok = false;
        public MainAdd(string l, string currTable, SqlCredential credd, string role, string user)
        {
            InitializeComponent();
            curTable = currTable;
            cred = credd;
            r = role;
            log = user;
            label45.Text = l;
            Add();
        }

        private void Add()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;";
            SqlConnection connection = new SqlConnection(connectionString)
            {
                Credential = cred
            };
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
                                com1 = "select Код, ФИО from Сотрудник where ДатаУвольнения is null";
                                com2 = "select Код, Номер from НомерГазеты";
                                com3 = "select Код, Название from Рубрика";
                                stType.Select();
                                combBox(stNames, "Сотрудник", "ФИО", com1, connection);
                                combBox(stNumbers, "НомерГазеты", "Номер", com2, connection);
                                combBox(stR, "Рубрика", "Название", com3, connection);
                                this.AcceptButton = stAdd;
                                if (String.Compare(r, "журналист") != 0)
                                {
                                    sotr.Visible = true;
                                    nom.Visible = true;
                                    rubr.Visible = true;
                                }
                                else
                                {
                                    stPanel.Location = new Point(3, 42);
                                    this.Size = new Size(855,100);
                                }
                            }
                            break;
                        case "Заказчик":
                            zPanel.Location = new Point(3, 42);
                            zPanel.Visible = true;
                            this.AcceptButton = zAdd;
                            break;
                        case "Договор":
                            {
                             //   dogPanel.Location = new Point(401, 72);
                                dogPanel.Visible = true;
                                dogZak.Select();
                                com1 = "select Код, Название from Заказчик";
                                combBox(dogZak, "Заказчик", "Название", com1, connection);
                                zak.Visible = true;
                                this.AcceptButton = dogAdd;
                            }
                            break;
                        case "Реклама":
                            {
                              //  reklPanel.Location = new Point(401, 72);
                                reklPanel.Visible = true;
                                reklNumber.Select();
                                com1 = "select Код, Номер from НомерГазеты";
                                com2 = "select Код, Название from Заказчик where Код in (select КодЗаказчика from Договор)";
                                combBox(reklNumber, "НомерГазеты", "Номер", com1, connection, "Номер");
                                combBox(reklZak, "Заказчик", "Название", com2, connection);
                                nom.Visible = true;
                                dog.Visible = true;
                                this.AcceptButton = reklAdd;
                            }
                            break;
                        case "Рубрика":
                            rPanel.Location = new Point(3, 42);
                            rPanel.Visible = true;
                            this.AcceptButton = rAdd;
                            break;
                        case "Сотрудник":
                            sotrPanel.Location = new Point(3, 42);
                            sotrPanel.Visible = true;
                            this.AcceptButton = sotrAdd;
                            sotrName.Select();
                            break;
                        case "НомерГазеты":
                            newspPanel.Location = new Point(3, 42);
                            newspPanel.Visible = true;
                            newspNumber.Select();
                            this.AcceptButton = newspAdd;
                            break;
                        case "Объявление":
                            {
                              //  obPanel.Location = new Point(401, 72);
                                obPanel.Visible = true;
                                com1 = "select Код, Номер from НомерГазеты";
                                combBox(obNumber, "НомерГазеты", "Номер", com1, connection);
                                if (String.Compare(r, "читатель") != 0)
                                {
                                    nom.Location = new Point(3, 42);
                                    nom.Visible = true;
                                }
                                else
                                {
                                    obPanel.Location = new Point(3, 42);
                                    obZak.Text = log;
                                    this.Size = new Size(0, 0);
                                }
                                this.AcceptButton = obAdd;

                            }
                            break;
                        case "Фото":
                            {
                              //  photoPanel.Location = new Point(401, 72);
                                photoPanel.Visible = true;
                                com1 = "select Код, ФИО from Сотрудник where ДатаУвольнения is null";
                                com2 = "select Код, Номер from НомерГазеты where Код in (select КодВыпуска from Статья)";
                                combBox(photoName, "Сотрудник", "ФИО", com1, connection);
                                combBox(photoNumber, "НомерГазеты", "Номер", com2, connection);
                                if (String.Compare(r, "журналист") != 0)
                                {
                                    stat.Visible = true;
                                    sotr.Visible = true;
                                }
                                else
                                {
                                    stat.Location = new Point(3, 42);
                                    stat.Visible = true;
                                }
                                this.AcceptButton = photoAdd;

                            }
                            break;
                        case "Отзыв":
                            {
                             //   otzPanel.Location = new Point(401, 72);
                                otzPanel.Visible = true;
                                otzName.Select();
                                com1 = "select Код, Номер from НомерГазеты where Код in (select КодВыпуска from Статья)";
                                combBox(otzNumber, "НомерГазеты", "Номер", com1, connection);
                                if (String.Compare(r, "читатель")!= 0)
                                {
                                    stat.Location = new Point(3, 42);
                                    stat.Visible = true;
                                }
                                else
                                {
                                    otzPanel.Location = new Point(3, 42);
                                    otzName.Text = log;
                                    this.Size = new Size(0, 0);
                                }
                                this.AcceptButton = otzAdd;
                            }
                            break;
                        case "Админ":
                            {
                                admPanel.Location = new Point(3, 42);
                                admPanel.Visible = true;
                                this.AcceptButton = admAdd;
                                com1 = "exec sp_helprole";
                                combBox(admR, "users", "RoleName", com1, connection, "RoleName");
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
            k = 0;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;";
            SqlConnection connection = new SqlConnection(connectionString)
            {
                Credential = cred
            };
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
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.RetryCancel);
                    k = 1;
                }
            }
        }

        private void stAdd_Click(object sender, EventArgs e)
        {
            if (stType.Text == "" || stTitle.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
                if (stTitle.Text == "")
                    stTitle.Focus();
                if (stType.Text == "")
                    stType.Focus();
            }
            else
            {
                string command = "insert into Статья values ('" + stType.Text + "', '" + stTitle.Text + "', " + stNames.SelectedValue.ToString() + ", " + stNumbers.SelectedValue.ToString() + ", " + stR.SelectedValue.ToString() + ")";
                Add(command);
                stTitle.Clear();
                stType.Clear();
                DialogResult = DialogResult.OK;
            }
        }

        private void zAdd_Click(object sender, EventArgs e)
        {
            if (zakName.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
                zakName.Focus();
                return;
            }
            else
            {
                string command = "insert into Заказчик(Название) values ('" + zakName.Text + "')";
                Add(command);
                zakName.Clear();
                DialogResult = DialogResult.OK;
            }
        }

        private void rAdd_Click(object sender, EventArgs e)
        {
            if (rName.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
                rName.Focus();
                return;
            }
            else
            {
                string command = "insert into Рубрика values ('" + rName.Text + "')";
                Add(command);
                rName.Clear();
                DialogResult = DialogResult.OK;
            }
        }

        private void sotrAdd_Click(object sender, EventArgs e)
        {
            if (sotrName.Text == "" || sotrDol.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
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
                DialogResult = DialogResult.OK;
            }
        }

        private void newspAdd_Click(object sender, EventArgs e)
        {
            if (newspNumber.Text == "" || newspPrice.Text == "" || nomKol.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
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
                DialogResult = DialogResult.OK;
            }
        }

        private void photoAdd_Click(object sender, EventArgs e)
        {
            if (photoF.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
                photoF.Focus();
                return;
            }
            else
            {
                string command = "insert into Фото values ('" + photoF.Text + "', " + photoName.SelectedValue.ToString() + ", " + photoTitle.SelectedValue.ToString() + ",'" + photoDate.Value + "')";
                Add(command);
                photoF.Clear();
                DialogResult = DialogResult.OK;
            }
        }

        private void obAdd_Click(object sender, EventArgs e)
        {
            if (obText.Text == "" || obZak.Text == "" || obCat.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
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
                DialogResult = DialogResult.OK;
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
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
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
                DialogResult = DialogResult.OK;
            }
        }

        public void reklAdd_Click(object sender, EventArgs e)
        {
            string command = "insert into Перечень_реклам (НомерВыпуска, ТекстРекламы) values (" + reklNumber.SelectedValue.ToString() + ", '" + reklText.SelectedValue.ToString() + "')";
            Add(command);
            DialogResult = DialogResult.OK;
        }

        private void dogAdd_Click(object sender, EventArgs e)
        {
            if (dogText.Text == "" || dogPrice.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
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
                DialogResult = DialogResult.OK;
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
                    com1 = "select Дата from НомерГазеты where Код=" + otzNumber.SelectedValue.ToString();
                    SqlCommand sql = new SqlCommand(com1, connection);
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        otzDate.MinDate = reader.GetDateTime(0);
                        otzDate.Value = reader.GetDateTime(0);
                    }
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
                    com1 = "select Дата from НомерГазеты where Код=" + photoNumber.SelectedValue.ToString();
                    SqlCommand sql = new SqlCommand(com1, connection);
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        photoDate.MaxDate = reader.GetDateTime(0);
                        photoDate.Value = reader.GetDateTime(0);
                    }
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
                Add();
            }
        }

        private void Nom_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("НомерГазеты", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                Add();
            }
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Статья", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                Add();
            }
        }

        private void Zak_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Заказчик", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                Add();
            }
        }

        private void Rubr_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Рубрика", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                Add();
            }
        }

        private void Sotr_Click(object sender, EventArgs e)
        {
            Add addForm = new Add("Сотрудник", cred);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                Add();
            }
        }

        private void dogPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(".")) | e.KeyChar == '\b')
                return;
            else
                e.Handled = true;
        }

        private void ReklZak_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string com1 = "";
                    com1 = "select Код, ТекстРекламы from Договор where КодЗаказчика=" + reklZak.SelectedValue.ToString();
                    combBox(reklText, "Договор", "ТекстРекламы", com1, connection, "ТекстРекламы");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AdmAdd_Click(object sender, EventArgs e)
        {
            if (admLog.Text == "" ||  admp1.Text == "" || admp2.Text == "")
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
                if (admLog.Text == "")
                    admLog.Focus();               
                if (admp1.Text == "")
                    admp1.Focus();
                if (admp2.Text == "")
                    admp2.Focus();
                return;
            }
            else
            {
                if (admp1.Text != admp2.Text)
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.RetryCancel);
                    admp1.Focus();
                    return;
                }
                else
                {
                    string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;";
                    SqlConnection connection = new SqlConnection(connectionString)
                    {
                        Credential = cred
                    };
                    using (connection)
                    {
                        try
                        {
                            connection.Open();
                            string command1 = "CREATE LOGIN " + admLog.Text + " WITH PASSWORD = '" + admp1.Text + "'";
                            SqlCommand myCommand1 = new SqlCommand(command1, connection);
                            int number = myCommand1.ExecuteNonQuery();                           
                            string command3 = "CREATE USER " + admLog.Text + " FOR LOGIN " + admLog.Text;
                            SqlCommand myCommand3 = new SqlCommand(command3, connection);
                            number = myCommand3.ExecuteNonQuery();
                            string command2 = "EXEC sp_addrolemember '" + admR.SelectedValue.ToString() + "', '" + admLog.Text + "';";
                            MessageBox.Show(command2);
                            SqlCommand myCommand2 = new SqlCommand(command2, connection);
                            number = myCommand2.ExecuteNonQuery();
                            DialogResult = DialogResult.OK;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    
                }
               

            }          
        }

        private void MainAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(k == 1)
            {
                e.Cancel = true;
                k = 0;
            }               
        }

        private void MainAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Opacity = 100;
            Owner.Enabled = true;
        }
    }
}
