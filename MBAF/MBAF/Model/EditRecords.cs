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
        public EditRecords(int id, in DataBase.MyDBContext context)
        {
            InitializeComponent();

        }
    }
}
