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
    public partial class Add_New_Student : Form
    {
        public Add_New_Student()
        {
            InitializeComponent();
            label6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koordinator_Login koordinator = new Koordinator_Login();
            this.Close(); koordinator.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, lastname, fathername, dataofbirth;
            name = textBox1.Text;
            lastname = textBox2.Text;
            fathername = textBox3.Text;
            dataofbirth = textBox4.Text;
            string path = "Students.txt";
            string count = "   "; string c = "\n";
            File.AppendAllText(path, lastname);
            File.AppendAllText(path, count);
            File.AppendAllText(path, name);
            File.AppendAllText(path, count);
            File.AppendAllText(path, fathername);
            File.AppendAllText(path, count);
            File.AppendAllText(path, dataofbirth);
            File.AppendAllText(path, c);
            label6.Visible = true;
        }
    }
}
