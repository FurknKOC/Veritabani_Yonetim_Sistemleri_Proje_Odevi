namespace odev
{
    partial class moderatorHome
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
            this.btnYeniAdmin = new System.Windows.Forms.Button();
            this.pnlAdminSec = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.radioModerator = new System.Windows.Forms.RadioButton();
            this.radioEditor = new System.Windows.Forms.RadioButton();
            this.lblAdminTuru = new System.Windows.Forms.Label();
            this.btnKitapGuncelleEkle = new System.Windows.Forms.Button();
            this.pnlKitapEkleGuncelle = new System.Windows.Forms.Panel();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblBasimEvi = new System.Windows.Forms.Label();
            this.lblKitapOzeti = new System.Windows.Forms.Label();
            this.lblResim = new System.Windows.Forms.Label();
            this.lblKitapTuru = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtBasimEvi = new System.Windows.Forms.TextBox();
            this.rtbKitapOzeti = new System.Windows.Forms.RichTextBox();
            this.cbKitapTuru = new System.Windows.Forms.ComboBox();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.btnResimArama = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pbKitap = new System.Windows.Forms.PictureBox();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblMacera = new System.Windows.Forms.Label();
            this.lblRoman = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pnlAdminSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlKitapEkleGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniAdmin
            // 
            this.btnYeniAdmin.Location = new System.Drawing.Point(12, 66);
            this.btnYeniAdmin.Name = "btnYeniAdmin";
            this.btnYeniAdmin.Size = new System.Drawing.Size(119, 23);
            this.btnYeniAdmin.TabIndex = 0;
            this.btnYeniAdmin.Text = "Yeni Admin Sec";
            this.btnYeniAdmin.UseVisualStyleBackColor = true;
            this.btnYeniAdmin.Click += new System.EventHandler(this.btnYeniAdmin_Click);
            // 
            // pnlAdminSec
            // 
            this.pnlAdminSec.Controls.Add(this.lblAdminTuru);
            this.pnlAdminSec.Controls.Add(this.radioEditor);
            this.pnlAdminSec.Controls.Add(this.radioModerator);
            this.pnlAdminSec.Controls.Add(this.button1);
            this.pnlAdminSec.Controls.Add(this.dataGridView1);
            this.pnlAdminSec.Location = new System.Drawing.Point(199, 12);
            this.pnlAdminSec.Name = "pnlAdminSec";
            this.pnlAdminSec.Size = new System.Drawing.Size(589, 426);
            this.pnlAdminSec.TabIndex = 1;
            this.pnlAdminSec.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(417, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Admin Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioModerator
            // 
            this.radioModerator.AutoSize = true;
            this.radioModerator.Location = new System.Drawing.Point(28, 337);
            this.radioModerator.Name = "radioModerator";
            this.radioModerator.Size = new System.Drawing.Size(73, 17);
            this.radioModerator.TabIndex = 2;
            this.radioModerator.TabStop = true;
            this.radioModerator.Text = "Moderator";
            this.radioModerator.UseVisualStyleBackColor = true;
            // 
            // radioEditor
            // 
            this.radioEditor.AutoSize = true;
            this.radioEditor.Location = new System.Drawing.Point(28, 360);
            this.radioEditor.Name = "radioEditor";
            this.radioEditor.Size = new System.Drawing.Size(52, 17);
            this.radioEditor.TabIndex = 3;
            this.radioEditor.TabStop = true;
            this.radioEditor.Text = "Editor";
            this.radioEditor.UseVisualStyleBackColor = true;
            // 
            // lblAdminTuru
            // 
            this.lblAdminTuru.AutoSize = true;
            this.lblAdminTuru.Location = new System.Drawing.Point(25, 321);
            this.lblAdminTuru.Name = "lblAdminTuru";
            this.lblAdminTuru.Size = new System.Drawing.Size(67, 13);
            this.lblAdminTuru.TabIndex = 4;
            this.lblAdminTuru.Text = "Admin Turu :";
            // 
            // btnKitapGuncelleEkle
            // 
            this.btnKitapGuncelleEkle.Location = new System.Drawing.Point(12, 113);
            this.btnKitapGuncelleEkle.Name = "btnKitapGuncelleEkle";
            this.btnKitapGuncelleEkle.Size = new System.Drawing.Size(119, 23);
            this.btnKitapGuncelleEkle.TabIndex = 2;
            this.btnKitapGuncelleEkle.Text = "Kitap Ekle / Guncelle";
            this.btnKitapGuncelleEkle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelleEkle.Click += new System.EventHandler(this.btnKitapGuncelleEkle_Click);
            // 
            // pnlKitapEkleGuncelle
            // 
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblTarih);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblRoman);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblMacera);
            this.pnlKitapEkleGuncelle.Controls.Add(this.dataGridView3);
            this.pnlKitapEkleGuncelle.Controls.Add(this.dataGridView2);
            this.pnlKitapEkleGuncelle.Controls.Add(this.btnGuncelle);
            this.pnlKitapEkleGuncelle.Controls.Add(this.dgvKitaplar);
            this.pnlKitapEkleGuncelle.Controls.Add(this.pbKitap);
            this.pnlKitapEkleGuncelle.Controls.Add(this.btnKaydet);
            this.pnlKitapEkleGuncelle.Controls.Add(this.btnResimArama);
            this.pnlKitapEkleGuncelle.Controls.Add(this.txtResim);
            this.pnlKitapEkleGuncelle.Controls.Add(this.cbKitapTuru);
            this.pnlKitapEkleGuncelle.Controls.Add(this.rtbKitapOzeti);
            this.pnlKitapEkleGuncelle.Controls.Add(this.txtBasimEvi);
            this.pnlKitapEkleGuncelle.Controls.Add(this.txtStok);
            this.pnlKitapEkleGuncelle.Controls.Add(this.txtFiyat);
            this.pnlKitapEkleGuncelle.Controls.Add(this.txtKitapAdi);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblKitapTuru);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblKitapAdi);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblResim);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblKitapOzeti);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblBasimEvi);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblStok);
            this.pnlKitapEkleGuncelle.Controls.Add(this.lblFiyat);
            this.pnlKitapEkleGuncelle.Location = new System.Drawing.Point(187, 15);
            this.pnlKitapEkleGuncelle.Name = "pnlKitapEkleGuncelle";
            this.pnlKitapEkleGuncelle.Size = new System.Drawing.Size(589, 423);
            this.pnlKitapEkleGuncelle.TabIndex = 3;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(22, 70);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 13);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(22, 96);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(35, 13);
            this.lblStok.TabIndex = 1;
            this.lblStok.Text = "Stok :";
            // 
            // lblBasimEvi
            // 
            this.lblBasimEvi.AutoSize = true;
            this.lblBasimEvi.Location = new System.Drawing.Point(22, 127);
            this.lblBasimEvi.Name = "lblBasimEvi";
            this.lblBasimEvi.Size = new System.Drawing.Size(59, 13);
            this.lblBasimEvi.TabIndex = 2;
            this.lblBasimEvi.Text = "Basim Evi :";
            // 
            // lblKitapOzeti
            // 
            this.lblKitapOzeti.AutoSize = true;
            this.lblKitapOzeti.Location = new System.Drawing.Point(22, 156);
            this.lblKitapOzeti.Name = "lblKitapOzeti";
            this.lblKitapOzeti.Size = new System.Drawing.Size(64, 13);
            this.lblKitapOzeti.TabIndex = 3;
            this.lblKitapOzeti.Text = "Kitap Ozeti :";
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(22, 271);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(42, 13);
            this.lblResim.TabIndex = 4;
            this.lblResim.Text = "Resim :";
            // 
            // lblKitapTuru
            // 
            this.lblKitapTuru.AutoSize = true;
            this.lblKitapTuru.Location = new System.Drawing.Point(22, 37);
            this.lblKitapTuru.Name = "lblKitapTuru";
            this.lblKitapTuru.Size = new System.Drawing.Size(62, 13);
            this.lblKitapTuru.TabIndex = 6;
            this.lblKitapTuru.Text = "Kitap Turu :";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(22, 11);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(55, 13);
            this.lblKitapAdi.TabIndex = 5;
            this.lblKitapAdi.Text = "Kitap Adi :";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(113, 3);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdi.TabIndex = 7;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(113, 67);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 20);
            this.txtFiyat.TabIndex = 8;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(113, 93);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(121, 20);
            this.txtStok.TabIndex = 9;
            // 
            // txtBasimEvi
            // 
            this.txtBasimEvi.Location = new System.Drawing.Point(113, 127);
            this.txtBasimEvi.Name = "txtBasimEvi";
            this.txtBasimEvi.Size = new System.Drawing.Size(121, 20);
            this.txtBasimEvi.TabIndex = 10;
            // 
            // rtbKitapOzeti
            // 
            this.rtbKitapOzeti.Location = new System.Drawing.Point(113, 156);
            this.rtbKitapOzeti.Name = "rtbKitapOzeti";
            this.rtbKitapOzeti.Size = new System.Drawing.Size(121, 96);
            this.rtbKitapOzeti.TabIndex = 11;
            this.rtbKitapOzeti.Text = "";
            // 
            // cbKitapTuru
            // 
            this.cbKitapTuru.FormattingEnabled = true;
            this.cbKitapTuru.Items.AddRange(new object[] {
            "Macera",
            "Roman",
            "Tarih"});
            this.cbKitapTuru.Location = new System.Drawing.Point(113, 34);
            this.cbKitapTuru.Name = "cbKitapTuru";
            this.cbKitapTuru.Size = new System.Drawing.Size(121, 21);
            this.cbKitapTuru.TabIndex = 12;
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(113, 268);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(121, 20);
            this.txtResim.TabIndex = 13;
            // 
            // btnResimArama
            // 
            this.btnResimArama.Location = new System.Drawing.Point(240, 266);
            this.btnResimArama.Name = "btnResimArama";
            this.btnResimArama.Size = new System.Drawing.Size(26, 23);
            this.btnResimArama.TabIndex = 14;
            this.btnResimArama.Text = "...";
            this.btnResimArama.UseVisualStyleBackColor = true;
            this.btnResimArama.Click += new System.EventHandler(this.btnResimArama_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(6, 397);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pbKitap
            // 
            this.pbKitap.Location = new System.Drawing.Point(113, 301);
            this.pbKitap.Name = "pbKitap";
            this.pbKitap.Size = new System.Drawing.Size(121, 94);
            this.pbKitap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKitap.TabIndex = 16;
            this.pbKitap.TabStop = false;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(291, 22);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.Size = new System.Drawing.Size(295, 102);
            this.dgvKitaplar.TabIndex = 17;
            this.dgvKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellClick);
            this.dgvKitaplar.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellValueChanged);
            this.dgvKitaplar.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvKitaplar_RowHeaderCellChanged);
            this.dgvKitaplar.SelectionChanged += new System.EventHandler(this.dgvKitaplar_SelectionChanged);
            this.dgvKitaplar.Click += new System.EventHandler(this.dgvKitaplar_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(87, 397);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(291, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(295, 102);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(291, 284);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(295, 102);
            this.dataGridView3.TabIndex = 20;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // lblMacera
            // 
            this.lblMacera.AutoSize = true;
            this.lblMacera.Location = new System.Drawing.Point(288, 3);
            this.lblMacera.Name = "lblMacera";
            this.lblMacera.Size = new System.Drawing.Size(43, 13);
            this.lblMacera.TabIndex = 21;
            this.lblMacera.Text = "Macera";
            // 
            // lblRoman
            // 
            this.lblRoman.AutoSize = true;
            this.lblRoman.Location = new System.Drawing.Point(288, 130);
            this.lblRoman.Name = "lblRoman";
            this.lblRoman.Size = new System.Drawing.Size(41, 13);
            this.lblRoman.TabIndex = 22;
            this.lblRoman.Text = "Roman";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(288, 265);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 23;
            this.lblTarih.Text = "Tarih";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 412);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 23);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // moderatorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.pnlKitapEkleGuncelle);
            this.Controls.Add(this.btnKitapGuncelleEkle);
            this.Controls.Add(this.pnlAdminSec);
            this.Controls.Add(this.btnYeniAdmin);
            this.Name = "moderatorHome";
            this.Text = "moderatorHome";
            this.Load += new System.EventHandler(this.moderatorHome_Load);
            this.pnlAdminSec.ResumeLayout(false);
            this.pnlAdminSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlKitapEkleGuncelle.ResumeLayout(false);
            this.pnlKitapEkleGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniAdmin;
        private System.Windows.Forms.Panel pnlAdminSec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAdminTuru;
        private System.Windows.Forms.RadioButton radioEditor;
        private System.Windows.Forms.RadioButton radioModerator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlKitapEkleGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.PictureBox pbKitap;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnResimArama;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.ComboBox cbKitapTuru;
        private System.Windows.Forms.RichTextBox rtbKitapOzeti;
        private System.Windows.Forms.TextBox txtBasimEvi;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label lblKitapTuru;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Label lblKitapOzeti;
        private System.Windows.Forms.Label lblBasimEvi;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnKitapGuncelleEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblRoman;
        private System.Windows.Forms.Label lblMacera;
        private System.Windows.Forms.Button btnGeri;
    }
}