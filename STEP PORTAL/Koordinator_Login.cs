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
    public partial class Koordinator_Login : Form
    {
        public Koordinator_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            this.Close(); exit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_New_Student student = new Add_New_Student();
            this.Hide(); student.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Creat_new_group new_Group = new Creat_new_group();
            this.Hide(); new_Group.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_student_group add_Student = new Add_student_group();
            this.Hide(); add_Student.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_new_teacher new_Teacher = new Add_new_teacher();
            this.Hide();   new_Teacher.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Delete_group delete_Group = new Delete_group();
            this.Hide(); delete_Group.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Delete_student_group delete_Student = new Delete_student_group();
            this.Hide();   delete_Student.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Print_Teacher print_Teacher = new Print_Teacher();
            this.Hide();  print_Teacher.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Print_groups print_Groups = new Print_groups();
            this.Hide();  print_Groups.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Print_Student print_Student = new Print_Student();
            this.Hide();   print_Student.Show();
        }
    }
}

