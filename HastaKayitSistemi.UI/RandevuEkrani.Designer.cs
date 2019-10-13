namespace HastaKayitSistemi.UI
{
    partial class RandevuEkrani
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
            this.btnMevcutRandevularim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtRandevuTarihi = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.nmrRandevuSaati = new System.Windows.Forms.NumericUpDown();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnDoktorOnayliRandevu = new System.Windows.Forms.Button();
            this.lblHastaAdiSoyadi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRandevuSaati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMevcutRandevularim
            // 
            this.btnMevcutRandevularim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMevcutRandevularim.Location = new System.Drawing.Point(65, 37);
            this.btnMevcutRandevularim.Name = "btnMevcutRandevularim";
            this.btnMevcutRandevularim.Size = new System.Drawing.Size(274, 28);
            this.btnMevcutRandevularim.TabIndex = 0;
            this.btnMevcutRandevularim.Text = "MEVCUT RANDEVULARIM";
            this.btnMevcutRandevularim.UseVisualStyleBackColor = true;
            this.btnMevcutRandevularim.Click += new System.EventHandler(this.BtnMevcutRandevularim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Poliklinik :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Departman :";
            // 
            // cmbHastane
            // 
            this.cmbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(143, 77);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(235, 28);
            this.cmbHastane.TabIndex = 4;
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(143, 115);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(235, 28);
            this.cmbPoliklinik.TabIndex = 5;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(143, 157);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(235, 28);
            this.cmbDepartman.TabIndex = 6;
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.CmbDepartman_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doktorlar :";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(143, 200);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(235, 28);
            this.cmbDoktor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Randevu Tarihi :";
            // 
            // dtRandevuTarihi
            // 
            this.dtRandevuTarihi.Location = new System.Drawing.Point(144, 245);
            this.dtRandevuTarihi.Name = "dtRandevuTarihi";
            this.dtRandevuTarihi.TabIndex = 10;
            this.dtRandevuTarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtRandevuTarihi_DateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Randevu Saati :";
            // 
            // nmrRandevuSaati
            // 
            this.nmrRandevuSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrRandevuSaati.Location = new System.Drawing.Point(143, 412);
            this.nmrRandevuSaati.Name = "nmrRandevuSaati";
            this.nmrRandevuSaati.Size = new System.Drawing.Size(234, 26);
            this.nmrRandevuSaati.TabIndex = 12;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAl.Location = new System.Drawing.Point(19, 444);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(157, 54);
            this.btnRandevuAl.TabIndex = 13;
            this.btnRandevuAl.Text = "RANDEVU AL";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // btnDoktorOnayliRandevu
            // 
            this.btnDoktorOnayliRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorOnayliRandevu.Location = new System.Drawing.Point(182, 444);
            this.btnDoktorOnayliRandevu.Name = "btnDoktorOnayliRandevu";
            this.btnDoktorOnayliRandevu.Size = new System.Drawing.Size(189, 54);
            this.btnDoktorOnayliRandevu.TabIndex = 14;
            this.btnDoktorOnayliRandevu.Text = "DOKTOR ONAYLI RANDEVU";
            this.btnDoktorOnayliRandevu.UseVisualStyleBackColor = true;
            // 
            // lblHastaAdiSoyadi
            // 
            this.lblHastaAdiSoyadi.AutoSize = true;
            this.lblHastaAdiSoyadi.Location = new System.Drawing.Point(13, 13);
            this.lblHastaAdiSoyadi.Name = "lblHastaAdiSoyadi";
            this.lblHastaAdiSoyadi.Size = new System.Drawing.Size(88, 13);
            this.lblHastaAdiSoyadi.TabIndex = 15;
            this.lblHastaAdiSoyadi.Text = "Hasta Adı Soyadı";
            // 
            // RandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 510);
            this.Controls.Add(this.lblHastaAdiSoyadi);
            this.Controls.Add(this.btnDoktorOnayliRandevu);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.nmrRandevuSaati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtRandevuTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.cmbHastane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMevcutRandevularim);
            this.Name = "RandevuEkrani";
            this.Text = "RandevuEkrani";
            this.Load += new System.EventHandler(this.RandevuEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrRandevuSaati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMevcutRandevularim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHastane;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar dtRandevuTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmrRandevuSaati;
        public System.Windows.Forms.Button btnDoktorOnayliRandevu;
        public System.Windows.Forms.Button btnRandevuAl;
        public System.Windows.Forms.Label lblHastaAdiSoyadi;
    }
}