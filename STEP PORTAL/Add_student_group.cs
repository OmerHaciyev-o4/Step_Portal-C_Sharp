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
    public partial class Add_student_group : Form
    {
        public Add_student_group()
        {
            InitializeComponent();
            label5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string groupName, name, lastName, fatherName;
            groupName = textBox1.Text;
            name = textBox2.Text;
            lastName = textBox3.Text;
            fatherName = textBox4.Text;
            try
            {
                string[] info = File.ReadAllLines(groupName);
                File.AppendAllText(groupName, "\t");
                File.AppendAllText(groupName, lastName);
                File.AppendAllText(groupName, "  ");
                File.AppendAllText(groupName, name);
                File.AppendAllText(groupName, "  ");
                File.AppendAllText(groupName, fatherName);
                File.AppendAllText(groupName, "\n");
                label5.Visible = true;
            }
            catch { MessageBox.Show("Gosterilen group yoxdur./There is no group shown"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koordinator_Login koordinator = new Koordinator_Login();
            this.Close();   koordinator.Show();
        }
    }
}
