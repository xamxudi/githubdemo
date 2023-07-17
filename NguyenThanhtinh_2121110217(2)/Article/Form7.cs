using System;
using System.Collections;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public ArrayList GetData()
        {
            ArrayList list = new ArrayList();
            Faculty f = new Faculty();
            f.Id = "k01";
            f.Name = "cnnt";
            f.Quantity ="1200";
            list.Add(f);

            f = new Faculty();
            f.Id = "k02";
            f.Name = "NN";
            f.Quantity = "4200";
            list.Add(f);

            f = new Faculty();
            f.Id = "k02";
            f.Name = "NN";
            f.Quantity = "4200";
            list.Add(f);

            f = new Faculty();
            f.Id = "k03";
            f.Name = "QTKD";
            f.Quantity = "5200";
            list.Add(f);
            return list;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "Id";
            string id = comboBox1.SelectedValue.ToString();
            kq.Text = "ban chon khoa co ma " + id;
        }

        private void btok_Click(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "Name";
            string name = comboBox1.SelectedValue.ToString();
            kq.Text = "ban chon khoa co ten " + name;


        }
        private void Form7_Load(object sender, EventArgs e)
        {
            ArrayList list = GetData();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";



        }
    }
}
