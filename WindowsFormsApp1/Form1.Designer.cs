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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Изменить/удалить существующую рубрику");
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
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Уволить сотрудника или поменять данные");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Отдел кадров", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Регистрация нового пользователя");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Просмотреть журнал изменений");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Просмотреть пользователей и их роли");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Раздел администратора", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Добавить заказчика");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Редактировать данные или удалить заказчика");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Заказчики", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Заключить договор");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Изменить условия или расторгнуть договор");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Договоры", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Разместить рекламу в выпуске");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Редактировать данные или убрать рекламу");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Размещение рекламы", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Рекламный отдел", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode43,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Написать отзыв на статью");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Редактировать или удалить отзыв");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Отзывы", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Добавить объявление в выпуск");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Редактировать или удалить объявление");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Объявления", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Работа с читателями", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Нанять сотрудника");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Уволить сотрудника или поменять данные");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Отдел кадров", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Добавить рубрику");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Изменить/удалить существующую рубрику");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Раздел рубрик", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Добавить выпуск газеты");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Редактировать или удалить выпуск");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Раздел выпусков", new System.Windows.Forms.TreeNode[] {
            treeNode61,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Добавить статью в выпуск");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Изменить или удалить статью");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Раздел статей", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Добавить снимок в статью");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Удалить или редактировать данные о фото");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Раздел фотографий", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Редакция газеты", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode63,
            treeNode66,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Добавить заказчика");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Редактировать данные или удалить заказчика");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Заказчики", new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Заключить договор");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Изменить условия или расторгнуть договор");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Договоры", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Разместить рекламу в выпуске");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Редактировать данные или убрать рекламу");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Размещение рекламы", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Рекламный отдел", new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode76,
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Добавить статью в выпуск");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Изменить или удалить статью");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Раздел статей", new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Добавить снимок в статью");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Удалить или редактировать данные о фото");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Раздел фотографий", new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Редакция газеты", new System.Windows.Forms.TreeNode[] {
            treeNode83,
            treeNode86});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётПоРекламеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётПоСтатьямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годовойОтчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фунционалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.фунционалToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(540, 29);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem1,
            this.выйтиToolStripMenuItem1});
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.loginToolStripMenuItem.Text = "login";
            // 
            // сменитьПользователяToolStripMenuItem1
            // 
            this.сменитьПользователяToolStripMenuItem1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сменитьПользователяToolStripMenuItem1.Name = "сменитьПользователяToolStripMenuItem1";
            this.сменитьПользователяToolStripMenuItem1.Size = new System.Drawing.Size(250, 24);
            this.сменитьПользователяToolStripMenuItem1.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem1.Click += new System.EventHandler(this.СменитьПользователяToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem1
            // 
            this.выйтиToolStripMenuItem1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выйтиToolStripMenuItem1.Name = "выйтиToolStripMenuItem1";
            this.выйтиToolStripMenuItem1.Size = new System.Drawing.Size(250, 24);
            this.выйтиToolStripMenuItem1.Text = "Выйти";
            this.выйтиToolStripMenuItem1.Click += new System.EventHandler(this.ВыйтиToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётПоРекламеToolStripMenuItem,
            this.отчётПоСтатьямToolStripMenuItem,
            this.годовойОтчётToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // отчётПоРекламеToolStripMenuItem
            // 
            this.отчётПоРекламеToolStripMenuItem.Name = "отчётПоРекламеToolStripMenuItem";
            this.отчётПоРекламеToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.отчётПоРекламеToolStripMenuItem.Text = "Отчёт по рекламе";
            this.отчётПоРекламеToolStripMenuItem.Click += new System.EventHandler(this.ОтчётПоРекламеToolStripMenuItem_Click);
            // 
            // отчётПоСтатьямToolStripMenuItem
            // 
            this.отчётПоСтатьямToolStripMenuItem.Name = "отчётПоСтатьямToolStripMenuItem";
            this.отчётПоСтатьямToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.отчётПоСтатьямToolStripMenuItem.Text = "Отчёт по статьям ";
            this.отчётПоСтатьямToolStripMenuItem.Click += new System.EventHandler(this.ОтчётПоСтатьямToolStripMenuItem_Click);
            // 
            // годовойОтчётToolStripMenuItem
            // 
            this.годовойОтчётToolStripMenuItem.Name = "годовойОтчётToolStripMenuItem";
            this.годовойОтчётToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.годовойОтчётToolStripMenuItem.Text = "Годовой отчёт";
            this.годовойОтчётToolStripMenuItem.Click += new System.EventHandler(this.ГодовойОтчётToolStripMenuItem_Click);
            // 
            // фунционалToolStripMenuItem
            // 
            this.фунционалToolStripMenuItem.Name = "фунционалToolStripMenuItem";
            this.фунционалToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.фунционалToolStripMenuItem.Text = "Статистика";
            this.фунционалToolStripMenuItem.Click += new System.EventHandler(this.ФунционалToolStripMenuItem_Click);
            // 
            // admView
            // 
            this.admView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.admView.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admView.Location = new System.Drawing.Point(0, 32);
            this.admView.Name = "admView";
            treeNode1.Name = "addR";
            treeNode1.Text = "Добавить рубрику";
            treeNode2.Name = "edR";
            treeNode2.Text = "Изменить/удалить существующую рубрику";
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
            treeNode32.Text = "Уволить сотрудника или поменять данные";
            treeNode33.Name = "Сотрудник";
            treeNode33.Text = "Отдел кадров";
            treeNode34.Name = "addUser";
            treeNode34.Text = "Регистрация нового пользователя";
            treeNode35.Name = "zurnal";
            treeNode35.Text = "Просмотреть журнал изменений";
            treeNode36.Name = "users";
            treeNode36.Text = "Просмотреть пользователей и их роли";
            treeNode37.Name = "Админ";
            treeNode37.Text = "Раздел администратора";
            this.admView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode20,
            treeNode30,
            treeNode33,
            treeNode37});
            this.admView.Size = new System.Drawing.Size(543, 772);
            this.admView.TabIndex = 66;
            this.admView.Visible = false;
            this.admView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // reklView
            // 
            this.reklView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.reklView.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reklView.Location = new System.Drawing.Point(0, 32);
            this.reklView.Name = "reklView";
            treeNode38.Name = "addZ";
            treeNode38.Text = "Добавить заказчика";
            treeNode39.Name = "edZ";
            treeNode39.Text = "Редактировать данные или удалить заказчика";
            treeNode40.Name = "Заказчик";
            treeNode40.Text = "Заказчики";
            treeNode41.Name = "addD";
            treeNode41.Text = "Заключить договор";
            treeNode42.Name = "edD";
            treeNode42.Text = "Изменить условия или расторгнуть договор";
            treeNode43.Name = "Договор";
            treeNode43.Text = "Договоры";
            treeNode44.Name = "addRekl";
            treeNode44.Text = "Разместить рекламу в выпуске";
            treeNode45.Name = "edRekl";
            treeNode45.Text = "Редактировать данные или убрать рекламу";
            treeNode46.Name = "Реклама";
            treeNode46.Text = "Размещение рекламы";
            treeNode47.Name = "Узел22";
            treeNode47.Text = "Рекламный отдел";
            this.reklView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode47});
            this.reklView.Size = new System.Drawing.Size(543, 295);
            this.reklView.TabIndex = 67;
            this.reklView.Visible = false;
            this.reklView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // chitView
            // 
            this.chitView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chitView.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chitView.Location = new System.Drawing.Point(0, 32);
            this.chitView.Name = "chitView";
            treeNode48.Name = "addOtz";
            treeNode48.Text = "Написать отзыв на статью";
            treeNode49.Name = "edOtz";
            treeNode49.Text = "Редактировать или удалить отзыв";
            treeNode50.Name = "Отзыв";
            treeNode50.Text = "Отзывы";
            treeNode51.Name = "addOb";
            treeNode51.Text = "Добавить объявление в выпуск";
            treeNode52.Name = "edOb";
            treeNode52.Text = "Редактировать или удалить объявление";
            treeNode53.Name = "Объявление";
            treeNode53.Text = "Объявления";
            treeNode54.Name = "Узел14";
            treeNode54.Text = "Работа с читателями";
            this.chitView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode54});
            this.chitView.Size = new System.Drawing.Size(543, 245);
            this.chitView.TabIndex = 68;
            this.chitView.Visible = false;
            this.chitView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // kadrView
            // 
            this.kadrView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.kadrView.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kadrView.Location = new System.Drawing.Point(0, 32);
            this.kadrView.Name = "kadrView";
            treeNode55.Name = "addSotr";
            treeNode55.Text = "Нанять сотрудника";
            treeNode56.Name = "edSotr";
            treeNode56.Text = "Уволить сотрудника или поменять данные";
            treeNode57.Name = "Сотрудник";
            treeNode57.Text = "Отдел кадров";
            this.kadrView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode57});
            this.kadrView.Size = new System.Drawing.Size(543, 245);
            this.kadrView.TabIndex = 69;
            this.kadrView.Visible = false;
            this.kadrView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // redView
            // 
            this.redView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.redView.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redView.Location = new System.Drawing.Point(0, 32);
            this.redView.Name = "redView";
            treeNode58.Name = "addR";
            treeNode58.Text = "Добавить рубрику";
            treeNode59.Name = "edR";
            treeNode59.Text = "Изменить/удалить существующую рубрику";
            treeNode60.Name = "Рубрика";
            treeNode60.Text = "Раздел рубрик";
            treeNode61.Name = "addNom";
            treeNode61.Text = "Добавить выпуск газеты";
            treeNode62.Name = "edNom";
            treeNode62.Text = "Редактировать или удалить выпуск";
            treeNode63.Name = "НомерГазеты";
            treeNode63.Text = "Раздел выпусков";
            treeNode64.Name = "addSt";
            treeNode64.Text = "Добавить статью в выпуск";
            treeNode65.Name = "edSt";
            treeNode65.Text = "Изменить или удалить статью";
            treeNode66.Name = "Статья";
            treeNode66.Text = "Раздел статей";
            treeNode67.Name = "addF";
            treeNode67.Text = "Добавить снимок в статью";
            treeNode68.Name = "edF";
            treeNode68.Text = "Удалить или редактировать данные о фото";
            treeNode69.Name = "Фото";
            treeNode69.Text = "Раздел фотографий";
            treeNode70.Name = "Узел0";
            treeNode70.Text = "Редакция газеты";
            treeNode71.Name = "addZ";
            treeNode71.Text = "Добавить заказчика";
            treeNode72.Name = "edZ";
            treeNode72.Text = "Редактировать данные или удалить заказчика";
            treeNode73.Name = "Заказчик";
            treeNode73.Text = "Заказчики";
            treeNode74.Name = "addD";
            treeNode74.Text = "Заключить договор";
            treeNode75.Name = "edD";
            treeNode75.Text = "Изменить условия или расторгнуть договор";
            treeNode76.Name = "Договор";
            treeNode76.Text = "Договоры";
            treeNode77.Name = "addRekl";
            treeNode77.Text = "Разместить рекламу в выпуске";
            treeNode78.Name = "edRekl";
            treeNode78.Text = "Редактировать данные или убрать рекламу";
            treeNode79.Name = "Реклама";
            treeNode79.Text = "Размещение рекламы";
            treeNode80.Name = "Узел22";
            treeNode80.Text = "Рекламный отдел";
            this.redView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode80});
            this.redView.Size = new System.Drawing.Size(543, 451);
            this.redView.TabIndex = 70;
            this.redView.Visible = false;
            this.redView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // zurView
            // 
            this.zurView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.zurView.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zurView.Location = new System.Drawing.Point(0, 32);
            this.zurView.Name = "zurView";
            treeNode81.Name = "addSt";
            treeNode81.Text = "Добавить статью в выпуск";
            treeNode82.Name = "edSt";
            treeNode82.Text = "Изменить или удалить статью";
            treeNode83.Name = "Статья";
            treeNode83.Text = "Раздел статей";
            treeNode84.Name = "addF";
            treeNode84.Text = "Добавить снимок в статью";
            treeNode85.Name = "edF";
            treeNode85.Text = "Удалить или редактировать данные о фото";
            treeNode86.Name = "Фото";
            treeNode86.Text = "Раздел фотографий";
            treeNode87.Name = "Узел0";
            treeNode87.Text = "Редакция газеты";
            this.zurView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode87});
            this.zurView.Size = new System.Drawing.Size(543, 230);
            this.zurView.TabIndex = 71;
            this.zurView.Visible = false;
            this.zurView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(540, 258);
            this.Controls.Add(this.zurView);
            this.Controls.Add(this.redView);
            this.Controls.Add(this.kadrView);
            this.Controls.Add(this.chitView);
            this.Controls.Add(this.reklView);
            this.Controls.Add(this.admView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(500, 10);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Приложение";
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
        private System.Windows.Forms.TreeView admView;
        private System.Windows.Forms.TreeView reklView;
        private System.Windows.Forms.TreeView chitView;
        private System.Windows.Forms.TreeView kadrView;
        private System.Windows.Forms.TreeView redView;
        private System.Windows.Forms.TreeView zurView;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отчётПоРекламеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётПоСтатьямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годовойОтчётToolStripMenuItem;
    }
}

