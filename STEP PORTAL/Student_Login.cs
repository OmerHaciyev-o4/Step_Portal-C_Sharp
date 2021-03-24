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
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
            textBox1.Visible = false; 
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "Groups", sum = '\t' + textBox3.Text + "  " + textBox2.Text + "  " + textBox4.Text;
            int size = 0, index = 0;
            string[] count = { "HI", "World" };
            string[] info = count, info1;
            try 
            { 
                info = File.ReadAllLines(filename);
                for (int i = 0; i < info.Count(); i++)
                {
                    int indexOfTab = info[i].IndexOf('\t');
                    info[i] = info[i].Substring(0, indexOfTab);
                }
                for (int i = 0; i < info.Count(); i++)
                {
                    info1 = File.ReadAllLines(info[i]);
                    for (int j = 4; j < info1.Count(); j++)
                    {
                        for (int k = 0; k < sum.Count(); k++) { if (sum[k] == info1[j][k]) { size++; } }
                        if (size == sum.Count()) { break; }
                    }
                    if (size == sum.Count()) { index = i; break; }
                }
                if (size == sum.Count())
                {
                    info1 = File.ReadAllLines(info[index]);
                    for (int i = 0; i < info1.Count(); i++)
                    {
                        textBox1.AppendText(info1[i]);
                        textBox1.AppendText(Environment.NewLine);
                    }
                    textBox1.Visible = true;
                }
                else { MessageBox.Show("Goserilen telebe hec bir groupda yoxdur./There are no students in any group."); }
            }
            catch { MessageBox.Show("Goserilen telebe hec bir groupda yoxdur./There are no students in any group."); }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();   form1.Show();
        }
    }
}
