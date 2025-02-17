﻿using System;
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
    public partial class MainEdit : Form
    {
        SqlCredential cred;
        string curTable;
        bool view;
        string log;
        string role;
        string cur;
        bool chit = false;
        bool zur = false;      
        bool first = true;
        string ulog;
        string command="";
        string comm="";
        SqlCommand sqlCom = new SqlCommand();
        public MainEdit(string l, string currTable, SqlCredential credd, bool v, string r, string login)
        {
            InitializeComponent();
            curTable = currTable;
            cred = credd;
            view = v;
            role = r;
            if (String.Compare(r, "читатель") == 0)
                chit = true;
            if (String.Compare(r, "журналист") == 0)
                zur = true;
            log = login;
            ulog = "";
            int i = 0;
            foreach (char c in log)
            {
                if (Char.IsUpper(c))
                    i++;
                if (i == 2)
                {
                    ulog += " ";
                    ulog += c;
                    ulog += ".";
                    continue;
                }
                ulog += c;
            }
            ulog += ".";
            label46.Text = l;
        }

        public void edit(string tableName)
        {
            switch (tableName)
            {
                case "Статья":
                    {
                        dataGridView1.Columns["ФИОСотрудника"].ReadOnly = true;
                        dataGridView1.Columns["НомерВыпуска"].ReadOnly = true;
                        dataGridView1.Columns["НазваниеРубрики"].ReadOnly = true;                        
                    }
                    break;
                case "Договор":
                    dataGridView1.Columns["НазваниеЗаказчика"].ReadOnly = true;
                    break;
                case "Реклама":
                    {
                        dataGridView1.Columns["ТекстРекламы"].ReadOnly = true;
                        dataGridView1.Columns["НомерВыпуска"].ReadOnly = true;
                    }
                    break;
                case "Объявление":
                    {
                        dataGridView1.Columns["НомерВыпуска"].ReadOnly = true;
                        if (chit)
                            dataGridView1.Columns["Заказчик"].ReadOnly = true;
                    }
                    break;
                case "Фото":
                    {
                        dataGridView1.Columns["ФИОСотрудника"].ReadOnly = true;
                        dataGridView1.Columns["ЗаголовокСтатьи"].ReadOnly = true;
                    }
                    break;
                case "Отзыв":
                    dataGridView1.Columns["ЗаголовокСтатьи"].ReadOnly = true;
                    if (chit)
                        dataGridView1.Columns["ФИО"].ReadOnly = true;
                    break;
            }

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string ulog = "";
            int i1 = 0;
            foreach (char c in log)
            {
                if (Char.IsUpper(c))
                    i1++;
                if (i1 == 2)
                {
                    ulog += " ";
                    ulog += c;
                    ulog += ".";
                    continue;
                }
                ulog += c;
            }
            ulog += ".";
            string s = "";
            if (curTable == "Отзыв")
                s = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["ФИО"].Value.ToString();
            if (curTable == "Объявление")
                s = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Заказчик"].Value.ToString();
            if (curTable == "Статья" || curTable == "Фото")
                s = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["ФИОСотрудника"].Value.ToString();
            if (curTable != "Сотрудник" || (curTable == "Сотрудник" && dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["ДатаУвольнения"].Value.ToString() == ""))
            {
                if ((!chit || (chit && String.Compare(log, s) == 0)) && (!zur || (zur && String.Compare(ulog, s) == 0)))
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
                            string command = "";
                            int i = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Код"].Value);
                            if (!view)
                                command = "delete from " + curTable + " where Код=" + i;
                            else
                                command = "delete from Перечень_реклам where Код=" + i;
                            DialogResult result;
                            if (curTable != "Договор")
                                result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Удаление записи", MessageBoxButtons.YesNo);
                            else
                                result = MessageBox.Show("Вы уверены, что хотите расторгнуть договор?\nЭто приведёт к удалению всех размещений реклам по этому договору", "Удаление записи", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                if (curTable == "Сотрудник")
                                {
                                    e.Cancel = true;
                                    SqlCommand myCommand = new SqlCommand(command, connection);
                                    int number = myCommand.ExecuteNonQuery();
                                    string command1 = "select Код, ФИО, Должность, ДатаПоступления, ДатаУвольнения from Сотрудник order by Код desc";
                                    SqlCommand myCommand1 = new SqlCommand(command1, connection);
                                    SqlDataReader dr = myCommand1.ExecuteReader();
                                    DataTable dt = new DataTable();
                                    dt.Load(dr);
                                    dataGridView1.DataSource = dt.DefaultView;
                                    dataGridView1.Columns["Код"].Visible = false;
                                }
                                else
                                {
                                    SqlCommand myCommand = new SqlCommand(command, connection);
                                    int number = myCommand.ExecuteNonQuery();
                                }

                            }
                            if (result == DialogResult.No)
                            {
                                e.Cancel = true;
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            e.Cancel = true;
                        }
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                    string command = "";
                    int i = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Код"].Value);
                    int c = dataGridView1.CurrentCell.ColumnIndex;
                    string col = dataGridView1.Columns[c].HeaderText;
                    if (!view)
                        command = "update " + curTable + " set " + col + "='" + dataGridView1.CurrentCell.Value.ToString() + "' where Код=" + i;
                    else
                        command = "update Перечень_реклам set " + col + "='" + dataGridView1.CurrentCell.Value.ToString() + "' where Код=" + i;
                    SqlCommand myCommand = new SqlCommand(command, connection);
                    int number = myCommand.ExecuteNonQuery();                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dataGridView1.CurrentCell.Value = cur;
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
          
            if (String.Compare(curTable, "Сотрудник") == 0 && e.ColumnIndex == 4)
            {
            }
            else
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    ((DataGridView)sender).CancelEdit();
                }         
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {            
            sqlCom.CommandText = "";
            Filter filterDialog;
            if (!chit && !zur)
                filterDialog = new Filter();
            else
                filterDialog = new Filter(checkBox2.Checked, curTable, log);
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
                            if (!zur)
                                filterDialog.listBox1.Items.Add("ФИО сотрудника");
                            if (!zur)
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
                            if (!zur)
                                filterDialog.listBox1.Items.Add("ФИО сотрудника");
                        }
                        break;
                    case "Отзыв":
                        {
                            filterDialog.listBox1.Items.Add("Жалоба или похвальный отзыв");
                            if (!chit)
                                filterDialog.listBox1.Items.Add("Номер выпуска и заголовок статьи");
                            if (chit)
                                filterDialog.listBox1.Items.Add("Номер выпуска газеты");
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
                            if (!zur && !chit)
                            {                               
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
                                sqlCom.CommandText = filterDialog.command.CommandText;
                            }
                            else
                            {
                                SqlCommand command = new SqlCommand(filterDialog.sql, connection);
                                SqlDataReader dr = command.ExecuteReader();
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                dataGridView1.DataSource = dt.DefaultView;
                                dataGridView1.Columns["Код"].Visible = false;
                                changeFilter.Visible = true;
                                richTextBox1.Visible = true;
                                richTextBox1.Text =  filterDialog.list + "\n" + filterDialog.list2;
                                sqlCom.CommandText = command.CommandText;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                    checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = false;
                if (!zur && !chit)
                    richTextBox1.Clear();
                if ((zur || chit) && checkBox2.Checked) 
                    richTextBox1.Text = "ФИОСотрудника = " + ulog; 
                changeFilter.Visible = false;
                exec(sender,e);          
            }
            
        }

        public void combBox(ComboBox cb, string table, string dispMember, string com1, SqlConnection connection, string valM = "Код")
        {
            
            SqlDataAdapter da2 = new SqlDataAdapter(com1, connection);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, table);
            cb.DisplayMember = dispMember;
            if (valM is null)
                cb.ValueMember = dispMember;
            else
                cb.ValueMember = "Код";
            cb.DataSource = ds2.Tables[table];
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ulog = "";
            int i1 = 0;
            foreach (char c in log)
            {
                if (Char.IsUpper(c))
                    i1++;
                if (i1 == 2)
                {
                    ulog += " ";
                    ulog += c;
                    ulog += ".";
                    continue;
                }
                ulog += c;
            }
            ulog += ".";
            if (e.RowIndex != -1)
            {
                Edit modalDialog = new Edit();
                bool show = false;
                string colName = "";
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=newspaper";
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
                        switch (curTable)
                        {
                            case "Статья":
                                {
                                    if (!zur || (zur && String.Compare(ulog, dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["ФИОСотрудника"].Value.ToString()) == 0))
                                        switch (e.ColumnIndex)
                                        {
                                            case 4:
                                                {
                                                    if (!zur)
                                                    {
                                                        show = true;
                                                        modalDialog.label1.Text = "ФИО сотрудника";
                                                        colName = "КодСотрудника";
                                                        com1 = "select Код, ФИО from Сотрудник";
                                                        combBox(modalDialog.comboBox1, "Сотрудник", "ФИО", com1, connection, "1");
                                                    }
                                                }
                                                break;
                                            case 5:
                                                {
                                                    show = true;
                                                    modalDialog.label1.Text = "Номер выпуска";
                                                    colName = "КодВыпуска";
                                                    com1 = "select Код, Номер from НомерГазеты";
                                                    combBox(modalDialog.comboBox1, "НомерГазеты", "Номер", com1, connection, "1");
                                                }
                                                break;
                                            case 2:
                                                {
                                                    show = true;
                                                    modalDialog.label1.Text = "Название рубрики";
                                                    colName = "КодРубрики";
                                                    com1 = "select Код, Название from Рубрика";
                                                    combBox(modalDialog.comboBox1, "Рубрика", "Название", com1, connection, "1");
                                                }
                                                break;
                                        }
                                }
                                break;
                            case "Договор":
                                {
                                    switch (e.ColumnIndex)
                                    {
                                        case 1:
                                            {
                                                show = true;
                                                modalDialog.label1.Text = "Название заказчика";
                                                colName = "КодЗаказчика";
                                                com1 = "select Код, Название from Заказчик";
                                                combBox(modalDialog.comboBox1, "Заказчик", "Название", com1, connection, "1");
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "Реклама":
                                {
                                    switch (e.ColumnIndex)
                                    {
                                        case 1:
                                            {
                                                show = true;
                                                modalDialog.label1.Text = "Номер выпуска";
                                                colName = "КодВыпуска";
                                                com1 = "select Код, Номер from НомерГазеты";
                                                combBox(modalDialog.comboBox1, "НомерГазеты", "Номер", com1, connection, "1");
                                            }
                                            break;
                                        case 2:
                                            {
                                                show = true;
                                                modalDialog.label1.Text = "Текст рекламы";
                                                colName = "КодДоговора";
                                                com1 = "select Код, ТекстРекламы from Договор";
                                                combBox(modalDialog.comboBox1, "Догoвор", "ТекстРекламы", com1, connection, "1");
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "Объявление":
                                {
                                    if (!chit || (chit && String.Compare(log, dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Заказчик"].Value.ToString()) == 0))
                                        switch (e.ColumnIndex)
                                        {
                                            case 1:
                                                {
                                                    show = true;
                                                    modalDialog.label1.Text = "Номер выпуска";
                                                    colName = "КодВыпуска";
                                                    com1 = "select Код, Номер from НомерГазеты";
                                                    combBox(modalDialog.comboBox1, "НомерГазеты", "Номер", com1, connection, "1");
                                                }
                                                break;
                                        }
                                }
                                break;
                            case "Фото":
                                {
                                    if (!zur || (zur && String.Compare(ulog, dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["ФИОСотрудника"].Value.ToString()) == 0))
                                        switch (e.ColumnIndex)
                                        {
                                            case 2:
                                                {
                                                    if (!zur)
                                                    {
                                                        show = true;
                                                        modalDialog.label1.Text = "ФИО сотрудника";
                                                        colName = "КодСотрудника";
                                                        com1 = "select Код, ФИО from Сотрудник";
                                                        combBox(modalDialog.comboBox1, "Сотрудник", "ФИО", com1, connection, "1");
                                                    }
                                                }
                                                break;
                                            case 3:
                                                {
                                                    show = true;
                                                    modalDialog.label1.Text = "Заголовок статьи";
                                                    colName = "КодСтатьи";
                                                    com1 = "select Код, Заголовок from Статья";
                                                    combBox(modalDialog.comboBox1, "Статья", "Заголовок", com1, connection, "1");
                                                }
                                                break;
                                        }

                                }
                                break;
                            case "Отзыв":
                                {
                                    if (!chit || (chit && String.Compare(log, dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["ФИО"].Value.ToString()) == 0))
                                        switch (e.ColumnIndex)
                                        {
                                            case 2:
                                                {
                                                    show = true;
                                                    modalDialog.label1.Text = "Заголовок статьи";
                                                    colName = "КодСтатьи";
                                                    com1 = "select Код, Заголовок from Статья";
                                                    combBox(modalDialog.comboBox1, "Статья", "Заголовок", com1, connection, "1");
                                                }
                                                break;
                                        }
                                }
                                break;
                        }
                        if (show)
                        {
                            if (modalDialog.ShowDialog(this) == DialogResult.OK)
                            {

                                int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Код"].Value);
                                int c = e.ColumnIndex;
                                string col = dataGridView1.Columns[c].HeaderText;
                                com1 = "update " + curTable + " set " + colName + "=" + modalDialog.comboBox1.SelectedValue.ToString() + " where Код=" + i;
                                SqlCommand myCommand = new SqlCommand(com1, connection);
                                int number = myCommand.ExecuteNonQuery();
                            }
                            exec(sender,e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            foreach (var item in checkedListBox1.Items)
            {
                if (!checkedListBox1.GetItemChecked(k))
                    dataGridView1.Columns[item.ToString()].Visible = false;
                if (checkedListBox1.GetItemChecked(k))
                    dataGridView1.Columns[item.ToString()].Visible = true;
                k++;
            }
        }

        private void MainEdit_Shown(object sender, EventArgs e)
        {
            label46.Visible = true;
            checkBox1.Checked = false;
            richTextBox1.Visible = false;
            changeFilter.Visible = false;
            label47.Visible = true;
            checkedListBox1.Enabled = true;  
            checkedListBox1.Items.Clear();
            if ((chit || zur) && first)
            {
               // checkBox1.Visible = false;
                checkBox2.Visible = true;
                changeFilter.Visible = false;
                checkBox2.Checked = true;
                checkedListBox1.Visible = false;
                label47.Visible = false;
                button2.Visible = false;
                switch (curTable)
                {
                    case "Статья":
                        checkBox2.Text = "Статьи сотрудника";
                        break;
                    case "Отзыв":
                        checkBox2.Text = "Отзывы читателя";
                        break;
                    case "Объявление":
                        checkBox2.Text = "Объявления читателя";
                        break;
                    case "Фото":
                        checkBox2.Text = "Фото сотрудника";
                        break;
                }
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
                        this.Location = new Point(400, 100);
                        switch (curTable)
                        {
                            case "Статья":
                                checkBox1.Visible = true;
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                command = "select * from Перечень_статей order by Код desc";
                                dataGridView1.Size = new System.Drawing.Size(1120, 332);
                                this.Size = new Size(1135, 641);
                                this.Location = new Point(300, 100);
                                break;
                            case "Заказчик":
                                command = "select * from Заказчик order by Код desc";
                                checkBox1.Visible = false;
                                checkedListBox1.Enabled = false;
                                checkedListBox1.Visible = true;
                                button2.Visible = false;
                                dataGridView1.Size = new System.Drawing.Size(327, 332);
                                this.Size = new Size(450, 332);
                                this.Location = new Point(600, 100);
                                break;
                            case "Договор":
                                checkBox1.Visible = true;
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                command = "select Договор.Код as Код, Название as НазваниеЗаказчика, ДатаДоговора, ДатаНачала, ДатаКонца, ЦенаРазмещения, ТекстРекламы " +
                                          "from Заказчик, Договор " +
                                          "where КодЗаказчика=Заказчик.Код order by Код desc";
                                dataGridView1.Size = new System.Drawing.Size(1300, 332);
                                this.Size = new Size(1315, 641);
                                this.Location = new Point(150, 100);
                                break;
                            case "Реклама":
                                checkBox1.Visible = true;
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                view = true;
                                command = "select * from Перечень_реклам order by Код desc";
                                dataGridView1.Size = new System.Drawing.Size(670, 332);
                                this.Size = new Size(685, 641);
                                this.Location = new Point(400, 100);
                                break;
                            case "Рубрика":
                                command = "select Код, Название from Рубрика order by Код desc";
                                checkedListBox1.Enabled = false;
                                checkedListBox1.Visible = false;
                                checkBox1.Visible = false;
                                button2.Visible = false;
                                dataGridView1.Size = new System.Drawing.Size(171, 332);
                                this.Size = new Size(400, 332);
                                this.Location = new Point(600, 100);
                                break;
                            case "Сотрудник":
                                checkBox1.Visible = true;
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                command = "select Код, ФИО, Должность, ДатаПоступления, ДатаУвольнения from Сотрудник order by Код desc";
                                dataGridView1.Size = new System.Drawing.Size(711, 332);
                                this.Size = new Size(726, 641);
                                this.Location = new Point(450, 100);
                                break;
                            case "НомерГазеты":
                                checkBox1.Visible = true;
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                command = "select Код, Номер, Ценa, Дата, КоличествоПроданных from НомерГазеты order by Код desc";
                                dataGridView1.Size = new System.Drawing.Size(520, 332);
                                this.Size = new Size(535, 641);
                                this.Location = new Point(500, 100);
                                break;
                            case "Объявление":
                                checkBox1.Visible = true;
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                command = "select Объявление.Код as Код, Номер as НомерВыпуска, Категория, Заказчик, Текст " +
                                              "from НомерГазеты, Объявление " +
                                              "where НомерГазеты.Код=КодВыпуска order by Код desc";
                                dataGridView1.Size = new System.Drawing.Size(940, 332);
                                this.Size = new Size(955, 641);
                                break;
                            case "Фото":
                                checkBox1.Visible = true;
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                command = "select * from Перечень_фото order by Код desc";
                                dataGridView1.Size = new System.Drawing.Size(887, 332);
                                this.Size = new Size(900, 645);
                                
                                break;
                            case "Отзыв":
                                checkBox1.Visible = true;
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                command = "select Отзыв.Код as Код, ФИО, Заголовок as ЗаголовокСтатьи, Жалоба, Текст, ДатаОтзыва " +
                                          "from Отзыв, Статья " +
                                          "where КодСтатьи=Статья.Код order by Код desc";
                                dataGridView1.Size = new System.Drawing.Size(1480, 332);
                                this.Size = new Size(1495, 641);
                                this.Location = new Point(20, 100);
                                break;
                        }
                        SqlCommand myCommand = new SqlCommand(command, connection);
                        comm = myCommand.CommandText;
                        SqlDataReader dr = myCommand.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt.DefaultView;
                        int i = 0;
                        if (checkedListBox1.Visible == true)
                        {
                            SqlDataAdapter da2 = new SqlDataAdapter(command, connection);
                            DataTable result = new DataTable();
                            da2.Fill(result);
                            foreach (DataColumn item in result.Columns)
                            {
                                checkedListBox1.Items.Add(item.ColumnName);
                                checkedListBox1.SetItemChecked(i, true);
                                i++;
                            }
                            checkedListBox1.Items.Remove("Код");
                            foreach (var item in checkedListBox1.Items)
                            {
                                dataGridView1.Columns[item.ToString()].Visible = true;
                            }
                        }
                        dataGridView1.Columns["Код"].Visible = false;
                        if (curTable == "Сотрудник")
                        {
                            dataGridView1.Columns["ДатаПоступления"].ReadOnly = true;
                            dataGridView1.Columns["ДатаУвольнения"].ReadOnly = true;
                        }
                        if (curTable == "Заказчик")
                        {
                            dataGridView1.Columns["СуммаПоРекламе"].ReadOnly = true;
                        }
                        edit(curTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void exec(object sender, EventArgs e)
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
                    if (!(sqlCom.CommandText == ""))
                    {
                        sqlCom.Connection = connection;
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt.DefaultView;
                        dataGridView1.Columns["Код"].Visible = false;
                    }
                    else
                    {
                        sqlCom.CommandText = comm;
                        sqlCom.Connection = connection;
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt.DefaultView;
                        dataGridView1.Columns["Код"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ulog = "";
            int i = 0;
            foreach (char c in log)
            {
                if (Char.IsUpper(c))
                    i++;
                if (i == 2)
                {
                    ulog += " ";
                    ulog += c;
                    ulog += ".";
                    continue;
                }
                ulog += c;
            }
            ulog += ".";
            string s = "";
            switch (curTable)
            {
                case "Отзыв":
                    if (chit)
                    {
                        s = dataGridView1.Rows[e.RowIndex].Cells["ФИО"].Value.ToString();
                        if (String.Compare(s, log) != 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                        }                           
                    }
                    break;
                case "Объявление":
                    if (chit)
                    {
                        s = dataGridView1.Rows[e.RowIndex].Cells["Заказчик"].Value.ToString();
                        if (String.Compare(s, log) != 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                        }
                    }
                    break;
                case "Статья":
                    if (zur)
                    {
                        s = dataGridView1.Rows[e.RowIndex].Cells["ФИОСотрудника"].Value.ToString();
                        if (String.Compare(s, ulog) != 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                        }
                    }
                    break;
                case "Фото":
                    if (zur)
                    {
                        s = dataGridView1.Rows[e.RowIndex].Cells["ФИОСотрудника"].Value.ToString();
                        if (String.Compare(s, ulog) != 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                        }
                    }
                    break;
                }
            
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            first = false;
            if (checkBox2.Checked)
            {
                richTextBox1.Visible = true;
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
                        string command = "";
                        switch (curTable)
                        {
                            case "Отзыв":
                                command = "select Отзыв.Код, ФИО, Заголовок as ЗаголовокСтатьи, Жалоба, Текст, ДатаОтзыва " +
                                          "from Отзыв, Статья " +
                                          "where КодСтатьи=Статья.Код and ФИО='" + log + "' order by Отзыв.Код desc";
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                dataGridView1.Size = new System.Drawing.Size(960, 194);
                                richTextBox1.Text = "ФИО = " + log;
                                break;
                            case "Объявление":
                                command = "select Объявление.Код, Номер as НомерВыпуска, Категория, Заказчик, Текст " +
                                          "from НомерГазеты, Объявление " +
                                          "where НомерГазеты.Код=КодВыпуска and Заказчик='" + log + "' order by Код desc";
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                dataGridView1.Size = new System.Drawing.Size(700, 194);
                                richTextBox1.Text = "Заказчик = " + log;
                                break;
                            case "Статья":
                                command = "select * from Перечень_статей where ФИОСотрудника='" + ulog + "' order by Код desc";
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                dataGridView1.Size = new System.Drawing.Size(1120, 332);
                                this.Size = new Size(1135, 641);
                                richTextBox1.Text = "ФИОСотрудника = " + ulog;
                                break;
                            case "Фото":
                                command = "select * from Перечень_фото where ФИОСотрудника='" + ulog + "' order by Код desc";
                                checkedListBox1.Visible = true;
                                button2.Visible = true;
                                dataGridView1.Size = new System.Drawing.Size(640, 194);
                                richTextBox1.Text = "ФИОСотрудника = " + ulog;
                                break;
                        }
                        SqlCommand myCommand = new SqlCommand(command, connection);
                        sqlCom.CommandText = myCommand.CommandText;
                        comm = myCommand.CommandText;
                        SqlDataReader dr = myCommand.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt.DefaultView;
                        dataGridView1.Columns["Код"].Visible = false;
                        edit(curTable);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                MainEdit_Shown(sender, e);
        
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Для удаления выделите строку и нажмите del \nДля редактирования нажмите на ячейку и введите новые данные", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cur = dataGridView1.CurrentCell.Value.ToString();
        }

        private void MainEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Opacity = 100;
            Owner.Enabled = true;
        }

    }
}
