using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBAF.Model.Administrativ
{
    public partial class AdminForm : Form
    {
        DataBase.MyDBContext context;
        public AdminForm(ref DataBase.MyDBContext context)
        {
            InitializeComponent();
            this.context = context;
            AudienceTabPage.Controls.Add(AudienceLOGDataGridView);
            CorptabPage.Controls.Add(CorpLogDataGridView);
            TeacherTabPage.Controls.Add(TeacherLogDataGridView);
        }
        
        private void PasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswor = new ChangePassword(ref context);
            changePasswor.ShowDialog();
        }

        private void RealoadButton_Click(object sender, EventArgs e)
        {
            TeacherLogDataGridView.DataSource = context.TeachersLog.ToList();
            CorpLogDataGridView.DataSource = context.CorpsLog.ToList();
            AudienceLOGDataGridView.DataSource = context.AudienceLog.ToList();
        }
    }
}
