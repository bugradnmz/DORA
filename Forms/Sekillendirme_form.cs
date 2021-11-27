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

namespace DORA
{
    public partial class Sekillendirme_form : Form
    {
        public Sekillendirme_form()
        {
            InitializeComponent();
        }

        private void Sekillendirme_form_Load(object sender, EventArgs e)
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
                this.sekillendirmeTableAdapter.Fill(this.dB_A4DFA8_sekillendirmeDataSet.sekillendirme);
            }
            #endregion

            kullanici_lbl.Text = Program.aktifKullanici;// + " (" + Program.aktifYetki + ")";

            Program.kimlik = null;

            if (Program.kayit == true)
            {
                Program.kayit = false;
                uyari_lbl.Text = "Yeni kayıt başarıyla eklendi.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }
            else if (Program.guncelle == true)
            {
                Program.guncelle = false;
                uyari_lbl.Text = "Kayıt başarıyla güncellendi.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }
            else if (Program.guncelleIptal == true)
            {
                Program.guncelleIptal = false;
                uyari_lbl.Text = "Kayıt güncelleme işlemi iptal edildi.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }
            else if (Program.kayitIptal == true)
            {
                Program.kayitIptal = false;
                uyari_lbl.Text = "Yeni kayıt ekleme işlemi iptal edildi.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }
        }

        private void Ekle_btn_Click(object sender, EventArgs e)
        {
            SekillendirmeKayit_form kayitForm = new SekillendirmeKayit_form();
            this.Hide();
            kayitForm.Show();
        }

        private void Guncelle_btn_Click(object sender, EventArgs e)
        {
            if (Program.kimlik != null)
            {
                if (Program.aktifYetki == "YÖNETİCİ" || Program.aktifYetki == "GELİŞTİRİCİ")
                {
                    SekillendirmeGuncelle_form guncelleForm = new SekillendirmeGuncelle_form();
                    this.Hide();
                    guncelleForm.Show();
                }
                else
                {
                    uyari_lbl.Text = "Kayıt güncelleme yetkiniz yok. Lütfen yöneticinize başvurun.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
            }
            else
            {
                uyari_lbl.Text = "Kayıt seçmediniz.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();                
            }
        }

        private void Sil_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);            

            try
            {
                uyari_lbl.Text = "Kayıt siliniyor...";
                uyari_lbl.Refresh();

                connection.Open();
            }
            catch
            {
                uyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }

            if (Program.kimlik != null)
            {
                if (Program.aktifYetki == "YÖNETİCİ" || Program.aktifYetki == "GELİŞTİRİCİ")
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        DialogResult deleteSure = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo);

                        if (deleteSure == DialogResult.Yes)
                        {
                            string deleteQuery = "delete from sekillendirme where id =" + Program.kimlik;
                            SqlCommand command = new SqlCommand(deleteQuery, connection);
                            command.ExecuteNonQuery();

                            this.sekillendirmeTableAdapter.Fill(this.dB_A4DFA8_sekillendirmeDataSet.sekillendirme);

                            Program.kimlik = null;
                            kimlik_lbl.Text = "Seçili Kayıt Kimliği: " + Program.kimlik;

                            uyari_lbl.Text = "Kayıt başarıyla silindi.";
                            uyari_lbl.Refresh();
                            timer1.Stop();
                            timer1.Start();
                        }
                        else
                        {
                            uyari_lbl.Text = "Kayıt silme işlemi iptal edildi.";
                            uyari_lbl.Refresh();
                            timer1.Stop();
                            timer1.Start();
                        }

                        connection.Close();
                    }                    
                }
                else
                {
                    uyari_lbl.Text = "Kayıt silme yetkiniz yok. Lütfen yöneticinize başvurun.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
            }
            else
            {
                uyari_lbl.Text = "Kayıt seçmediniz.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            uyari_lbl.Text = "";
            uyari_lbl.Refresh();
            timer1.Stop();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];

                Program.kimlik = selectedRow.Cells["id"].Value.ToString();

                kimlik_lbl.Text = "Seçili Kayıt Kimliği: " + Program.kimlik;
            }
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
    }
}
