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
    public partial class Add_new_teacher : Form
    {
        public Add_new_teacher()
        {
            InitializeComponent();
            label6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, lastname, fathername, age, specialty, filename;
            name = textBox1.Text;
            lastname = textBox2.Text;
            fathername = textBox3.Text;
            age = textBox4.Text;
            specialty = textBox5.Text;
            filename = "Teachers";
            File.AppendAllText(filename, lastname);
            File.AppendAllText(filename, "   ");
            File.AppendAllText(filename, name);
            File.AppendAllText(filename, "   ");
            File.AppendAllText(filename, fathername);
            File.AppendAllText(filename, "   ");
            File.AppendAllText(filename, age);
            File.AppendAllText(filename, "   ");
            File.AppendAllText(filename, specialty);
            File.AppendAllText(filename, "\n");

            string count = lastname.ToLower();
            string len = "@itstep.edu.az";
            string gmail = count + len;
            // Dear% teacher, you are already working at STEP IT Academy. Good luck to you.
            File.AppendAllText(gmail, "Dear ");
            File.AppendAllText(gmail, name);
            File.AppendAllText(gmail, " teacher, you are already working at STEP IT Academy. Good luck to you.\n\n");
            label6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koordinator_Login koordinator = new Koordinator_Login();
            this.Close(); koordinator.Show();
        }
    }
}
