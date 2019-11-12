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
            fill();


        }

        //Вызов формы смены пароля
        private void PasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswor = new ChangePassword();
            changePasswor.ShowDialog();
            changePasswor.Dispose();
        }

        /// <summary>
        /// заполнение таблиц
        /// </summary>
        void fill()
        {
            corpscomboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).ToList();
            TablecomboBox.DataSource = DBObject.context.Database.SqlQuery<string>(@"use MBAF Select TABLE_NAME from INFORMATION_SCHEMA.TABLES where 
            TABLE_NAME not like 'sysdiagrams'").ToList();
            TeacherLogDataGridView.DataSource = DBObject.context.TeacherLOG.ToList();
            TeacherLogDataGridView.Columns["operation_dt"].SortMode = DataGridViewColumnSortMode.Automatic;
            CorpLogDataGridView.DataSource = DBObject.context.CorpsLOG.ToList();
            CorpLogDataGridView.Columns["operation_dt"].SortMode = DataGridViewColumnSortMode.Automatic;
            AudienceLOGDataGridView.DataSource = DBObject.context.AudienceTypeLOG.ToList();
            AudienceLOGDataGridView.Columns["operation_dt"].SortMode = DataGridViewColumnSortMode.Automatic;
            audTypeDataGridView.DataSource = DBObject.context.AudType.ToList();
            corpsDataGridView.DataSource = DBObject.context.Corps.ToList();
        }
        private void RealoadButton_Click(object sender, EventArgs e)
        {

            fill();
        }

        #region adminstrativJOB
        /// <summary>
        /// создание бекапа
        /// </summary>
        void Backup()
        {
            try
            {
                saveFileDialog.Filter = "bak-Файл|*.bak";
                saveFileDialog.DefaultExt = ".bak";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    DBObject.context.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, $"use master backup database MBAF" +
                        $" to disk=\'{saveFileDialog.FileName}\'");
                    MessageBox.Show("Резервная копия сделана успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void BackUpbutton_Click(object sender, EventArgs e)
        {
            Backup();

        }


        /// <summary>
        /// Восстанавление данных в SQL с файла бекапа
        /// </summary>
        void Restore()
        {

            try
            {
                openFileDialog.Filter = "bak-Файл|*.bak";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName.EndsWith(".bak"))
                    {
                        DBObject.context.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, $"use master restore database MBAF from  disk=\'{openFileDialog.FileName}\' with replace");
                        MessageBox.Show("База данных успешно восстановлена из резервной копии!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        throw new Exception("Выбран некорректный файл");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        private void RestoreButton_Click(object sender, EventArgs e)
        {
            Restore();
        }

        void Export()
        {
            try
            {
                saveFileDialog.Filter = "csv-файл|*.csv";
                saveFileDialog.DefaultExt = ".csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Process.Start("sqlcmd.exe", $"-S WIN-O6S40144ELL\\SQLEXPRESS -d MBAF -Q \"select * from {TablecomboBox.SelectedItem}\" " +
                        $"-o \"{saveFileDialog.FileName}\" -s" + ';' + " -w 700 ").WaitForExit();
                    MessageBox.Show("Таблица успешно экпортирована!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            Export();
        }

        void Import()
        {
            try
            {
                openFileDialog.Filter = "CSV-Файл|*.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName.EndsWith(".csv"))
                    {
                        DBObject.context.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, $"bulk insert Reservation from " +
                            $"\'{openFileDialog.FileName}\' with(keepidentity, fieldterminator=\';\', rowterminator=\'\\n\'");
                        MessageBox.Show("Данные успешно импортированы из файла!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void ImportButton_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void ImportExportbutton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft SQL Server\140\DTS\Binn\DTSWizard.exe");

        }
        #endregion



        private void GetCountRecButton_Click(object sender, EventArgs e)
        {
            var result = DBObject.context.GetCountOfAllRecords()?.FirstOrDefault().ToString() ?? "Ошибка";
            MessageBox.Show("Кол-во записей: " + result);
        }

        private void AllCapacityButton_Click(object sender, EventArgs e)
        {
            var result = DBObject.context.Database.SqlQuery<int?>($"use MBAF select dbo.GetHumanCapacity({ corpscomboBox.SelectedItem.ToString()})");
            MessageBox.Show(result.FirstOrDefault()?.ToString() ?? "Таблица не выбрана!");

        }



        private void QueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBObject.context.Database.ExecuteSqlCommand(queryTextBox.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void removeTypeAddbtn_Click(object sender, EventArgs e)
        {
            if (audTypeDataGridView.SelectedRows.Count > 0)
            {
                AudType audType = (AudType)audTypeDataGridView.CurrentRow.DataBoundItem;
                DBObject.context.AudType.Remove(audType);
                fill();
            }

        }

        private void corpsRemoveBtn_Click(object sender, EventArgs e)
        {
                if (corpsDataGridView.SelectedRows.Count > 0)
                {
                    Corps corps = (Corps)corpsDataGridView.CurrentRow.DataBoundItem;
                    DBObject.context.Corps.Remove(corps);
                    fill();
                }
        }
    }
}
