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
    public partial class Print_groups : Form
    {
        public Print_groups()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = "Groups";
            try
            {
                string[] info = File.ReadAllLines(file);
                for (int i = 0; i < info.Count(); i++)
                {
                    textBox1.AppendText(info[i]);
                    textBox1.AppendText(Environment.NewLine);
                }
                textBox1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Hec bir group yoxdur./There is no group.");
            }
            string[] vs = File.ReadAllLines(file);
            char[] vs1;
            for(int i = 0; i < vs.Count(); i++)
            {
                vs1 = vs[i].ToCharArray();
                // deyisikler 
                vs[i] = vs1.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koordinator_Login koordinator = new Koordinator_Login();
            this.Close();    koordinator.Show();
        }
    }
}
