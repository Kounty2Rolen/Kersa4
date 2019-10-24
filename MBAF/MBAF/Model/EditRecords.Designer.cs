namespace MBAF.Model
{
    partial class EditRecords
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
            this.components = new System.ComponentModel.Container();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.CabinetTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AuditoryCapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.AuditorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDayMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CorpsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AuditoryCapacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuditorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Enabled = false;
            this.FIOTextBox.Location = new System.Drawing.Point(143, 134);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(133, 20);
            this.FIOTextBox.TabIndex = 33;
            // 
            // CabinetTextBox
            // 
            this.CabinetTextBox.Enabled = false;
            this.CabinetTextBox.Location = new System.Drawing.Point(143, 106);
            this.CabinetTextBox.Name = "CabinetTextBox";
            this.CabinetTextBox.Size = new System.Drawing.Size(133, 20);
            this.CabinetTextBox.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Вместимость аудитории";
            // 
            // AuditoryCapacityNumericUpDown
            // 
            this.AuditoryCapacityNumericUpDown.Enabled = false;
            this.AuditoryCapacityNumericUpDown.Location = new System.Drawing.Point(143, 80);
            this.AuditoryCapacityNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AuditoryCapacityNumericUpDown.Name = "AuditoryCapacityNumericUpDown";
            this.AuditoryCapacityNumericUpDown.Size = new System.Drawing.Size(133, 20);
            this.AuditoryCapacityNumericUpDown.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Кол-во аудиторий";
            // 
            // AuditorNumericUpDown
            // 
            this.AuditorNumericUpDown.Enabled = false;
            this.AuditorNumericUpDown.Location = new System.Drawing.Point(143, 54);
            this.AuditorNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AuditorNumericUpDown.Name = "AuditorNumericUpDown";
            this.AuditorNumericUpDown.Size = new System.Drawing.Size(133, 20);
            this.AuditorNumericUpDown.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "День рождения";
            // 
            // BirthDayMaskedTextBox
            // 
            this.BirthDayMaskedTextBox.Enabled = false;
            this.BirthDayMaskedTextBox.Location = new System.Drawing.Point(143, 160);
            this.BirthDayMaskedTextBox.Mask = "00.00.0000";
            this.BirthDayMaskedTextBox.Name = "BirthDayMaskedTextBox";
            this.BirthDayMaskedTextBox.Size = new System.Drawing.Size(133, 20);
            this.BirthDayMaskedTextBox.TabIndex = 26;
            this.BirthDayMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(95, 212);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Изменить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Личный телефон\r\nответсвенного";
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Enabled = false;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(143, 186);
            this.PhoneMaskedTextBox.Mask = "+7(999)-999-99-99";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(133, 20);
            this.PhoneMaskedTextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ответственный за ПБ\r\n(ФИО через пробел)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Кабинет";
            // 
            // CorpsComboBox
            // 
            this.CorpsComboBox.FormattingEnabled = true;
            this.CorpsComboBox.Location = new System.Drawing.Point(143, 28);
            this.CorpsComboBox.Name = "CorpsComboBox";
            this.CorpsComboBox.Size = new System.Drawing.Size(133, 21);
            this.CorpsComboBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Корпус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "null";
            this.InfoToolTip.SetToolTip(this.label5, "Это ID записи в базе данных");
            // 
            // InfoToolTip
            // 
            this.InfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InfoToolTip.ToolTipTitle = "Подсказочка";
            // 
            // EditRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 259);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FIOTextBox);
            this.Controls.Add(this.CabinetTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AuditoryCapacityNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AuditorNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BirthDayMaskedTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CorpsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "EditRecords";
            this.Text = "EditRecords";
            ((System.ComponentModel.ISupportInitialize)(this.AuditoryCapacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuditorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.TextBox CabinetTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown AuditoryCapacityNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AuditorNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox BirthDayMaskedTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CorpsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip InfoToolTip;
    }
}