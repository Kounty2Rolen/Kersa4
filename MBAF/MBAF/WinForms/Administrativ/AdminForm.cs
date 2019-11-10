using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBAF.EntityModel;
using System.IO;

namespace MBAF.WinForms.Administrativ
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            RealoadButton_Click(this, new EventArgs());
            corpscomboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).ToList();
            TablecomboBox.DataSource = DBObject.context.Database.SqlQuery<string>(@"use MBAF Select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_NAME not like 'sysdiagrams'").ToList(); ;
        }

        private void PasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswor = new ChangePassword();
            changePasswor.ShowDialog();
        }

        private void RealoadButton_Click(object sender, EventArgs e)
        {
            TeacherLogDataGridView.DataSource = DBObject.context.TeacherLOG.ToList();
            TeacherLogDataGridView.Columns["operation_dt"].SortMode = DataGridViewColumnSortMode.Automatic;
            CorpLogDataGridView.DataSource = DBObject.context.CorpsLOG.ToList();
            CorpLogDataGridView.Columns["operation_dt"].SortMode = DataGridViewColumnSortMode.Automatic;
            AudienceLOGDataGridView.DataSource = DBObject.context.AudienceTypeLOG.ToList();
            AudienceLOGDataGridView.Columns["operation_dt"].SortMode = DataGridViewColumnSortMode.Automatic;

        }

        private void BackUpbutton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "bak-Файл|*.bak";
            saveFileDialog.DefaultExt = ".bak";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                DBObject.context.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, $"use master backup database MBAF to disk=\'{saveFileDialog.FileName}\'");
                MessageBox.Show("Резервная копия сделана успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "bak-Файл|*.bak";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".bak"))
                {
                    DBObject.context.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, $"use master restore database MBAF from  disk=\'{openFileDialog.FileName}\' with replace");
                    MessageBox.Show("База данных успешно восстановлена из резервной копии!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "csv-файл|*.csv";
            saveFileDialog.DefaultExt = ".csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Process.Start("sqlcmd.exe" ,$"-S WIN-O6S40144ELL\\SQLEXPRESS -d MBAF -Q \"select * from {TablecomboBox.SelectedItem}\" -o \"{saveFileDialog.FileName}\" -s" + ';' + " -w 700 ").WaitForExit();
                MessageBox.Show("Таблица успешно экпортирована!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "CSV-Файл|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".csv"))
                {
                    DBObject.context.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, $"bulk insert Reservation from \'{openFileDialog.FileName}\' with(keepidentity, fieldterminator=\';\', rowterminator=\'\\n\'");
                    MessageBox.Show("Данные успешно импортированы из файла!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ImportExportbutton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft SQL Server\140\DTS\Binn\DTSWizard.exe");

        }

        private void GetCountRecButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кол-во записей: "+DBObject.context.GetCountOfAllRecords().FirstOrDefault().ToString());
        }

        private void allCapacityButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DBObject.context.Database.SqlQuery<int>($"use MBAF select dbo.GetHumanCapacity({ corpscomboBox.SelectedItem.ToString()})").FirstOrDefault().ToString());
        }
    }
}
