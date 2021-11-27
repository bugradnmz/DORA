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
    public partial class UrunlerVePresler_form : Form
    {
        String urunKimlik;
        String urunKodu;
        String urunAdi;

        String makineKimlik;
        String makineAdi;

        public UrunlerVePresler_form()
        {
            InitializeComponent();
        }

        private void Urunler_form_Load(object sender, EventArgs e)
        {
            #region Check Connection
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            try
            {
                connection.Open();
            }
            catch
            {
                urunUyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                urunUyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();

                presUyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                presUyari_lbl.Refresh();
                timer2.Stop();
                timer2.Start();
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                this.makinelerTableAdapter.Fill(this.dB_A4DFA8_makinelerDataSet.makineler);
                this.urunlerTableAdapter.Fill(this.dB_A4DFA8_urunlerDataSet.urunler);
            }
            #endregion            

            kullanici_lbl.Text = Program.aktifKullanici;// + " (" + Program.aktifYetki + ")";
        }       

        private void UrunEkle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getUrunKodu = "select urun_kodu from urunler where urun_kodu='" + urunKodu_txt.Text.Trim() + "'";
            string getUrunAdi = "select urun_adi from urunler where urun_adi='" + urunAdi_txt.Text.Trim() + "'";

            try
            {
                urunUyari_lbl.Text = "Yeni ürün ekleniyor...";
                urunUyari_lbl.Refresh();

                connection.Open();
            }
            catch
            {
                urunUyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                urunUyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }

            if(connection.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDataAdapterKod = new SqlDataAdapter(getUrunKodu, connection);
                DataTable dataTableKod = new DataTable();
                sqlDataAdapterKod.Fill(dataTableKod);

                SqlDataAdapter sqlDataAdapterAd = new SqlDataAdapter(getUrunAdi, connection);
                DataTable dataTableAd = new DataTable();
                sqlDataAdapterAd.Fill(dataTableAd);

                if(urunKodu_txt.Text == "")
                {
                    urunUyari_lbl.Text = "Ürün Kodu'nu boş bıraktınız.";
                    urunUyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if(urunAdi_txt.Text == "")
                {
                    urunUyari_lbl.Text = "Ürün Adı'nı boş bıraktınız.";
                    urunUyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if(dataTableKod.Rows.Count == 1)
                {
                    urunUyari_lbl.Text = "Bu Ürün Kodu'na sahip bir ürün zaten mevcut.";
                    urunUyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (dataTableAd.Rows.Count == 1)
                {
                    urunUyari_lbl.Text = "Bu Ürün Adı'na sahip bir ürün zaten mevcut.";
                    urunUyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else
                {
                    string insertUrun = "insert into urunler (urun_kodu,urun_adi,ham_stok,biskuvi_stok,kalite1,kalite2,tamir) values('" + urunKodu_txt.Text.Trim() + "','" + urunAdi_txt.Text.Trim() + "',0,0,0,0,0);";
                    SqlCommand command = new SqlCommand(insertUrun, connection);
                    command.ExecuteNonQuery();

                    this.urunlerTableAdapter.Fill(this.dB_A4DFA8_urunlerDataSet.urunler);

                    ResetFormUrun();

                    urunUyari_lbl.Text = "Ürün başarıyla eklendi.";
                    urunUyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                connection.Close();
            }
        }

        private void UrunGuncelle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getID = "select urun_id from urunler where urun_id =" + urunKimlik;
            string getUrunKodu = "select urun_kodu from urunler where urun_kodu='" + urunKodu_txt.Text.Trim() + "'";
            string getUrunAdi = "select urun_adi from urunler where urun_adi='" + urunAdi_txt.Text.Trim() + "'";

            try
            {
                urunUyari_lbl.Text = "Ürün güncelleniyor...";
                urunUyari_lbl.Refresh();

                connection.Open();
            }
            catch
            {
                urunUyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                urunUyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }

            if (urunKimlik != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sqlDataAdapterID = new SqlDataAdapter(getID, connection);
                    DataTable dataTableID = new DataTable();
                    sqlDataAdapterID.Fill(dataTableID);

                    SqlDataAdapter sqlDataAdapterKod = new SqlDataAdapter(getUrunKodu, connection);
                    DataTable dataTableKod = new DataTable();
                    sqlDataAdapterKod.Fill(dataTableKod);

                    SqlDataAdapter sqlDataAdapterAd = new SqlDataAdapter(getUrunAdi, connection);
                    DataTable dataTableAd = new DataTable();
                    sqlDataAdapterAd.Fill(dataTableAd);

                    if (dataTableID.Rows.Count == 1)
                    {
                        if (dataTableKod.Rows.Count == 0 || urunKodu_txt.Text == urunKodu)
                        {
                            if (dataTableAd.Rows.Count == 0 || urunAdi_txt.Text == urunAdi)
                            {
                                DialogResult changeSure = MessageBox.Show("Ürün'ü güncellemek istediğinize emin misiniz?", "Ürün'ü Güncelle", MessageBoxButtons.YesNo);

                                if (changeSure == DialogResult.Yes)
                                {                                    
                                    string updateUrun = "UPDATE urunler SET urun_kodu='" + urunKodu_txt.Text.Trim() + "',urun_adi ='" + urunAdi_txt.Text.Trim() + "' WHERE urun_id=" + urunKimlik;
                                    SqlCommand command = new SqlCommand(updateUrun, connection);
                                    command.ExecuteNonQuery();

                                    this.urunlerTableAdapter.Fill(this.dB_A4DFA8_urunlerDataSet.urunler);

                                    urunKodu = urunKodu_txt.Text;
                                    urunAdi = urunAdi_txt.Text;

                                    ResetFormUrun();

                                    urunUyari_lbl.Text = "Ürün başarıyla güncellendi.";
                                    urunUyari_lbl.Refresh();
                                    timer1.Stop();
                                    timer1.Start();
                                }
                                else
                                {
                                    urunUyari_lbl.Text = "Ürün güncelleme işlemi iptal edildi.";
                                    urunUyari_lbl.Refresh();
                                    timer1.Stop();
                                    timer1.Start();
                                }
                            }
                            else
                            {
                                urunUyari_lbl.Text = "Bu Ürün Adı'na sahip bir ürün zaten mevcut.";
                                urunUyari_lbl.Refresh();
                                timer1.Stop();
                                timer1.Start();
                            }
                        }
                        else
                        {
                            urunUyari_lbl.Text = "Bu Ürün Kodu'na sahip bir ürün zaten mevcut.";
                            urunUyari_lbl.Refresh();
                            timer1.Stop();
                            timer1.Start();
                        }
                    }
                    else
                    {
                        urunUyari_lbl.Text = "Böyle bir ürün bulunmamaktadır. Lütfen Ürün'ü doğru seçtiğinizden emin olun.";
                        urunUyari_lbl.Refresh();
                        timer1.Stop();
                        timer1.Start();
                    }
                    connection.Close();
                }
            }
            else
            {
                urunUyari_lbl.Text = "Böyle bir ürün bulunmamaktadır. Lütfen Ürün'ü doğru seçtiğinizden emin olun.";
                urunUyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }            
        }

        private void UrunSil_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getID = "select urun_id from urunler where urun_id =" + urunKimlik;

            try
            {
                urunUyari_lbl.Text = "Ürün siliniyor...";
                urunUyari_lbl.Refresh();

                connection.Open();
            }
            catch
            {
                urunUyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                urunUyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }

            if (urunKimlik != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sqlDataAdapterID = new SqlDataAdapter(getID, connection);
                    DataTable dataTableID = new DataTable();
                    sqlDataAdapterID.Fill(dataTableID);

                    if (dataTableID.Rows.Count == 1)
                    {
                        DialogResult deleteSure = MessageBox.Show("Ürün'ü silmek istediğinize emin misiniz?", "Ürün'ü Sil", MessageBoxButtons.YesNo);

                        if (deleteSure == DialogResult.Yes)
                        {
                            string deleteUrun = "delete from urunler where urun_id=" + urunKimlik;
                            SqlCommand command = new SqlCommand(deleteUrun, connection);
                            command.ExecuteNonQuery();

                            this.urunlerTableAdapter.Fill(this.dB_A4DFA8_urunlerDataSet.urunler);

                            ResetFormUrun();

                            urunUyari_lbl.Text = "Ürün başarıyla silindi.";
                            urunUyari_lbl.Refresh();
                            timer1.Stop();
                            timer1.Start();
                        }
                        else
                        {
                            urunUyari_lbl.Text = "Ürün silme işlemi iptal edildi.";
                            urunUyari_lbl.Refresh();
                            timer1.Stop();
                            timer1.Start();
                        }
                    }
                    else
                    {
                        urunUyari_lbl.Text = "Böyle bir ürün bulunmamaktadır. Lütfen Ürün'ü doğru seçtiğinizden emin olun.";
                        urunUyari_lbl.Refresh();
                        timer1.Stop();
                        timer1.Start();
                    }
                connection.Close();
                }
            }
            else
            {
                urunUyari_lbl.Text = "Böyle bir ürün bulunmamaktadır. Lütfen Ürün'ü doğru seçtiğinizden emin olun.";
                urunUyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }
        }

        private void MakineEkle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getPresAdi = "select makine_adi from makineler where makine_adi='" + makineAdi_txt.Text.Trim() + "'";

            try
            {
                presUyari_lbl.Text = "Yeni Makine ekleniyor...";
                presUyari_lbl.Refresh();

                connection.Open();
            }
            catch
            {
                presUyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                presUyari_lbl.Refresh();
                timer2.Stop();
                timer2.Start();
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDataAdapterAd = new SqlDataAdapter(getPresAdi, connection);
                DataTable dataTableAd = new DataTable();
                sqlDataAdapterAd.Fill(dataTableAd);

                if (makineAdi_txt.Text == "")
                {
                    presUyari_lbl.Text = "Makine Adı'nı boş bıraktınız.";
                    presUyari_lbl.Refresh();
                    timer2.Stop();
                    timer2.Start();
                }
                else if (dataTableAd.Rows.Count == 1)
                {
                    presUyari_lbl.Text = "Bu Makine Adı'na sahip bir Makine zaten mevcut.";
                    presUyari_lbl.Refresh();
                    timer2.Stop();
                    timer2.Start();
                }
                else
                {
                    string insertPres = "insert into makineler (makine_adi) values('" + makineAdi_txt.Text.Trim() + "');";
                    SqlCommand command = new SqlCommand(insertPres, connection);
                    command.ExecuteNonQuery();

                    this.makinelerTableAdapter.Fill(this.dB_A4DFA8_makinelerDataSet.makineler);

                    ResetFormMakine();

                    presUyari_lbl.Text = "Makine başarıyla eklendi.";
                    presUyari_lbl.Refresh();
                    timer2.Stop();
                    timer2.Start();
                }
                connection.Close();
            }
        }

        private void MakineGuncelle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getID = "select makine_id from makineler where makine_id =" + makineKimlik;
            string getPresAdi = "select makine_adi from makineler where makine_adi ='" + makineAdi_txt.Text.Trim() + "'";

            try
            {
                presUyari_lbl.Text = "Makine güncelleniyor...";
                presUyari_lbl.Refresh();

                connection.Open();
            }
            catch
            {
                presUyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                presUyari_lbl.Refresh();
                timer2.Stop();
                timer2.Start();
            }

            if (makineKimlik != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sqlDataAdapterID = new SqlDataAdapter(getID, connection);
                    DataTable dataTableID = new DataTable();
                    sqlDataAdapterID.Fill(dataTableID);

                    SqlDataAdapter sqlDataAdapterAd = new SqlDataAdapter(getPresAdi, connection);
                    DataTable dataTableAd = new DataTable();
                    sqlDataAdapterAd.Fill(dataTableAd);
                                        
                    if (dataTableID.Rows.Count == 1)
                    {
                        if (dataTableAd.Rows.Count == 0 || makineAdi_txt.Text == makineAdi) //Aynı isimden tabloda yoksa yap. Kendi ismi hariç.
                        {
                            DialogResult changeSure = MessageBox.Show("Makine'yi güncellemek istediğinize emin misiniz?", "Makine'yi Güncelle", MessageBoxButtons.YesNo);

                            if (changeSure == DialogResult.Yes)
                            {
                                string updatePres = "UPDATE makineler SET makine_adi='" + makineAdi_txt.Text.Trim() +"' WHERE makine_id=" + makineKimlik;
                                SqlCommand command = new SqlCommand(updatePres, connection);
                                command.ExecuteNonQuery();

                                this.makinelerTableAdapter.Fill(this.dB_A4DFA8_makinelerDataSet.makineler);

                                makineAdi = makineAdi_txt.Text;//Aynı isimden tabloda yoksa yap. Kendi ismi hariç.

                                ResetFormMakine();

                                presUyari_lbl.Text = "Makine başarıyla güncellendi.";
                                presUyari_lbl.Refresh();
                                timer2.Stop();
                                timer2.Start();
                            }
                            else
                            {
                                presUyari_lbl.Text = "Makine güncelleme işlemi iptal edildi.";
                                presUyari_lbl.Refresh();
                                timer2.Stop();
                                timer2.Start();
                            }
                        }
                        else
                        {
                            presUyari_lbl.Text = "Bu Makine Adı'na sahip bir Makine zaten mevcut.";
                            presUyari_lbl.Refresh();
                            timer2.Stop();
                            timer2.Start();
                        }
                    }
                    else
                    {
                        presUyari_lbl.Text = "Böyle bir Makine bulunmamaktadır. Lütfen Makine'yi doğru seçtiğinizden emin olun.";
                        presUyari_lbl.Refresh();
                        timer2.Stop();
                        timer2.Start();
                    }
                    
                    connection.Close();
                }
            }
            else
            {
                presUyari_lbl.Text = "Böyle bir Makine bulunmamaktadır. Lütfen Makine'yi doğru seçtiğinizden emin olun.";
                presUyari_lbl.Refresh();
                timer2.Stop();
                timer2.Start();
            }
        }

        private void MakineSil_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getID = "select makine_id from makineler where makine_id =" + makineKimlik;

            try
            {
                presUyari_lbl.Text = "Makine siliniyor...";
                presUyari_lbl.Refresh();

                connection.Open();
            }
            catch
            {
                presUyari_lbl.Text = "Bağlantı başarız. Lütfen internet bağlantınızı kontrol edin. İnternet bağlantınız olmasına rağmen bu hatayı görüyorsanız yazılım geliştiricinize başvurun.";
                presUyari_lbl.Refresh();
                timer2.Stop();
                timer2.Start();
            }

            if (makineKimlik != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sqlDataAdapterID = new SqlDataAdapter(getID, connection);
                    DataTable dataTableID = new DataTable();
                    sqlDataAdapterID.Fill(dataTableID);

                    if (dataTableID.Rows.Count == 1)
                    {
                        DialogResult deleteSure = MessageBox.Show("Makine'yi silmek istediğinize emin misiniz?", "Makine'yi Sil", MessageBoxButtons.YesNo);

                        if (deleteSure == DialogResult.Yes)
                        {
                            string deletePres = "delete from makineler where makine_id=" + makineKimlik;
                            SqlCommand command = new SqlCommand(deletePres, connection);
                            command.ExecuteNonQuery();

                            this.makinelerTableAdapter.Fill(this.dB_A4DFA8_makinelerDataSet.makineler);

                            ResetFormMakine();

                            presUyari_lbl.Text = "Makine başarıyla silindi.";
                            presUyari_lbl.Refresh();
                            timer2.Stop();
                            timer2.Start();
                        }
                        else
                        {
                            presUyari_lbl.Text = "Makine silme işlemi iptal edildi.";
                            presUyari_lbl.Refresh();
                            timer2.Stop();
                            timer2.Start();
                        }
                    }
                    else
                    {
                        presUyari_lbl.Text = "Böyle bir Makine bulunmamaktadır. Lütfen Makine'yi doğru seçtiğinizden emin olun.";
                        presUyari_lbl.Refresh();
                        timer2.Stop();
                        timer2.Start();
                    }
                    connection.Close();
                }
            }
            else
            {
                presUyari_lbl.Text = "Böyle bir Makine bulunmamaktadır. Lütfen Makine'yi doğru seçtiğinizden emin olun.";
                presUyari_lbl.Refresh();
                timer2.Stop();
                timer2.Start();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                urunKodu = selectedRow.Cells["urun_kodu"].Value.ToString();
                urunAdi = selectedRow.Cells["urun_adi"].Value.ToString();

                urunKimlik = selectedRow.Cells["urun_id"].Value.ToString();
                urunKimlik_lbl.Text = "Seçili Ürün Kimliği: " + urunKimlik;

                urunKodu_txt.Text = selectedRow.Cells["urun_kodu"].Value.ToString();
                urunAdi_txt.Text = selectedRow.Cells["urun_adi"].Value.ToString();
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                makineAdi = selectedRow.Cells["makine_adi"].Value.ToString();

                makineKimlik = selectedRow.Cells["makine_id"].Value.ToString();
                makineKimlik_lbl.Text = "Seçili Makine Kimliği: " + makineKimlik;

                makineAdi_txt.Text = selectedRow.Cells["makine_adi"].Value.ToString();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            urunUyari_lbl.Text = "";
            urunUyari_lbl.Refresh();
            timer1.Stop();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            presUyari_lbl.Text = "";
            presUyari_lbl.Refresh();
            timer1.Stop();
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

        //Tüm textboxlar için türkçe büyük harf.
        private void PresAdi_txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txBox = (TextBox)sender;
            int pos = txBox.SelectionStart;
            int slen = txBox.SelectionLength;
            txBox.Text = txBox.Text.ToUpper();
            txBox.SelectionStart = pos;
            txBox.SelectionLength = slen;
            txBox.Focus();
        }

        private void ResetFormUrun()
        {
            urunKimlik = null;
            urunKimlik_lbl.Text = "Seçili Ürün Kimliği: " + urunKimlik;
            urunKodu_txt.Text = "";
            urunAdi_txt.Text = "";
        }

        private void ResetFormMakine()
        {
            makineKimlik = null;
            makineKimlik_lbl.Text = "Seçili Makine Kimliği: " + makineKimlik;
            makineAdi_txt.Text = "";
        }
    }
}
