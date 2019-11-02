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

namespace MBAF.Model
{
    public partial class EditRecords : Form
    {
        DataBase.Corps corps;
        DataBase.Teacher teacher;
        DataBase.AudienceType audience;
        public EditRecords(AudienceType audience)
        {
            InitializeComponent();
            this.audience = audience;
            teacher = audience.Teacher;
            corps = audience.Corp;

        }

        private void EditRecords_Shown(object sender, EventArgs e)
        {
            IDlabel.Text = audience.Id.ToString();
            CorpsComboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).ToList();
            CorpsComboBox.SelectedItem = corps.CorpNumber.FirstOrDefault();
            AuditorNumericUpDown.Value = corps.NumberOfAudiences;
            AuditoryCapacityNumericUpDown.Value = audience.Capacity;
            AudTypeTextBox.Text = audience.TypeOf;
            CabinetTextBox.Text = audience.Cabinet;
            MnameTextBox.Text = teacher.Mname;
            FnameTextBox.Text = teacher.Fname;
            LnameTextBox.Text = teacher.Lname;
            BirthDayMaskedTextBox.Text = DateTime.Parse(teacher.Birthday.ToString()).ToString();
            PhoneMaskedTextBox.Text = teacher.Phone;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            corps.NumberOfAudiences = (int)AuditorNumericUpDown.Value;
            corps.CorpNumber = CorpsComboBox.Text;
            audience.Cabinet = CabinetTextBox.Text;
            audience.Capacity = (int)AuditoryCapacityNumericUpDown.Value;
            audience.TypeOf = AudTypeTextBox.Text;
            teacher.Mname = MnameTextBox.Text;
            teacher.Fname = FnameTextBox.Text;
            teacher.Lname = LnameTextBox.Text;
            teacher.Phone = PhoneMaskedTextBox.Text;
            teacher.Birthday = DateTime.Parse(BirthDayMaskedTextBox.Text);
            DBObject.context.SaveChanges();
            MessageBox.Show("Запись Изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
            this.Dispose();
        }
    }
}
