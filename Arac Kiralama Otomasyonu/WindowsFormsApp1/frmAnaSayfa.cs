using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAnaSayfa : Form
    {

        public frmAnaSayfa()
        {
            InitializeComponent();
            
        }


        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm ekle = new frm();
            ekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAracKayit kayıt = new frmAracKayit();
            kayıt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAracListele listele = new frmAracListele();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSozlesme sozlesme = new frmSozlesme();
            sozlesme.ShowDialog ();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }
    }
}
