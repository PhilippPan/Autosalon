using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsWorkToDB
{
    public partial class RegaPage : Form
    {
        public RegaPage()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // btnOkR
        {
            this.Hide();
            VhodPage VPage = new VhodPage();
            VPage.Show();
        }

        private void button2_Click(object sender, EventArgs e) // btnCancelR
        {
            this.Hide();
            VhodPage VPage = new VhodPage();
            VPage.Show();
        }

        private void RegaPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            VhodPage VPage = new VhodPage();
            VPage.Show();
        }
    }
}
