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
        DataBase.MyDBContext context;
        DataBase.Corps corps;
        DataBase.Teacher teacher;
        DataBase.AudienceType audience;
        int id = 0;
        public EditRecords(int id,ref DataBase.MyDBContext context)
        {
            InitializeComponent();
            this.context = context;
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
            context.SaveChanges();
            MessageBox.Show("Запись Изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
            this.Dispose();
        }

        private void EditRecords_Load(object sender, EventArgs e)
        {

        }
    }
}
