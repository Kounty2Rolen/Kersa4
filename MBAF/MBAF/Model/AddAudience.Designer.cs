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
            this.CabinetComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FireSecurityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
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
            this.CorpsComboBox.Location = new System.Drawing.Point(142, 19);
            this.CorpsComboBox.Name = "CorpsComboBox";
            this.CorpsComboBox.Size = new System.Drawing.Size(133, 21);
            this.CorpsComboBox.TabIndex = 1;
            this.CorpsComboBox.SelectedIndexChanged += new System.EventHandler(this.CorpsComboBox_SelectedIndexChanged);
            // 
            // CabinetComboBox
            // 
            this.CabinetComboBox.Enabled = false;
            this.CabinetComboBox.FormattingEnabled = true;
            this.CabinetComboBox.Location = new System.Drawing.Point(142, 46);
            this.CabinetComboBox.Name = "CabinetComboBox";
            this.CabinetComboBox.Size = new System.Drawing.Size(133, 21);
            this.CabinetComboBox.TabIndex = 4;
            this.CabinetComboBox.SelectedIndexChanged += new System.EventHandler(this.CabinetComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кабинет";
            // 
            // FireSecurityComboBox
            // 
            this.FireSecurityComboBox.Enabled = false;
            this.FireSecurityComboBox.FormattingEnabled = true;
            this.FireSecurityComboBox.Location = new System.Drawing.Point(142, 73);
            this.FireSecurityComboBox.Name = "FireSecurityComboBox";
            this.FireSecurityComboBox.Size = new System.Drawing.Size(133, 21);
            this.FireSecurityComboBox.TabIndex = 6;
            this.FireSecurityComboBox.SelectedIndexChanged += new System.EventHandler(this.FireSecurityComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ответственный за ПБ";
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Enabled = false;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(142, 109);
            this.PhoneMaskedTextBox.Mask = "+7(999)-999-99-99";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(133, 20);
            this.PhoneMaskedTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Личный телефон\r\nответсвенного";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(346, 98);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // AddAudience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 139);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.FireSecurityComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CabinetComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CorpsComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAudience";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CorpsComboBox;
        private System.Windows.Forms.ComboBox CabinetComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FireSecurityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
    }
}