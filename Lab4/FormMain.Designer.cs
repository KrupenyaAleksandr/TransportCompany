namespace Lab4
{
    partial class FormMain
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
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFileItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRouteAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRouteEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDriverAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDriverEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDoneWork = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDoneWorkAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDoneWorkEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.routesTabPage = new System.Windows.Forms.TabPage();
            this.routeListView = new System.Windows.Forms.ListView();
            this.routeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distanceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tripTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driversTabPage = new System.Windows.Forms.TabPage();
            this.driverListView = new System.Windows.Forms.ListView();
            this.driverLastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driverFirstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driverMiddleNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driverExperienceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doneWorksTabPage = new System.Windows.Forms.TabPage();
            this.toolStripMenu.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.routesTabPage.SuspendLayout();
            this.driversTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFileItem1});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(48, 22);
            this.toolStripMenuFile.Text = "Файл";
            // 
            // toolStripMenuFileItem1
            // 
            this.toolStripMenuFileItem1.Name = "toolStripMenuFileItem1";
            this.toolStripMenuFileItem1.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuFileItem1.Text = "Выход";
            this.toolStripMenuFileItem1.Click += new System.EventHandler(this.toolStripMenuFileItem1_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuRoute,
            this.toolStripMenuDriver,
            this.toolStripMenuDoneWork});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.toolStripMenu.Size = new System.Drawing.Size(604, 24);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "Файл";
            // 
            // toolStripMenuRoute
            // 
            this.toolStripMenuRoute.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRouteAdd,
            this.toolStripMenuRouteEdit});
            this.toolStripMenuRoute.Name = "toolStripMenuRoute";
            this.toolStripMenuRoute.Size = new System.Drawing.Size(81, 22);
            this.toolStripMenuRoute.Text = "Маршруты";
            // 
            // toolStripMenuRouteAdd
            // 
            this.toolStripMenuRouteAdd.Name = "toolStripMenuRouteAdd";
            this.toolStripMenuRouteAdd.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuRouteAdd.Text = "Добавить";
            this.toolStripMenuRouteAdd.Click += new System.EventHandler(this.toolStripMenuRouteAdd_Click);
            // 
            // toolStripMenuRouteEdit
            // 
            this.toolStripMenuRouteEdit.Name = "toolStripMenuRouteEdit";
            this.toolStripMenuRouteEdit.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuRouteEdit.Text = "Редактировать";
            this.toolStripMenuRouteEdit.Click += new System.EventHandler(this.toolStripMenuRouteEdit_Click);
            // 
            // toolStripMenuDriver
            // 
            this.toolStripMenuDriver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDriverAdd,
            this.toolStripMenuDriverEdit});
            this.toolStripMenuDriver.Name = "toolStripMenuDriver";
            this.toolStripMenuDriver.Size = new System.Drawing.Size(71, 22);
            this.toolStripMenuDriver.Text = "Водители";
            // 
            // toolStripMenuDriverAdd
            // 
            this.toolStripMenuDriverAdd.Name = "toolStripMenuDriverAdd";
            this.toolStripMenuDriverAdd.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuDriverAdd.Text = "Добавить";
            this.toolStripMenuDriverAdd.Click += new System.EventHandler(this.toolStripMenuDriverAdd_Click);
            // 
            // toolStripMenuDriverEdit
            // 
            this.toolStripMenuDriverEdit.Name = "toolStripMenuDriverEdit";
            this.toolStripMenuDriverEdit.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuDriverEdit.Text = "Редактировать";
            this.toolStripMenuDriverEdit.Click += new System.EventHandler(this.toolStripMenuDriverEdit_Click);
            // 
            // toolStripMenuDoneWork
            // 
            this.toolStripMenuDoneWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDoneWorkAdd,
            this.toolStripMenuDoneWorkEdit});
            this.toolStripMenuDoneWork.Name = "toolStripMenuDoneWork";
            this.toolStripMenuDoneWork.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuDoneWork.Text = "Выполненные заказы";
            // 
            // toolStripMenuDoneWorkAdd
            // 
            this.toolStripMenuDoneWorkAdd.Name = "toolStripMenuDoneWorkAdd";
            this.toolStripMenuDoneWorkAdd.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuDoneWorkAdd.Text = "Добавить";
            this.toolStripMenuDoneWorkAdd.Click += new System.EventHandler(this.toolStripMenuDoneWorkAdd_Click);
            // 
            // toolStripMenuDoneWorkEdit
            // 
            this.toolStripMenuDoneWorkEdit.Name = "toolStripMenuDoneWorkEdit";
            this.toolStripMenuDoneWorkEdit.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuDoneWorkEdit.Text = "Редактировать";
            this.toolStripMenuDoneWorkEdit.Click += new System.EventHandler(this.toolStripMenuDoneWorkEdit_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 257);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.routesTabPage);
            this.tabControlMain.Controls.Add(this.driversTabPage);
            this.tabControlMain.Controls.Add(this.doneWorksTabPage);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(604, 257);
            this.tabControlMain.TabIndex = 3;
            // 
            // routesTabPage
            // 
            this.routesTabPage.Controls.Add(this.routeListView);
            this.routesTabPage.Location = new System.Drawing.Point(4, 22);
            this.routesTabPage.Name = "routesTabPage";
            this.routesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.routesTabPage.Size = new System.Drawing.Size(617, 194);
            this.routesTabPage.TabIndex = 0;
            this.routesTabPage.Text = "Маршруты";
            this.routesTabPage.UseVisualStyleBackColor = true;
            // 
            // routeListView
            // 
            this.routeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.routeColumnHeader,
            this.distanceColumnHeader,
            this.tripTimeColumnHeader,
            this.paymentColumnHeader});
            this.routeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routeListView.FullRowSelect = true;
            this.routeListView.GridLines = true;
            this.routeListView.HideSelection = false;
            this.routeListView.Location = new System.Drawing.Point(3, 3);
            this.routeListView.Name = "routeListView";
            this.routeListView.Size = new System.Drawing.Size(611, 188);
            this.routeListView.TabIndex = 1;
            this.routeListView.UseCompatibleStateImageBehavior = false;
            this.routeListView.View = System.Windows.Forms.View.Details;
            this.routeListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.routeListView_KeyUp);
            // 
            // routeColumnHeader
            // 
            this.routeColumnHeader.Text = "Название";
            this.routeColumnHeader.Width = 183;
            // 
            // distanceColumnHeader
            // 
            this.distanceColumnHeader.Text = "Расстояние";
            this.distanceColumnHeader.Width = 108;
            // 
            // tripTimeColumnHeader
            // 
            this.tripTimeColumnHeader.Text = "Время в пути";
            this.tripTimeColumnHeader.Width = 116;
            // 
            // paymentColumnHeader
            // 
            this.paymentColumnHeader.Text = "Оплата";
            this.paymentColumnHeader.Width = 133;
            // 
            // driversTabPage
            // 
            this.driversTabPage.Controls.Add(this.driverListView);
            this.driversTabPage.Location = new System.Drawing.Point(4, 22);
            this.driversTabPage.Name = "driversTabPage";
            this.driversTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.driversTabPage.Size = new System.Drawing.Size(617, 194);
            this.driversTabPage.TabIndex = 1;
            this.driversTabPage.Text = "Водители";
            this.driversTabPage.UseVisualStyleBackColor = true;
            // 
            // driverListView
            // 
            this.driverListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.driverLastNameColumnHeader,
            this.driverFirstNameColumnHeader,
            this.driverMiddleNameColumnHeader,
            this.driverExperienceColumnHeader});
            this.driverListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverListView.FullRowSelect = true;
            this.driverListView.GridLines = true;
            this.driverListView.HideSelection = false;
            this.driverListView.Location = new System.Drawing.Point(3, 3);
            this.driverListView.Name = "driverListView";
            this.driverListView.Size = new System.Drawing.Size(611, 188);
            this.driverListView.TabIndex = 1;
            this.driverListView.UseCompatibleStateImageBehavior = false;
            this.driverListView.View = System.Windows.Forms.View.Details;
            this.driverListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.driverListView_KeyUp);
            // 
            // driverLastNameColumnHeader
            // 
            this.driverLastNameColumnHeader.Text = "Фамилия";
            this.driverLastNameColumnHeader.Width = 150;
            // 
            // driverFirstNameColumnHeader
            // 
            this.driverFirstNameColumnHeader.Text = "Имя";
            this.driverFirstNameColumnHeader.Width = 150;
            // 
            // driverMiddleNameColumnHeader
            // 
            this.driverMiddleNameColumnHeader.Text = "Отчество";
            this.driverMiddleNameColumnHeader.Width = 150;
            // 
            // driverExperienceColumnHeader
            // 
            this.driverExperienceColumnHeader.Text = "Стаж";
            // 
            // doneWorksTabPage
            // 
            this.doneWorksTabPage.Location = new System.Drawing.Point(4, 22);
            this.doneWorksTabPage.Name = "doneWorksTabPage";
            this.doneWorksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.doneWorksTabPage.Size = new System.Drawing.Size(596, 231);
            this.doneWorksTabPage.TabIndex = 2;
            this.doneWorksTabPage.Text = "Выполненные заказы";
            this.doneWorksTabPage.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 281);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Грузовые перевозки";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.routesTabPage.ResumeLayout(false);
            this.driversTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFileItem1;
        private System.Windows.Forms.MenuStrip toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRoute;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRouteAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRouteEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDriver;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDriverAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDriverEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDoneWork;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDoneWorkAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDoneWorkEdit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage routesTabPage;
        private System.Windows.Forms.TabPage driversTabPage;
        private System.Windows.Forms.TabPage doneWorksTabPage;
        private System.Windows.Forms.ListView routeListView;
        private System.Windows.Forms.ColumnHeader routeColumnHeader;
        private System.Windows.Forms.ListView driverListView;
        private System.Windows.Forms.ColumnHeader driverLastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader distanceColumnHeader;
        private System.Windows.Forms.ColumnHeader tripTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader paymentColumnHeader;
        private System.Windows.Forms.ColumnHeader driverFirstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader driverMiddleNameColumnHeader;
        private System.Windows.Forms.ColumnHeader driverExperienceColumnHeader;
    }
}

