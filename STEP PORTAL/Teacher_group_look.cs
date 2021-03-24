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
    public partial class Teacher_Login : Form
    {
        public Teacher_Login()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            textBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Menu teacher_Menu = new Teacher_Menu();
            this.Close(); teacher_Menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "Groups";
            string[] info = null, info1;
            try 
            {
                info = File.ReadAllLines(filename);
                int index = 0, indexOfTab = 0, size = 0;
                string sum = textBox2.Text + " " + textBox1.Text;
                for (int i = 0; i < info.Count(); i++)
                {
                    for (int j = 0; j < info[i].Count(); j++)
                    {
                        if (info[i][j] == '\t')
                        {
                            indexOfTab = j;
                            for (int k = j + 1, l = 0; (k < info[i].Count()) && (l < sum.Count()); k++, l++)
                            {
                                if (info[i][k] == sum[l]) { index++; }
                                else { break; }
                            }
                            break;
                        }
                    }
                    if (index == sum.Count())
                    {
                        info[i] = info[i].Substring(0, indexOfTab);
                        info1 = File.ReadAllLines(info[i]);
                        for (int j = 0; j < info1.Count(); j++)
                        {
                            textBox3.AppendText(info1[j]);
                            textBox3.AppendText(Environment.NewLine);
                        }
                        textBox3.Visible = true;
                        break;
                    }
                    else { size++; }
                }
                if (size == info.Count())
                {
                    MessageBox.Show("Gosterilen melim hec bir qurubda deyil./ The melim shown is not in any structure.");
                }
            }
            catch { MessageBox.Show("Hec bir group yaradilmayib./ There is no group."); }
        }
    }
}
