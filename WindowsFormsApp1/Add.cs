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
    public partial class Add : Form
    {
        SqlCredential credd;
        public Add(string table, SqlCredential cred)
        {
            InitializeComponent();
            credd = cred;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                try
                {
                    connection.Open();
                    string com1 = "";
                    string com2 = "";
                    string com3 = "";
                    switch (table)
                    {
                        case "Статья":
                            {
                                stPanel.Visible = true;
                                com1 = "select Код, ФИО from Сотрудник";
                                com2 = "select Код, Номер from НомерГазеты";
                                com3 = "select Код, Название from Рубрика";
                                combBox(stNames, "Сотрудник", "ФИО", com1, connection);
                                combBox(stNumbers, "НомерГазеты", "Номер", com2, connection);
                                combBox(stR, "Рубрика", "Название", com3, connection);
                                this.AcceptButton = stAdd;
                                stType.Select();
                            }
                            break;
                        case "Заказчик":
                            zPanel.Visible = true;
                            this.AcceptButton = zAdd;
                            break;
                        case "Договор":
                            {
                                dogPanel.Visible = true;
                                dogZak.Select();
                                com1 = "select Код, Название from Заказчик";
                                combBox(dogZak, "Заказчик", "Название", com1, connection);
                                this.AcceptButton = dogAdd;
                            }
                            break;
                        case "Рубрика":
                            rPanel.Visible = true;
                            this.AcceptButton = rAdd;
                            break;
                        case "Сотрудник":
                            sotrPanel.Visible = true;
                            sotrName.Select();
                            this.AcceptButton = sotrAdd;
                            break;
                        case "НомерГазеты":
                            newspPanel.Visible = true;
                            newspNumber.Select();
                            this.AcceptButton = newspAdd;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void dogPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(".")) | e.KeyChar == '\b')
                return;
            else
                e.Handled = true;
        }
        public void combBox(ComboBox cb, string table, string dispMember, string com1, SqlConnection connection)
        {
            SqlDataAdapter da2 = new SqlDataAdapter(com1, connection);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, table);
            cb.DisplayMember = dispMember;
            cb.ValueMember = "Код";
            cb.DataSource = ds2.Tables[table];
        }

        private void Adding(string command)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Credential = credd;
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
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.RetryCancel);
                if (stTitle.Text == "")
                    stTitle.Focus();
                if (stType.Text == "")
                    stType.Focus();
                return;
            }
            else
            {
                string command = "insert into Статья values ('" + stType.Text + "', '" + stTitle.Text + "', " + stNames.SelectedValue.ToString() + ", " + stNumbers.SelectedValue.ToString() + ", " + stR.SelectedValue.ToString() + ")";
                Adding(command);
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
                Adding(command);
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
                Adding(command);
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
                string command = "insert into Сотрудник values ('" + sotrName.Text + "', '" + sotrDol.Text + "', null, null)";
                Adding(command);
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
                Adding(command);
                newspNumber.Clear();
                newspPrice.Clear();
                nomKol.Clear();
                DialogResult = DialogResult.OK;
            }
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
                Adding(command);
                dogText.Clear();
                dogPrice.Clear();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
