namespace odev
{
    partial class kitaplar
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
            this.btnMacera = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlMacera = new System.Windows.Forms.Panel();
            this.cbKargo = new System.Windows.Forms.ComboBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.dgvMacera = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvRoman = new System.Windows.Forms.DataGridView();
            this.panelRoman = new System.Windows.Forms.Panel();
            this.panelTarih = new System.Windows.Forms.Panel();
            this.dgvTarih = new System.Windows.Forms.DataGridView();
            this.pnlMacera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoman)).BeginInit();
            this.panelRoman.SuspendLayout();
            this.panelTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarih)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMacera
            // 
            this.btnMacera.Location = new System.Drawing.Point(12, 12);
            this.btnMacera.Name = "btnMacera";
            this.btnMacera.Size = new System.Drawing.Size(75, 23);
            this.btnMacera.TabIndex = 0;
            this.btnMacera.Text = "Macera";
            this.btnMacera.UseVisualStyleBackColor = true;
            this.btnMacera.Click += new System.EventHandler(this.btnMacera_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Roman";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tarih";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlMacera
            // 
            this.pnlMacera.Controls.Add(this.dgvMacera);
            this.pnlMacera.Location = new System.Drawing.Point(25, 117);
            this.pnlMacera.Name = "pnlMacera";
            this.pnlMacera.Size = new System.Drawing.Size(985, 386);
            this.pnlMacera.TabIndex = 3;
            this.pnlMacera.Visible = false;
            this.pnlMacera.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMacera_Paint);
            // 
            // cbKargo
            // 
            this.cbKargo.FormattingEnabled = true;
            this.cbKargo.Location = new System.Drawing.Point(25, 509);
            this.cbKargo.Name = "cbKargo";
            this.cbKargo.Size = new System.Drawing.Size(121, 21);
            this.cbKargo.TabIndex = 2;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(164, 509);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(75, 23);
            this.btnSatinAl.TabIndex = 1;
            this.btnSatinAl.Text = "Satin Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // dgvMacera
            // 
            this.dgvMacera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMacera.Location = new System.Drawing.Point(15, 14);
            this.dgvMacera.Name = "dgvMacera";
            this.dgvMacera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMacera.Size = new System.Drawing.Size(958, 361);
            this.dgvMacera.TabIndex = 0;
            this.dgvMacera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMacera_CellContentClick);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(826, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgvRoman
            // 
            this.dgvRoman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoman.Location = new System.Drawing.Point(15, 14);
            this.dgvRoman.Name = "dgvRoman";
            this.dgvRoman.Size = new System.Drawing.Size(916, 361);
            this.dgvRoman.TabIndex = 4;
            this.dgvRoman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoman_CellContentClick);
            // 
            // panelRoman
            // 
            this.panelRoman.Controls.Add(this.dgvRoman);
            this.panelRoman.Location = new System.Drawing.Point(40, 83);
            this.panelRoman.Name = "panelRoman";
            this.panelRoman.Size = new System.Drawing.Size(945, 386);
            this.panelRoman.TabIndex = 3;
            this.panelRoman.Visible = false;
            // 
            // panelTarih
            // 
            this.panelTarih.Controls.Add(this.dgvTarih);
            this.panelTarih.Location = new System.Drawing.Point(28, 57);
            this.panelTarih.Name = "panelTarih";
            this.panelTarih.Size = new System.Drawing.Size(969, 386);
            this.panelTarih.TabIndex = 6;
            this.panelTarih.Visible = false;
            // 
            // dgvTarih
            // 
            this.dgvTarih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarih.Location = new System.Drawing.Point(12, 14);
            this.dgvTarih.Name = "dgvTarih";
            this.dgvTarih.Size = new System.Drawing.Size(931, 361);
            this.dgvTarih.TabIndex = 0;
            // 
            // kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 542);
            this.Controls.Add(this.panelTarih);
            this.Controls.Add(this.panelRoman);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cbKargo);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.pnlMacera);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMacera);
            this.Name = "kitaplar";
            this.Text = "kitaplar";
            this.Load += new System.EventHandler(this.kitaplar_Load);
            this.pnlMacera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoman)).EndInit();
            this.panelRoman.ResumeLayout(false);
            this.panelTarih.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarih)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMacera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlMacera;
        private System.Windows.Forms.DataGridView dgvMacera;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.ComboBox cbKargo;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dgvRoman;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelRoman;
        private System.Windows.Forms.Panel panelTarih;
        private System.Windows.Forms.DataGridView dgvTarih;
    }
}