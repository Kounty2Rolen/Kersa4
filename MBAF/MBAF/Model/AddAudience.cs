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
        DataBase.MyDBContext context;
        bool FirstRow = false;
        public AddAudience(in DataBase.MyDBContext context, bool FirstRow = false)
        {
            InitializeComponent();
            this.context = context;
            this.FirstRow = FirstRow;
            CorpsComboBox.DataSource = context.Corps.Select(c => c.CorpNumber).ToList();
            CorpsComboBox.SelectedIndex = -1;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime.Parse(BirthDayMaskedTextBox.Text);
                var teacher = new DataBase.Teacher();

                var fio = FIOTextBox.Text.Split(' ');
                teacher.Mname = fio[0];
                teacher.Fname = fio[1];
                teacher.Lname = fio[2];
                fio= null;
                teacher.Phone = PhoneMaskedTextBox.Text;
                teacher.Birthday = DateTime.Parse(BirthDayMaskedTextBox.Text);

                context.Teachers.Add(teacher);

                var corps = new DataBase.Corps
                {
                    CorpNumber = CorpsComboBox.Text,
                    NumberOfAudiences = (int)AuditorNumericUpDown.Value
                };
                context.Corps.Add(corps);

                var AudienceType = new DataBase.AudienceType
                {
                    Cabinet = CabinetTextBox.Text,
                    TypeOf = AudTypeTextBox.Text,
                    Capacity = (int)AuditoryCapacityNumericUpDown.Value
                };
                AudienceType.Teacherid = teacher.Id;
                AudienceType.Corpid = corps.Id;
                context.AudienceType.Add(AudienceType);
                context.SaveChanges();
                MessageBox.Show("Запись добавлена!","Успешно!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Close();
                this.Dispose();

            }
            catch (Exception)
            {
              MessageBox.Show("Данные введены не верно!, проверьте введеные данные","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);

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
                FIOTextBox.Enabled = true;
                BirthDayMaskedTextBox.Enabled = true;
                PhoneMaskedTextBox.Enabled = true;
            }
            else
            {
                AuditorNumericUpDown.Enabled = false;
                AuditoryCapacityNumericUpDown.Enabled = false;
                CabinetTextBox.Enabled = false;
                AudTypeTextBox.Enabled = false;
                FIOTextBox.Enabled = false;
                BirthDayMaskedTextBox.Enabled = false;
                PhoneMaskedTextBox.Enabled = false;
            }
        }
    }
}
