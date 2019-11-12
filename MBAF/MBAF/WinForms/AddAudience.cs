using MBAF.EntityModel;
using System;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace MBAF.WinForms
{
    public partial class AddAudience : Form
    {
        private readonly AudienceType audience;
        private readonly Teacher teacher;
        private readonly Corps corps;
        private readonly AudType audType = new AudType();
        public AddAudience(AudienceType audtype, Teacher teacher, Corps corp)
        {
            this.audience = audtype;
            this.teacher = teacher;
            this.corps = corp;
            InitializeComponent();
            CorpsComboBox.DataSource = DBObject.context.Corps.Select(c => c.CorpNumber).Distinct().ToList();
            CorpsComboBox.SelectedIndex = -1;
            //Заполнение комбобокса Corps
            audTypeComboBox.DataSource = DBObject.context.AudType.Select(c => c.AudType1).Distinct().ToList();
            responseComboBox.DataSource= DBObject.context.Teacher.Select(c =>c.Mname+" "+c.Fname+" "+c.Lname).Distinct().ToList();
            //Заполнение комбокоса aud
            if (DBObject.context.AudienceType.Where(c => c.id == audtype.id).Count() > 0)
                Fill();
        }



        /// <summary>
        /// Заполнение полей
        /// </summary>
        void Fill()
        {
            CorpsComboBox.SelectedItem = corps.CorpNumber;
            audTypeComboBox.SelectedItem = audience.AudType.AudType1;
            responseComboBox.SelectedItem = teacher.ToString();

            AuditorNumericUpDown.Value = (int)corps.NumberOfAudiences;
            AuditoryCapacityNumericUpDown.Value = audience.Capacity;
            CabinetTextBox.Text = audience.Cabinet;
           

            dateTimePicker.Value = (DateTime)teacher.Birthday;
            PhoneMaskedTextBox.Text = teacher.Phone;


        }
        #region addrecord
        /// <summary>
        /// Проверка и заполнение обьектов
        /// </summary>
        void Fillentity()
        {
            try
            {
                teacher.Mname = MnameTextBox.Text;
                teacher.Fname = FnameTextBox.Text;
                teacher.Lname = LnameTextBox.Text;
                teacher.Phone = PhoneMaskedTextBox.Text;
                teacher.Birthday = dateTimePicker.Value;

                corps.CorpNumber = CorpsComboBox.Text;
                corps.NumberOfAudiences = (int)AuditorNumericUpDown.Value;


                if (DBObject.context.AudType.Where(c => c.AudType1 == audTypeComboBox.Text).Count() <= 0)
                {
                    audType.AudType1 = audTypeComboBox.Text;
                    DBObject.context.AudType.Add(audType);
                    audience.TypeID = audType.id;

                }
                audience.TypeID = DBObject.context.AudType.Where(c => c.AudType1 == audTypeComboBox.Text).Select(c => c.id).FirstOrDefault();

                audience.Capacity = (int)AuditoryCapacityNumericUpDown.Value;
                audience.TeacherId = teacher.Id;
                audience.CorpID = corps.Id;
                audience.Cabinet = CabinetTextBox.Text;



                if (DBObject.context.Corps.Where(c => c.CorpNumber == corps.CorpNumber).Count() == 0)
                {
                    DBObject.context.Corps.Add(corps);
                }
                else
                {
                    audience.CorpID = DBObject.context.Corps.Where(c => c.CorpNumber == corps.CorpNumber).Select(c => c.Id).FirstOrDefault();
                }
                if (DBObject.context.Teacher.Where(c => c.Fname + c.Mname + c.Lname == teacher.Fname + teacher.Mname + teacher.Lname).Count() == 0)
                {
                    DBObject.context.Teacher.Add(teacher);
                }
                else
                {
                    audience.TeacherId = DBObject.context.Teacher.Where(c => c.Fname + c.Mname + c.Lname == teacher.Fname + teacher.Mname + teacher.Lname).Select(c => c.Id).FirstOrDefault();
                }
                if (DBObject.context.AudienceType.Where(c => c.Cabinet == audience.Cabinet && c.CorpID == audience.CorpID).Count() == 0)
                    DBObject.context.AudienceType.Add(audience);
                else if(audience.id==0)
                {
                    throw new AlreadyContainsException("Запись уже существует");
                }
                MessageBox.Show("Запись добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DBObject.context.SaveChanges();

                Close();
                Dispose();
            }
            catch (AlreadyContainsException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Проверьте введеные данные \n" + exc.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Fillentity();
        }
        #endregion

        #region maintaince
        void corpsSelected()
        {
            if (CorpsComboBox.SelectedIndex != -1)
            {
                var a = (decimal)DBObject.context.Corps.Where(c => c.CorpNumber == CorpsComboBox.Text).Select(c => c.NumberOfAudiences).FirstOrDefault();
                AuditorNumericUpDown.Value = a;
                AuditorNumericUpDown.Enabled = false;

            }
            else
            {
                AuditorNumericUpDown.Value = 0;
                AuditorNumericUpDown.Enabled = true;

            }
        }
        //Тоже самое что и ниже
        private void CorpsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            corpsSelected();
        }
        /// <summary>
        /// если выберут ответсвенного то смысла в текстбоксах не будет,
        //так что заполняем их данными для пользвоателя и убираем
        /// </summary>
        void responseSelected()
        {
            
            if (responseComboBox.SelectedIndex != -1&& responseComboBox.Text!=string.Empty)
            {
                var a = DBObject.context.Teacher.Where(c => c.Mname + " " + c.Fname + " " + c.Lname == responseComboBox.SelectedItem.ToString());
                FnameTextBox.Text = a.Select(c => c.Fname).FirstOrDefault();
                MnameTextBox.Text = a.Select(c => c.Mname).FirstOrDefault();
                LnameTextBox.Text = a.Select(c => c.Lname).FirstOrDefault();
                FnameTextBox.Enabled = false;
                MnameTextBox.Enabled = false;
                LnameTextBox.Enabled = false;

            }
            else
            {
                FnameTextBox.Enabled = true;
                MnameTextBox.Enabled = true;
                LnameTextBox.Enabled = true;

            }


        }
        private void responseComboBox_SelectedIndexChanged(object sender, EventArgs e) => responseSelected();
        #endregion//"Технисческий раздел"

        private void responseComboBox_TextUpdate(object sender, EventArgs e)
        {
            responseSelected();
        }
    }

    class AlreadyContainsException : Exception
    {
        public AlreadyContainsException(string message)
            : base(message)
        { }
    }//Класс для вызова исключения если запись уже существует

}
