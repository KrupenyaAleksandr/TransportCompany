namespace WindowsFormsControlLibraryTransportCompany
{
    partial class UserControlDoneWork
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.routeLabel = new System.Windows.Forms.Label();
            this.routeTextBox = new System.Windows.Forms.TextBox();
            this.driverLabel = new System.Windows.Forms.Label();
            this.driverTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.awardLabel = new System.Windows.Forms.Label();
            this.awardTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.Location = new System.Drawing.Point(10, 15);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(52, 13);
            this.routeLabel.TabIndex = 0;
            this.routeLabel.Text = "Маршрут";
            // 
            // routeTextBox
            // 
            this.routeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.routeTextBox.Location = new System.Drawing.Point(68, 12);
            this.routeTextBox.Name = "routeTextBox";
            this.routeTextBox.ReadOnly = true;
            this.routeTextBox.Size = new System.Drawing.Size(225, 20);
            this.routeTextBox.TabIndex = 1;
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(300, 15);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(55, 13);
            this.driverLabel.TabIndex = 2;
            this.driverLabel.Text = "Водитель";
            // 
            // driverTextBox
            // 
            this.driverTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.driverTextBox.Location = new System.Drawing.Point(361, 12);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.ReadOnly = true;
            this.driverTextBox.Size = new System.Drawing.Size(225, 20);
            this.driverTextBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(19, 44);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Дата";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dateTextBox.Location = new System.Drawing.Point(68, 41);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(287, 20);
            this.dateTextBox.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(534, 38);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(52, 24);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlDoneWork_Paint);
            // 
            // awardLabel
            // 
            this.awardLabel.AutoSize = true;
            this.awardLabel.Location = new System.Drawing.Point(370, 44);
            this.awardLabel.Name = "awardLabel";
            this.awardLabel.Size = new System.Drawing.Size(47, 13);
            this.awardLabel.TabIndex = 7;
            this.awardLabel.Text = "Премия";
            // 
            // awardTextBox
            // 
            this.awardTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.awardTextBox.Location = new System.Drawing.Point(423, 41);
            this.awardTextBox.Name = "awardTextBox";
            this.awardTextBox.ReadOnly = true;
            this.awardTextBox.Size = new System.Drawing.Size(100, 20);
            this.awardTextBox.TabIndex = 8;
            // 
            // UserControlDoneWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.awardTextBox);
            this.Controls.Add(this.awardLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.driverTextBox);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.routeTextBox);
            this.Controls.Add(this.routeLabel);
            this.Name = "UserControlDoneWork";
            this.Size = new System.Drawing.Size(610, 70);
            this.Click += new System.EventHandler(this.UserControlDoneWork_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.TextBox routeTextBox;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.TextBox driverTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label awardLabel;
        private System.Windows.Forms.TextBox awardTextBox;
    }
}
