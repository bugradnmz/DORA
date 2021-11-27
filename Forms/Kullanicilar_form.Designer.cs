namespace DORA
{
    partial class Kullanicilar_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanicilar_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROGRAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şekillendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fırınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sırlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaliteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dekorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yÖNETİCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hamStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICILARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanici_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kimlik_lbl = new System.Windows.Forms.Label();
            this.uyari_lbl = new System.Windows.Forms.Label();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.yetki_lbl = new System.Windows.Forms.Label();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.kullaniciAdi_lbl = new System.Windows.Forms.Label();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.kullanici_txt = new System.Windows.Forms.TextBox();
            this.yetki_list = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullanici_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_sifresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_yetkisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A4DFA8_kullanicilarDataSet = new DORA.DB_A4DFA8_kullanicilarDataSet();
            this.kullanicilarTableAdapter1 = new DORA.DB_A4DFA8_kullanicilarDataSetTableAdapters.kullanicilarTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A4DFA8_kullanicilarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROGRAMToolStripMenuItem,
            this.şekillendirmeToolStripMenuItem,
            this.fırınToolStripMenuItem,
            this.sırlamaToolStripMenuItem,
            this.kaliteToolStripMenuItem,
            this.dekorToolStripMenuItem,
            this.yÖNETİCİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROGRAMToolStripMenuItem
            // 
            this.pROGRAMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgiToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.pROGRAMToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pROGRAMToolStripMenuItem.Name = "pROGRAMToolStripMenuItem";
            this.pROGRAMToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pROGRAMToolStripMenuItem.Text = "Genel";
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.bilgiToolStripMenuItem.Text = "Hakkında";
            this.bilgiToolStripMenuItem.Click += new System.EventHandler(this.HakkindaToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.çIKIŞToolStripMenuItem.Text = "Çıkış";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.ÇIKIŞToolStripMenuItem_Click);
            // 
            // şekillendirmeToolStripMenuItem
            // 
            this.şekillendirmeToolStripMenuItem.Name = "şekillendirmeToolStripMenuItem";
            this.şekillendirmeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.şekillendirmeToolStripMenuItem.Text = "Şekillendirme";
            this.şekillendirmeToolStripMenuItem.Click += new System.EventHandler(this.ŞekillendirmeToolStripMenuItem_Click);
            // 
            // fırınToolStripMenuItem
            // 
            this.fırınToolStripMenuItem.Name = "fırınToolStripMenuItem";
            this.fırınToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fırınToolStripMenuItem.Text = "Fırın";
            // 
            // sırlamaToolStripMenuItem
            // 
            this.sırlamaToolStripMenuItem.Name = "sırlamaToolStripMenuItem";
            this.sırlamaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sırlamaToolStripMenuItem.Text = "Sırlama";
            // 
            // kaliteToolStripMenuItem
            // 
            this.kaliteToolStripMenuItem.Name = "kaliteToolStripMenuItem";
            this.kaliteToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.kaliteToolStripMenuItem.Text = "Kalite";
            // 
            // dekorToolStripMenuItem
            // 
            this.dekorToolStripMenuItem.Name = "dekorToolStripMenuItem";
            this.dekorToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dekorToolStripMenuItem.Text = "Dekor";
            // 
            // yÖNETİCİToolStripMenuItem
            // 
            this.yÖNETİCİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hamStokToolStripMenuItem,
            this.üRÜNLERToolStripMenuItem,
            this.kULLANICILARToolStripMenuItem});
            this.yÖNETİCİToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.yÖNETİCİToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yÖNETİCİToolStripMenuItem.Name = "yÖNETİCİToolStripMenuItem";
            this.yÖNETİCİToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.yÖNETİCİToolStripMenuItem.Text = "Yönetici";
            // 
            // hamStokToolStripMenuItem
            // 
            this.hamStokToolStripMenuItem.Name = "hamStokToolStripMenuItem";
            this.hamStokToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hamStokToolStripMenuItem.Text = "Ürün Stokları";
            this.hamStokToolStripMenuItem.Click += new System.EventHandler(this.HamStokToolStripMenuItem_Click);
            // 
            // üRÜNLERToolStripMenuItem
            // 
            this.üRÜNLERToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.üRÜNLERToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.üRÜNLERToolStripMenuItem.Name = "üRÜNLERToolStripMenuItem";
            this.üRÜNLERToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.üRÜNLERToolStripMenuItem.Text = "Ürünler ve Makineler";
            this.üRÜNLERToolStripMenuItem.Click += new System.EventHandler(this.ÜRÜNLERToolStripMenuItem_Click);
            // 
            // kULLANICILARToolStripMenuItem
            // 
            this.kULLANICILARToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.kULLANICILARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kULLANICILARToolStripMenuItem.Name = "kULLANICILARToolStripMenuItem";
            this.kULLANICILARToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kULLANICILARToolStripMenuItem.Text = "Kullanıcılar";
            this.kULLANICILARToolStripMenuItem.Click += new System.EventHandler(this.KULLANICILARToolStripMenuItem_Click);
            // 
            // kullanici_lbl
            // 
            this.kullanici_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kullanici_lbl.Font = new System.Drawing.Font("Tahoma", 9F);
            this.kullanici_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kullanici_lbl.Location = new System.Drawing.Point(1002, 8);
            this.kullanici_lbl.Name = "kullanici_lbl";
            this.kullanici_lbl.Size = new System.Drawing.Size(250, 15);
            this.kullanici_lbl.TabIndex = 2;
            this.kullanici_lbl.Text = "BUGRA (YÖNETİCİ)";
            this.kullanici_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.kimlik_lbl);
            this.groupBox1.Controls.Add(this.uyari_lbl);
            this.groupBox1.Controls.Add(this.guncelle_btn);
            this.groupBox1.Controls.Add(this.sil_btn);
            this.groupBox1.Controls.Add(this.ekle_btn);
            this.groupBox1.Controls.Add(this.yetki_lbl);
            this.groupBox1.Controls.Add(this.sifre_lbl);
            this.groupBox1.Controls.Add(this.kullaniciAdi_lbl);
            this.groupBox1.Controls.Add(this.sifre_txt);
            this.groupBox1.Controls.Add(this.kullanici_txt);
            this.groupBox1.Controls.Add(this.yetki_list);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 650);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KULLANICILAR";
            // 
            // kimlik_lbl
            // 
            this.kimlik_lbl.AutoSize = true;
            this.kimlik_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.kimlik_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kimlik_lbl.Location = new System.Drawing.Point(795, 37);
            this.kimlik_lbl.Name = "kimlik_lbl";
            this.kimlik_lbl.Size = new System.Drawing.Size(135, 17);
            this.kimlik_lbl.TabIndex = 23;
            this.kimlik_lbl.Text = "Seçili Kullanıcı Kimliği: ";
            // 
            // uyari_lbl
            // 
            this.uyari_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uyari_lbl.Location = new System.Drawing.Point(795, 365);
            this.uyari_lbl.Name = "uyari_lbl";
            this.uyari_lbl.Size = new System.Drawing.Size(357, 77);
            this.uyari_lbl.TabIndex = 22;
            this.uyari_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.guncelle_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guncelle_btn.Location = new System.Drawing.Point(905, 308);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(100, 35);
            this.guncelle_btn.TabIndex = 21;
            this.guncelle_btn.Text = "Güncelle";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.Guncelle_btn_Click_1);
            // 
            // sil_btn
            // 
            this.sil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sil_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sil_btn.Location = new System.Drawing.Point(1055, 308);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(100, 35);
            this.sil_btn.TabIndex = 20;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.Sil_btn_Click_1);
            // 
            // ekle_btn
            // 
            this.ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ekle_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ekle_btn.Location = new System.Drawing.Point(798, 308);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(100, 35);
            this.ekle_btn.TabIndex = 19;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.Ekle_btn_Click_1);
            // 
            // yetki_lbl
            // 
            this.yetki_lbl.AutoSize = true;
            this.yetki_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.yetki_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yetki_lbl.Location = new System.Drawing.Point(795, 189);
            this.yetki_lbl.Name = "yetki_lbl";
            this.yetki_lbl.Size = new System.Drawing.Size(42, 17);
            this.yetki_lbl.TabIndex = 18;
            this.yetki_lbl.Text = "Yetki:";
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sifre_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sifre_lbl.Location = new System.Drawing.Point(795, 135);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(39, 17);
            this.sifre_lbl.TabIndex = 17;
            this.sifre_lbl.Text = "Şifre:";
            // 
            // kullaniciAdi_lbl
            // 
            this.kullaniciAdi_lbl.AutoSize = true;
            this.kullaniciAdi_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.kullaniciAdi_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kullaniciAdi_lbl.Location = new System.Drawing.Point(795, 79);
            this.kullaniciAdi_lbl.Name = "kullaniciAdi_lbl";
            this.kullaniciAdi_lbl.Size = new System.Drawing.Size(85, 17);
            this.kullaniciAdi_lbl.TabIndex = 16;
            this.kullaniciAdi_lbl.Text = "Kullanıcı Adı: ";
            // 
            // sifre_txt
            // 
            this.sifre_txt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sifre_txt.Location = new System.Drawing.Point(905, 132);
            this.sifre_txt.MaxLength = 16;
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(250, 24);
            this.sifre_txt.TabIndex = 15;
            this.sifre_txt.TextChanged += new System.EventHandler(this.Sifre_txt_TextChanged);
            // 
            // kullanici_txt
            // 
            this.kullanici_txt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.kullanici_txt.Location = new System.Drawing.Point(905, 76);
            this.kullanici_txt.MaxLength = 16;
            this.kullanici_txt.Name = "kullanici_txt";
            this.kullanici_txt.Size = new System.Drawing.Size(250, 24);
            this.kullanici_txt.TabIndex = 14;
            this.kullanici_txt.TextChanged += new System.EventHandler(this.Sifre_txt_TextChanged);
            // 
            // yetki_list
            // 
            this.yetki_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yetki_list.Font = new System.Drawing.Font("Tahoma", 10F);
            this.yetki_list.FormattingEnabled = true;
            this.yetki_list.ItemHeight = 16;
            this.yetki_list.Items.AddRange(new object[] {
            "ŞEKİLLENDİRME",
            "FIRIN",
            "SIRLAMA",
            "KALİTE",
            "DEKOR",
            "YÖNETİCİ"});
            this.yetki_list.Location = new System.Drawing.Point(905, 189);
            this.yetki_list.Name = "yetki_list";
            this.yetki_list.Size = new System.Drawing.Size(250, 100);
            this.yetki_list.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullanici_id,
            this.kullanici_adi,
            this.kullanici_sifresi,
            this.kullanici_yetkisi});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.kullanicilarBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(73, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = "-";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 614);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick_1);
            // 
            // kullanici_id
            // 
            this.kullanici_id.DataPropertyName = "kullanici_id";
            this.kullanici_id.HeaderText = "Kimlik";
            this.kullanici_id.Name = "kullanici_id";
            this.kullanici_id.ReadOnly = true;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.DataPropertyName = "kullanici_adi";
            this.kullanici_adi.HeaderText = "Kullanıcı Adı";
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.ReadOnly = true;
            this.kullanici_adi.Width = 150;
            // 
            // kullanici_sifresi
            // 
            this.kullanici_sifresi.DataPropertyName = "kullanici_sifresi";
            this.kullanici_sifresi.HeaderText = "Şifre";
            this.kullanici_sifresi.Name = "kullanici_sifresi";
            this.kullanici_sifresi.ReadOnly = true;
            this.kullanici_sifresi.Width = 150;
            // 
            // kullanici_yetkisi
            // 
            this.kullanici_yetkisi.DataPropertyName = "kullanici_yetkisi";
            this.kullanici_yetkisi.HeaderText = "Yetki";
            this.kullanici_yetkisi.Name = "kullanici_yetkisi";
            this.kullanici_yetkisi.ReadOnly = true;
            this.kullanici_yetkisi.Width = 150;
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.dB_A4DFA8_kullanicilarDataSet;
            // 
            // dB_A4DFA8_kullanicilarDataSet
            // 
            this.dB_A4DFA8_kullanicilarDataSet.DataSetName = "DB_A4DFA8_kullanicilarDataSet";
            this.dB_A4DFA8_kullanicilarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarTableAdapter1
            // 
            this.kullanicilarTableAdapter1.ClearBeforeFill = true;
            // 
            // Kullanicilar_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kullanici_lbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Kullanicilar_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DORA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A4DFA8_kullanicilarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yÖNETİCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kULLANICILARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROGRAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.Label kullanici_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem şekillendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fırınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sırlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaliteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dekorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hamStokToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kimlik_lbl;
        private System.Windows.Forms.Label uyari_lbl;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label yetki_lbl;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.Label kullaniciAdi_lbl;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.TextBox kullanici_txt;
        private System.Windows.Forms.ListBox yetki_list;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_A4DFA8_kullanicilarDataSet dB_A4DFA8_kullanicilarDataSet;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private DB_A4DFA8_kullanicilarDataSetTableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_sifresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_yetkisi;
    }
}