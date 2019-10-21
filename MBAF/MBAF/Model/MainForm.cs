using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MBAF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        internal string conectionstring;
        internal DataSet sqlDS;
        internal SqlConnection sqlc;
        private void подключитсяКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conectionstring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\DataBase\Database1.mdf;Integrated Security=True";
            sqlDS = new DataSet();
            sqlc = new SqlConnection(conectionstring);
            try
            {
                sqlc.Open();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlDataAdapter sqlData = new SqlDataAdapter("select Cor.CorpNumber,Cor.NumberOfAudiences, Aud.TypeOf,Aud.Capacity,T.Fname,T.Mname,T.Lname,T.Phone,T.Birthday  from Corps Cor join AudienceType Aud ON Aud.CorpID=Cor.id join Teacher T on T.Id=Aud.ResponsibleID", sqlc);
            sqlData.Fill(sqlDS);
            MainDataGridView.DataSource = sqlDS.Tables[0].DefaultView;
        }

        private void отключитсяОтБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDataGridView.DataSource = null;
        }

        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainDataGridView.DataSource != null)
            {
                MainDataGridView.DataSource = null;
                SqlDataAdapter sqlData = new SqlDataAdapter("select Cor.CorpNumber,Cor.NumberOfAudiences, Aud.TypeOf,Aud.Capacity,T.Fname,T.Mname,T.Lname,T.Phone,T.Birthday  from Corps Cor join AudienceType Aud ON Aud.CorpID=Cor.id join Teacher T on T.Id=Aud.ResponsibleID", sqlc);
                sqlData.Fill(sqlDS);
                MainDataGridView.DataSource = sqlDS.Tables[0].DefaultView;
            }
        }
    }
}
