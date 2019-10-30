namespace MBAF.Model.Administrativ
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
            this.AudienceLOGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AudienceLOGDataGridView.Location = new System.Drawing.Point(3, 3);
            this.AudienceLOGDataGridView.Name = "AudienceLOGDataGridView";
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
            this.CorpLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CorpLogDataGridView.Location = new System.Drawing.Point(6, 6);
            this.CorpLogDataGridView.Name = "CorpLogDataGridView";
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
            this.TeacherLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherLogDataGridView.Location = new System.Drawing.Point(6, 6);
            this.TeacherLogDataGridView.Name = "TeacherLogDataGridView";
            this.TeacherLogDataGridView.Size = new System.Drawing.Size(643, 388);
            this.TeacherLogDataGridView.TabIndex = 0;
            // 
            // PasswordButton
            // 
            this.PasswordButton.Location = new System.Drawing.Point(677, 12);
            this.PasswordButton.Name = "PasswordButton";
            this.PasswordButton.Size = new System.Drawing.Size(32, 23);
            this.PasswordButton.TabIndex = 1;
            this.PasswordButton.Text = "P";
            this.PasswordButton.UseVisualStyleBackColor = true;
            this.PasswordButton.Click += new System.EventHandler(this.PasswordButton_Click);
            // 
            // RealoadButton
            // 
            this.RealoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RealoadButton.Location = new System.Drawing.Point(677, 40);
            this.RealoadButton.Name = "RealoadButton";
            this.RealoadButton.Size = new System.Drawing.Size(32, 23);
            this.RealoadButton.TabIndex = 3;
            this.RealoadButton.Text = "⟳";
            this.RealoadButton.UseVisualStyleBackColor = true;
            this.RealoadButton.Click += new System.EventHandler(this.RealoadButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 480);
            this.Controls.Add(this.RealoadButton);
            this.Controls.Add(this.PasswordButton);
            this.Controls.Add(this.DGVTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}