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
    public partial class frmMusteriListele : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();


        }
        private void YenileListele()
        {
            string cumle = "select * from müşteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from müşteri where tc = '" + satır.Cells["tc"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_guncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from müşteri where tc like '%"+textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.Columns[0].HeaderText = "TC"; // Column names
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Telefon";
            dataGridView1.Columns[3].HeaderText = "Adres";
            dataGridView1.Columns[4].HeaderText = "E-mail";
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update müşteri set adsoyad = @adsoyad,telefon = @telefon,adres = @adres,email = @email where tc = @tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            arackiralama.ekle_sil_guncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            YenileListele();



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtAdres.Text = satir.Cells[3].Value.ToString();
            txtEmail.Text = satir.Cells[4].Value.ToString();

        }
    }
}
