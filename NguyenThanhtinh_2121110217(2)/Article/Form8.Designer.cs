namespace Article
{
    partial class Form8
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
            this.ten = new System.Windows.Forms.TextBox();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.gg = new System.Windows.Forms.CheckBox();
            this.kq = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(29, 34);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(238, 20);
            this.ten.TabIndex = 0;
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Location = new System.Drawing.Point(29, 100);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(45, 17);
            this.rbnam.TabIndex = 3;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "nam";
            this.rbnam.UseVisualStyleBackColor = true;
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Location = new System.Drawing.Point(185, 100);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(37, 17);
            this.rbnu.TabIndex = 4;
            this.rbnu.TabStop = true;
            this.rbnu.Text = "nu";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // gg
            // 
            this.gg.AutoSize = true;
            this.gg.Location = new System.Drawing.Point(29, 134);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(65, 17);
            this.gg.TabIndex = 5;
            this.gg.Text = "giam gia";
            this.gg.UseVisualStyleBackColor = true;
            this.gg.CheckedChanged += new System.EventHandler(this.gg_CheckedChanged);
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(29, 169);
            this.kq.Multiline = true;
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(238, 80);
            this.kq.TabIndex = 6;
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(29, 256);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 23);
            this.btok.TabIndex = 7;
            this.btok.Text = "TINH TIEN";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 279);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.gg);
            this.Controls.Add(this.rbnu);
            this.Controls.Add(this.rbnam);
            this.Controls.Add(this.ten);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.CheckBox gg;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.Button btok;
    }
}