namespace WindowsFormsApp1
{
    partial class frmSozlesme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSozlesme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.txtE_Yer = new System.Windows.Forms.TextBox();
            this.txtE_Tarih = new System.Windows.Forms.TextBox();
            this.txtE_No = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dateDonus = new System.Windows.Forms.DateTimePicker();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboKiraSekli = new System.Windows.Forms.ComboBox();
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAracTeslim = new System.Windows.Forms.Button();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtTcAra);
            this.groupBox1.Controls.Add(this.txtE_Yer);
            this.groupBox1.Controls.Add(this.txtE_Tarih);
            this.groupBox1.Controls.Add(this.txtE_No);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(54, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(43, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "TC ARA:";
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(115, 19);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(173, 20);
            this.txtTcAra.TabIndex = 10;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // txtE_Yer
            // 
            this.txtE_Yer.Location = new System.Drawing.Point(115, 282);
            this.txtE_Yer.Name = "txtE_Yer";
            this.txtE_Yer.Size = new System.Drawing.Size(173, 20);
            this.txtE_Yer.TabIndex = 9;
            // 
            // txtE_Tarih
            // 
            this.txtE_Tarih.Location = new System.Drawing.Point(115, 237);
            this.txtE_Tarih.Name = "txtE_Tarih";
            this.txtE_Tarih.Size = new System.Drawing.Size(173, 20);
            this.txtE_Tarih.TabIndex = 8;
            // 
            // txtE_No
            // 
            this.txtE_No.Location = new System.Drawing.Point(115, 192);
            this.txtE_No.Name = "txtE_No";
            this.txtE_No.Size = new System.Drawing.Size(173, 20);
            this.txtE_No.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(115, 147);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(173, 20);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(115, 102);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(173, 20);
            this.txtAdSoyad.TabIndex = 5;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(115, 57);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(173, 20);
            this.txtTc.TabIndex = 4;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ehliyet Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ehliyetin Verildiği Yer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ehliyet No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TC no:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.dateDonus);
            this.groupBox2.Controls.Add(this.dateCikis);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtGun);
            this.groupBox2.Controls.Add(this.txtKiraUcreti);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.txtYil);
            this.groupBox2.Controls.Add(this.txtSeri);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.comboKiraSekli);
            this.groupBox2.Controls.Add(this.comboAraclar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(420, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageIndex = 3;
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(236, 273);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(79, 37);
            this.btnTemizle.TabIndex = 27;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHesapla.ImageList = this.ımageList1;
            this.btnHesapla.Location = new System.Drawing.Point(527, 31);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(74, 221);
            this.btnHesapla.TabIndex = 26;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 1;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(137, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(84, 37);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(56, 273);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 37);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateDonus
            // 
            this.dateDonus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDonus.Location = new System.Drawing.Point(358, 232);
            this.dateDonus.Name = "dateDonus";
            this.dateDonus.Size = new System.Drawing.Size(150, 20);
            this.dateDonus.TabIndex = 23;
            // 
            // dateCikis
            // 
            this.dateCikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCikis.Location = new System.Drawing.Point(358, 192);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(150, 20);
            this.dateCikis.TabIndex = 22;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(358, 152);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(150, 20);
            this.txtTutar.TabIndex = 19;
            this.txtTutar.TextChanged += new System.EventHandler(this.txtTutar_TextChanged);
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(358, 112);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(150, 20);
            this.txtGun.TabIndex = 18;
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.Location = new System.Drawing.Point(358, 72);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(150, 20);
            this.txtKiraUcreti.TabIndex = 17;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(74, 241);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(149, 20);
            this.txtRenk.TabIndex = 16;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(74, 196);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(149, 20);
            this.txtYil.TabIndex = 15;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(74, 151);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(149, 20);
            this.txtSeri.TabIndex = 14;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(74, 106);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(149, 20);
            this.txtMarka.TabIndex = 13;
            // 
            // comboKiraSekli
            // 
            this.comboKiraSekli.FormattingEnabled = true;
            this.comboKiraSekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.comboKiraSekli.Location = new System.Drawing.Point(358, 31);
            this.comboKiraSekli.Name = "comboKiraSekli";
            this.comboKiraSekli.Size = new System.Drawing.Size(150, 21);
            this.comboKiraSekli.TabIndex = 12;
            this.comboKiraSekli.SelectedIndexChanged += new System.EventHandler(this.comboKiraSekli_SelectedIndexChanged);
            // 
            // comboAraclar
            // 
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Location = new System.Drawing.Point(74, 60);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(149, 21);
            this.comboAraclar.TabIndex = 11;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboAraclar_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(285, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Dönüş Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(294, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Çıkış Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(320, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kira Ücreti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kira Şekli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Model(Yıl)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araçlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1001, 308);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnAracTeslim
            // 
            this.btnAracTeslim.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracTeslim.ImageIndex = 4;
            this.btnAracTeslim.Location = new System.Drawing.Point(1068, 377);
            this.btnAracTeslim.Name = "btnAracTeslim";
            this.btnAracTeslim.Size = new System.Drawing.Size(74, 60);
            this.btnAracTeslim.TabIndex = 26;
            this.btnAracTeslim.Text = "Araç Teslim";
            this.btnAracTeslim.UseVisualStyleBackColor = true;
            this.btnAracTeslim.Click += new System.EventHandler(this.btnAracTeslim_Click);
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(1048, 504);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(123, 20);
            this.txtEkstra.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1065, 477);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Alacak/Verecek:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arackayit.png");
            this.ımageList1.Images.SetKeyName(1, "guncelle.png");
            this.ımageList1.Images.SetKeyName(2, "hesapla.png");
            this.ımageList1.Images.SetKeyName(3, "temizle.png");
            this.ımageList1.Images.SetKeyName(4, "teslimat.png");
            // 
            // frmSozlesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 742);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnAracTeslim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSozlesme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme Sayfası";
            this.Load += new System.EventHandler(this.frmSozlesme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtE_Yer;
        private System.Windows.Forms.TextBox txtE_Tarih;
        private System.Windows.Forms.TextBox txtE_No;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDonus;
        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtKiraUcreti;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox comboKiraSekli;
        private System.Windows.Forms.ComboBox comboAraclar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAracTeslim;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ImageList ımageList1;
    }
}