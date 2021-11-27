using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DORA.Forms
{
    public partial class UrunStoklari_form : Form
    {
        public UrunStoklari_form()
        {
            InitializeComponent();
        }

        private void UrunStoklari_form_Load(object sender, EventArgs e)
        {
            #region Check Connection
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            try
            {
                connection.Open();
            }
            catch
            {
                uyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                this.urunlerTableAdapter.Fill(this.dB_A4DFA8_urunStokDataSet.urunler);
            }
            #endregion
            
            kullanici_lbl.Text = Program.aktifKullanici;// + " (" + Program.aktifYetki + ")";
        }

        #region Menu
        private void KULLANICILARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.aktifYetki == "YÖNETİCİ" || Program.aktifYetki == "GELİŞTİRİCİ")
            {
                Kullanicilar_form kullanicilarForm = new Kullanicilar_form();
                this.Hide();
                kullanicilarForm.Show();
            }
            else
            {
                MessageBox.Show("Bu alana girme yetkiniz yok.", "Uyarı");
            }
        }

        private void ÜRÜNLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.aktifYetki == "YÖNETİCİ" || Program.aktifYetki == "GELİŞTİRİCİ")
            {
                UrunlerVePresler_form urunlerForm = new UrunlerVePresler_form();
                this.Hide();
                urunlerForm.Show();
            }
            else
            {
                MessageBox.Show("Bu alana girme yetkiniz yok.", "Uyarı");
            }
        }

        private void HamStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.aktifYetki == "YÖNETİCİ" || Program.aktifYetki == "GELİŞTİRİCİ")
            {
                Forms.UrunStoklari_form urunStoklariForm = new Forms.UrunStoklari_form();
                this.Hide();
                urunStoklariForm.Show();
            }
            else
            {
                MessageBox.Show("Bu alana girme yetkiniz yok.", "Uyarı");
            }
        }

        private void ŞekillendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.aktifYetki == "ŞEKİLLENDİRME" || Program.aktifYetki == "YÖNETİCİ" || Program.aktifYetki == "GELİŞTİRİCİ")
            {
                Sekillendirme_form sekillendirmeForm = new Sekillendirme_form();
                this.Hide();
                sekillendirmeForm.Show();
            }
            else
            {
                MessageBox.Show("Bu alana girme yetkiniz yok.", "Uyarı");
            }
        }

        private void ÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giris_form girisForm = new Giris_form();
            this.Hide();
            girisForm.Show();
        }

        private void HakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.hakkinda, "Hakkında");
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            uyari_lbl.Text = "";
            uyari_lbl.Refresh();
            timer1.Stop();
        }
    }
}
