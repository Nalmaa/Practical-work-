using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadesOfGray
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static string conString = Properties.Settings.Default.EtoBazaConnectionString;

        private void btnOK_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Select *
from Users
where [login] = '{tbxLogin.Text}' and pass = '{tbxPass.Text}'", con);
            SqlDataReader res = query.ExecuteReader();
            if (res.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
            }
            else
                MessageBox.Show("Неправильный логин/пароль");
            con.Close();
            Hide();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            Hide(); 

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'etoBazaDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.etoBazaDataSet.Users);
        }
    }
}
