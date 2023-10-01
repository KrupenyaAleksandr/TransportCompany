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
            this.toolStripMenuFile.Size = new System.Drawing.Size(48, 22);
            this.toolStripMenuFile.Text = "Файл";
            // 
            // toolStripMenuFileItem1
            // 
            this.toolStripMenuFileItem1.Name = "toolStripMenuFileItem1";
            this.toolStripMenuFileItem1.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuFileItem1.Text = "Выход";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuRoute,
            this.toolStripMenuDriver});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.toolStripMenu.Size = new System.Drawing.Size(436, 24);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Грузовые перевозки";
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

