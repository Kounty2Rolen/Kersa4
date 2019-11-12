namespace MBAF.WinForms.Administrativ
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.DGVTab = new System.Windows.Forms.TabControl();
            this.AudienceTabPage = new System.Windows.Forms.TabPage();
            this.AudienceLOGDataGridView = new System.Windows.Forms.DataGridView();
            this.CorptabPage = new System.Windows.Forms.TabPage();
            this.CorpLogDataGridView = new System.Windows.Forms.DataGridView();
            this.TeacherTabPage = new System.Windows.Forms.TabPage();
            this.TeacherLogDataGridView = new System.Windows.Forms.DataGridView();
            this.PasswordButton = new System.Windows.Forms.Button();
            this.RealoadButton = new System.Windows.Forms.Button();
            this.BackUpbutton = new System.Windows.Forms.Button();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ImportExportbutton = new System.Windows.Forms.Button();
            this.TablecomboBox = new System.Windows.Forms.ComboBox();
            this.GetCountRecButton = new System.Windows.Forms.Button();
            this.allCapacityButton = new System.Windows.Forms.Button();
            this.corpscomboBox = new System.Windows.Forms.ComboBox();
            this.TabPageSQL = new System.Windows.Forms.TabPage();
            this.QueryButton = new System.Windows.Forms.Button();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.AudTypeTabPage = new System.Windows.Forms.TabPage();
            this.CorpstabPage = new System.Windows.Forms.TabPage();
            this.removeTypeAddbtn = new System.Windows.Forms.Button();
            this.audTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.corpsDataGridView = new System.Windows.Forms.DataGridView();
            this.corpsRemoveBtn = new System.Windows.Forms.Button();
            this.DGVTab.SuspendLayout();
            this.AudienceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudienceLOGDataGridView)).BeginInit();
            this.CorptabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorpLogDataGridView)).BeginInit();
            this.TeacherTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherLogDataGridView)).BeginInit();
            this.TabPageSQL.SuspendLayout();
            this.AudTypeTabPage.SuspendLayout();
            this.CorpstabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTab
            // 
            this.DGVTab.Controls.Add(this.AudienceTabPage);
            this.DGVTab.Controls.Add(this.CorptabPage);
            this.DGVTab.Controls.Add(this.TeacherTabPage);
            this.DGVTab.Controls.Add(this.TabPageSQL);
            this.DGVTab.Controls.Add(this.AudTypeTabPage);
            this.DGVTab.Controls.Add(this.CorpstabPage);
            this.DGVTab.Location = new System.Drawing.Point(12, 12);
            this.DGVTab.Name = "DGVTab";
            this.DGVTab.SelectedIndex = 0;
            this.DGVTab.Size = new System.Drawing.Size(663, 426);
            this.DGVTab.TabIndex = 2;
            // 
            // AudienceTabPage
            // 
            this.AudienceTabPage.Controls.Add(this.AudienceLOGDataGridView);
            this.AudienceTabPage.Location = new System.Drawing.Point(4, 22);
            this.AudienceTabPage.Name = "AudienceTabPage";
            this.AudienceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AudienceTabPage.Size = new System.Drawing.Size(655, 400);
            this.AudienceTabPage.TabIndex = 0;
            this.AudienceTabPage.Text = "AudienceLOG";
            this.AudienceTabPage.UseVisualStyleBackColor = true;
            // 
            // AudienceLOGDataGridView
            // 
            this.AudienceLOGDataGridView.AllowUserToAddRows = false;
            this.AudienceLOGDataGridView.AllowUserToDeleteRows = false;
            this.AudienceLOGDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AudienceLOGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AudienceLOGDataGridView.Location = new System.Drawing.Point(6, 6);
            this.AudienceLOGDataGridView.Name = "AudienceLOGDataGridView";
            this.AudienceLOGDataGridView.ReadOnly = true;
            this.AudienceLOGDataGridView.Size = new System.Drawing.Size(643, 388);
            this.AudienceLOGDataGridView.TabIndex = 0;
            // 
            // CorptabPage
            // 
            this.CorptabPage.Controls.Add(this.CorpLogDataGridView);
            this.CorptabPage.Location = new System.Drawing.Point(4, 22);
            this.CorptabPage.Name = "CorptabPage";
            this.CorptabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CorptabPage.Size = new System.Drawing.Size(655, 400);
            this.CorptabPage.TabIndex = 1;
            this.CorptabPage.Text = "CorpLOG";
            this.CorptabPage.UseVisualStyleBackColor = true;
            // 
            // CorpLogDataGridView
            // 
            this.CorpLogDataGridView.AllowUserToAddRows = false;
            this.CorpLogDataGridView.AllowUserToDeleteRows = false;
            this.CorpLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CorpLogDataGridView.Location = new System.Drawing.Point(6, 6);
            this.CorpLogDataGridView.Name = "CorpLogDataGridView";
            this.CorpLogDataGridView.ReadOnly = true;
            this.CorpLogDataGridView.Size = new System.Drawing.Size(643, 388);
            this.CorpLogDataGridView.TabIndex = 0;
            // 
            // TeacherTabPage
            // 
            this.TeacherTabPage.Controls.Add(this.TeacherLogDataGridView);
            this.TeacherTabPage.Location = new System.Drawing.Point(4, 22);
            this.TeacherTabPage.Name = "TeacherTabPage";
            this.TeacherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherTabPage.Size = new System.Drawing.Size(655, 400);
            this.TeacherTabPage.TabIndex = 2;
            this.TeacherTabPage.Text = "TeacherLOG";
            this.TeacherTabPage.UseVisualStyleBackColor = true;
            // 
            // TeacherLogDataGridView
            // 
            this.TeacherLogDataGridView.AllowUserToAddRows = false;
            this.TeacherLogDataGridView.AllowUserToDeleteRows = false;
            this.TeacherLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherLogDataGridView.Location = new System.Drawing.Point(6, 6);
            this.TeacherLogDataGridView.Name = "TeacherLogDataGridView";
            this.TeacherLogDataGridView.ReadOnly = true;
            this.TeacherLogDataGridView.Size = new System.Drawing.Size(643, 388);
            this.TeacherLogDataGridView.TabIndex = 0;
            // 
            // PasswordButton
            // 
            this.PasswordButton.Location = new System.Drawing.Point(677, 12);
            this.PasswordButton.Name = "PasswordButton";
            this.PasswordButton.Size = new System.Drawing.Size(105, 23);
            this.PasswordButton.TabIndex = 1;
            this.PasswordButton.Text = "Сменить пароль";
            this.PasswordButton.UseVisualStyleBackColor = true;
            this.PasswordButton.Click += new System.EventHandler(this.PasswordButton_Click);
            // 
            // RealoadButton
            // 
            this.RealoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RealoadButton.Location = new System.Drawing.Point(677, 40);
            this.RealoadButton.Name = "RealoadButton";
            this.RealoadButton.Size = new System.Drawing.Size(105, 23);
            this.RealoadButton.TabIndex = 3;
            this.RealoadButton.Text = "Обновить";
            this.RealoadButton.UseVisualStyleBackColor = true;
            this.RealoadButton.Click += new System.EventHandler(this.RealoadButton_Click);
            // 
            // BackUpbutton
            // 
            this.BackUpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackUpbutton.Location = new System.Drawing.Point(677, 69);
            this.BackUpbutton.Name = "BackUpbutton";
            this.BackUpbutton.Size = new System.Drawing.Size(105, 23);
            this.BackUpbutton.TabIndex = 4;
            this.BackUpbutton.Text = "Резервная копия";
            this.BackUpbutton.UseVisualStyleBackColor = true;
            this.BackUpbutton.Click += new System.EventHandler(this.BackUpbutton_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(677, 98);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(105, 23);
            this.RestoreButton.TabIndex = 5;
            this.RestoreButton.Text = "Восстановить БД";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файл бекапа базы|*.bak";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Файлы бекапа базы данных|*.bak";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(677, 154);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(105, 23);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "Экспорт csv";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(677, 183);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(105, 23);
            this.ImportButton.TabIndex = 7;
            this.ImportButton.Text = "Импорт csv";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ImportExportbutton
            // 
            this.ImportExportbutton.Location = new System.Drawing.Point(677, 212);
            this.ImportExportbutton.Name = "ImportExportbutton";
            this.ImportExportbutton.Size = new System.Drawing.Size(105, 23);
            this.ImportExportbutton.TabIndex = 8;
            this.ImportExportbutton.Text = "I/E мастер";
            this.ImportExportbutton.UseVisualStyleBackColor = true;
            this.ImportExportbutton.Click += new System.EventHandler(this.ImportExportbutton_Click);
            // 
            // TablecomboBox
            // 
            this.TablecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablecomboBox.FormattingEnabled = true;
            this.TablecomboBox.Location = new System.Drawing.Point(677, 127);
            this.TablecomboBox.Name = "TablecomboBox";
            this.TablecomboBox.Size = new System.Drawing.Size(105, 21);
            this.TablecomboBox.TabIndex = 9;
            // 
            // GetCountRecButton
            // 
            this.GetCountRecButton.Location = new System.Drawing.Point(677, 241);
            this.GetCountRecButton.Name = "GetCountRecButton";
            this.GetCountRecButton.Size = new System.Drawing.Size(105, 23);
            this.GetCountRecButton.TabIndex = 10;
            this.GetCountRecButton.Text = "Кол-Во записей";
            this.GetCountRecButton.UseVisualStyleBackColor = true;
            this.GetCountRecButton.Click += new System.EventHandler(this.GetCountRecButton_Click);
            // 
            // allCapacityButton
            // 
            this.allCapacityButton.Location = new System.Drawing.Point(677, 297);
            this.allCapacityButton.Name = "allCapacityButton";
            this.allCapacityButton.Size = new System.Drawing.Size(105, 23);
            this.allCapacityButton.TabIndex = 11;
            this.allCapacityButton.Text = "Вместимость";
            this.allCapacityButton.UseVisualStyleBackColor = true;
            this.allCapacityButton.Click += new System.EventHandler(this.AllCapacityButton_Click);
            // 
            // corpscomboBox
            // 
            this.corpscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.corpscomboBox.FormattingEnabled = true;
            this.corpscomboBox.Location = new System.Drawing.Point(677, 270);
            this.corpscomboBox.Name = "corpscomboBox";
            this.corpscomboBox.Size = new System.Drawing.Size(105, 21);
            this.corpscomboBox.TabIndex = 12;
            // 
            // TabPageSQL
            // 
            this.TabPageSQL.Controls.Add(this.queryTextBox);
            this.TabPageSQL.Controls.Add(this.QueryButton);
            this.TabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.TabPageSQL.Name = "TabPageSQL";
            this.TabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSQL.Size = new System.Drawing.Size(655, 400);
            this.TabPageSQL.TabIndex = 3;
            this.TabPageSQL.Text = "AdminQuery";
            this.TabPageSQL.UseVisualStyleBackColor = true;
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(502, 360);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(147, 34);
            this.QueryButton.TabIndex = 0;
            this.QueryButton.Text = "Выполнить запрос";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(6, 6);
            this.queryTextBox.Multiline = true;
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(643, 348);
            this.queryTextBox.TabIndex = 1;
            // 
            // AudTypeTabPage
            // 
            this.AudTypeTabPage.Controls.Add(this.audTypeDataGridView);
            this.AudTypeTabPage.Controls.Add(this.removeTypeAddbtn);
            this.AudTypeTabPage.Location = new System.Drawing.Point(4, 22);
            this.AudTypeTabPage.Name = "AudTypeTabPage";
            this.AudTypeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AudTypeTabPage.Size = new System.Drawing.Size(655, 400);
            this.AudTypeTabPage.TabIndex = 4;
            this.AudTypeTabPage.Text = "AudType";
            this.AudTypeTabPage.UseVisualStyleBackColor = true;
            // 
            // CorpstabPage
            // 
            this.CorpstabPage.Controls.Add(this.corpsDataGridView);
            this.CorpstabPage.Controls.Add(this.corpsRemoveBtn);
            this.CorpstabPage.Location = new System.Drawing.Point(4, 22);
            this.CorpstabPage.Name = "CorpstabPage";
            this.CorpstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CorpstabPage.Size = new System.Drawing.Size(655, 400);
            this.CorpstabPage.TabIndex = 5;
            this.CorpstabPage.Text = "Corps";
            this.CorpstabPage.UseVisualStyleBackColor = true;
            // 
            // removeTypeAddbtn
            // 
            this.removeTypeAddbtn.Location = new System.Drawing.Point(574, 371);
            this.removeTypeAddbtn.Name = "removeTypeAddbtn";
            this.removeTypeAddbtn.Size = new System.Drawing.Size(75, 23);
            this.removeTypeAddbtn.TabIndex = 1;
            this.removeTypeAddbtn.Text = "Удалить";
            this.removeTypeAddbtn.UseVisualStyleBackColor = true;
            this.removeTypeAddbtn.Click += new System.EventHandler(this.removeTypeAddbtn_Click);
            // 
            // audTypeDataGridView
            // 
            this.audTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.audTypeDataGridView.Location = new System.Drawing.Point(6, 6);
            this.audTypeDataGridView.Name = "audTypeDataGridView";
            this.audTypeDataGridView.Size = new System.Drawing.Size(643, 359);
            this.audTypeDataGridView.TabIndex = 2;
            // 
            // corpsDataGridView
            // 
            this.corpsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.corpsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.corpsDataGridView.Name = "corpsDataGridView";
            this.corpsDataGridView.Size = new System.Drawing.Size(643, 359);
            this.corpsDataGridView.TabIndex = 5;
            // 
            // corpsRemoveBtn
            // 
            this.corpsRemoveBtn.Location = new System.Drawing.Point(574, 371);
            this.corpsRemoveBtn.Name = "corpsRemoveBtn";
            this.corpsRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.corpsRemoveBtn.TabIndex = 4;
            this.corpsRemoveBtn.Text = "Удалить";
            this.corpsRemoveBtn.UseVisualStyleBackColor = true;
            this.corpsRemoveBtn.Click += new System.EventHandler(this.corpsRemoveBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 480);
            this.Controls.Add(this.corpscomboBox);
            this.Controls.Add(this.allCapacityButton);
            this.Controls.Add(this.GetCountRecButton);
            this.Controls.Add(this.TablecomboBox);
            this.Controls.Add(this.ImportExportbutton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.BackUpbutton);
            this.Controls.Add(this.RealoadButton);
            this.Controls.Add(this.PasswordButton);
            this.Controls.Add(this.DGVTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(788, 519);
            this.Name = "AdminForm";
            this.Text = "Панель администратора";
            this.DGVTab.ResumeLayout(false);
            this.AudienceTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AudienceLOGDataGridView)).EndInit();
            this.CorptabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CorpLogDataGridView)).EndInit();
            this.TeacherTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherLogDataGridView)).EndInit();
            this.TabPageSQL.ResumeLayout(false);
            this.TabPageSQL.PerformLayout();
            this.AudTypeTabPage.ResumeLayout(false);
            this.CorpstabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.audTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl DGVTab;
        private System.Windows.Forms.TabPage AudienceTabPage;
        private System.Windows.Forms.DataGridView AudienceLOGDataGridView;
        private System.Windows.Forms.TabPage CorptabPage;
        private System.Windows.Forms.DataGridView CorpLogDataGridView;
        private System.Windows.Forms.TabPage TeacherTabPage;
        private System.Windows.Forms.DataGridView TeacherLogDataGridView;
        private System.Windows.Forms.Button PasswordButton;
        private System.Windows.Forms.Button RealoadButton;
        private System.Windows.Forms.Button BackUpbutton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ImportExportbutton;
        private System.Windows.Forms.ComboBox TablecomboBox;
        private System.Windows.Forms.Button GetCountRecButton;
        private System.Windows.Forms.Button allCapacityButton;
        private System.Windows.Forms.ComboBox corpscomboBox;
        private System.Windows.Forms.TabPage TabPageSQL;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.TabPage AudTypeTabPage;
        private System.Windows.Forms.DataGridView audTypeDataGridView;
        private System.Windows.Forms.Button removeTypeAddbtn;
        private System.Windows.Forms.TabPage CorpstabPage;
        private System.Windows.Forms.DataGridView corpsDataGridView;
        private System.Windows.Forms.Button corpsRemoveBtn;
    }
}