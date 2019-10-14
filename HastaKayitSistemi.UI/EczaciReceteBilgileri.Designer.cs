namespace HastaKayitSistemi.UI
{
    partial class EczaciReceteBilgileri
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
            this.btnHastaReceteGecmisi = new System.Windows.Forms.Button();
            this.btnIlacTeslimEdildi = new System.Windows.Forms.Button();
            this.txtReceteNumarasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIlaclariGoruntule = new System.Windows.Forms.Button();
            this.lsvIlaclar = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnHastaReceteGecmisi
            // 
            this.btnHastaReceteGecmisi.Location = new System.Drawing.Point(55, 210);
            this.btnHastaReceteGecmisi.Name = "btnHastaReceteGecmisi";
            this.btnHastaReceteGecmisi.Size = new System.Drawing.Size(242, 23);
            this.btnHastaReceteGecmisi.TabIndex = 13;
            this.btnHastaReceteGecmisi.Text = "HASTA REÇETE GEÇMİŞİ";
            this.btnHastaReceteGecmisi.UseVisualStyleBackColor = true;
            this.btnHastaReceteGecmisi.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnIlacTeslimEdildi
            // 
            this.btnIlacTeslimEdildi.Location = new System.Drawing.Point(55, 239);
            this.btnIlacTeslimEdildi.Name = "btnIlacTeslimEdildi";
            this.btnIlacTeslimEdildi.Size = new System.Drawing.Size(242, 23);
            this.btnIlacTeslimEdildi.TabIndex = 12;
            this.btnIlacTeslimEdildi.Text = "HASTAYA İLAÇLAR TESLİM EDİLDİ";
            this.btnIlacTeslimEdildi.UseVisualStyleBackColor = true;
            // 
            // txtReceteNumarasi
            // 
            this.txtReceteNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceteNumarasi.Location = new System.Drawing.Point(158, 6);
            this.txtReceteNumarasi.Name = "txtReceteNumarasi";
            this.txtReceteNumarasi.Size = new System.Drawing.Size(186, 26);
            this.txtReceteNumarasi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reçete Numarası :";
            // 
            // btnIlaclariGoruntule
            // 
            this.btnIlaclariGoruntule.Location = new System.Drawing.Point(158, 39);
            this.btnIlaclariGoruntule.Name = "btnIlaclariGoruntule";
            this.btnIlaclariGoruntule.Size = new System.Drawing.Size(186, 23);
            this.btnIlaclariGoruntule.TabIndex = 14;
            this.btnIlaclariGoruntule.Text = "İLAÇLARI LİSTELE";
            this.btnIlaclariGoruntule.UseVisualStyleBackColor = true;
            this.btnIlaclariGoruntule.Click += new System.EventHandler(this.BtnIlaclariGoruntule_Click);
            // 
            // lsvIlaclar
            // 
            this.lsvIlaclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.lsvIlaclar.GridLines = true;
            this.lsvIlaclar.Location = new System.Drawing.Point(25, 92);
            this.lsvIlaclar.Name = "lsvIlaclar";
            this.lsvIlaclar.Size = new System.Drawing.Size(319, 97);
            this.lsvIlaclar.TabIndex = 15;
            this.lsvIlaclar.UseCompatibleStateImageBehavior = false;
            this.lsvIlaclar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Ilaclar";
            this.columnHeader.Width = 313;
            // 
            // EczaciReceteBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 275);
            this.Controls.Add(this.lsvIlaclar);
            this.Controls.Add(this.btnIlaclariGoruntule);
            this.Controls.Add(this.btnHastaReceteGecmisi);
            this.Controls.Add(this.btnIlacTeslimEdildi);
            this.Controls.Add(this.txtReceteNumarasi);
            this.Controls.Add(this.label3);
            this.Name = "EczaciReceteBilgileri";
            this.Text = "EczacıReceteBilgileri";
            this.Load += new System.EventHandler(this.EczaciReceteBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaReceteGecmisi;
        private System.Windows.Forms.Button btnIlacTeslimEdildi;
        private System.Windows.Forms.TextBox txtReceteNumarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIlaclariGoruntule;
        private System.Windows.Forms.ListView lsvIlaclar;
        private System.Windows.Forms.ColumnHeader columnHeader;
    }
}