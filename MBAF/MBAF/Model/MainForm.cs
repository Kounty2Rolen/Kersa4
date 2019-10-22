using System;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
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

        }


        private void ConnectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var context = new DataBase.MyDBContext())
            {
                //context.AudienceType.Load();
                //MainDataGridView.DataSource = context.AudienceType.Local.ToBindingList();
                    var DataSource = from Audience in context.AudienceType
                                     join Corps in context.Corps on Audience.CorpID equals Corps.id
                                     join Teachers in context.Teachers on Audience.ResponsibleID equals Teachers.id
                                     select new
                                     {
                                         AudienceType = Audience.TypeOf,
                                         AudienceCabinet = Audience.Cabinet,
                                         AudienceCorp = Corps.CorpNumber,
                                         Responsible_Fname = Teachers.Fname,
                                         Responsible_Mname = Teachers.Mname,
                                         Responsible_Lname = Teachers.Lname,
                                         Responsible_Phone = Teachers.phone,

                                     };


                MainDataGridView.DataSource = DataSource.ToList(); ;

            }

        }

        private void DisconncetDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDataGridView.DataSource = null;
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainDataGridView.DataSource != null)
            {
                DataSet dataSet = new DataSet();
                dataSet.Dispose();
            }
        }

        private void AddAudienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.AddAudience add = new Model.AddAudience(this);
            add.ShowDialog();

        }
    }
}
