﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Form1_ResizeEnd(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Width;
            this.Text = width.ToString() + " 300-300 " + height.ToString();

        }
        void Form1_Load(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Width;
            this.Text = width.ToString() + " - " + height.ToString();

        }

    }
}
