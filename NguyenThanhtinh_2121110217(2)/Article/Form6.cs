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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            kq.Text = "ban la sinh khoa" + item;
        }

        private void btc_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            kq.Text = "ban la sinh vien khoa" + index.ToString();

        }
    }
}
