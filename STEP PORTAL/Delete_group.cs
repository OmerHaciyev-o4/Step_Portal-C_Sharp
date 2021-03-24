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
    public partial class Delete_group : Form
    {
        public Delete_group()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koordinator_Login koordinator = new Koordinator_Login();
            this.Close(); koordinator.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string groupName = textBox1.Text, group = "Groups";
            string[] info = null;
            try 
            { 
                info = File.ReadAllLines(group);
                int size = 0;
                for (int i = 0; i < info.Count(); i++)
                {
                    for (int j = 0; j < groupName.Count(); j++)
                    {
                        if (info[i][j] == groupName[j]) { size++; }
                        else { break; }
                    }
                    if (size == groupName.Count()) { info[i] = ""; break; }
                }
                if (info.Count() == 1 && info[0] == "")
                {
                    try
                    {
                        File.Delete(group);
                        File.Delete(groupName);
                        label2.Visible = true;
                    }
                    catch { MessageBox.Show("Hec bir grubunuz yoxdur./You have no group."); }
                }
                else
                {
                    try
                    {
                        File.Delete(groupName);
                        for (int i = 0; i < info.Count(); i++)
                        {
                            File.AppendAllText(group, info[i]);
                            File.AppendAllText(group, "\n");
                        }
                        label2.Visible = true;
                    }
                    catch { MessageBox.Show("Hec bir grubunuz yoxdur./You have no group."); }
                }
            }
            catch { MessageBox.Show("Hec bir grubunuz yoxdur./You have no group."); }
            
        }
    }
}