using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBAF.WinForms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:molodcovdaniil123@gmail.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kounty2rolen");

        }
    }
}
