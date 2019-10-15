namespace HastaKayitSistemi.UI
{
    partial class DoktorRandevulari
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpRandevular = new System.Windows.Forms.GroupBox();
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.dtCalismaGunu = new System.Windows.Forms.DateTimePicker();
            this.RandevuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışma Günü :";
            // 
            // grpRandevular
            // 
            this.grpRandevular.Controls.Add(this.dgvRandevular);
            this.grpRandevular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpRandevular.Location = new System.Drawing.Point(12, 44);
            this.grpRandevular.Name = "grpRandevular";
            this.grpRandevular.Size = new System.Drawing.Size(846, 336);
            this.grpRandevular.TabIndex = 2;
            this.grpRandevular.TabStop = false;
            this.grpRandevular.Text = "Randevular";
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RandevuID,
            this.HastaTC,
            this.HastaAd,
            this.Tarih});
            this.dgvRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRandevular.Location = new System.Drawing.Point(3, 22);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.Size = new System.Drawing.Size(840, 311);
            this.dgvRandevular.TabIndex = 0;
            // 
            // btnMuayene
            // 
            this.btnMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayene.Location = new System.Drawing.Point(80, 397);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Size = new System.Drawing.Size(187, 34);
            this.btnMuayene.TabIndex = 3;
            this.btnMuayene.Text = "MUAYENE OLUŞTUR";
            this.btnMuayene.UseVisualStyleBackColor = true;
            this.btnMuayene.Click += new System.EventHandler(this.BtnMuayene_Click);
            // 
            // dtCalismaGunu
            // 
            this.dtCalismaGunu.Location = new System.Drawing.Point(135, 18);
            this.dtCalismaGunu.Name = "dtCalismaGunu";
            this.dtCalismaGunu.Size = new System.Drawing.Size(200, 20);
            this.dtCalismaGunu.TabIndex = 4;
            this.dtCalismaGunu.ValueChanged += new System.EventHandler(this.dtCalısmaGunu_ValueChanged);
            // 
            // RandevuID
            // 
            this.RandevuID.HeaderText = "RandevuID";
            this.RandevuID.Name = "RandevuID";
            // 
            // HastaTC
            // 
            this.HastaTC.HeaderText = "Hasta TC";
            this.HastaTC.Name = "HastaTC";
            // 
            // HastaAd
            // 
            this.HastaAd.HeaderText = "Hasta Ad Soyad";
            this.HastaAd.Name = "HastaAd";
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // DoktorRandevuları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 475);
            this.Controls.Add(this.dtCalismaGunu);
            this.Controls.Add(this.btnMuayene);
            this.Controls.Add(this.grpRandevular);
            this.Controls.Add(this.label1);
            this.Name = "DoktorRandevuları";
            this.Text = "DoktorRandevuları";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoktorRandevuları_FormClosed);
            this.Load += new System.EventHandler(this.DoktorRandevuları_Load);
            this.grpRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRandevular;
        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.Button btnMuayene;
        private System.Windows.Forms.DateTimePicker dtCalismaGunu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
    }
}