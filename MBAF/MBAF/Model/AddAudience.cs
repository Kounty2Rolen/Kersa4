using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBAF.Model
{
    public partial class AddAudience : Form
    {
        public AddAudience(in MainForm main)
        {
            InitializeComponent();
            //DataSet ds = new DataSet();
            //CorpsComboBox.DataSource=(from DataRow row in main.GetContect(in ds, "select  c.CorpNumber  from Corps c").Tables[0].Rows select row["CorpNumber"]).ToList();
            using (var context = new DataBase.MyDBContext())
            {
                CorpsComboBox.DataSource = context.Corps.Select(c => c.CorpNumber).ToList();
                CorpsComboBox.SelectedIndex = -1;
            }
        }

        private void CorpsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CorpsComboBox.SelectedIndex >= 0)
            {
                CabinetComboBox.Enabled = true;
               
                    using (var context = new DataBase.MyDBContext())
                    {
                        CabinetComboBox.DataSource = context.AudienceType.Select(c => c.Cabinet).ToList();
                        CabinetComboBox.SelectedIndex = -1;
                    }
            }
            else
                CabinetComboBox.Enabled = false;

        }

        private void CabinetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CabinetComboBox.SelectedIndex >= 0)
            {
                FireSecurityComboBox.Enabled = true;
                if (FireSecurityComboBox.DataSource == null)
                    using (var context = new DataBase.MyDBContext())
                {
                    FireSecurityComboBox.DataSource = context.AudienceType.Select(c => c.Cabinet).ToList();
                    FireSecurityComboBox.SelectedIndex = -1;
                }
            }
            else
                FireSecurityComboBox.Enabled = false;

        }

        private void FireSecurityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (FireSecurityComboBox.SelectedIndex >= 0)
            {
                PhoneMaskedTextBox.Enabled = true;
            }
            else
                PhoneMaskedTextBox.Enabled = false;

        }
    }
}
