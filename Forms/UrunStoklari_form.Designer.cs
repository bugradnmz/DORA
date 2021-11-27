namespace DORA.Forms
{
    partial class UrunStoklari_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunStoklari_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A4DFA8_urunStokDataSet = new DORA.DB_A4DFA8_urunStokDataSet();
            this.uyari_lbl = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.urunlerTableAdapter = new DORA.DB_A4DFA8_urunStokDataSetTableAdapters.urunlerTableAdapter();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hamstokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biskuvistokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalite1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalite2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A4DFA8_urunStokDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.uyari_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 642);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN STOKLARI";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.hamstokDataGridViewTextBoxColumn,
            this.biskuvistokDataGridViewTextBoxColumn,
            this.kalite1DataGridViewTextBoxColumn,
            this.kalite2DataGridViewTextBoxColumn,
            this.tamirDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.urunlerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(53, 46);
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
            this.dataGridView1.Size = new System.Drawing.Size(1128, 590);
            this.dataGridView1.TabIndex = 1;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "urunler";
            this.urunlerBindingSource.DataSource = this.dB_A4DFA8_urunStokDataSet;
            // 
            // dB_A4DFA8_urunStokDataSet
            // 
            this.dB_A4DFA8_urunStokDataSet.DataSetName = "DB_A4DFA8_urunStokDataSet";
            this.dB_A4DFA8_urunStokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyari_lbl
            // 
            this.uyari_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uyari_lbl.Location = new System.Drawing.Point(6, 21);
            this.uyari_lbl.Name = "uyari_lbl";
            this.uyari_lbl.Size = new System.Drawing.Size(1228, 17);
            this.uyari_lbl.TabIndex = 0;
            this.uyari_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.menuStrip1.TabIndex = 8;
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
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.hakkindaToolStripMenuItem.Text = "Hakkında";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.HakkindaToolStripMenuItem_Click);
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
            this.kullanici_lbl.TabIndex = 7;
            this.kullanici_lbl.Text = "BUGRA (YÖNETİCİ)";
            this.kullanici_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "Kimlik";
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urun_kodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            this.urunkoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunkoduDataGridViewTextBoxColumn.Width = 150;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urun_adi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunadiDataGridViewTextBoxColumn.Width = 250;
            // 
            // hamstokDataGridViewTextBoxColumn
            // 
            this.hamstokDataGridViewTextBoxColumn.DataPropertyName = "ham_stok";
            this.hamstokDataGridViewTextBoxColumn.HeaderText = "Ham Stok";
            this.hamstokDataGridViewTextBoxColumn.Name = "hamstokDataGridViewTextBoxColumn";
            this.hamstokDataGridViewTextBoxColumn.ReadOnly = true;
            this.hamstokDataGridViewTextBoxColumn.Width = 150;
            // 
            // biskuvistokDataGridViewTextBoxColumn
            // 
            this.biskuvistokDataGridViewTextBoxColumn.DataPropertyName = "biskuvi_stok";
            this.biskuvistokDataGridViewTextBoxColumn.HeaderText = "Bisküvi Stok";
            this.biskuvistokDataGridViewTextBoxColumn.Name = "biskuvistokDataGridViewTextBoxColumn";
            this.biskuvistokDataGridViewTextBoxColumn.ReadOnly = true;
            this.biskuvistokDataGridViewTextBoxColumn.Width = 150;
            // 
            // kalite1DataGridViewTextBoxColumn
            // 
            this.kalite1DataGridViewTextBoxColumn.DataPropertyName = "kalite1";
            this.kalite1DataGridViewTextBoxColumn.HeaderText = "1.Kalite";
            this.kalite1DataGridViewTextBoxColumn.Name = "kalite1DataGridViewTextBoxColumn";
            this.kalite1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalite2DataGridViewTextBoxColumn
            // 
            this.kalite2DataGridViewTextBoxColumn.DataPropertyName = "kalite2";
            this.kalite2DataGridViewTextBoxColumn.HeaderText = "2.Kalite";
            this.kalite2DataGridViewTextBoxColumn.Name = "kalite2DataGridViewTextBoxColumn";
            this.kalite2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamirDataGridViewTextBoxColumn
            // 
            this.tamirDataGridViewTextBoxColumn.DataPropertyName = "tamir";
            this.tamirDataGridViewTextBoxColumn.HeaderText = "Tamir";
            this.tamirDataGridViewTextBoxColumn.Name = "tamirDataGridViewTextBoxColumn";
            this.tamirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UrunStoklari_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.kullanici_lbl);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UrunStoklari_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DORA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UrunStoklari_form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A4DFA8_urunStokDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label uyari_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private DB_A4DFA8_urunStokDataSet dB_A4DFA8_urunStokDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private DB_A4DFA8_urunStokDataSetTableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hamstokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biskuvistokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalite1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalite2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamirDataGridViewTextBoxColumn;
    }
}