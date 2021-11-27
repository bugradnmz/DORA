namespace DORA
{
    partial class Giris_form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.baslik_lbl = new System.Windows.Forms.Label();
            this.kullanici_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.kullaniciAdi_lbl = new System.Windows.Forms.Label();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.giris_btn = new System.Windows.Forms.Button();
            this.uyari_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel1.Controls.Add(this.baslik_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kullanici_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sifre_txt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kullaniciAdi_lbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sifre_lbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.giris_btn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.uyari_lbl, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-150, -75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.46346F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.664884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.664884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.15508F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // baslik_lbl
            // 
            this.baslik_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.baslik_lbl.AutoSize = true;
            this.baslik_lbl.Font = new System.Drawing.Font("Tahoma", 56F, System.Drawing.FontStyle.Bold);
            this.baslik_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baslik_lbl.Location = new System.Drawing.Point(283, 135);
            this.baslik_lbl.Name = "baslik_lbl";
            this.baslik_lbl.Size = new System.Drawing.Size(258, 90);
            this.baslik_lbl.TabIndex = 0;
            this.baslik_lbl.Text = "DORA";
            this.baslik_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kullanici_txt
            // 
            this.kullanici_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullanici_txt.Location = new System.Drawing.Point(300, 234);
            this.kullanici_txt.Name = "kullanici_txt";
            this.kullanici_txt.Size = new System.Drawing.Size(224, 24);
            this.kullanici_txt.TabIndex = 3;
            this.kullanici_txt.TextChanged += new System.EventHandler(this.Sifre_txt_TextChanged);
            // 
            // sifre_txt
            // 
            this.sifre_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifre_txt.Location = new System.Drawing.Point(300, 276);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(224, 24);
            this.sifre_txt.TabIndex = 4;
            this.sifre_txt.TextChanged += new System.EventHandler(this.Sifre_txt_TextChanged);
            // 
            // kullaniciAdi_lbl
            // 
            this.kullaniciAdi_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kullaniciAdi_lbl.AutoSize = true;
            this.kullaniciAdi_lbl.Location = new System.Drawing.Point(194, 237);
            this.kullaniciAdi_lbl.Name = "kullaniciAdi_lbl";
            this.kullaniciAdi_lbl.Size = new System.Drawing.Size(81, 17);
            this.kullaniciAdi_lbl.TabIndex = 1;
            this.kullaniciAdi_lbl.Text = "Kullanıcı Adı:";
            this.kullaniciAdi_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.Location = new System.Drawing.Point(232, 279);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(43, 17);
            this.sifre_lbl.TabIndex = 2;
            this.sifre_lbl.Text = "Şifre: ";
            this.sifre_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giris_btn
            // 
            this.giris_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.giris_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_btn.Location = new System.Drawing.Point(361, 321);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(102, 41);
            this.giris_btn.TabIndex = 5;
            this.giris_btn.Text = "GİRİŞ";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.Giris_btn_Click);
            // 
            // uyari_lbl
            // 
            this.uyari_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uyari_lbl.AutoSize = true;
            this.uyari_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uyari_lbl.Location = new System.Drawing.Point(412, 374);
            this.uyari_lbl.Name = "uyari_lbl";
            this.uyari_lbl.Size = new System.Drawing.Size(0, 17);
            this.uyari_lbl.TabIndex = 6;
            this.uyari_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Giris_form
            // 
            this.AcceptButton = this.giris_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Giris_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DORA";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label kullaniciAdi_lbl;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.TextBox kullanici_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.Label baslik_lbl;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Label uyari_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

