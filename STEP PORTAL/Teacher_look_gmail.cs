using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STEP_PORTAL
{
    public partial class Teacher_look_gmail : Form
    {
        public Teacher_look_gmail()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            textBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;

            button1.Visible = true;
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = textBox1.Text;
                string[] info = File.ReadAllLines(fileName);
                for(int i = 0; i < info.Count(); i++)
                {
                    textBox2.AppendText(info[i]);
                    textBox2.AppendText(Environment.NewLine);
                }
                textBox2.Visible = true;
            }
            catch{ MessageBox.Show("Siz yanlis gmail hesabi daxil ediniz./You have entered the wrong gmail account"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Menu teacher_Menu = new Teacher_Menu();
            this.Close();   teacher_Menu.Show();
        }
    }
}
