using MBAF.DataBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MBAF.Model
{
    public partial class AddAudience : Form
    {
        private readonly AudienceType audience;
        private readonly Teacher teacher;
        private readonly Corps corps;

        public AddAudience(AudienceType At, Teacher Tc, Corps C)
        {
            this.audience = At;
            this.teacher = Tc;
            this.corps = C;
            InitializeComponent();
            CorpsComboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).ToList();
            CorpsComboBox.SelectedIndex = -1;
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


                if (DBObject.context.AudienceType.Where(c => c.Cabinet == audience.Cabinet&&c.Corp.CorpNumber==corps.CorpNumber).Count() == 0)
                {
                    DBObject.context.Corps.Add(corps);
                    DBObject.context.Teachers.Add(teacher);
                    DBObject.context.AudienceType.Add(audience);
                    DBObject.context.SaveChanges();
                    MessageBox.Show("Запись добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else MessageBox.Show("Запись уже есть!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
                this.Dispose();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введеные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CorpsComboBox_TextUpdate(object sender, EventArgs e)
        {
            if (CorpsComboBox.Text != "")
            {
                AuditorNumericUpDown.Enabled = true;
                AuditoryCapacityNumericUpDown.Enabled = true;
                CabinetTextBox.Enabled = true;
                AudTypeTextBox.Enabled = true;
                MnameTextBox.Enabled = true;
                LnameTextBox.Enabled = true;
                FnameTextBox.Enabled = true;
                BirthDayMaskedTextBox.Enabled = true;
                PhoneMaskedTextBox.Enabled = true;
            }
            else
            {
                AuditorNumericUpDown.Enabled = false;
                AuditoryCapacityNumericUpDown.Enabled = false;
                CabinetTextBox.Enabled = false;
                AudTypeTextBox.Enabled = false;
                MnameTextBox.Enabled = false;
                LnameTextBox.Enabled = false;
                FnameTextBox.Enabled = false;
                BirthDayMaskedTextBox.Enabled = false;
                PhoneMaskedTextBox.Enabled = false;
            }
        }

    }
}
