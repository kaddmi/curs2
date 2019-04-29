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
    public partial class Form1 : Form
    {
        string role;
        public SqlCredential cred;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Authorization aut = this.Owner as Authorization;
            role = aut.role;
            aut.pwd.MakeReadOnly();
            cred = new SqlCredential(aut.login, aut.pwd);
            if (aut != null)
            {
                if (aut.login == "читатель")
                    loginToolStripMenuItem.Text = aut.fio;
                else
                    loginToolStripMenuItem.Text = aut.login;
            }
            switch (role)
            {
                case "системный администратор":
                    работаСТаблицамиToolStripMenuItem.Visible = true;
                    admView.Visible = true;
                    admView.Nodes[0].Expand();
                    admView.Nodes[1].Expand();
                    admView.Nodes[2].Expand();
                    break;
                case "главный редактор":
                    redView.Visible = true;
                    redView.Nodes[0].Expand();

                    break;
                case "журналист":
                    zurView.Visible = true;
                    zurView.Nodes[0].Expand();
                    break;
                case "читатель":
                    chitView.Visible = true;
                    chitView.Nodes[0].Expand();
                    break;
                case "специалист по кадрам":
                    kadrView.Visible = true;
                    kadrView.Nodes[0].Expand();
                    break;
                case "работник рекламного отдела":
                    reklView.Visible = true;
                    reklView.Nodes[0].Expand();
                    break;
            }                     
        }

        private void edit(string cT, bool view)
        {
            MainEdit edit = new MainEdit(cT, cred, view, role, loginToolStripMenuItem.Text);
            if (edit.ShowDialog(this) == DialogResult.OK)
            {
                //add.Close();
            }
        }

        private void add(string cT)
        {
            MainAdd add = new MainAdd(cT, cred, role, loginToolStripMenuItem.Text);
            if (add.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int k = e.Node.Level;
            if (k != 0)
                switch (e.Node.Parent.Name)
                {
                    case "Статья":
                        if (e.Node.Name == "addSt")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edSt")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Заказчик":
                        if (e.Node.Name == "addZ")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edZ")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Договор":
                        if (e.Node.Name == "addD")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edD")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Реклама":
                        if (e.Node.Name == "addRekl")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edRekl")
                        {
                            edit(e.Node.Parent.Name, true);
                        }
                        break;
                    case "Рубрика":
                        if (e.Node.Name == "addR")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edR")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Сотрудник":
                        if (e.Node.Name == "addSotr")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edSotr")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "НомерГазеты":
                        if (e.Node.Name == "addNom")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edNom")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Объявление":
                        if (e.Node.Name == "addOb")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edOb")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Фото":
                        if (e.Node.Name == "addF")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edF")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Отзыв":
                        if (e.Node.Name == "addOtz")
                        {
                            add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edOtz")
                        {
                            edit(e.Node.Parent.Name, false);
                        }
                        break;
                }
        }

        private void СменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization aut = new Authorization();
            aut.Show();
        }

        private void ВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void ИсторияИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log logForm = new Log();
            if (logForm.ShowDialog(this) == DialogResult.Cancel)
            {
                logForm.Close();
            }
        }

        private void ФунционалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func funcForm = new Func(role);
            switch (role)
            {
                case "системный администратор":
                    funcForm.listBox1.Items.Add("Суммарная информация по статье в выпуске");
                    funcForm.listBox1.Items.Add("Количество статей сотрудника");
                    funcForm.listBox1.Items.Add("Выручка с выпусков по годам");
                    funcForm.listBox1.Items.Add("Рейтинг читателей по отзывам");
                    funcForm.listBox1.Items.Add("Сумма по договорам за период");
                    funcForm.listBox1.Items.Add("Количество объявлений по категориям");
                    funcForm.listBox1.Items.Add("Стаж работников");
                    funcForm.listBox1.Items.Add("Статистика по увольнению и найму сотрудников");
                    break;
                case "главный редактор":
                    funcForm.listBox1.Items.Add("Суммарная информация по статье в выпуске");
                    funcForm.listBox1.Items.Add("Количество статей сотрудника");
                    funcForm.listBox1.Items.Add("Выручка с выпусков по годам");
                    funcForm.listBox1.Items.Add("Рейтинг читателей по отзывам");
                    funcForm.listBox1.Items.Add("Сумма по договорам за период");
                    funcForm.listBox1.Items.Add("Количество объявлений по категориям");
                    funcForm.listBox1.Items.Add("Стаж работников");
                    funcForm.listBox1.Items.Add("Статистика по увольнению и найму сотрудников");
                    break;
                case "журналист":
                    funcForm.listBox1.Items.Add("Суммарная информация по статье в выпуске");
                    funcForm.listBox1.Items.Add("Количество статей сотрудника");
                    break;
                case "читатель":
                    funcForm.listBox1.Items.Add("Рейтинг читателей по отзывам");
                    funcForm.listBox1.Items.Add("Количество объявлений по категориям");
                    break;
                case "специалист по кадрам":
                    funcForm.listBox1.Items.Add("Количество статей сотрудника");
                    funcForm.listBox1.Items.Add("Стаж работников");
                    funcForm.listBox1.Items.Add("Статистика по увольнению и найму сотрудников");
                    break;
                case "работник рекламного отдела":
                    funcForm.listBox1.Items.Add("Сумма по договорам за период");
                    funcForm.listBox1.Items.Add("Выручка с выпусков по годам");
                    break;
            }
            if (funcForm.ShowDialog(this) == DialogResult.Cancel)
            {
                funcForm.Close();
            }
        }

        private void ОтчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports();
            if (rep.ShowDialog(this) == DialogResult.Cancel)
            {
                rep.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
    } 
}
