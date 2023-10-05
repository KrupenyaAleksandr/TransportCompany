namespace Lab4
{
    partial class FormRoute
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
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.tripTimeInDaysLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tripTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.paymentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(288, 41);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(239, 29);
            this.fromTextBox.TabIndex = 0;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(288, 116);
            this.toTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(239, 29);
            this.toTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(579, 378);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 52);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(68, 46);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(194, 25);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "Пункт отправления";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(68, 122);
            this.toLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(181, 25);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "Пункт назначения";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(94, 198);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(121, 25);
            this.distanceLabel.TabIndex = 8;
            this.distanceLabel.Text = "Расстояние";
            // 
            // tripTimeInDaysLabel
            // 
            this.tripTimeInDaysLabel.AutoSize = true;
            this.tripTimeInDaysLabel.Location = new System.Drawing.Point(68, 273);
            this.tripTimeInDaysLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tripTimeInDaysLabel.Name = "tripTimeInDaysLabel";
            this.tripTimeInDaysLabel.Size = new System.Drawing.Size(184, 25);
            this.tripTimeInDaysLabel.TabIndex = 9;
            this.tripTimeInDaysLabel.Text = "Время в пути (дн.)";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(110, 349);
            this.paymentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(82, 25);
            this.paymentLabel.TabIndex = 10;
            this.paymentLabel.Text = "Оплата";
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.DecimalPlaces = 1;
            this.distanceNumericUpDown.Location = new System.Drawing.Point(288, 196);
            this.distanceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.distanceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(239, 29);
            this.distanceNumericUpDown.TabIndex = 11;
            this.distanceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.distanceNumericUpDown.ThousandsSeparator = true;
            this.distanceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tripTimeNumericUpDown
            // 
            this.tripTimeNumericUpDown.Location = new System.Drawing.Point(288, 271);
            this.tripTimeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tripTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tripTimeNumericUpDown.Name = "tripTimeNumericUpDown";
            this.tripTimeNumericUpDown.Size = new System.Drawing.Size(239, 29);
            this.tripTimeNumericUpDown.TabIndex = 12;
            this.tripTimeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tripTimeNumericUpDown.ThousandsSeparator = true;
            this.tripTimeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // paymentNumericUpDown
            // 
            this.paymentNumericUpDown.DecimalPlaces = 3;
            this.paymentNumericUpDown.Location = new System.Drawing.Point(288, 347);
            this.paymentNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.paymentNumericUpDown.Name = "paymentNumericUpDown";
            this.paymentNumericUpDown.Size = new System.Drawing.Size(239, 29);
            this.paymentNumericUpDown.TabIndex = 13;
            this.paymentNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.paymentNumericUpDown.ThousandsSeparator = true;
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.paymentNumericUpDown);
            this.Controls.Add(this.tripTimeNumericUpDown);
            this.Controls.Add(this.distanceNumericUpDown);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.tripTimeInDaysLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRoute";
            this.Text = "Маршрут";
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label tripTimeInDaysLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.NumericUpDown tripTimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown paymentNumericUpDown;
    }
}