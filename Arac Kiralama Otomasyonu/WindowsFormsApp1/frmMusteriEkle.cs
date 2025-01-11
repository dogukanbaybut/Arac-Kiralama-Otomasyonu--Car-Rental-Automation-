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
    public partial class frm : Form
    {
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public frm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                // Check if any of the text boxes are empty
                if (string.IsNullOrWhiteSpace(txtTc.Text) ||
                    string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                    string.IsNullOrWhiteSpace(txtAdres.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string cumle = "insert into müşteri(tc,adsoyad,telefon,adres,email) values (@tc,@adsoyad,@telefon,@adres,@email)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", txtTc.Text);
                komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut2.Parameters.AddWithValue("@email", txtEmail.Text);
                arac_kiralama.ekle_sil_guncelle(komut2, cumle);


                foreach(Control item in Controls) // Formdaki tüm elemanları temizleme
        {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

                MessageBox.Show("Başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) // Hata yakalama
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
