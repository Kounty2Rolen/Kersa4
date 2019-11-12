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
    public partial class UnlockForm : Form
    {
        readonly int password = -1;

        public UnlockForm()
        {
            InitializeComponent();
            CenterToParent();
            if (DBObject.context.Password.First().Password1 != -1)
                password =(int) DBObject.context.Password.FirstOrDefault().Password1;
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (password != -1)
            {
                if (PasswordtextBox.Text.GetHashCode() == password)
                {
                    Close();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Неправельный пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Пожалуйста установите пароль!");
                this.Close();
                this.Dispose();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
