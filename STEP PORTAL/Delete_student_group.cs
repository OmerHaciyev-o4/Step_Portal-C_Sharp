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
    public partial class Delete_student_group : Form
    {
        public Delete_student_group()
        {
            InitializeComponent();
            label5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string groupname, countname;
            groupname = textBox1.Text;
            countname = "Groups";
            try
            {
                string[] info = File.ReadAllLines(countname);
                int size = 0, index = 0;
                for (int i = 0; i < info.Count(); i++)
                {
                    for (int j = 0; j < groupname.Count(); j++)
                    {
                        if (info[i][j] == groupname[j]) { size++; }
                    }
                    if (size == groupname.Count()) { index++; break; }
                }
                if (index == 0) { MessageBox.Show("Daxil olunana group yoxdur/There is no group to join"); }
                else
                {
                    string sum = '\t' + textBox3.Text + "  " + textBox2.Text + "  " + textBox4.Text;
                    info = File.ReadAllLines(groupname); index = 0; size = 0;
                    for (int i = 4; i < info.Count(); i++)
                    {
                        for (int j = 0; j < sum.Count(); j++)
                        {
                            if (info[i][j] == sum[j]) { size++; }
                            else if (info[i][j] != sum[j]) { size = 0; break; }
                        }
                        if (size == sum.Count()) { info[i] = ""; index++; break; }
                    }
                    if (index == 0) { MessageBox.Show("Daxil olunana sagir yoxdur/There is no student to join"); }
                    else
                    {
                        File.WriteAllText(groupname, "");
                        File.AppendAllText(groupname, info[0]);
                        File.AppendAllText(groupname, "\n\n\n");
                        for (int i = 3; i < info.Count(); i++)
                        {
                            if (info[i] != "")
                            {
                                File.AppendAllText(groupname, info[i]);
                                File.AppendAllText(groupname, "\n");
                            }
                        }
                        label5.Visible = true;
                    }
                }
            }
            catch { MessageBox.Show("Hec bir group yoxdur./There is not any group."); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koordinator_Login koordinator = new Koordinator_Login();
            this.Close();   koordinator.Show();
        }
    }
}
