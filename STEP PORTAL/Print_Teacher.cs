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
    public partial class Print_Teacher : Form
    {
        public Print_Teacher()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koordinator_Login koordinator = new Koordinator_Login();
            this.Close();   koordinator.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "Teachers";
            try
            {
                string[] info = File.ReadAllLines(file);
                for(int i = 0; i < info.Count(); i++)
                {
                    textBox1.AppendText(info[i]);
                    textBox1.AppendText(Environment.NewLine);
                }
                textBox1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Hec bir muellim yoxdur./There is no teacher.");
            }
        }
    }
}
