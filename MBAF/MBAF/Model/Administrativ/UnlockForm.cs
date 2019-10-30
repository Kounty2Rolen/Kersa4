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
    public partial class UnlockForm : Form
    {
        DataBase.MyDBContext context;
        private int password = -1;

        public UnlockForm(in DataBase.MyDBContext context)
        {
            this.context = context;
            InitializeComponent();
            CenterToParent();
            if (context.passwords.First().Password != -1)
                password = context.passwords.FirstOrDefault().Password;
        }

        private void UnlockForm_Load(object sender, EventArgs e)
        {
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (password != -1)
            {
                if (PasswordtextBox.Text.GetHashCode() == password)
                {
                    this.Close();
                    this.Dispose();
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
    }
}
