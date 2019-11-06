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
            this.DGVTab.SuspendLayout();
            this.AudienceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudienceLOGDataGridView)).BeginInit();
            this.CorptabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorpLogDataGridView)).BeginInit();
            this.TeacherTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTab
            // 
            this.DGVTab.Controls.Add(this.AudienceTabPage);
            this.DGVTab.Controls.Add(this.CorptabPage);
            this.DGVTab.Controls.Add(this.TeacherTabPage);
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
            this.AudienceLOGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AudienceLOGDataGridView.Location = new System.Drawing.Point(3, 3);
            this.AudienceLOGDataGridView.Name = "AudienceLOGDataGridView";
            this.AudienceLOGDataGridView.ReadOnly = true;
            this.AudienceLOGDataGridView.Size = new System.Drawing.Size(646, 388);
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
            this.PasswordButton.Size = new System.Drawing.Size(83, 23);
            this.PasswordButton.TabIndex = 1;
            this.PasswordButton.Text = "Password";
            this.PasswordButton.UseVisualStyleBackColor = true;
            this.PasswordButton.Click += new System.EventHandler(this.PasswordButton_Click);
            // 
            // RealoadButton
            // 
            this.RealoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RealoadButton.Location = new System.Drawing.Point(677, 40);
            this.RealoadButton.Name = "RealoadButton";
            this.RealoadButton.Size = new System.Drawing.Size(83, 23);
            this.RealoadButton.TabIndex = 3;
            this.RealoadButton.Text = "⟳";
            this.RealoadButton.UseVisualStyleBackColor = true;
            this.RealoadButton.Click += new System.EventHandler(this.RealoadButton_Click);
            // 
            // BackUpbutton
            // 
            this.BackUpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackUpbutton.Location = new System.Drawing.Point(677, 69);
            this.BackUpbutton.Name = "BackUpbutton";
            this.BackUpbutton.Size = new System.Drawing.Size(83, 23);
            this.BackUpbutton.TabIndex = 4;
            this.BackUpbutton.Text = "&Backup";
            this.BackUpbutton.UseVisualStyleBackColor = true;
            this.BackUpbutton.Click += new System.EventHandler(this.BackUpbutton_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(677, 98);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(83, 23);
            this.RestoreButton.TabIndex = 5;
            this.RestoreButton.Text = "&Restore";
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
            this.ExportButton.Size = new System.Drawing.Size(83, 23);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "&Export csv";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(677, 183);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(83, 23);
            this.ImportButton.TabIndex = 7;
            this.ImportButton.Text = "&Import csv";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ImportExportbutton
            // 
            this.ImportExportbutton.Location = new System.Drawing.Point(677, 212);
            this.ImportExportbutton.Name = "ImportExportbutton";
            this.ImportExportbutton.Size = new System.Drawing.Size(83, 23);
            this.ImportExportbutton.TabIndex = 8;
            this.ImportExportbutton.Text = "I/E master";
            this.ImportExportbutton.UseVisualStyleBackColor = true;
            this.ImportExportbutton.Click += new System.EventHandler(this.ImportExportbutton_Click);
            // 
            // TablecomboBox
            // 
            this.TablecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablecomboBox.FormattingEnabled = true;
            this.TablecomboBox.Location = new System.Drawing.Point(677, 127);
            this.TablecomboBox.Name = "TablecomboBox";
            this.TablecomboBox.Size = new System.Drawing.Size(83, 21);
            this.TablecomboBox.TabIndex = 9;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 480);
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
            this.MaximumSize = new System.Drawing.Size(788, 519);
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
    }
}