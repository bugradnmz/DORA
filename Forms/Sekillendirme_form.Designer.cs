namespace DORA
{
    partial class Sekillendirme_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sekillendirme_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROGRAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uyari_lbl = new System.Windows.Forms.Label();
            this.sil_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.kimlik_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sekillendirmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A4DFA8_sekillendirmeDataSet = new DORA.DB_A4DFA8_sekillendirmeDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sekillendirmeTableAdapter = new DORA.DB_A4DFA8_sekillendirmeDataSetTableAdapters.sekillendirmeTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makineadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makineturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurutmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.besikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zayiatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekillendirmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A4DFA8_sekillendirmeDataSet)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROGRAMToolStripMenuItem
            // 
            this.pROGRAMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkindaToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.pROGRAMToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pROGRAMToolStripMenuItem.Name = "pROGRAMToolStripMenuItem";
            this.pROGRAMToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pROGRAMToolStripMenuItem.Text = "Genel";
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkindaToolStripMenuItem.Text = "Hakkında";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.HakkindaToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.yÖNETİCİToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.yÖNETİCİToolStripMenuItem.Text = "Yönetim";
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
            this.kullanici_lbl.Location = new System.Drawing.Point(1002, 9);
            this.kullanici_lbl.Name = "kullanici_lbl";
            this.kullanici_lbl.Size = new System.Drawing.Size(250, 15);
            this.kullanici_lbl.TabIndex = 5;
            this.kullanici_lbl.Text = "BUGRA (YÖNETİCİ)";
            this.kullanici_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.uyari_lbl);
            this.groupBox1.Controls.Add(this.sil_btn);
            this.groupBox1.Controls.Add(this.guncelle_btn);
            this.groupBox1.Controls.Add(this.ekle_btn);
            this.groupBox1.Controls.Add(this.kimlik_lbl);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 642);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ŞEKİLLENDİRME";
            // 
            // uyari_lbl
            // 
            this.uyari_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uyari_lbl.Location = new System.Drawing.Point(544, 19);
            this.uyari_lbl.Name = "uyari_lbl";
            this.uyari_lbl.Size = new System.Drawing.Size(690, 69);
            this.uyari_lbl.TabIndex = 5;
            this.uyari_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sil_btn
            // 
            this.sil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sil_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sil_btn.Location = new System.Drawing.Point(388, 58);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(150, 30);
            this.sil_btn.TabIndex = 4;
            this.sil_btn.Text = "Kayıt Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.Sil_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.guncelle_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guncelle_btn.Location = new System.Drawing.Point(161, 58);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(150, 30);
            this.guncelle_btn.TabIndex = 3;
            this.guncelle_btn.Text = "Kayıt Güncelle";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.Guncelle_btn_Click);
            // 
            // ekle_btn
            // 
            this.ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ekle_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ekle_btn.Location = new System.Drawing.Point(5, 58);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(150, 30);
            this.ekle_btn.TabIndex = 2;
            this.ekle_btn.Text = "Yeni Kayıt";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.Ekle_btn_Click);
            // 
            // kimlik_lbl
            // 
            this.kimlik_lbl.AutoSize = true;
            this.kimlik_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.kimlik_lbl.Location = new System.Drawing.Point(6, 32);
            this.kimlik_lbl.Name = "kimlik_lbl";
            this.kimlik_lbl.Size = new System.Drawing.Size(119, 17);
            this.kimlik_lbl.TabIndex = 1;
            this.kimlik_lbl.Text = "Seçili Kayıt Kimliği: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tarihDataGridViewTextBoxColumn,
            this.vardiyaDataGridViewTextBoxColumn,
            this.makineadiDataGridViewTextBoxColumn,
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.makineturDataGridViewTextBoxColumn,
            this.kalipDataGridViewTextBoxColumn,
            this.kurutmaDataGridViewTextBoxColumn,
            this.besikDataGridViewTextBoxColumn,
            this.zayiatDataGridViewTextBoxColumn,
            this.netDataGridViewTextBoxColumn,
            this.brutDataGridViewTextBoxColumn,
            this.calisanlarDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.kullaniciDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.sekillendirmeBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(6, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1228, 539);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // sekillendirmeBindingSource
            // 
            this.sekillendirmeBindingSource.DataMember = "sekillendirme";
            this.sekillendirmeBindingSource.DataSource = this.dB_A4DFA8_sekillendirmeDataSet;
            // 
            // dB_A4DFA8_sekillendirmeDataSet
            // 
            this.dB_A4DFA8_sekillendirmeDataSet.DataSetName = "DB_A4DFA8_sekillendirmeDataSet";
            this.dB_A4DFA8_sekillendirmeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // sekillendirmeTableAdapter
            // 
            this.sekillendirmeTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Kimlik";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 150;
            // 
            // vardiyaDataGridViewTextBoxColumn
            // 
            this.vardiyaDataGridViewTextBoxColumn.DataPropertyName = "vardiya";
            this.vardiyaDataGridViewTextBoxColumn.HeaderText = "Vardiya";
            this.vardiyaDataGridViewTextBoxColumn.Name = "vardiyaDataGridViewTextBoxColumn";
            this.vardiyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vardiyaDataGridViewTextBoxColumn.Width = 150;
            // 
            // makineadiDataGridViewTextBoxColumn
            // 
            this.makineadiDataGridViewTextBoxColumn.DataPropertyName = "makine_adi";
            this.makineadiDataGridViewTextBoxColumn.HeaderText = "Makine Adı";
            this.makineadiDataGridViewTextBoxColumn.Name = "makineadiDataGridViewTextBoxColumn";
            this.makineadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.makineadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urun_kodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            this.urunkoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunkoduDataGridViewTextBoxColumn.Width = 190;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urun_adi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "Urun Adı";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunadiDataGridViewTextBoxColumn.Width = 280;
            // 
            // makineturDataGridViewTextBoxColumn
            // 
            this.makineturDataGridViewTextBoxColumn.DataPropertyName = "makine_tur";
            this.makineturDataGridViewTextBoxColumn.HeaderText = "Makine Tur Sayısı";
            this.makineturDataGridViewTextBoxColumn.Name = "makineturDataGridViewTextBoxColumn";
            this.makineturDataGridViewTextBoxColumn.ReadOnly = true;
            this.makineturDataGridViewTextBoxColumn.Width = 150;
            // 
            // kalipDataGridViewTextBoxColumn
            // 
            this.kalipDataGridViewTextBoxColumn.DataPropertyName = "kalip";
            this.kalipDataGridViewTextBoxColumn.HeaderText = "Kalıp Göz Sayısı";
            this.kalipDataGridViewTextBoxColumn.Name = "kalipDataGridViewTextBoxColumn";
            this.kalipDataGridViewTextBoxColumn.ReadOnly = true;
            this.kalipDataGridViewTextBoxColumn.Width = 150;
            // 
            // kurutmaDataGridViewTextBoxColumn
            // 
            this.kurutmaDataGridViewTextBoxColumn.DataPropertyName = "kurutma";
            this.kurutmaDataGridViewTextBoxColumn.HeaderText = "Kurutma Süresi (dk)";
            this.kurutmaDataGridViewTextBoxColumn.Name = "kurutmaDataGridViewTextBoxColumn";
            this.kurutmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kurutmaDataGridViewTextBoxColumn.Width = 150;
            // 
            // besikDataGridViewTextBoxColumn
            // 
            this.besikDataGridViewTextBoxColumn.DataPropertyName = "besik";
            this.besikDataGridViewTextBoxColumn.HeaderText = "Beşikteki Ürün Sayısı";
            this.besikDataGridViewTextBoxColumn.Name = "besikDataGridViewTextBoxColumn";
            this.besikDataGridViewTextBoxColumn.ReadOnly = true;
            this.besikDataGridViewTextBoxColumn.Width = 150;
            // 
            // zayiatDataGridViewTextBoxColumn
            // 
            this.zayiatDataGridViewTextBoxColumn.DataPropertyName = "zayiat";
            this.zayiatDataGridViewTextBoxColumn.HeaderText = "Zayiat";
            this.zayiatDataGridViewTextBoxColumn.Name = "zayiatDataGridViewTextBoxColumn";
            this.zayiatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netDataGridViewTextBoxColumn
            // 
            this.netDataGridViewTextBoxColumn.DataPropertyName = "net";
            this.netDataGridViewTextBoxColumn.HeaderText = "Net";
            this.netDataGridViewTextBoxColumn.Name = "netDataGridViewTextBoxColumn";
            this.netDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brutDataGridViewTextBoxColumn
            // 
            this.brutDataGridViewTextBoxColumn.DataPropertyName = "brut";
            this.brutDataGridViewTextBoxColumn.HeaderText = "Brüt";
            this.brutDataGridViewTextBoxColumn.Name = "brutDataGridViewTextBoxColumn";
            this.brutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calisanlarDataGridViewTextBoxColumn
            // 
            this.calisanlarDataGridViewTextBoxColumn.DataPropertyName = "calisanlar";
            this.calisanlarDataGridViewTextBoxColumn.HeaderText = "Çalışanlar";
            this.calisanlarDataGridViewTextBoxColumn.Name = "calisanlarDataGridViewTextBoxColumn";
            this.calisanlarDataGridViewTextBoxColumn.ReadOnly = true;
            this.calisanlarDataGridViewTextBoxColumn.Width = 250;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            this.aciklamaDataGridViewTextBoxColumn.Width = 250;
            // 
            // kullaniciDataGridViewTextBoxColumn
            // 
            this.kullaniciDataGridViewTextBoxColumn.DataPropertyName = "kullanici";
            this.kullaniciDataGridViewTextBoxColumn.HeaderText = "Kullanıcı";
            this.kullaniciDataGridViewTextBoxColumn.Name = "kullaniciDataGridViewTextBoxColumn";
            this.kullaniciDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciDataGridViewTextBoxColumn.Width = 200;
            // 
            // Sekillendirme_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.kullanici_lbl);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sekillendirme_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DORA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sekillendirme_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekillendirmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A4DFA8_sekillendirmeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROGRAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şekillendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fırınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sırlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaliteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dekorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yÖNETİCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hamStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kULLANICILARToolStripMenuItem;
        private System.Windows.Forms.Label kullanici_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label kimlik_lbl;
        private System.Windows.Forms.Label uyari_lbl;
        private System.Windows.Forms.Timer timer1;
        private DB_A4DFA8_sekillendirmeDataSet dB_A4DFA8_sekillendirmeDataSet;
        private System.Windows.Forms.BindingSource sekillendirmeBindingSource;
        private DB_A4DFA8_sekillendirmeDataSetTableAdapters.sekillendirmeTableAdapter sekillendirmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makineadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makineturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurutmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn besikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zayiatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciDataGridViewTextBoxColumn;
    }
}