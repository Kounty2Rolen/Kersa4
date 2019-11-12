using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBAF.EntityModel;

namespace MBAF.WinForms.Administrativ
{
    public partial class ChangePassword : Form
    {
        readonly int password;
        public ChangePassword()
        {
            InitializeComponent();
            password = (int)DBObject.context.Password.FirstOrDefault().Password1;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            EntityModel.Password pass = DBObject.context.Password.FirstOrDefault();
            if (OldPasswordTextBox.Text.GetHashCode() == password||password==-1)
            {
                if (NewPasswordTextBox.Text == RepeatPasswordTextBox.Text)
                {
                    pass.Password1 = NewPasswordTextBox.Text.GetHashCode();
                    DBObject.context.SaveChanges();
                    MessageBox.Show("Пароль успешно изменен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Пароли не совпадают, проверьте введеные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                MessageBox.Show("Старый пароль не верен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
