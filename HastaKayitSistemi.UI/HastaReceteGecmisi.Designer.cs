namespace HastaKayitSistemi.UI
{
    partial class HastaReceteGecmisi
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
            this.btnIlacKontrol = new System.Windows.Forms.Button();
            this.txtHastaNumarasi = new System.Windows.Forms.TextBox();
            this.lblIlaclar = new System.Windows.Forms.Label();
            this.lblNumaraGiriniz = new System.Windows.Forms.Label();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastanın Kullandığı İlaçlar";
            // 
            // btnIlacKontrol
            // 
            this.btnIlacKontrol.Location = new System.Drawing.Point(12, 259);
            this.btnIlacKontrol.Name = "btnIlacKontrol";
            this.btnIlacKontrol.Size = new System.Drawing.Size(206, 23);
            this.btnIlacKontrol.TabIndex = 2;
            this.btnIlacKontrol.Text = "İLAÇLAR KONTROL EDİLDİ";
            this.btnIlacKontrol.UseVisualStyleBackColor = true;
            this.btnIlacKontrol.Click += new System.EventHandler(this.BtnIlacKontrol_Click);
            // 
            // txtHastaNumarasi
            // 
            this.txtHastaNumarasi.Location = new System.Drawing.Point(146, 24);
            this.txtHastaNumarasi.Name = "txtHastaNumarasi";
            this.txtHastaNumarasi.Size = new System.Drawing.Size(159, 20);
            this.txtHastaNumarasi.TabIndex = 3;
            // 
            // lblIlaclar
            // 
            this.lblIlaclar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIlaclar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIlaclar.Location = new System.Drawing.Point(22, 134);
            this.lblIlaclar.Name = "lblIlaclar";
            this.lblIlaclar.Size = new System.Drawing.Size(283, 108);
            this.lblIlaclar.TabIndex = 4;
            // 
            // lblNumaraGiriniz
            // 
            this.lblNumaraGiriniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumaraGiriniz.Location = new System.Drawing.Point(19, 23);
            this.lblNumaraGiriniz.Name = "lblNumaraGiriniz";
            this.lblNumaraGiriniz.Size = new System.Drawing.Size(121, 23);
            this.lblNumaraGiriniz.TabIndex = 5;
            this.lblNumaraGiriniz.Text = "Numara giriniz:";
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(230, 50);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 6;
            this.btnSonuc.Text = "LİSTELE";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(230, 259);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // HastaReceteGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 357);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.lblNumaraGiriniz);
            this.Controls.Add(this.lblIlaclar);
            this.Controls.Add(this.txtHastaNumarasi);
            this.Controls.Add(this.btnIlacKontrol);
            this.Controls.Add(this.label1);
            this.Name = "HastaReceteGecmisi";
            this.Text = "HastaReceteGecmisi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HastaReceteGecmisi_FormClosed);
            this.Load += new System.EventHandler(this.HastaReceteGecmisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIlacKontrol;
        private System.Windows.Forms.TextBox txtHastaNumarasi;
        private System.Windows.Forms.Label lblIlaclar;
        private System.Windows.Forms.Label lblNumaraGiriniz;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Button btnTemizle;
    }
}