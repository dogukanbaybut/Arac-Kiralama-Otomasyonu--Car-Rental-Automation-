﻿namespace WindowsFormsApp1
{
    partial class frmAracKayit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracKayit));
            this.PlakaTxt = new System.Windows.Forms.TextBox();
            this.MarkaCombo = new System.Windows.Forms.ComboBox();
            this.SeriCombo = new System.Windows.Forms.ComboBox();
            this.YilTxt = new System.Windows.Forms.TextBox();
            this.RenkTxt = new System.Windows.Forms.TextBox();
            this.KmTxt = new System.Windows.Forms.TextBox();
            this.YakitCombo = new System.Windows.Forms.ComboBox();
            this.UcretTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlakaTxt
            // 
            this.PlakaTxt.Location = new System.Drawing.Point(131, 43);
            this.PlakaTxt.Name = "PlakaTxt";
            this.PlakaTxt.Size = new System.Drawing.Size(156, 20);
            this.PlakaTxt.TabIndex = 0;
            // 
            // MarkaCombo
            // 
            this.MarkaCombo.FormattingEnabled = true;
            this.MarkaCombo.Items.AddRange(new object[] {
            "Opel",
            "Mercedes",
            "BMW",
            "Audi",
            "Toyota"});
            this.MarkaCombo.Location = new System.Drawing.Point(131, 84);
            this.MarkaCombo.Name = "MarkaCombo";
            this.MarkaCombo.Size = new System.Drawing.Size(156, 21);
            this.MarkaCombo.TabIndex = 1;
            this.MarkaCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SeriCombo
            // 
            this.SeriCombo.FormattingEnabled = true;
            this.SeriCombo.Location = new System.Drawing.Point(131, 126);
            this.SeriCombo.Name = "SeriCombo";
            this.SeriCombo.Size = new System.Drawing.Size(156, 21);
            this.SeriCombo.TabIndex = 2;
            // 
            // YilTxt
            // 
            this.YilTxt.Location = new System.Drawing.Point(131, 168);
            this.YilTxt.Name = "YilTxt";
            this.YilTxt.Size = new System.Drawing.Size(156, 20);
            this.YilTxt.TabIndex = 3;
            // 
            // RenkTxt
            // 
            this.RenkTxt.Location = new System.Drawing.Point(131, 209);
            this.RenkTxt.Name = "RenkTxt";
            this.RenkTxt.Size = new System.Drawing.Size(156, 20);
            this.RenkTxt.TabIndex = 3;
            // 
            // KmTxt
            // 
            this.KmTxt.Location = new System.Drawing.Point(131, 250);
            this.KmTxt.Name = "KmTxt";
            this.KmTxt.Size = new System.Drawing.Size(156, 20);
            this.KmTxt.TabIndex = 3;
            // 
            // YakitCombo
            // 
            this.YakitCombo.FormattingEnabled = true;
            this.YakitCombo.Items.AddRange(new object[] {
            "LPG",
            "Benzin",
            "Benzin & LPG",
            "Dizel",
            "Hybrid"});
            this.YakitCombo.Location = new System.Drawing.Point(131, 291);
            this.YakitCombo.Name = "YakitCombo";
            this.YakitCombo.Size = new System.Drawing.Size(156, 21);
            this.YakitCombo.TabIndex = 4;
            // 
            // UcretTxt
            // 
            this.UcretTxt.Location = new System.Drawing.Point(131, 333);
            this.UcretTxt.Name = "UcretTxt";
            this.UcretTxt.Size = new System.Drawing.Size(156, 20);
            this.UcretTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kilometre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kira Ücreti";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox1.Location = new System.Drawing.Point(427, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(131, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(212, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(486, 263);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(95, 42);
            this.btnResim.TabIndex = 11;
            this.btnResim.Text = "Resim Ekle";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arackayit.png");
            this.ımageList1.Images.SetKeyName(1, "iptal.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 511);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UcretTxt);
            this.Controls.Add(this.YakitCombo);
            this.Controls.Add(this.KmTxt);
            this.Controls.Add(this.RenkTxt);
            this.Controls.Add(this.YilTxt);
            this.Controls.Add(this.SeriCombo);
            this.Controls.Add(this.MarkaCombo);
            this.Controls.Add(this.PlakaTxt);
            this.Name = "frmAracKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Sayfası";
            this.Load += new System.EventHandler(this.frmAracKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlakaTxt;
        private System.Windows.Forms.ComboBox MarkaCombo;
        private System.Windows.Forms.ComboBox SeriCombo;
        private System.Windows.Forms.TextBox YilTxt;
        private System.Windows.Forms.TextBox RenkTxt;
        private System.Windows.Forms.TextBox KmTxt;
        private System.Windows.Forms.ComboBox YakitCombo;
        private System.Windows.Forms.TextBox UcretTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}