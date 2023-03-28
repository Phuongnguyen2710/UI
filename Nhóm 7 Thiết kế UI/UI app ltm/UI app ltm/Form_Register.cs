using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_app_ltm
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f1 = new Login();
            f1.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            textBox3.Hide();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You have created a new account");
            this.Close();
            Login f = new Login();
            f.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_Click(object sender, EventArgs e)
        {
            textBox4.Hide();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Hide();
        }

        private void guna2TextBox4_Click(object sender, EventArgs e)
        {
            textBox5.Hide();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Hide();
        }
    }
}
