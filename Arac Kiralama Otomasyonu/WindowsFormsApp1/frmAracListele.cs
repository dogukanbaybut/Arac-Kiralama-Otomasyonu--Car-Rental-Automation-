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
    public partial class frmAracListele : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmAracListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            PlakaTxt.Text = satir.Cells["plaka"].Value.ToString();
            MarkaCombo.Text = satir.Cells["marka"].Value.ToString();
            SeriCombo.Text = satir.Cells["seri"].Value.ToString();
            YilTxt.Text = satir.Cells["yil"].Value.ToString();
            RenkTxt.Text = satir.Cells["renk"].Value.ToString();
            KmTxt.Text = satir.Cells["km"].Value.ToString();
            YakitCombo.Text = satir.Cells["yakit"].Value.ToString();
            UcretTxt.Text = satir.Cells["kiraucreti"].Value.ToString();
            
            pictureBox2.ImageLocation = satir.Cells["resim"].Value.ToString();
            


        }

        private void frmAracListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarıListesi();
            try
            {
                ComboAraclar.SelectedIndex= 0;
            }
            catch
            {

            }
        }
        private void YenileAraçlarıListesi()
        {
            string cümle = "select * from arac_kayit";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource= arackiralama.listele(adtr2, cümle);

        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update arac_kayit set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim, tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", PlakaTxt.Text);
            komut2.Parameters.AddWithValue("@marka", MarkaCombo.Text);
            komut2.Parameters.AddWithValue("@seri", SeriCombo.Text);
            komut2.Parameters.AddWithValue("@yil", YilTxt.Text);
            komut2.Parameters.AddWithValue("@renk", RenkTxt.Text);
            komut2.Parameters.AddWithValue("@km", KmTxt.Text);
            komut2.Parameters.AddWithValue("@yakit", YakitCombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(UcretTxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
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
            pictureBox2.ImageLocation = "";
            MessageBox.Show("Araç Kayıt İşlemi Güncellendi");
            YenileAraçlarıListesi();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from arac_kayit where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_guncelle(komut2, cümle);
            pictureBox2.ImageLocation = "";
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
            YenileAraçlarıListesi();
        }

        private void MarkaCombo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ComboAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(ComboAraclar.SelectedIndex==0)
                {
                    YenileAraçlarıListesi();
                }
                if (ComboAraclar.SelectedIndex == 1)
                {
                    string cümle = "select * from arac_kayit where durumu='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
                if (ComboAraclar.SelectedIndex == 2)
                {
                    string cümle = "select * from arac_kayit where durumu ='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
            }
            catch
            {

            }
        }
    }
}
