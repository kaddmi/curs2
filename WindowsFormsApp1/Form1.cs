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
        bool editbb;
        bool delB;
        public SqlCredential cred;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Expand();
            treeView1.Nodes[1].Expand();
            treeView1.Nodes[2].Expand();
            Authorization aut = this.Owner as Authorization;
            editbb = aut.editB;
            delB = aut.deleteB;
            aut.pwd.MakeReadOnly();
            cred = new SqlCredential(aut.login, aut.pwd);
            if (aut != null)
            {
                label48.Text = aut.login;
                
            }
        }

        private void edit(string cT, bool view)
        {
            MainEdit edit = new MainEdit(cT, cred, view, editbb, delB);
            if (edit.ShowDialog(this) == DialogResult.OK)
            {
                //add.Close();
            }
        }

        private void add(string cT)
        {
            MainAdd add = new MainAdd(cT, cred);
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                //add.Close();
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

    
    } 
}
