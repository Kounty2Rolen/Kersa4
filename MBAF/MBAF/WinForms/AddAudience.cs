using MBAF.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MBAF.WinForms
{
    public partial class AddAudience : Form
    {
        private readonly AudienceType audience;
        private readonly Teacher teacher;
        private readonly Corps corps;
        private readonly AudType type;
        public AddAudience(AudienceType audtype, Corps corps, Teacher teacher, AudType type)
        {
            this.audience = audtype;
            this.teacher = teacher;
            this.corps = corps;
            this.type = type;
            InitializeComponent();
            CorpsComboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).ToList();
            CorpsComboBox.SelectedIndex = -1;
            if (DBObject.context.AudienceType.Where(c=>c.id==audtype.id).Count()>0)
                Fill();
        }

        void Fill()
        {
            CorpsComboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).ToList();
            CorpsComboBox.SelectedItem = corps.CorpNumber.FirstOrDefault();
            AuditorNumericUpDown.Value =(int) corps.NumberOfAudiences;
            AuditoryCapacityNumericUpDown.Value = audience.Capacity;
            AudienceTypecomboBox.DataSource = DBObject.context.AudType.Select(c => c.AudienceType).ToList();
            AudienceTypecomboBox.Text = type.AudType1;
            CabinetTextBox.Text = audience.Cabinet;
            MnameTextBox.Text = teacher.Mname;
            FnameTextBox.Text = teacher.Fname;
            LnameTextBox.Text = teacher.Lname;
            //BirthDayMaskedTextBox.Text = DateTime.Parse(teacher.Birthday.ToString()).ToString();
            BirthDateTimePicker.Value =(DateTime)teacher.Birthday;
            PhoneMaskedTextBox.Text = teacher.Phone;


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                teacher.Mname = MnameTextBox.Text;
                teacher.Fname = FnameTextBox.Text;
                teacher.Lname = LnameTextBox.Text;
                teacher.Phone = PhoneMaskedTextBox.Text;
                teacher.Birthday = BirthDateTimePicker.Value;

                corps.CorpNumber = CorpsComboBox.Text;
                corps.NumberOfAudiences = (int)AuditorNumericUpDown.Value;


                audience.Cabinet = CabinetTextBox.Text;
                audience.TypeID = AudienceTypecomboBox.SelectedIndex+1;
                audience.Capacity = (int)AuditoryCapacityNumericUpDown.Value;
                audience.TeacherId = teacher.Id;
                audience.CorpID = corps.Id;

                type.AudType1 = AudienceTypecomboBox.Text;


                if (DBObject.context.AudienceType.Where(c => c.Cabinet == audience.Cabinet).Count() ==0 && DBObject.context.Teacher.Where(c => c.Id== teacher.Id).Count() == 0 && DBObject.context.Corps.Where(c => c.CorpNumber == corps.CorpNumber).Count() == 0)
                {
                    DBObject.context.Corps.Add(corps);
                    DBObject.context.Teacher.Add(teacher);
                    DBObject.context.AudienceType.Add(audience);
                    DBObject.context.AudType.Add(type);

                    MessageBox.Show("Запись добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (corps.Id == 0) MessageBox.Show("Запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBObject.context.SaveChanges();

                this.Dispose();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Проверьте введеные данные!\n\n"+exc.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
