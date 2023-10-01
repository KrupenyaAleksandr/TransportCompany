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
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFileItem1});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(80, 34);
            this.toolStripMenuFile.Text = "Файл";
            // 
            // toolStripMenuFileItem1
            // 
            this.toolStripMenuFileItem1.Name = "toolStripMenuFileItem1";
            this.toolStripMenuFileItem1.Size = new System.Drawing.Size(191, 40);
            this.toolStripMenuFileItem1.Text = "Выход";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuRoute,
            this.toolStripMenuDriver});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(800, 38);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "Файл";
            // 
            // toolStripMenuRoute
            // 
            this.toolStripMenuRoute.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRouteAdd,
            this.toolStripMenuRouteEdit});
            this.toolStripMenuRoute.Name = "toolStripMenuRoute";
            this.toolStripMenuRoute.Size = new System.Drawing.Size(136, 34);
            this.toolStripMenuRoute.Text = "Маршруты";
            // 
            // toolStripMenuRouteAdd
            // 
            this.toolStripMenuRouteAdd.Name = "toolStripMenuRouteAdd";
            this.toolStripMenuRouteAdd.Size = new System.Drawing.Size(273, 40);
            this.toolStripMenuRouteAdd.Text = "Добавить";
            this.toolStripMenuRouteAdd.Click += new System.EventHandler(this.toolStripMenuRouteAdd_Click);
            // 
            // toolStripMenuRouteEdit
            // 
            this.toolStripMenuRouteEdit.Name = "toolStripMenuRouteEdit";
            this.toolStripMenuRouteEdit.Size = new System.Drawing.Size(273, 40);
            this.toolStripMenuRouteEdit.Text = "Редактировать";
            this.toolStripMenuRouteEdit.Click += new System.EventHandler(this.toolStripMenuRouteEdit_Click);
            // 
            // toolStripMenuDriver
            // 
            this.toolStripMenuDriver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDriverAdd,
            this.toolStripMenuDriverEdit});
            this.toolStripMenuDriver.Name = "toolStripMenuDriver";
            this.toolStripMenuDriver.Size = new System.Drawing.Size(121, 34);
            this.toolStripMenuDriver.Text = "Водители";
            // 
            // toolStripMenuDriverAdd
            // 
            this.toolStripMenuDriverAdd.Name = "toolStripMenuDriverAdd";
            this.toolStripMenuDriverAdd.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuDriverAdd.Text = "Добавить";
            this.toolStripMenuDriverAdd.Click += new System.EventHandler(this.toolStripMenuDriverAdd_Click);
            // 
            // toolStripMenuDriverEdit
            // 
            this.toolStripMenuDriverEdit.Name = "toolStripMenuDriverEdit";
            this.toolStripMenuDriverEdit.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuDriverEdit.Text = "Редактировать";
            this.toolStripMenuDriverEdit.Click += new System.EventHandler(this.toolStripMenuDriverEdit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
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
    }
}

