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
    public partial class Kullanicilar_form : Form
    {
        String kimlik;
        String kullaniciAdi;//Aynı isimden tabloda yoksa yap. Kendi ismi hariç.

        public Kullanicilar_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
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
                this.kullanicilarTableAdapter1.Fill(this.dB_A4DFA8_kullanicilarDataSet.kullanicilar);
            }
            #endregion         
                   
            kullanici_lbl.Text = Program.aktifKullanici;// + " (" + Program.aktifYetki + ")";

            HideDev();
        }               

        private void Ekle_btn_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getUsername = "select kullanici_adi from kullanicilar where kullanici_adi ='" + kullanici_txt.Text.Trim() + "'";

            try
            {
                uyari_lbl.Text = "Yeni kullanıcı ekleniyor...";
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

            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(getUsername, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (kullanici_txt.Text == "")
                {
                    uyari_lbl.Text = "Kullanıcı Adı'nı boş bıraktınız.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (sifre_txt.Text == "")
                {
                    uyari_lbl.Text = "Şifre'yi boş bıraktınız.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (yetki_list.SelectedItem == null)
                {
                    uyari_lbl.Text = "Yetki seçmediniz.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else if (dataTable.Rows.Count == 1)
                {
                    uyari_lbl.Text = "Bu Kullanıcı Adı'na sahip bir kullanıcı zaten mevcut.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }
                else
                {
                    string insertUser = "insert into kullanicilar (kullanici_adi,kullanici_sifresi,kullanici_yetkisi) values('" + kullanici_txt.Text.Trim() + "','" + sifre_txt.Text.Trim() + "','" + yetki_list.SelectedItem + "');";
                    SqlCommand command = new SqlCommand(insertUser, connection);
                    command.ExecuteNonQuery();

                    this.kullanicilarTableAdapter1.Fill(this.dB_A4DFA8_kullanicilarDataSet.kullanicilar);
                    HideDev();

                    ResetForm();

                    uyari_lbl.Text = "Kullanıcı başarıyla eklendi.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();                                      
                }
                connection.Close();
            }            
        }                

        private void Sil_btn_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getID = "select kullanici_id from kullanicilar where kullanici_id =" + kimlik;
            string getPermission = "select kullanici_yetkisi from kullanicilar where kullanici_adi ='" + kullanici_txt.Text.Trim() + "'";

            try
            {
                uyari_lbl.Text = "Kullanıcı siliniyor...";
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

            if (kimlik != null) {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sqlDataAdapterID = new SqlDataAdapter(getID, connection);
                    DataTable dataTableID = new DataTable();
                    sqlDataAdapterID.Fill(dataTableID);

                    SqlDataAdapter sqlDataAdapterPermission = new SqlDataAdapter(getPermission, connection);
                    DataTable dataTablePermission = new DataTable();
                    sqlDataAdapterPermission.Fill(dataTablePermission);

                    var yetki = "";

                    if (dataTablePermission.Rows.Count == 1)
                    {
                        yetki = dataTablePermission.Rows[0]["kullanici_yetkisi"].ToString();
                    }

                    if (yetki != "GELİŞTİRİCİ")
                    {
                        if (dataTableID.Rows.Count == 1)
                        {
                            DialogResult deleteSure = MessageBox.Show("Kullanıcı'yı silmek istediğinize emin misiniz?", "Kullanıcı'yı Sil", MessageBoxButtons.YesNo);

                            if (deleteSure == DialogResult.Yes)
                            {
                                string deleteUser = "delete from kullanicilar where kullanici_id=" + kimlik;
                                SqlCommand command = new SqlCommand(deleteUser, connection);
                                command.ExecuteNonQuery();

                                this.kullanicilarTableAdapter1.Fill(this.dB_A4DFA8_kullanicilarDataSet.kullanicilar);
                                HideDev();

                                ResetForm();

                                uyari_lbl.Text = "Kullanıcı başarıyla silindi.";
                                uyari_lbl.Refresh();
                                timer1.Stop();
                                timer1.Start();
                            }
                            else
                            {
                                uyari_lbl.Text = "Kullanıcı silme işlemi iptal edildi.";
                                uyari_lbl.Refresh();
                                timer1.Stop();
                                timer1.Start();
                            }
                        }
                        else
                        {
                            uyari_lbl.Text = "Böyle bir kullanıcı bulunmamaktadır. Lütfen Kullanıcı'yı doğru seçtiğinizden emin olun.";
                            uyari_lbl.Refresh();
                            timer1.Stop();
                            timer1.Start();
                        }
                    }
                    else
                    {
                        uyari_lbl.Text = "Bu yetkide bir kullanıcıyı silemezsiniz.";
                        uyari_lbl.Refresh();
                        timer1.Stop();
                        timer1.Start();
                    }
                    connection.Close();
                }
            }
            else
            {
                uyari_lbl.Text = "Böyle bir kullanıcı bulunmamaktadır. Lütfen Kullanıcı'yı doğru seçtiğinizden emin olun.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }            
        }

        private void Guncelle_btn_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connectionPath);

            string getID = "select kullanici_id from kullanicilar where kullanici_id =" + kimlik;
            string getPermission = "select kullanici_yetkisi from kullanicilar where kullanici_id =" + kimlik;
            string getUsername = "select kullanici_adi from kullanicilar where kullanici_adi ='" + kullanici_txt.Text.Trim() + "'";

            try
            {
                uyari_lbl.Text = "Kullanıcı güncelleniyor...";
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

            if (kimlik != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sqlDataAdapterID = new SqlDataAdapter(getID, connection);
                    DataTable dataTableID = new DataTable();
                    sqlDataAdapterID.Fill(dataTableID);

                    SqlDataAdapter sqlDataAdapterPermission = new SqlDataAdapter(getPermission, connection);
                    DataTable dataTablePermission = new DataTable();
                    sqlDataAdapterPermission.Fill(dataTablePermission);

                    SqlDataAdapter sqlDataAdapterUsername = new SqlDataAdapter(getUsername, connection);
                    DataTable dataTableUsername = new DataTable();
                    sqlDataAdapterUsername.Fill(dataTableUsername);

                    var yetki = "";

                    if (dataTablePermission.Rows.Count == 1)
                    {
                        yetki = dataTablePermission.Rows[0]["kullanici_yetkisi"].ToString();
                    }

                    if (yetki != "GELİŞTİRİCİ")
                    {
                        if (dataTableID.Rows.Count == 1)
                        {
                            if (dataTableUsername.Rows.Count == 0 || kullanici_txt.Text == kullaniciAdi) //Aynı isimden tabloda yoksa yap. Kendi ismi hariç.
                            {
                                DialogResult changeSure = MessageBox.Show("Kullanıcı'yı güncellemek istediğinize emin misiniz?", "Kullanıcı'yı Güncelle", MessageBoxButtons.YesNo);

                                if (changeSure == DialogResult.Yes)
                                {
                                    string updateUser = "UPDATE kullanicilar SET kullanici_adi='" + kullanici_txt.Text.Trim() + "',kullanici_sifresi ='" + sifre_txt.Text.Trim() + "',kullanici_yetkisi='" + yetki_list.SelectedItem + "' WHERE kullanici_id=" + kimlik;
                                    SqlCommand command = new SqlCommand(updateUser, connection);
                                    command.ExecuteNonQuery();

                                    this.kullanicilarTableAdapter1.Fill(this.dB_A4DFA8_kullanicilarDataSet.kullanicilar);
                                    HideDev();                                                                      

                                    kullaniciAdi = kullanici_txt.Text;//Aynı isimden tabloda yoksa yap. Kendi ismi hariç.

                                    ResetForm();

                                    uyari_lbl.Text = "Kullanıcı başarıyla güncellendi.";
                                    uyari_lbl.Refresh();
                                    timer1.Stop();
                                    timer1.Start();
                                }
                                else
                                {
                                    uyari_lbl.Text = "Kullanıcı güncelleme işlemi iptal edildi.";
                                    uyari_lbl.Refresh();
                                    timer1.Stop();
                                    timer1.Start();
                                }
                            }
                            else
                            {
                                uyari_lbl.Text = "Bu Kullanıcı Adı'na sahip bir kullanıcı zaten mevcut.";
                                uyari_lbl.Refresh();
                                timer1.Stop();
                                timer1.Start();
                            }
                        }
                        else
                        {
                            uyari_lbl.Text = "Böyle bir kullanıcı bulunmamaktadır. Lütfen Kullanıcı'yı doğru seçtiğinizden emin olun.";
                            uyari_lbl.Refresh();
                            timer1.Stop();
                            timer1.Start();
                        }
                    }
                    else
                    {
                        uyari_lbl.Text = "Bu yetkide bir kullanıcıyı güncelleyemezsiniz.";
                        uyari_lbl.Refresh();
                        timer1.Stop();
                        timer1.Start();
                    }
                    connection.Close();
                }
            }
            else
            {
                uyari_lbl.Text = "Böyle bir kullanıcı bulunmamaktadır. Lütfen Kullanıcı'yı doğru seçtiğinizden emin olun.";
                uyari_lbl.Refresh();
                timer1.Stop();
                timer1.Start();
            }            
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];

                kullaniciAdi = selectedRow.Cells["kullanici_adi"].Value.ToString();//Aynı isimden tabloda yoksa yap. Kendi ismi hariç.

                kimlik = selectedRow.Cells["kullanici_id"].Value.ToString();
                kimlik_lbl.Text = "Seçili Kullanıcı Kimliği: " + kimlik;

                kullanici_txt.Text = selectedRow.Cells["kullanici_adi"].Value.ToString();
                sifre_txt.Text = selectedRow.Cells["kullanici_sifresi"].Value.ToString();

                if (selectedRow.Cells["kullanici_yetkisi"].Value.ToString() == "YÖNETİCİ")
                {
                    yetki_list.SelectedItem = "YÖNETİCİ";
                }
                else if (selectedRow.Cells["kullanici_yetkisi"].Value.ToString() == "DEKOR")
                {
                    yetki_list.SelectedItem = "DEKOR";
                }
                else if (selectedRow.Cells["kullanici_yetkisi"].Value.ToString() == "KALİTE")
                {
                    yetki_list.SelectedItem = "KALİTE";
                }
                else if (selectedRow.Cells["kullanici_yetkisi"].Value.ToString() == "SIRLAMA")
                {
                    yetki_list.SelectedItem = "SIRLAMA";
                }
                else if (selectedRow.Cells["kullanici_yetkisi"].Value.ToString() == "FIRIN")
                {
                    yetki_list.SelectedItem = "FIRIN";
                }
                else if (selectedRow.Cells["kullanici_yetkisi"].Value.ToString() == "ŞEKİLLENDİRME")
                {
                    yetki_list.SelectedItem = "ŞEKİLLENDİRME";
                }
                else
                {
                    yetki_list.ClearSelected();
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            uyari_lbl.Text = "";
            uyari_lbl.Refresh();
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
        private void Sifre_txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txBox = (TextBox)sender;
            int pos = txBox.SelectionStart;
            int slen = txBox.SelectionLength;
            txBox.Text = txBox.Text.ToUpper();
            txBox.SelectionStart = pos;
            txBox.SelectionLength = slen;
            txBox.Focus();
        }

        //Bu bölüm geliştiricinin ad ve şifresini gizlemek için var.
        private void HideDev()
        {            
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            dataGridView1.Rows[0].Visible = false;
            currencyManager1.ResumeBinding();
        }

        private void ResetForm()
        {
            kimlik = null;
            kimlik_lbl.Text = "Seçili Kullanıcı Kimliği: " + kimlik;
            kullanici_txt.Text = "";
            sifre_txt.Text = "";
            yetki_list.SelectedItem = null;
        }
    }
}