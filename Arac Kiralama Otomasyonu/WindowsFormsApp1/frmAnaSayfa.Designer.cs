﻿namespace WindowsFormsApp1
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 105);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button7
            // 
            this.button7.ImageIndex = 3;
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(924, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 81);
            this.button7.TabIndex = 4;
            this.button7.Text = "Çıkış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arackayit.png");
            this.ımageList1.Images.SetKeyName(1, "carlist.png");
            this.ımageList1.Images.SetKeyName(2, "carlist3.png");
            this.ımageList1.Images.SetKeyName(3, "cikis.png");
            this.ımageList1.Images.SetKeyName(4, "satis.png");
            this.ımageList1.Images.SetKeyName(5, "sozlesme.ong.png");
            this.ımageList1.Images.SetKeyName(6, "user_add.png");
            this.ımageList1.Images.SetKeyName(7, "msuterilist.png");
            // 
            // button6
            // 
            this.button6.ImageIndex = 4;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(773, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 81);
            this.button6.TabIndex = 3;
            this.button6.Text = "Satışlar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(18, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "Müşteri Ekleme";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.ImageIndex = 7;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(169, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 81);
            this.button3.TabIndex = 4;
            this.button3.Text = "Müşteri Listeleme";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImageKey = "arackayit.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(320, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 81);
            this.button4.TabIndex = 5;
            this.button4.Text = "Araç Kayıt";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ImageIndex = 2;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(471, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 81);
            this.button5.TabIndex = 6;
            this.button5.Text = "Araç Listeleme";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.ImageIndex = 5;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(622, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sözleşme";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1054, 748);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

