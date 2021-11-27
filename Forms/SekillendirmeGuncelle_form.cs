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
    public partial class SekillendirmeGuncelle_form : Form
    {
        //Stok Çalışmaları
        string eskiUrunKodu;
        int eskiNet;
        int yeniStok;
        //

        public SekillendirmeGuncelle_form()
        {
            InitializeComponent();

            FillList();
            FillCombo();
            LoadData();

            kimlik_lbl.Text = "Güncellenen Kayıt Kimliği: " + Program.kimlik;
        }

        private void Guncelle_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getMakine = "select makine_adi from makineler where makine_adi ='" + makine_list.SelectedItem + "'";
            string getUrunKodu = "select urun_kodu from urunler where urun_kodu ='" + urunKodu_cmb.Text.Trim() + "'";
            string getUrunAdi = "select urun_adi from urunler where urun_kodu ='" + urunKodu_cmb.Text.Trim() + "'";

            //Stok Çalışmaları
            string getHamStok = "select ham_stok from urunler where urun_kodu ='" + eskiUrunKodu + "'";
            //

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
                SqlDataAdapter sqlDataAdapterMakine = new SqlDataAdapter(getMakine, connection);
                DataTable dataTableMakine = new DataTable();
                sqlDataAdapterMakine.Fill(dataTableMakine);

                SqlDataAdapter sqlDataAdapterUrunKodu = new SqlDataAdapter(getUrunKodu, connection);
                DataTable dataTableUrunKodu = new DataTable();
                sqlDataAdapterUrunKodu.Fill(dataTableUrunKodu);

                SqlDataAdapter sqlDataAdapterUrunAdi = new SqlDataAdapter(getUrunAdi, connection);
                DataTable dataTableUrunAdi = new DataTable();
                sqlDataAdapterUrunAdi.Fill(dataTableUrunAdi);

                //Stok Çalışmaları
                SqlDataAdapter sqlDataAdapterHamStok = new SqlDataAdapter(getHamStok, connection);
                DataTable dataTableHamStok = new DataTable();
                sqlDataAdapterHamStok.Fill(dataTableHamStok);
                //

                if (vardiya_list.SelectedItem == null)
                {
                    uyari_lbl.Text = "Vardiya seçmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (dataTableMakine.Rows.Count == 0)
                {
                    uyari_lbl.Text = "Makine seçmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (dataTableUrunKodu.Rows.Count == 0)
                {
                    uyari_lbl.Text = "Ürün Kodu'nu doğru girmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (makine_txt.Text == "")
                {
                    uyari_lbl.Text = "Makine Tur Sayısı'nı girmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (kalip_txt.Text == "")
                {
                    uyari_lbl.Text = "Kalıp Göz Sayısı'nı girmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (kurutma_txt.Text == "")
                {
                    uyari_lbl.Text = "Kurutma Süresi'ni girmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (besik_txt.Text == "")
                {
                    uyari_lbl.Text = "Beşikteki Ürün Sayısı'nı girmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (net_txt.Text == "")
                {
                    uyari_lbl.Text = "Net'i girmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (calisanlar_txt.Text == "")
                {
                    uyari_lbl.Text = "Çalışanlar'ı yazmadınız.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else
                {
                    //String tarih = DateTime.Now.ToString("M/d/yyyy hh:mm");
                    String vardiya = vardiya_list.SelectedItem.ToString();
                    String makineAdi = makine_list.SelectedItem.ToString();
                    String urunKodu = urunKodu_cmb.Text;
                    String urunAdi = dataTableUrunAdi.Rows[0]["urun_adi"].ToString();
                    int makineTur = Convert.ToInt32(makine_txt.Text);
                    int kalip = Convert.ToInt32(kalip_txt.Text);
                    int kurutma = Convert.ToInt32(kurutma_txt.Text);
                    int besik = Convert.ToInt32(besik_txt.Text);
                    int zayiat = 0;
                    if (zayiat_txt.Text != "")
                        zayiat = Convert.ToInt32(zayiat_txt.Text);
                    int net = Convert.ToInt32(net_txt.Text);
                    int brut = zayiat + net;
                    String calisanlar = calisanlar_txt.Text;
                    String aciklama = aciklama_txt.Text;
                    String kullanici = Program.aktifKullanici;// + " (" + Program.aktifYetki + ")";

                    string updateSekillendirme =
                        "update sekillendirme set " +
                        "vardiya ='" + vardiya + "'," +
                        "makine_adi ='" + makineAdi + "'," +
                        "urun_kodu ='" + urunKodu + "'," +
                        "urun_adi ='" + urunAdi + "'," +
                        "makine_tur =" + makineTur + "," +
                        "kalip =" + kalip + "," +
                        "kurutma =" + kurutma + "," +
                        "besik =" + besik + "," +
                        "zayiat =" + zayiat + "," +
                        "net =" + net + "," +
                        "brut =" + brut + "," +
                        "calisanlar ='" + calisanlar + "'," +
                        "aciklama ='" + aciklama + "'," +
                        "kullanici ='" + kullanici + "' " +
                        "where id =" + Program.kimlik + ";";

                    //Stok Çalışmaları
                    int eskiStok = Convert.ToInt32(dataTableHamStok.Rows[0]["ham_stok"].ToString());

                    if (urunKodu == eskiUrunKodu)
                    {
                        yeniStok = eskiStok + (net - eskiNet);
                    }
                    else
                    {
                        yeniStok = eskiStok - eskiNet;
                    }

                    string updateEskiStok = "update urunler set ham_stok = ham_stok - " + eskiNet + "where urun_kodu ='" + eskiUrunKodu + "';";
                    string updateYeniStok = "update urunler set ham_stok = ham_stok + " + net + "where urun_kodu ='" + urunKodu + "';";
                    //                    

                    if (yeniStok >= 0)
                    {
                        DialogResult changeSure = MessageBox.Show("Kaydı güncellemek istediğinize emin misiniz?", "Kayıt Güncelle", MessageBoxButtons.YesNo);

                        if (changeSure == DialogResult.Yes)
                        {
                            SqlCommand commandSekillendirme = new SqlCommand(updateSekillendirme, connection);
                            commandSekillendirme.ExecuteNonQuery();

                            //Stok Çalışmaları
                            SqlCommand commandEskiStok = new SqlCommand(updateEskiStok, connection);
                            commandEskiStok.ExecuteNonQuery();
                            
                            SqlCommand commandYeniStok = new SqlCommand(updateYeniStok, connection);
                            commandYeniStok.ExecuteNonQuery();
                            //

                            Program.guncelle = true;

                            Sekillendirme_form sekillendirmeForm = new Sekillendirme_form();
                            this.Hide();
                            sekillendirmeForm.Show();
                        }
                        else
                        {
                            uyari_lbl.Text = "Kayıt güncelleme işlemi iptal edildi.";
                        }
                    }
                    else
                    {
                        uyari_lbl.Text = "Bu kayıttaki ürün bilgilerini güncelleyemezsiniz. Stoktaki ürün sonraki bölümler tarafından kullanılmıştır.";
                    }
                }

                connection.Close();
            }
        }

        private void İptal_btn_Click(object sender, EventArgs e)
        {
            Program.guncelleIptal = true;
            Sekillendirme_form sekillendirmeForm = new Sekillendirme_form();
            this.Hide();
            sekillendirmeForm.Show();
        }

        #region Functions
        void FillList()
        {
            string query = "select * from makineler";

            SqlConnection connection = new SqlConnection(Program.connectionPath);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader;

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
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string items = reader.GetString(1); //2.sütun
                    makine_list.Items.Add(items);
                }

                connection.Close();
            }
        }

        void FillCombo()
        {
            string query = "select * from urunler";

            SqlConnection connection = new SqlConnection(Program.connectionPath);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader;

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
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string items = reader.GetString(1);
                    urunKodu_cmb.Items.Add(items);
                }

                connection.Close();
            }
        }

        private void LoadData()
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string query = "select * from sekillendirme where id = " + Program.kimlik;

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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    vardiya_list.SelectedItem = dataTable.Rows[0]["vardiya"].ToString();
                    makine_list.SelectedItem = dataTable.Rows[0]["makine_adi"].ToString();
                    urunKodu_cmb.SelectedItem = dataTable.Rows[0]["urun_kodu"].ToString();
                    urunAdi_lbl.Text = "Ürün Adı: " + dataTable.Rows[0]["urun_adi"].ToString();
                    makine_txt.Text = dataTable.Rows[0]["makine_tur"].ToString();
                    kalip_txt.Text = dataTable.Rows[0]["kalip"].ToString();
                    kurutma_txt.Text = dataTable.Rows[0]["kurutma"].ToString();
                    besik_txt.Text = dataTable.Rows[0]["besik"].ToString();
                    zayiat_txt.Text = dataTable.Rows[0]["zayiat"].ToString();
                    net_txt.Text = dataTable.Rows[0]["net"].ToString();
                    brut_lbl.Text = "Brüt: " + dataTable.Rows[0]["brut"].ToString();
                    calisanlar_txt.Text = dataTable.Rows[0]["calisanlar"].ToString();
                    aciklama_txt.Text = dataTable.Rows[0]["aciklama"].ToString();

                    //Stok Çalışmaları
                    eskiUrunKodu = urunKodu_cmb.SelectedItem.ToString();
                    eskiNet = Convert.ToInt32(net_txt.Text);
                    //
                }

                connection.Close();
            }
        }

        private void UrunKodu_cmb_TextChanged_1(object sender, EventArgs e)
        {
            string query = "select urun_adi from urunler where urun_kodu='" + urunKodu_cmb.Text.Trim() + "'";

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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    urunAdi_lbl.Text = "Ürün Adı: " + dataTable.Rows[0]["urun_adi"].ToString();
                }
                else
                {
                    urunAdi_lbl.Text = "Bu koda sahip bir ürün bulunamadı.";
                }
            }

            connection.Close();
        }
        #endregion

        #region Digit Restriction
        private void Pres_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Kalip_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Kurutma_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Besik_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Zayiat_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Net_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Calculate Total
        private void Zayiat_txt_TextChanged(object sender, EventArgs e)
        {
            int zayiat, net;

            if (zayiat_txt.Text == "")
            {
                zayiat = 0;
            }
            else
            {
                zayiat = Convert.ToInt32(zayiat_txt.Text);
            }

            if (net_txt.Text == "")
            {
                net = 0;
            }
            else
            {
                net = Convert.ToInt32(net_txt.Text);
            }

            brut_lbl.Text = "Brüt: " + (zayiat + net).ToString();
        }

        private void Net_txt_TextChanged_1(object sender, EventArgs e)
        {
            int zayiat, net;

            if (zayiat_txt.Text == "")
            {
                zayiat = 0;
            }
            else
            {
                zayiat = Convert.ToInt32(zayiat_txt.Text);
            }

            if (net_txt.Text == "")
            {
                net = 0;
            }
            else
            {
                net = Convert.ToInt32(net_txt.Text);
            }

            brut_lbl.Text = "Brüt: " + (zayiat + net).ToString();
        }
        #endregion

        private void Timer1_Tick(object sender, EventArgs e)
        {
            uyari_lbl.Text = "";
            uyari_lbl.Refresh();
            timer1.Stop();
        }

        //Tüm textboxlar için türkçe büyük harf.
        private void Aciklama_txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txBox = (TextBox)sender;
            int pos = txBox.SelectionStart;
            int slen = txBox.SelectionLength;
            txBox.Text = txBox.Text.ToUpper();
            txBox.SelectionStart = pos;
            txBox.SelectionLength = slen;
            txBox.Focus();
        }        
    }
}
