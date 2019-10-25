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
    public partial class EditRecords : Form
    {
        DataBase.MyDBContext context = new DataBase.MyDBContext();
        DataBase.Corps corps;
        DataBase.Teacher teacher;
        DataBase.AudienceType audience;
        int id = 0;
        public EditRecords(int id)
        {
            InitializeComponent();
            this.id = id;
            corps = context.Corps.Where(c => c.Id == id).FirstOrDefault();
            teacher = context.Teachers.Where(c => c.Id == id).SingleOrDefault();
            audience = context.AudienceType.Where(c => c.Id == id).SingleOrDefault();

        }

        private void EditRecords_Shown(object sender, EventArgs e)
        {
            IDlabel.Text = id.ToString();
            CorpsComboBox.DataSource = context.Corps.Select(c => c.CorpNumber).ToList();
            CorpsComboBox.SelectedItem = corps.CorpNumber.FirstOrDefault();
            AuditorNumericUpDown.Value = corps.NumberOfAudiences;
            AuditoryCapacityNumericUpDown.Value = audience.Capacity;
            AudTypeTextBox.Text = audience.TypeOf;
            CabinetTextBox.Text = audience.Cabinet;
            FIOTextBox.Text = teacher.Mname + " " + teacher.Fname + " " + teacher.Lname;
            BirthDayMaskedTextBox.Text = teacher.Birthday.ToString().Reverse().ToString();
            PhoneMaskedTextBox.Text = teacher.Phone;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            corps.NumberOfAudiences = (int)AuditorNumericUpDown.Value;
            corps.CorpNumber = CorpsComboBox.Text;
            audience.Cabinet = CabinetTextBox.Text;
            audience.Capacity = (int)AuditoryCapacityNumericUpDown.Value;
            audience.TypeOf = AudTypeTextBox.Text;
            var fio = FIOTextBox.Text.Split(' ');
            teacher.Mname = fio[0];
            teacher.Fname = fio[1];
            teacher.Lname = fio[2];
            teacher.Phone = PhoneMaskedTextBox.Text;
            teacher.Birthday = DateTime.Parse(BirthDayMaskedTextBox.Text);
            context.SaveChanges();
            MessageBox.Show("Запись Изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
            this.Dispose();
        }
    }
}
