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
    public partial class Teacher_Menu : Form
    {
        public Teacher_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher_Login teacher_Login = new Teacher_Login();
            this.Hide();   teacher_Login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();   form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_look_gmail gmail = new Teacher_look_gmail();
            this.Hide();   gmail.Show(); 
        }
    }
}
