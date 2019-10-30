namespace MBAF.Model
{
    partial class AddAudience
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAudience));
            this.label1 = new System.Windows.Forms.Label();
            this.CorpsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuditorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AuditoryCapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CabinetTextBox = new System.Windows.Forms.TextBox();
            this.MnameTextBox = new System.Windows.Forms.TextBox();
            this.AudTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDayMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AuditorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuditoryCapacityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Корпус";
            // 
            // CorpsComboBox
            // 
            this.CorpsComboBox.FormattingEnabled = true;
            this.CorpsComboBox.Location = new System.Drawing.Point(143, 19);
            this.CorpsComboBox.Name = "CorpsComboBox";
            this.CorpsComboBox.Size = new System.Drawing.Size(133, 21);
            this.CorpsComboBox.TabIndex = 1;
            this.CorpsComboBox.TextUpdate += new System.EventHandler(this.CorpsComboBox_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кабинет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // AuditorNumericUpDown
            // 
            this.AuditorNumericUpDown.Enabled = false;
            this.AuditorNumericUpDown.Location = new System.Drawing.Point(143, 45);
            this.AuditorNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AuditorNumericUpDown.Name = "AuditorNumericUpDown";
            this.AuditorNumericUpDown.Size = new System.Drawing.Size(133, 20);
            this.AuditorNumericUpDown.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кол-во аудиторий";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Вместимость аудитории";
            // 
            // AuditoryCapacityNumericUpDown
            // 
            this.AuditoryCapacityNumericUpDown.Enabled = false;
            this.AuditoryCapacityNumericUpDown.Location = new System.Drawing.Point(143, 71);
            this.AuditoryCapacityNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AuditoryCapacityNumericUpDown.Name = "AuditoryCapacityNumericUpDown";
            this.AuditoryCapacityNumericUpDown.Size = new System.Drawing.Size(133, 20);
            this.AuditoryCapacityNumericUpDown.TabIndex = 15;
            // 
            // CabinetTextBox
            // 
            this.CabinetTextBox.Enabled = false;
            this.CabinetTextBox.Location = new System.Drawing.Point(143, 97);
            this.CabinetTextBox.Name = "CabinetTextBox";
            this.CabinetTextBox.Size = new System.Drawing.Size(133, 20);
            this.CabinetTextBox.TabIndex = 17;
            // 
            // MnameTextBox
            // 
            this.MnameTextBox.Enabled = false;
            this.MnameTextBox.Location = new System.Drawing.Point(143, 149);
            this.MnameTextBox.Name = "MnameTextBox";
            this.MnameTextBox.Size = new System.Drawing.Size(133, 20);
            this.MnameTextBox.TabIndex = 18;
            // 
            // AudTypeTextBox
            // 
            this.AudTypeTextBox.Enabled = false;
            this.AudTypeTextBox.Location = new System.Drawing.Point(143, 123);
            this.AudTypeTextBox.Name = "AudTypeTextBox";
            this.AudTypeTextBox.Size = new System.Drawing.Size(133, 20);
            this.AudTypeTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Тип аудитории";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "День рождения";
            // 
            // BirthDayMaskedTextBox
            // 
            this.BirthDayMaskedTextBox.Enabled = false;
            this.BirthDayMaskedTextBox.Location = new System.Drawing.Point(143, 227);
            this.BirthDayMaskedTextBox.Mask = "00.00.0000";
            this.BirthDayMaskedTextBox.Name = "BirthDayMaskedTextBox";
            this.BirthDayMaskedTextBox.Size = new System.Drawing.Size(133, 20);
            this.BirthDayMaskedTextBox.TabIndex = 24;
            this.BirthDayMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(89, 288);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 23;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Личный телефон\r\nответсвенного";
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Enabled = false;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(143, 253);
            this.PhoneMaskedTextBox.Mask = "+7(999)-999-99-99";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(133, 20);
            this.PhoneMaskedTextBox.TabIndex = 21;
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Enabled = false;
            this.FnameTextBox.Location = new System.Drawing.Point(144, 175);
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(133, 20);
            this.FnameTextBox.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Имя";
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Enabled = false;
            this.LnameTextBox.Location = new System.Drawing.Point(144, 201);
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(133, 20);
            this.LnameTextBox.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Отчество";
            // 
            // AddAudience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 330);
            this.Controls.Add(this.LnameTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FnameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BirthDayMaskedTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.AudTypeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MnameTextBox);
            this.Controls.Add(this.CabinetTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AuditoryCapacityNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AuditorNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CorpsComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 275);
            this.Name = "AddAudience";
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddAudience_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuditorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuditoryCapacityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CorpsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AuditorNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown AuditoryCapacityNumericUpDown;
        private System.Windows.Forms.TextBox CabinetTextBox;
        private System.Windows.Forms.TextBox MnameTextBox;
        private System.Windows.Forms.TextBox AudTypeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox BirthDayMaskedTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LnameTextBox;
        private System.Windows.Forms.Label label10;
    }
}