namespace Article
{
    partial class Form6
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kq = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.btc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CNNT",
            "NN",
            "QTKD",
            "CK",
            "DIEN",
            "CKDL"});
            this.comboBox1.Location = new System.Drawing.Point(44, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(44, 88);
            this.kq.Multiline = true;
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(223, 96);
            this.kq.TabIndex = 1;
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(44, 202);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 23);
            this.btok.TabIndex = 2;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btc
            // 
            this.btc.Location = new System.Drawing.Point(192, 202);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(75, 23);
            this.btc.TabIndex = 3;
            this.btc.Text = "Clear";
            this.btc.UseVisualStyleBackColor = true;
            this.btc.Click += new System.EventHandler(this.btc_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btc;
    }
}