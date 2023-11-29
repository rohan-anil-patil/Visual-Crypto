using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void slicer_Click(object sender, EventArgs e)
        {
            Encryption frm = new Encryption();


            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void stacker_Click(object sender, EventArgs e)
        {
            Decryption frm = new Decryption();


            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }
    }
}
