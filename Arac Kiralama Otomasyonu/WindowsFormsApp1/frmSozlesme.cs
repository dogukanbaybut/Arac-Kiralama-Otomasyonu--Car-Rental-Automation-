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
    public partial class frmSozlesme : Form
    {
        public frmSozlesme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sozlesme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarih) values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
            komut.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
            komut.Parameters.AddWithValue("@e_yer", txtE_Yer.Text);
            komut.Parameters.AddWithValue("@plaka", comboAraclar.Text);
            komut.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut.Parameters.AddWithValue("@yil", txtYil.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@kirasekli", comboKiraSekli.Text);
            if (int.TryParse(txtKiraUcreti.Text, out int kiraUcreti))
            {
                komut.Parameters.AddWithValue("@kiraucreti", kiraUcreti);
            }
            else
            {
                MessageBox.Show("Kira ücreti geçerli bir sayı olmalıdır.");
                return;
            }

            if (int.TryParse(txtGun.Text, out int gun))
            {
                komut.Parameters.AddWithValue("@gun", gun);
            }
            else
            {
                MessageBox.Show("Gün geçerli bir sayı olmalıdır.");
                return;
            }

            if (int.TryParse(txtTutar.Text, out int tutar))
            {
                komut.Parameters.AddWithValue("@tutar", tutar);
            }
            else
            {
                MessageBox.Show("Tutar geçerli bir sayı olmalıdır.");
                return;
            }
            komut.Parameters.AddWithValue("@ctarih", dateCikis.Text);
            komut.Parameters.AddWithValue("@dtarih", dateDonus.Text);
            arac.ekle_sil_guncelle(komut, sorgu2);
            string sorgu3 = "update arac_kayit set durumu='DOLU' where plaka ='" + comboAraclar.Text + "'";
            SqlCommand komut3 = new SqlCommand();
            arac.ekle_sil_guncelle(komut3, sorgu3);
            comboAraclar.Items.Clear();
            BosAraclar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraclar.Text = "";
            Temizle();
            // Show success message
            MessageBox.Show("Her şey başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        Arac_Kiralama arac = new Arac_Kiralama();

        private void frmSozlesme_Load(object sender, EventArgs e)
        {
            BosAraclar();
            Yenile();

        }

        private void BosAraclar()
        {
            string sorgu2 = "Select * from arac_kayit where durumu='BOŞ'";
            arac.Bos_Araclar(comboAraclar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sozlesme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "Select * from arac_kayit where plaka like '" + comboAraclar.SelectedItem + "'";
            arac.CombodanGetir(comboAraclar,txtMarka, txtSeri, txtYil, txtRenk,sorgu2);
        }

        private void comboKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "Select * from arac_kayit where plaka like '" + comboAraclar.SelectedItem + "'";
            arac.Ucret_Hesapla(comboKiraSekli, txtKiraUcreti, sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateCikisValue = DateTime.Parse(dateCikis.Text);
                DateTime dateDonusValue = DateTime.Parse(dateDonus.Text);

                if (dateDonusValue < dateCikisValue)
                {
                    MessageBox.Show("Dönüş tarihi çıkış tarihinden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimeSpan gunFarki = dateDonusValue - dateCikisValue;
                int totalDays = gunFarki.Days;

                // Display the total days in the respective text box
                txtGun.Text = totalDays.ToString();

                // Get the daily rental rate
                if (decimal.TryParse(txtKiraUcreti.Text, out decimal dailyRate))
                {
                    decimal totalCost = totalDays * dailyRate;

                    // Display the total cost in the respective text box
                    txtTutar.Text = totalCost.ToString("F0");

                    // Optionally, display the total cost in a message box
                    MessageBox.Show("Toplam maliyet: " + totalCost.ToString("F0") + " TL", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Geçerli bir kira ücreti girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir tarih formatı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dateCikis.Text = DateTime.Now.ToShortDateString();
            dateDonus.Text = DateTime.Now.ToShortDateString();
            comboKiraSekli.Text = "";
            txtKiraUcreti.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";


        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "Select * from müşteri where tc like '" + txtTcAra.Text + "'";
            arac.TC_Ara(txtTcAra,txtTc, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            {
                string sorgu2 = "update sozlesme set adsoyad=@adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, e_tarih=@e_tarih, e_yer=@e_yer, plaka=@plaka, marka=@marka, seri=@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti=@kiraucreti, gun=@gun, tutar=@tutar, ctarih=@ctarih, dtarih=@dtarih where tc=@tc";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
                komut.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
                komut.Parameters.AddWithValue("@e_yer", txtE_Yer.Text);
                komut.Parameters.AddWithValue("@plaka", comboAraclar.Text);
                komut.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut.Parameters.AddWithValue("@seri", txtSeri.Text);
                komut.Parameters.AddWithValue("@yil", txtYil.Text);
                komut.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut.Parameters.AddWithValue("@kirasekli", comboKiraSekli.Text);
                if (int.TryParse(txtKiraUcreti.Text, out int kiraUcreti))
                {
                    komut.Parameters.AddWithValue("@kiraucreti", kiraUcreti);
                }
                else
                {
                    MessageBox.Show("Kira ücreti geçerli bir sayı olmalıdır.");
                    return;
                }

                if (int.TryParse(txtGun.Text, out int gun))
                {
                    komut.Parameters.AddWithValue("@gun", gun);
                }
                else
                {
                    MessageBox.Show("Gün geçerli bir sayı olmalıdır.");
                    return;
                }

                if (int.TryParse(txtTutar.Text, out int tutar))
                {
                    komut.Parameters.AddWithValue("@tutar", tutar);
                }
                else
                {
                    MessageBox.Show("Tutar geçerli bir sayı olmalıdır.");
                    return;
                }
                komut.Parameters.AddWithValue("@ctarih", dateCikis.Text);
                komut.Parameters.AddWithValue("@dtarih", dateDonus.Text);
                arac.ekle_sil_guncelle(komut, sorgu2);
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboAraclar.Text = "";
                Temizle();

                // Show success message
                MessageBox.Show("Sözleşme başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txtTc.Text = row.Cells["tc"].Value.ToString();
                    txtAdSoyad.Text = row.Cells["adsoyad"].Value.ToString();
                    txtTelefon.Text = row.Cells["telefon"].Value.ToString();
                    txtE_No.Text = row.Cells["ehliyetno"].Value.ToString();
                    txtE_Tarih.Text = row.Cells["e_tarih"].Value.ToString();
                    txtE_Yer.Text = row.Cells["e_yer"].Value.ToString();
                    comboAraclar.Text = row.Cells["plaka"].Value.ToString();
                    txtMarka.Text = row.Cells["marka"].Value.ToString();
                    txtSeri.Text = row.Cells["seri"].Value.ToString();
                    txtYil.Text = row.Cells["yil"].Value.ToString();
                    txtRenk.Text = row.Cells["renk"].Value.ToString();
                    comboKiraSekli.Text = row.Cells["kirasekli"].Value.ToString();
                    txtKiraUcreti.Text = row.Cells["kiraucreti"].Value.ToString();
                    txtGun.Text = row.Cells["gun"].Value.ToString();
                    txtTutar.Text = row.Cells["tutar"].Value.ToString();
                    dateCikis.Text = row.Cells["ctarih"].Value.ToString();
                    dateDonus.Text = row.Cells["dtarih"].Value.ToString();
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;

                if (satır.Cells["dtarih"].Value != null && DateTime.TryParse(satır.Cells["dtarih"].Value.ToString(), out DateTime dönüş) &&
                    satır.Cells["kiraucreti"].Value != null && int.TryParse(satır.Cells["kiraucreti"].Value.ToString(), out int ucret))
                {
                    DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                    TimeSpan gunfarkı = bugün - dönüş;
                    int _gunfarkı = gunfarkı.Days;
                    int ucretfarkı = _gunfarkı * ucret;
                    txtEkstra.Text = ucretfarkı.ToString();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir tarih ve kira ücreti girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;

                if (satır.Cells["dtarih"].Value != null && DateTime.TryParse(satır.Cells["dtarih"].Value.ToString(), out DateTime dönüş) &&
                    satır.Cells["kiraucreti"].Value != null && int.TryParse(satır.Cells["kiraucreti"].Value.ToString(), out int ucret) &&
                    satır.Cells["tutar"].Value != null && int.TryParse(satır.Cells["tutar"].Value.ToString(), out int tutar) &&
                    satır.Cells["ctarih"].Value != null && DateTime.TryParse(satır.Cells["ctarih"].Value.ToString(), out DateTime çıkış))
                {
                    DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                    TimeSpan gun = bugün - çıkış;
                    int _gun = gun.Days;
                    int toplamtutar = _gun * ucret;

                    // Ekstra ücret hesaplama
                    int ekstraUcret = toplamtutar - tutar;
                    txtEkstra.Text = ekstraUcret.ToString();

                    // Aracın durumunu güncelle
                    string plaka = satır.Cells["plaka"].Value.ToString();
                    string sorgu = "update arac_kayit set durumu='BOŞ' where plaka=@plaka";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.AddWithValue("@plaka", plaka);
                    arac.ekle_sil_guncelle(komut, sorgu);

                    // Sözleşme tablosundan ilgili kaydı sil
                    string sorgu2 = "delete from sozlesme where plaka=@plaka";
                    SqlCommand komut3 = new SqlCommand();
                    komut3.Parameters.AddWithValue("@plaka", plaka);
                    arac.ekle_sil_guncelle(komut3, sorgu2);

                    string sorgu3 = "insert into satis(tc,adsoyad,plaka,marka,seri,yil,renk,gun,tutar,tarih1,tarih2,fiyat) values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@tutar,@tarih1,@tarih2,@fiyat)";
                    SqlCommand komut4 = new SqlCommand();
                    komut4.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                    komut4.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
                    komut4.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                    komut4.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                    komut4.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                    komut4.Parameters.AddWithValue("@yil", satır.Cells["yil"].Value.ToString());
                    komut4.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                    komut4.Parameters.AddWithValue("@gun", _gun);
                    komut4.Parameters.AddWithValue("@tutar", toplamtutar);
                    komut4.Parameters.AddWithValue("@tarih1", satır.Cells["ctarih"].Value.ToString());
                    komut4.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                    komut4.Parameters.AddWithValue("@fiyat", ucret);
                    arac.ekle_sil_guncelle(komut4, sorgu3);


                    MessageBox.Show("Araç teslim edildi.");
                    





                    // Arayüzü güncelle
                    comboAraclar.Items.Clear();
                    BosAraclar();
                    Yenile();
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                    comboAraclar.Text = "";
                    Temizle();
                    txtEkstra.Text = "";

                    // Başarı mesajı göster

                }
                
            }
            
        }

    }
    
}
