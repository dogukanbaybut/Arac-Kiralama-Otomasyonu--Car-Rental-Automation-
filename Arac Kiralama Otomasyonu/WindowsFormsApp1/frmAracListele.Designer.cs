namespace WindowsFormsApp1
{
    partial class frmAracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComboAraclar = new System.Windows.Forms.ComboBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UcretTxt = new System.Windows.Forms.TextBox();
            this.YakitCombo = new System.Windows.Forms.ComboBox();
            this.KmTxt = new System.Windows.Forms.TextBox();
            this.RenkTxt = new System.Windows.Forms.TextBox();
            this.YilTxt = new System.Windows.Forms.TextBox();
            this.SeriCombo = new System.Windows.Forms.ComboBox();
            this.MarkaCombo = new System.Windows.Forms.ComboBox();
            this.PlakaTxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ComboAraclar
            // 
            this.ComboAraclar.FormattingEnabled = true;
            this.ComboAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.ComboAraclar.Location = new System.Drawing.Point(1021, 27);
            this.ComboAraclar.Name = "ComboAraclar";
            this.ComboAraclar.Size = new System.Drawing.Size(121, 21);
            this.ComboAraclar.TabIndex = 1;
            this.ComboAraclar.SelectedIndexChanged += new System.EventHandler(this.ComboAraclar_SelectedIndexChanged);
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(433, 507);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(95, 42);
            this.btnResim.TabIndex = 31;
            this.btnResim.Text = "Resim Değiştir";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.ImageIndex = 1;
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(211, 613);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(94, 47);
            this.btnIptal.TabIndex = 30;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "guncelle.png");
            this.ımageList1.Images.SetKeyName(1, "iptal.png");
            this.ımageList1.Images.SetKeyName(2, "sil.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 0;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(89, 613);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(91, 47);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kilometre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Plaka";
            // 
            // UcretTxt
            // 
            this.UcretTxt.Location = new System.Drawing.Point(123, 340);
            this.UcretTxt.Name = "UcretTxt";
            this.UcretTxt.Size = new System.Drawing.Size(156, 20);
            this.UcretTxt.TabIndex = 19;
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
            this.YakitCombo.Location = new System.Drawing.Point(123, 298);
            this.YakitCombo.Name = "YakitCombo";
            this.YakitCombo.Size = new System.Drawing.Size(156, 21);
            this.YakitCombo.TabIndex = 18;
            // 
            // KmTxt
            // 
            this.KmTxt.Location = new System.Drawing.Point(123, 257);
            this.KmTxt.Name = "KmTxt";
            this.KmTxt.Size = new System.Drawing.Size(156, 20);
            this.KmTxt.TabIndex = 17;
            // 
            // RenkTxt
            // 
            this.RenkTxt.Location = new System.Drawing.Point(123, 216);
            this.RenkTxt.Name = "RenkTxt";
            this.RenkTxt.Size = new System.Drawing.Size(156, 20);
            this.RenkTxt.TabIndex = 16;
            // 
            // YilTxt
            // 
            this.YilTxt.Location = new System.Drawing.Point(123, 175);
            this.YilTxt.Name = "YilTxt";
            this.YilTxt.Size = new System.Drawing.Size(156, 20);
            this.YilTxt.TabIndex = 15;
            // 
            // SeriCombo
            // 
            this.SeriCombo.FormattingEnabled = true;
            this.SeriCombo.Location = new System.Drawing.Point(123, 133);
            this.SeriCombo.Name = "SeriCombo";
            this.SeriCombo.Size = new System.Drawing.Size(156, 21);
            this.SeriCombo.TabIndex = 14;
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
            this.MarkaCombo.Location = new System.Drawing.Point(123, 91);
            this.MarkaCombo.Name = "MarkaCombo";
            this.MarkaCombo.Size = new System.Drawing.Size(156, 21);
            this.MarkaCombo.TabIndex = 13;
            this.MarkaCombo.SelectedIndexChanged += new System.EventHandler(this.MarkaCombo_SelectedIndexChanged);
            // 
            // PlakaTxt
            // 
            this.PlakaTxt.Location = new System.Drawing.Point(123, 50);
            this.PlakaTxt.Name = "PlakaTxt";
            this.PlakaTxt.Size = new System.Drawing.Size(156, 20);
            this.PlakaTxt.TabIndex = 12;
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 2;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(1148, 63);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 62);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox2.Location = new System.Drawing.Point(14, 380);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 733);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
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
            this.Controls.Add(this.ComboAraclar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboAraclar;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UcretTxt;
        private System.Windows.Forms.ComboBox YakitCombo;
        private System.Windows.Forms.TextBox KmTxt;
        private System.Windows.Forms.TextBox RenkTxt;
        private System.Windows.Forms.TextBox YilTxt;
        private System.Windows.Forms.ComboBox SeriCombo;
        private System.Windows.Forms.ComboBox MarkaCombo;
        private System.Windows.Forms.TextBox PlakaTxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}