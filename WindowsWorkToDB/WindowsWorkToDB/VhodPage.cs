using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsWorkToDB
{
    public partial class VhodPage : Form
    {
        public VhodPage()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
   
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VhodPage_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVhod_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnect = new SqlConnection("Data Source = 172.16.0.211\\SQLEXPRESS; Initial Catalog = user20; Persist Security Info = True; User ID = User20; Password = wsruser20");
            SqlConnect.Open();
            SqlCommand SqlQuery = new SqlCommand("SELECT * FROM [dbo].[User] where Login=' " + txtLogin.Text + " ' and Password=' " + txtPassword.Text + "' ", SqlConnect);
            SqlDataReader sqlQueryReader = null;
            sqlQueryReader = SqlQuery.ExecuteReader();

            if (sqlQueryReader.HasRows)
            {
                sqlQueryReader.Read();

                if ((sqlQueryReader.GetValue(0).ToString() == txtLogin.Text) &&
                    (sqlQueryReader.GetValue(1).ToString() == txtPassword.Text))
                { if (sqlQueryReader.GetValue(2).ToString() == "Admin") { AdminPage APage = new AdminPage(); APage.Show(); } }
                else if ((sqlQueryReader.GetValue(0).ToString() == txtLogin.Text) &&
                    (sqlQueryReader.GetValue(1).ToString() == txtPassword.Text))
                { if (sqlQueryReader.GetValue(2).ToString() == "Manager") { ManagerPage MPage = new ManagerPage(); MPage.Show(); } }
                else if ((sqlQueryReader.GetValue(0).ToString() == txtLogin.Text) &&
                    (sqlQueryReader.GetValue(1).ToString() == txtPassword.Text))
                {
                    if (sqlQueryReader.GetValue(2).ToString() == "Client") { UserPage UPage = new UserPage(); UPage.Show(); }
                }
            }
        }

        private void btnRega_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegaPage RPage = new RegaPage();
            RPage.Show();
        }
    }
}
