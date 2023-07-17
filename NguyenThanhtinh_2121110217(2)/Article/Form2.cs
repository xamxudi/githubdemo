using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xa = int.Parse(x.Text);
            int ya= int.Parse(y.Text);
            int kqa = xa + ya;
            kq.Text = kqa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int xa = int.Parse(x.Text);
            int ya = int.Parse(y.Text);
            int kqa = xa * ya;
            kq.Text = kqa.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
