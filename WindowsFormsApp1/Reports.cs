using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Reports : Form
    {
        string n;
        public Reports(string name)
        {
            InitializeComponent();
            n = name;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            
            switch (n)
            {
                case "Отчёт по рекламе":
                    this.Size = new Size(864, 909);
                    XtraReport1 rep1 = new XtraReport1();
                    rep1.CreateDocument();
                    documentViewer1.DocumentSource = rep1;
                    break;
                case "Отчёт по статьям":
                    this.Size = new Size(1200, 909);
                    XtraReport2 rep2 = new XtraReport2();
                    rep2.CreateDocument();
                    documentViewer1.DocumentSource = rep2;
                    break;
                case "Годовой отчёт":
                    this.Size = new Size(1200, 909);
                    XtraReport3 rep3 = new XtraReport3();
                    rep3.CreateDocument();
                    documentViewer1.DocumentSource = rep3;
                    break;
            }
        }

    }
}
