namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Добавить рубрику");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Изменить/удалить существующую");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Раздел рубрик", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Добавить выпуск газеты");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Редактировать или удалить выпуск");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Раздел выпусков", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Добавить статью в выпуск");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Изменить или удалить статью");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Раздел статей", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Добавить снимок в статью");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Удалить или редактировать данные о фото");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Раздел фотогрфий", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Редакция газеты", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Написать отзыв на статью");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Редактировать или удалить отзыв");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Отзывы", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Добавить объявление в выпуск");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Редактировать или удалить объявление");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Объявления", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Работа с читателями", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Добавить заказчика");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Редактировать данные или удалить заказчика");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Заказчики", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Заключить договор");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Изменить условия или расторгнуть договор");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Договоры", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Разместить рекламу в выпуске");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Редактировать данные или убрать рекламу");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Размещение рекламы", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Рекламный отдел", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode26,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Нанять сотрудника");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Уволить или поменять данные");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Отдел кадров", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фунционалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label48 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.фунционалToolStripMenuItem,
            this.работаСТаблицамиToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(780, 29);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(185, 25);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.СменитьПользователяToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // фунционалToolStripMenuItem
            // 
            this.фунционалToolStripMenuItem.Name = "фунционалToolStripMenuItem";
            this.фунционалToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.фунционалToolStripMenuItem.Text = "Фунционал";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяИзмененияToolStripMenuItem});
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(166, 25);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            // 
            // историяИзмененияToolStripMenuItem
            // 
            this.историяИзмененияToolStripMenuItem.Name = "историяИзмененияToolStripMenuItem";
            this.историяИзмененияToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.историяИзмененияToolStripMenuItem.Text = "История изменения  ";
            this.историяИзмененияToolStripMenuItem.Click += new System.EventHandler(this.ИсторияИзмененияToolStripMenuItem_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.Location = new System.Drawing.Point(18, 4);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(67, 20);
            this.label48.TabIndex = 63;
            this.label48.Text = "label48";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(0, 32);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "addR";
            treeNode1.Text = "Добавить рубрику";
            treeNode2.Name = "edR";
            treeNode2.Text = "Изменить/удалить существующую";
            treeNode3.Name = "Рубрика";
            treeNode3.Text = "Раздел рубрик";
            treeNode4.Name = "addNom";
            treeNode4.Text = "Добавить выпуск газеты";
            treeNode5.Name = "edNom";
            treeNode5.Text = "Редактировать или удалить выпуск";
            treeNode6.Name = "НомерГазеты";
            treeNode6.Text = "Раздел выпусков";
            treeNode7.Name = "addSt";
            treeNode7.Text = "Добавить статью в выпуск";
            treeNode8.Name = "edSt";
            treeNode8.Text = "Изменить или удалить статью";
            treeNode9.Name = "Статья";
            treeNode9.Text = "Раздел статей";
            treeNode10.Name = "addF";
            treeNode10.Text = "Добавить снимок в статью";
            treeNode11.Name = "edF";
            treeNode11.Text = "Удалить или редактировать данные о фото";
            treeNode12.Name = "Фото";
            treeNode12.Text = "Раздел фотогрфий";
            treeNode13.Name = "Узел0";
            treeNode13.Text = "Редакция газеты";
            treeNode14.Name = "addOtz";
            treeNode14.Text = "Написать отзыв на статью";
            treeNode15.Name = "edOb";
            treeNode15.Text = "Редактировать или удалить отзыв";
            treeNode16.Name = "Отзыв";
            treeNode16.Text = "Отзывы";
            treeNode17.Name = "addOb";
            treeNode17.Text = "Добавить объявление в выпуск";
            treeNode18.Name = "edOtz";
            treeNode18.Text = "Редактировать или удалить объявление";
            treeNode19.Name = "Объявление";
            treeNode19.Text = "Объявления";
            treeNode20.Name = "Узел14";
            treeNode20.Text = "Работа с читателями";
            treeNode21.Name = "addZ";
            treeNode21.Text = "Добавить заказчика";
            treeNode22.Name = "edZ";
            treeNode22.Text = "Редактировать данные или удалить заказчика";
            treeNode23.Name = "Заказчик";
            treeNode23.Text = "Заказчики";
            treeNode24.Name = "addD";
            treeNode24.Text = "Заключить договор";
            treeNode25.Name = "edD";
            treeNode25.Text = "Изменить условия или расторгнуть договор";
            treeNode26.Name = "Договор";
            treeNode26.Text = "Договоры";
            treeNode27.Name = "addRekl";
            treeNode27.Text = "Разместить рекламу в выпуске";
            treeNode28.Name = "edRekl";
            treeNode28.Text = "Редактировать данные или убрать рекламу";
            treeNode29.Name = "Реклама";
            treeNode29.Text = "Размещение рекламы";
            treeNode30.Name = "Узел22";
            treeNode30.Text = "Рекламный отдел";
            treeNode31.Name = "addSotr";
            treeNode31.Text = "Нанять сотрудника";
            treeNode32.Name = "edSotr";
            treeNode32.Text = "Уволить или поменять данные";
            treeNode33.Name = "Сотрудник";
            treeNode33.Text = "Отдел кадров";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode20,
            treeNode30,
            treeNode33});
            this.treeView1.Size = new System.Drawing.Size(489, 772);
            this.treeView1.TabIndex = 66;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(780, 802);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фунционалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяИзмененияToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
    }
}

