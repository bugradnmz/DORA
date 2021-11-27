using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DORA
{
    public partial class Giris_form : Form
    {
        public Giris_form()
        {
            InitializeComponent();
        }

        public string connectionPath = "Data Source=SQL6007.site4now.net;Initial Catalog=DB_A4DFA8_dora;Persist Security Info=True;User ID=DB_A4DFA8_dora_admin;Password=1616392b";

        private void Giris_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            
            try
            {
                uyari_lbl.Text = "Lütfen bekleyin. Bağlanılıyor...";
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
                string query = "select * from kullanicilar where kullanici_adi ='" + kullanici_txt.Text.Trim() + "' and kullanici_sifresi ='" + sifre_txt.Text.Trim() + "'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count==1)
                {
                    Program.aktifKullanici = dataTable.Rows[0][1].ToString();
                    Program.aktifYetki = dataTable.Rows[0][3].ToString();

                    Sekillendirme_form sekillendirmeForm = new Sekillendirme_form();
                    this.Hide();
                    sekillendirmeForm.Show();                    
                }
                else
                {
                    uyari_lbl.Text = "Kullanıcı Adı veya Şifre hatalı.";
                    uyari_lbl.Refresh();
                    timer1.Stop();
                    timer1.Start();
                }

            connection.Close();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            uyari_lbl.Text = "";
            uyari_lbl.Refresh();
            timer1.Stop();
        }
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
    }
}
