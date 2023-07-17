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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if (rbnam.Checked == true)
                msg += "ong";
            if (rbnu.Checked == true)
                msg += "nu";
            if (gg.Checked == true)
                disc = 5;
            kq.Text = msg + ten.Text + "duoc giam" + disc.ToString() + "%" + "\r\n";


        }

        private void gg_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
