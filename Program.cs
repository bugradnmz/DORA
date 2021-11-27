using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORA
{
    static class Program
    {
        public static string aktifKullanici = "";
        public static string aktifYetki = "";
        public static string hakkinda = "Yazılım: DORA\nSürüm: 1.0.0.4\n\nGeliştirici: Buğra DÖNMEZ\nE-Mail: bugradnmz@hotmail.com\nTelefon: 545 624 82 07";
        public static string connectionPath = "Data Source=SQL6007.site4now.net;Initial Catalog=DB_A4DFA8_dora;Persist Security Info=True;User ID=DB_A4DFA8_dora_admin;Password=1616392b";

        public static string kimlik;
        public static bool kayit = false;
        public static bool guncelle = false;
        public static bool guncelleIptal = false;
        public static bool kayitIptal = false;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris_form());
        }
    }
}
