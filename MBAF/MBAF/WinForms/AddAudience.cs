using MBAF.EntityModel;
using System;
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
        public AddAudience(AudienceType audtype,Teacher teacher,Corps corp)
        {
            this.audience = audtype;
            this.teacher = teacher;
            this.corps = corp;
            InitializeComponent();
            CorpsComboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).ToList();
            CorpsComboBox.SelectedIndex = -1;
            if (DBObject.context.AudienceType.Where(c=>c.Id==audtype.Id).Count()>0)
                Fill();
        }

        void Fill()
        {
            CorpsComboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).ToList();
            CorpsComboBox.SelectedItem = corps.CorpNumber.FirstOrDefault();
            AuditorNumericUpDown.Value = corps.NumberOfAudiences;
            AuditoryCapacityNumericUpDown.Value = audience.Capacity;
            AudTypeTextBox.Text = audience.TypeOf;
            CabinetTextBox.Text = audience.Cabinet;
            MnameTextBox.Text = teacher.Mname;
            FnameTextBox.Text = teacher.Fname;
            LnameTextBox.Text = teacher.Lname;
            //BirthDayMaskedTextBox.Text = DateTime.Parse(teacher.Birthday.ToString()).ToString();
            LnameTextBox.Text = DateTime.Parse(teacher.Birthday.ToString()).ToString();
            PhoneMaskedTextBox.Text = teacher.Phone;


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime.Parse(BirthDayMaskedTextBox.Text);

                teacher.Mname = MnameTextBox.Text;
                teacher.Fname = FnameTextBox.Text;
                teacher.Lname = LnameTextBox.Text;
                teacher.Phone = PhoneMaskedTextBox.Text;
                teacher.Birthday = DateTime.Parse(BirthDayMaskedTextBox.Text);

                corps.CorpNumber = CorpsComboBox.Text;
                corps.NumberOfAudiences = (int)AuditorNumericUpDown.Value;


                audience.Cabinet = CabinetTextBox.Text;
                audience.TypeOf = AudTypeTextBox.Text;
                audience.Capacity = (int)AuditoryCapacityNumericUpDown.Value;
                audience.Teacherid = teacher.Id;
                audience.Corpid = corps.Id;


                if (DBObject.context.AudienceType.Where(c => c.Id == corps.Id).Count() == 0 && DBObject.context.Teachers.Where(c => c.Id == teacher.Id).Count() == 0 && DBObject.context.Corps.Where(c => c.Id == corps.Id).Count() == 0)
                {
                    DBObject.context.Corps.Add(corps);
                    DBObject.context.Teachers.Add(teacher);
                    DBObject.context.AudienceType.Add(audience);

                    MessageBox.Show("Запись добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                DBObject.context.SaveChanges();

                this.Close();
                this.Dispose();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Проверьте введеные данные!\n\n"+exc.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
