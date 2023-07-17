namespace Article
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kq = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btc = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btcc = new System.Windows.Forms.Button();
            this.btb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(51, 55);
            this.kq.Multiline = true;
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(190, 50);
            this.kq.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(51, 111);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(43, 36);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(100, 111);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(43, 36);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(149, 111);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(43, 36);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(198, 111);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(43, 36);
            this.bt0.TabIndex = 4;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btc
            // 
            this.btc.Location = new System.Drawing.Point(51, 153);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(43, 36);
            this.btc.TabIndex = 5;
            this.btc.Text = "+";
            this.btc.UseVisualStyleBackColor = true;
            this.btc.Click += new System.EventHandler(this.btc_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(100, 153);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(43, 36);
            this.btn.TabIndex = 6;
            this.btn.Text = "*";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btcc
            // 
            this.btcc.Location = new System.Drawing.Point(149, 153);
            this.btcc.Name = "btcc";
            this.btcc.Size = new System.Drawing.Size(43, 36);
            this.btcc.TabIndex = 7;
            this.btcc.Text = ".";
            this.btcc.UseVisualStyleBackColor = true;
            this.btcc.Click += new System.EventHandler(this.button7_Click);
            // 
            // btb
            // 
            this.btb.Location = new System.Drawing.Point(198, 153);
            this.btb.Name = "btb";
            this.btb.Size = new System.Drawing.Size(43, 36);
            this.btb.TabIndex = 8;
            this.btb.Text = "=";
            this.btb.UseVisualStyleBackColor = true;
            this.btb.Click += new System.EventHandler(this.btb_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 261);
            this.Controls.Add(this.btb);
            this.Controls.Add(this.btcc);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.kq);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btc;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btcc;
        private System.Windows.Forms.Button btb;
    }
}