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
    public partial class Creat_new_group : Form
    {
        public Creat_new_group()
        {
            InitializeComponent();
            label7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string groupName, name, lastName, fatherName, specialtyAndSemester, count, len, gmail, groups;
            groupName = textBox1.Text;
            name = textBox2.Text;
            lastName = textBox3.Text;
            fatherName = textBox4.Text;
            specialtyAndSemester = textBox5.Text;

            File.AppendAllText(groupName, "Theacher: ");
            File.AppendAllText(groupName, name);
            File.AppendAllText(groupName, "  ");
            File.AppendAllText(groupName, lastName);
            File.AppendAllText(groupName, "\t\t\t");
            File.AppendAllText(groupName, specialtyAndSemester);
            File.AppendAllText(groupName, "\n\n\nStudents:\n"); 

            groups = "Groups";
            File.AppendAllText(groups, groupName);
            File.AppendAllText(groups, "\t");
            File.AppendAllText(groups, lastName);
            File.AppendAllText(groups, " ");
            File.AppendAllText(groups, name);
            File.AppendAllText(groups, "\n");

            count = lastName.ToLower(); len = "@itstep.edu.az"; gmail = count + len;
            File.AppendAllText(gmail, "Dear ");
            File.AppendAllText(gmail, name);
            File.AppendAllText(gmail, " teacher your new group is ");
            File.AppendAllText(gmail, groupName);
            File.AppendAllText(gmail, " Good luck to you.\n\n");
            label7.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koordinator_Login koordinator = new Koordinator_Login();
            this.Close();  koordinator.Show();
        }
    }
}
