namespace Lab4
{
    partial class FormDoneWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.routeComboBox = new System.Windows.Forms.ComboBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.awardNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.driverLabel = new System.Windows.Forms.Label();
            this.routeLabel = new System.Windows.Forms.Label();
            this.awardLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.awardNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // driverComboBox
            // 
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(142, 39);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(121, 21);
            this.driverComboBox.TabIndex = 0;
            // 
            // routeComboBox
            // 
            this.routeComboBox.FormattingEnabled = true;
            this.routeComboBox.Location = new System.Drawing.Point(142, 80);
            this.routeComboBox.Name = "routeComboBox";
            this.routeComboBox.Size = new System.Drawing.Size(121, 21);
            this.routeComboBox.TabIndex = 1;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(142, 162);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(316, 205);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 28);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // awardNumericUpDown
            // 
            this.awardNumericUpDown.Location = new System.Drawing.Point(142, 121);
            this.awardNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.awardNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.awardNumericUpDown.Name = "awardNumericUpDown";
            this.awardNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.awardNumericUpDown.TabIndex = 5;
            this.awardNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.awardNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(55, 42);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(55, 13);
            this.driverLabel.TabIndex = 6;
            this.driverLabel.Text = "Водитель";
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.Location = new System.Drawing.Point(55, 83);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(52, 13);
            this.routeLabel.TabIndex = 7;
            this.routeLabel.Text = "Маршрут";
            // 
            // awardLabel
            // 
            this.awardLabel.AutoSize = true;
            this.awardLabel.Location = new System.Drawing.Point(55, 123);
            this.awardLabel.Name = "awardLabel";
            this.awardLabel.Size = new System.Drawing.Size(47, 13);
            this.awardLabel.TabIndex = 8;
            this.awardLabel.Text = "Премия";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(39, 168);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(83, 13);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Дата отправки";
            // 
            // FormDoneWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.awardLabel);
            this.Controls.Add(this.routeLabel);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.awardNumericUpDown);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.routeComboBox);
            this.Controls.Add(this.driverComboBox);
            this.Name = "FormDoneWork";
            this.Text = "FormDoneWork";
            ((System.ComponentModel.ISupportInitialize)(this.awardNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.ComboBox routeComboBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown awardNumericUpDown;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.Label awardLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}