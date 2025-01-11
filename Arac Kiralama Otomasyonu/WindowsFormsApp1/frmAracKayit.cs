using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAracKayit : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SeriCombo.Items.Clear(); // SeriCombo öğelerini temizle

                if (MarkaCombo.SelectedItem.ToString() == "Opel")
                {
                    SeriCombo.Items.Add("Astra");
                    SeriCombo.Items.Add("Corsa");
                    SeriCombo.Items.Add("Insignia");
                    SeriCombo.Items.Add("Vectra");
                    SeriCombo.Items.Add("Zafira");
                }
                else if (MarkaCombo.SelectedIndex == 1)
                {
                    SeriCombo.Items.Add("C180");
                    SeriCombo.Items.Add("C200");
                    SeriCombo.Items.Add("E200");
                    SeriCombo.Items.Add("E250");
                    SeriCombo.Items.Add("S500");
                }
                else if (MarkaCombo.SelectedIndex == 2)
                {
                    SeriCombo.Items.Add("M5");
                    SeriCombo.Items.Add("M6");
                    SeriCombo.Items.Add("X5");
                    SeriCombo.Items.Add("X6");
                    SeriCombo.Items.Add("Z4");
                }
                else if (MarkaCombo.SelectedIndex == 3)
                {
                    SeriCombo.Items.Add("A3");
                    SeriCombo.Items.Add("A4");
                    SeriCombo.Items.Add("A5");
                    SeriCombo.Items.Add("A6");
                    SeriCombo.Items.Add("A7");
                }
                else if (MarkaCombo.SelectedIndex == 4)
                {
                    SeriCombo.Items.Add("Corolla");
                    SeriCombo.Items.Add("Yaris");
                    SeriCombo.Items.Add("Auris");
                    SeriCombo.Items.Add("Avensis");
                    SeriCombo.Items.Add("C-HR");
                }
            }
            catch
            {
                // Hata işleme kodu
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into arac_kayit(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durumu) values (@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", PlakaTxt.Text);
            komut2.Parameters.AddWithValue("@marka", MarkaCombo.Text);
            komut2.Parameters.AddWithValue("@seri", SeriCombo.Text);
            komut2.Parameters.AddWithValue("@yil", YilTxt.Text);
            komut2.Parameters.AddWithValue("@renk", RenkTxt.Text);
            komut2.Parameters.AddWithValue("@km", KmTxt.Text);
            komut2.Parameters.AddWithValue("@yakit", YakitCombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(UcretTxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            arackiralama.ekle_sil_guncelle(komut2, cümle);
            SeriCombo.Items.Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            pictureBox1.ImageLocation = "";
            MessageBox.Show("Araç Kayıt İşlemi Gerçekleşti");




        }

        private void frmAracKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
