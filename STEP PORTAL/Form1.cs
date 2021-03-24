using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STEP_PORTAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher_Menu teacher_Menu = new Teacher_Menu();
            this.Hide(); teacher_Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Login student = new Student_Login();
            this.Hide(); student.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = textBox1.Text;
            password = textBox2.Text;
            if (username == "admin" && password == "admin")
            {
                Koordinator_Login koordinator = new Koordinator_Login();
                label5.Visible = false;
                this.Hide(); koordinator.Show();
            }
            else { label5.Visible = true; }
        }
    }
}
