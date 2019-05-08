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
        string lbl;
        public SqlCredential cred;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Authorization aut = this.Owner as Authorization;
            aut.ex = false;
            role = aut.role;
            aut.pwd.MakeReadOnly();
            cred = new SqlCredential(aut.login, aut.pwd);
            if (aut != null)
            {
                if (aut.login == "reader")
                    loginToolStripMenuItem.Text = aut.fio;
                else
                    loginToolStripMenuItem.Text = aut.login;
            }
            switch (role)
            {
                case "системный администратор":
                    admView.Visible = true;
                    admView.Nodes[0].Expand();
                    admView.Nodes[1].Expand();
                    admView.Nodes[2].Expand();
                    admView.Nodes[3].Expand();
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

        private void Edit(string cT, bool view)
        {
            MainEdit edit = new MainEdit(lbl, cT, cred, view, role, loginToolStripMenuItem.Text);
            this.Opacity = 0;
            this.Enabled = false;
            edit.Owner = this;
            if (edit.ShowDialog(this) == DialogResult.OK)
            {
                this.Opacity = 100;
                this.Enabled = true;
            }
        }

        private void Add(string cT)
        {
            MainAdd add = new MainAdd(lbl, cT, cred, role, loginToolStripMenuItem.Text);
            this.Opacity = 0;
            this.Enabled = false;
            add.Owner = this;
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                this.Opacity = 100;
                this.Enabled = true;
            }
            
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int k = e.Node.Level;
            lbl = e.Node.Text;
            if (k != 0)
                switch (e.Node.Parent.Name)
                {
                    case "Статья":
                        if (e.Node.Name == "addSt")
                        {
                            
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edSt")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Заказчик":
                        if (e.Node.Name == "addZ")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edZ")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Договор":
                        if (e.Node.Name == "addD")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edD")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Реклама":
                        if (e.Node.Name == "addRekl")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edRekl")
                        {
                            Edit(e.Node.Parent.Name, true);
                        }
                        break;
                    case "Рубрика":
                        if (e.Node.Name == "addR")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edR")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Сотрудник":
                        if (e.Node.Name == "addSotr")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edSotr")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "НомерГазеты":
                        if (e.Node.Name == "addNom")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edNom")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Объявление":
                        if (e.Node.Name == "addOb")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edOb")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Фото":
                        if (e.Node.Name == "addF")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edF")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Отзыв":
                        if (e.Node.Name == "addOtz")
                        {
                            Add(e.Node.Parent.Name);
                        }
                        if (e.Node.Name == "edOtz")
                        {
                            Edit(e.Node.Parent.Name, false);
                        }
                        break;
                    case "Админ":
                        {
                            if (e.Node.Name == "addUser")
                            {
                                Add(e.Node.Parent.Name);
                            }
                            if (e.Node.Name == "zurnal")
                            {
                                ИсторияИзмененияToolStripMenuItem_Click(sender, e);
                            }
                        }
                        break;
                }
        }

        private void СменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner.Close();
            this.Close();
            Authorization aut = new Authorization();
            aut.Show();
        }

        private void ВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ИсторияИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log logForm = new Log();
            this.Opacity = 0;
            this.Enabled = false;
            logForm.Owner = this;
            if (logForm.ShowDialog(this) == DialogResult.Cancel)
            {
                this.Opacity = 100;
                this.Enabled = true;
                logForm.Close();
            }
        }

        private void ФунционалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func funcForm = new Func();
            this.Opacity = 0;
            this.Enabled = false;
            funcForm.Owner = this;
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
                this.Opacity = 100;
                this.Enabled = true;
                funcForm.Close();
            }
        }

        private void ОтчётПоРекламеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports("Отчёт по рекламе");
            if (rep.ShowDialog(this) == DialogResult.Cancel)
            {
                rep.Close();
            }
        }

        private void ОтчётПоСтатьямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports("Отчёт по статьям");
            if (rep.ShowDialog(this) == DialogResult.Cancel)
            {
                rep.Close();
            }
        }

        private void ГодовойОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports("Годовой отчёт");
            if (rep.ShowDialog(this) == DialogResult.Cancel)
            {
                rep.Close();
            }
        }
    } 
}
