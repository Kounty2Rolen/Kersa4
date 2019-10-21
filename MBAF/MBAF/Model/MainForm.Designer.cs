namespace MBAF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.подключитсяКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитсяОтБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmintoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.добавитьАудиториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьАудиториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.MainDataGridView.Location = new System.Drawing.Point(0, 28);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(800, 422);
            this.MainDataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1,
            this.toolStripButton2,
            this.AdmintoolStripButton,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитсяКБДToolStripMenuItem,
            this.отключитсяОтБДToolStripMenuItem,
            this.обновитьДанныеToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "Подключение";
            // 
            // подключитсяКБДToolStripMenuItem
            // 
            this.подключитсяКБДToolStripMenuItem.Name = "подключитсяКБДToolStripMenuItem";
            this.подключитсяКБДToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.подключитсяКБДToolStripMenuItem.Text = "Подключится к БД";
            this.подключитсяКБДToolStripMenuItem.Click += new System.EventHandler(this.подключитсяКБДToolStripMenuItem_Click);
            // 
            // отключитсяОтБДToolStripMenuItem
            // 
            this.отключитсяОтБДToolStripMenuItem.Name = "отключитсяОтБДToolStripMenuItem";
            this.отключитсяОтБДToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отключитсяОтБДToolStripMenuItem.Text = "Отключится от БД";
            this.отключитсяОтБДToolStripMenuItem.Click += new System.EventHandler(this.отключитсяОтБДToolStripMenuItem_Click);
            // 
            // обновитьДанныеToolStripMenuItem
            // 
            this.обновитьДанныеToolStripMenuItem.Name = "обновитьДанныеToolStripMenuItem";
            this.обновитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьДанныеToolStripMenuItem.Text = "Обновить данные";
            this.обновитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.обновитьДанныеToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton2.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе ";
            // 
            // AdmintoolStripButton
            // 
            this.AdmintoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AdmintoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AdmintoolStripButton.Image")));
            this.AdmintoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdmintoolStripButton.Name = "AdmintoolStripButton";
            this.AdmintoolStripButton.Size = new System.Drawing.Size(98, 22);
            this.AdmintoolStripButton.Text = "Администратор";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton3.Text = "Заблокировать";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАудиториюToolStripMenuItem,
            this.удалитьАудиториюToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton1.Text = "Таблица";
            // 
            // добавитьАудиториюToolStripMenuItem
            // 
            this.добавитьАудиториюToolStripMenuItem.Name = "добавитьАудиториюToolStripMenuItem";
            this.добавитьАудиториюToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.добавитьАудиториюToolStripMenuItem.Text = "Добавить Аудиторию";
            // 
            // удалитьАудиториюToolStripMenuItem
            // 
            this.удалитьАудиториюToolStripMenuItem.Name = "удалитьАудиториюToolStripMenuItem";
            this.удалитьАудиториюToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.удалитьАудиториюToolStripMenuItem.Text = "Удалить аудиторию";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Аудиторный фонд многокорпусного здания";
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem подключитсяКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитсяОтБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AdmintoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem обновитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьАудиториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьАудиториюToolStripMenuItem;
    }
}

