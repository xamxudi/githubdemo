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
    public partial class Form4 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form4()
        {
            
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kq.Text += bt2.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kq.Text += btcc.Text;
        }

        private void btc_Click(object sender, EventArgs e)
        {
            opr = btc.Text;
            workingMemory = decimal.Parse(kq.Text);
            kq.Clear();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            kq.Text += bt1.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            kq.Text += bt3.Text;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            kq.Text += bt0.Text;
        }

        private void btb_Click(object sender, EventArgs e)
        {
            decimal secondaValue = decimal.Parse(kq.Text);
            if (opr == "+")
                kq.Text = (workingMemory + secondaValue).ToString();
            if(opr == "*")
                kq.Text = (workingMemory * secondaValue).ToString();

            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            opr = btn.Text;
            workingMemory = decimal.Parse(kq.Text);
            kq.Clear();
        }
    }
}
