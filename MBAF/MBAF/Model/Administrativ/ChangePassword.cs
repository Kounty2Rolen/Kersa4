using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBAF.Model.Administrativ
{
    public partial class ChangePassword : Form
    {
        DataBase.MyDBContext context;
        int password;
        public ChangePassword(ref DataBase.MyDBContext context)
        {
            InitializeComponent();
            this.context = context;
            password = context.passwords.FirstOrDefault().Password;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DataBase.Passwords pass = context.passwords.First();
            if (OldPasswordTextBox.Text.GetHashCode() == password||password==-1)
            {
                if (NewPasswordTextBox.Text == RepeatPasswordTextBox.Text)
                {
                    pass.Password = NewPasswordTextBox.Text.GetHashCode();
                    context.SaveChanges();
                    MessageBox.Show("Пароль успешно изменен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Пароли не совпадают, проверьте введеные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                MessageBox.Show("Старый пароль не верен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            password = context.passwords.FirstOrDefault().Password;
        }
    }
}
