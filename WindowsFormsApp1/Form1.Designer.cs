﻿namespace WindowsFormsApp1
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
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Раздел фотографий", new System.Windows.Forms.TreeNode[] {
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
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Добавить заказчика");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Редактировать данные или удалить заказчика");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Заказчики", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Заключить договор");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Изменить условия или расторгнуть договор");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Договоры", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Разместить рекламу в выпуске");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Редактировать данные или убрать рекламу");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Размещение рекламы", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Рекламный отдел", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode39,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Написать отзыв на статью");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Редактировать или удалить отзыв");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Отзывы", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Добавить объявление в выпуск");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Редактировать или удалить объявление");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Объявления", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Работа с читателями", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Нанять сотрудника");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Уволить или поменять данные");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Отдел кадров", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Добавить рубрику");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Изменить/удалить существующую");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Раздел рубрик", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Добавить выпуск газеты");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Редактировать или удалить выпуск");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Раздел выпусков", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Добавить статью в выпуск");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Изменить или удалить статью");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Раздел статей", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Добавить снимок в статью");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Удалить или редактировать данные о фото");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Раздел фотографий", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Редакция газеты", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode59,
            treeNode62,
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Добавить заказчика");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Редактировать данные или удалить заказчика");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Заказчики", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Заключить договор");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Изменить условия или расторгнуть договор");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Договоры", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Разместить рекламу в выпуске");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Редактировать данные или убрать рекламу");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Размещение рекламы", new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Рекламный отдел", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode72,
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Добавить статью в выпуск");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Изменить или удалить статью");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Раздел статей", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Добавить снимок в статью");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Удалить или редактировать данные о фото");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Раздел фотографий", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Редакция газеты", new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode82});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фунционалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admView = new System.Windows.Forms.TreeView();
            this.reklView = new System.Windows.Forms.TreeView();
            this.chitView = new System.Windows.Forms.TreeView();
            this.kadrView = new System.Windows.Forms.TreeView();
            this.redView = new System.Windows.Forms.TreeView();
            this.zurView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.фунционалToolStripMenuItem,
            this.работаСТаблицамиToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(486, 29);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem1,
            this.выйтиToolStripMenuItem1});
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.loginToolStripMenuItem.Text = "login";
            // 
            // сменитьПользователяToolStripMenuItem1
            // 
            this.сменитьПользователяToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сменитьПользователяToolStripMenuItem1.Name = "сменитьПользователяToolStripMenuItem1";
            this.сменитьПользователяToolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.сменитьПользователяToolStripMenuItem1.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem1.Click += new System.EventHandler(this.СменитьПользователяToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem1
            // 
            this.выйтиToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выйтиToolStripMenuItem1.Name = "выйтиToolStripMenuItem1";
            this.выйтиToolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.выйтиToolStripMenuItem1.Text = "Выйти";
            this.выйтиToolStripMenuItem1.Click += new System.EventHandler(this.ВыйтиToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            this.отчётыToolStripMenuItem.Click += new System.EventHandler(this.ОтчётыToolStripMenuItem_Click);
            // 
            // фунционалToolStripMenuItem
            // 
            this.фунционалToolStripMenuItem.Name = "фунционалToolStripMenuItem";
            this.фунционалToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.фунционалToolStripMenuItem.Text = "Статистика";
            this.фунционалToolStripMenuItem.Click += new System.EventHandler(this.ФунционалToolStripMenuItem_Click);
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(177, 25);
            this.работаСТаблицамиToolStripMenuItem.Text = "Журнал изменений    ";
            this.работаСТаблицамиToolStripMenuItem.Visible = false;
            this.работаСТаблицамиToolStripMenuItem.Click += new System.EventHandler(this.ИсторияИзмененияToolStripMenuItem_Click);
            // 
            // admView
            // 
            this.admView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.admView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admView.Location = new System.Drawing.Point(0, 32);
            this.admView.Name = "admView";
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
            treeNode12.Text = "Раздел фотографий";
            treeNode13.Name = "Узел0";
            treeNode13.Text = "Редакция газеты";
            treeNode14.Name = "addOtz";
            treeNode14.Text = "Написать отзыв на статью";
            treeNode15.Name = "edOtz";
            treeNode15.Text = "Редактировать или удалить отзыв";
            treeNode16.Name = "Отзыв";
            treeNode16.Text = "Отзывы";
            treeNode17.Name = "addOb";
            treeNode17.Text = "Добавить объявление в выпуск";
            treeNode18.Name = "edOb";
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
            this.admView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode20,
            treeNode30,
            treeNode33});
            this.admView.Size = new System.Drawing.Size(489, 772);
            this.admView.TabIndex = 66;
            this.admView.Visible = false;
            this.admView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // reklView
            // 
            this.reklView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.reklView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reklView.Location = new System.Drawing.Point(0, 32);
            this.reklView.Name = "reklView";
            treeNode34.Name = "addZ";
            treeNode34.Text = "Добавить заказчика";
            treeNode35.Name = "edZ";
            treeNode35.Text = "Редактировать данные или удалить заказчика";
            treeNode36.Name = "Заказчик";
            treeNode36.Text = "Заказчики";
            treeNode37.Name = "addD";
            treeNode37.Text = "Заключить договор";
            treeNode38.Name = "edD";
            treeNode38.Text = "Изменить условия или расторгнуть договор";
            treeNode39.Name = "Договор";
            treeNode39.Text = "Договоры";
            treeNode40.Name = "addRekl";
            treeNode40.Text = "Разместить рекламу в выпуске";
            treeNode41.Name = "edRekl";
            treeNode41.Text = "Редактировать данные или убрать рекламу";
            treeNode42.Name = "Реклама";
            treeNode42.Text = "Размещение рекламы";
            treeNode43.Name = "Узел22";
            treeNode43.Text = "Рекламный отдел";
            this.reklView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode43});
            this.reklView.Size = new System.Drawing.Size(489, 295);
            this.reklView.TabIndex = 67;
            this.reklView.Visible = false;
            this.reklView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // chitView
            // 
            this.chitView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chitView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chitView.Location = new System.Drawing.Point(0, 32);
            this.chitView.Name = "chitView";
            treeNode44.Name = "addOtz";
            treeNode44.Text = "Написать отзыв на статью";
            treeNode45.Name = "edOtz";
            treeNode45.Text = "Редактировать или удалить отзыв";
            treeNode46.Name = "Отзыв";
            treeNode46.Text = "Отзывы";
            treeNode47.Name = "addOb";
            treeNode47.Text = "Добавить объявление в выпуск";
            treeNode48.Name = "edOb";
            treeNode48.Text = "Редактировать или удалить объявление";
            treeNode49.Name = "Объявление";
            treeNode49.Text = "Объявления";
            treeNode50.Name = "Узел14";
            treeNode50.Text = "Работа с читателями";
            this.chitView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode50});
            this.chitView.Size = new System.Drawing.Size(489, 245);
            this.chitView.TabIndex = 68;
            this.chitView.Visible = false;
            this.chitView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // kadrView
            // 
            this.kadrView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.kadrView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kadrView.Location = new System.Drawing.Point(0, 32);
            this.kadrView.Name = "kadrView";
            treeNode51.Name = "addSotr";
            treeNode51.Text = "Нанять сотрудника";
            treeNode52.Name = "edSotr";
            treeNode52.Text = "Уволить или поменять данные";
            treeNode53.Name = "Сотрудник";
            treeNode53.Text = "Отдел кадров";
            this.kadrView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode53});
            this.kadrView.Size = new System.Drawing.Size(489, 245);
            this.kadrView.TabIndex = 69;
            this.kadrView.Visible = false;
            this.kadrView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // redView
            // 
            this.redView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.redView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redView.Location = new System.Drawing.Point(0, 32);
            this.redView.Name = "redView";
            treeNode54.Name = "addR";
            treeNode54.Text = "Добавить рубрику";
            treeNode55.Name = "edR";
            treeNode55.Text = "Изменить/удалить существующую";
            treeNode56.Name = "Рубрика";
            treeNode56.Text = "Раздел рубрик";
            treeNode57.Name = "addNom";
            treeNode57.Text = "Добавить выпуск газеты";
            treeNode58.Name = "edNom";
            treeNode58.Text = "Редактировать или удалить выпуск";
            treeNode59.Name = "НомерГазеты";
            treeNode59.Text = "Раздел выпусков";
            treeNode60.Name = "addSt";
            treeNode60.Text = "Добавить статью в выпуск";
            treeNode61.Name = "edSt";
            treeNode61.Text = "Изменить или удалить статью";
            treeNode62.Name = "Статья";
            treeNode62.Text = "Раздел статей";
            treeNode63.Name = "addF";
            treeNode63.Text = "Добавить снимок в статью";
            treeNode64.Name = "edF";
            treeNode64.Text = "Удалить или редактировать данные о фото";
            treeNode65.Name = "Фото";
            treeNode65.Text = "Раздел фотографий";
            treeNode66.Name = "Узел0";
            treeNode66.Text = "Редакция газеты";
            treeNode67.Name = "addZ";
            treeNode67.Text = "Добавить заказчика";
            treeNode68.Name = "edZ";
            treeNode68.Text = "Редактировать данные или удалить заказчика";
            treeNode69.Name = "Заказчик";
            treeNode69.Text = "Заказчики";
            treeNode70.Name = "addD";
            treeNode70.Text = "Заключить договор";
            treeNode71.Name = "edD";
            treeNode71.Text = "Изменить условия или расторгнуть договор";
            treeNode72.Name = "Договор";
            treeNode72.Text = "Договоры";
            treeNode73.Name = "addRekl";
            treeNode73.Text = "Разместить рекламу в выпуске";
            treeNode74.Name = "edRekl";
            treeNode74.Text = "Редактировать данные или убрать рекламу";
            treeNode75.Name = "Реклама";
            treeNode75.Text = "Размещение рекламы";
            treeNode76.Name = "Узел22";
            treeNode76.Text = "Рекламный отдел";
            this.redView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode66,
            treeNode76});
            this.redView.Size = new System.Drawing.Size(489, 451);
            this.redView.TabIndex = 70;
            this.redView.Visible = false;
            this.redView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // zurView
            // 
            this.zurView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.zurView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zurView.Location = new System.Drawing.Point(0, 32);
            this.zurView.Name = "zurView";
            treeNode77.Name = "addSt";
            treeNode77.Text = "Добавить статью в выпуск";
            treeNode78.Name = "edSt";
            treeNode78.Text = "Изменить или удалить статью";
            treeNode79.Name = "Статья";
            treeNode79.Text = "Раздел статей";
            treeNode80.Name = "addF";
            treeNode80.Text = "Добавить снимок в статью";
            treeNode81.Name = "edF";
            treeNode81.Text = "Удалить или редактировать данные о фото";
            treeNode82.Name = "Фото";
            treeNode82.Text = "Раздел фотографий";
            treeNode83.Name = "Узел0";
            treeNode83.Text = "Редакция газеты";
            this.zurView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode83});
            this.zurView.Size = new System.Drawing.Size(489, 230);
            this.zurView.TabIndex = 71;
            this.zurView.Visible = false;
            this.zurView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(486, 258);
            this.Controls.Add(this.zurView);
            this.Controls.Add(this.redView);
            this.Controls.Add(this.kadrView);
            this.Controls.Add(this.chitView);
            this.Controls.Add(this.reklView);
            this.Controls.Add(this.admView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(600, 20);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Приложение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фунционалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.TreeView admView;
        private System.Windows.Forms.TreeView reklView;
        private System.Windows.Forms.TreeView chitView;
        private System.Windows.Forms.TreeView kadrView;
        private System.Windows.Forms.TreeView redView;
        private System.Windows.Forms.TreeView zurView;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem1;
    }
}

