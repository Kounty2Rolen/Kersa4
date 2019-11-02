using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBAF.DataBase;

namespace MBAF.Model.Administrativ
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            AudienceTabPage.Controls.Add(AudienceLOGDataGridView);
            CorptabPage.Controls.Add(CorpLogDataGridView);
            TeacherTabPage.Controls.Add(TeacherLogDataGridView);
        }
        
        private void PasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswor = new ChangePassword();
            changePasswor.ShowDialog();
        }

        private void RealoadButton_Click(object sender, EventArgs e)
        {
            TeacherLogDataGridView.DataSource = DBObject.context.TeachersLog.ToList();
            CorpLogDataGridView.DataSource = DBObject.context.CorpsLog.ToList();
            AudienceLOGDataGridView.DataSource = DBObject.context.AudienceLog.ToList();
        }
    }
}
