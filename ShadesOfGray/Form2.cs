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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbxPass.Text != textBox3.Text)
            {
                MessageBox.Show("Повторите пароль!");
            }
            else { 
            SqlConnection con = new SqlConnection(Form3.conString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Insert into
Users
Values ('{tbxLogin.Text}','{tbxPass.Text}')", con);
            query.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Регистрация прошла успешно!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}