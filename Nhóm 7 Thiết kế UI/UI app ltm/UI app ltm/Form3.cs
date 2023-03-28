using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_app_ltm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //private Form current_FormChild;
        //private void OpenFormChild(Form Child_Form)
        //{
        //    if (current_FormChild != null)
        //    {
        //        current_FormChild.Close();
        //    }
        //    current_FormChild = Child_Form;
        //    Child_Form.TopLevel = false;
        //    Child_Form.FormBorderStyle = FormBorderStyle.None;
        //    Child_Form.Dock = DockStyle.Fill;
        //    Panel1.Controls.Add(Child_Form);
        //    Panel1.Tag = Child_Form;
        //    Child_Form.BringToFront();
        //    Child_Form.Show();
        //}
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }





        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }









        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            //623, 64
            panel1.Location = new Point(623, 64);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            panel1.Location = new Point(304, 64);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            int x = 477; // 477, 64
            int y = 64;
            panel1.Location = new Point(x, y);
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            //797, 64
            panel1.Location = new Point(791, 64);

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            label2.Hide();
        }
    }
}
