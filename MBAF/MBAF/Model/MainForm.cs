using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MBAF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        DataBase.MyDBContext context = new DataBase.MyDBContext();

        void DGVRefresh()
        {
            //context.AudienceType.Load();
            //MainDataGridView.DataSource = context.AudienceType.Local.ToBindingList();
            MainDataGridView.DataSource = null;
            var DGVDataSource = from Audience in context.AudienceType
                                join Corps in context.Corps on Audience.Corpid equals Corps.Id
                                join Teachers in context.Teachers on Audience.Teacherid equals Teachers.Id
                                select new
                                {
                                    AudienceID = Audience.Id,
                                    AudienceType = Audience.TypeOf,
                                    AudienceCabinet = Audience.Cabinet,
                                    AudienceCorp = Corps.CorpNumber,
                                    Responsible_Fname = Teachers.Fname,
                                    Responsible_Mname = Teachers.Mname,
                                    Responsible_Lname = Teachers.Lname,
                                    Responsible_Phone = Teachers.Phone
                                };
            MainDataGridView.ContextMenuStrip = MainContextMenuStrip;
            MainDataGridView.DataSource = DGVDataSource.ToList();
            MainDataGridView.Columns[0].Visible = false;





        }

        private void ConnectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVRefresh();
        }

        private void DisconncetDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDataGridView.DataSource = null;
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainDataGridView.DataSource != null)
            {
                DGVRefresh();

            }
        }

        void ShowAddAudience()
        {
            Model.AddAudience add = null;
            if (MainDataGridView.DataSource != null)
            {
                add = new Model.AddAudience(context);
                add.ShowDialog();
                add.Dispose();
            }
            else
                MessageBox.Show("Таблица не подключена! Пожалуйста подключите таблицу и попробуйте еще раз", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        void DeleteRow()
        {

            int id = 0;

            if (MainDataGridView.DataSource != null)
                if (MainDataGridView.CurrentRow != null)
                {
                    id = Convert.ToInt32(MainDataGridView.CurrentRow.Cells[0].Value);
                    if (id != null)
                    {
                        DataBase.AudienceType audience = context.AudienceType.Where(c => c.Id == id).FirstOrDefault();
                        context.AudienceType.Remove(audience);
                        context.SaveChanges();
                    }
                    else
                        MessageBox.Show("Таблица не подключена! Пожалуйста подключите таблицу и попробуйте еще раз", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                    MessageBox.Show("Запись не выбрана! Пожалуйста выберете запись и попробуйте еще раз", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        void editrow()
        {
            int Id = -1;
            if (MainDataGridView.DataSource != null)
            {
                if (MainDataGridView.CurrentRow != null)
                {
                    Id = Convert.ToInt32(MainDataGridView.CurrentRow.Cells[0].Value);
                    if (Id != null)
                    {
                        Model.EditRecords edit = new Model.EditRecords(Id);
                        edit.ShowDialog();


                    }
                    else
                        MessageBox.Show("Таблица не подключена! Пожалуйста подключите таблицу и попробуйте еще раз", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Запись не выбрана! Пожалуйста выберете запись и попробуйте еще раз", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void AddAudienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddAudience();
        }

        private void УдалитьАудиториюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void AddTpoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddAudience();
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editrow();
        }

        private void ОтредактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editrow();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
        }
    }
}
