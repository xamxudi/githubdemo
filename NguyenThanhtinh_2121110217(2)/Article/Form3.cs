using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("sad", true);
            sw.Write(kq.Text);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                int xa = int.Parse(x.Text);
                int ya = int.Parse(y.Text);
                int kqa = xa * ya;
                kq.Text = kqa.ToString();

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int xa = int.Parse(x.Text);
            int ya = int.Parse(y.Text);
            int kqa = xa + ya;
            kq.Text = kqa.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
