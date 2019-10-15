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
            this.lblHastaAdiSoyadi = new System.Windows.Forms.Label();
            this.panelRandevu = new System.Windows.Forms.Panel();
            this.grpRandevu = new System.Windows.Forms.GroupBox();
            this.btnSaatleriGoruntule = new System.Windows.Forms.Button();
            this.btnMevcutRandevularim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoktorOnayliRandevu = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.dtRandevuTarihi = new System.Windows.Forms.MonthCalendar();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpRandevu.SuspendLayout();
            this.SuspendLayout();
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
            // panelRandevu
            // 
            this.panelRandevu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRandevu.Location = new System.Drawing.Point(424, 37);
            this.panelRandevu.Name = "panelRandevu";
            this.panelRandevu.Size = new System.Drawing.Size(314, 480);
            this.panelRandevu.TabIndex = 17;
            // 
            // grpRandevu
            // 
            this.grpRandevu.Controls.Add(this.btnSaatleriGoruntule);
            this.grpRandevu.Controls.Add(this.btnMevcutRandevularim);
            this.grpRandevu.Controls.Add(this.label1);
            this.grpRandevu.Controls.Add(this.label2);
            this.grpRandevu.Controls.Add(this.cmbDepartman);
            this.grpRandevu.Controls.Add(this.label3);
            this.grpRandevu.Controls.Add(this.btnDoktorOnayliRandevu);
            this.grpRandevu.Controls.Add(this.btnRandevuAl);
            this.grpRandevu.Controls.Add(this.cmbHastane);
            this.grpRandevu.Controls.Add(this.dtRandevuTarihi);
            this.grpRandevu.Controls.Add(this.cmbPoliklinik);
            this.grpRandevu.Controls.Add(this.label5);
            this.grpRandevu.Controls.Add(this.cmbDoktor);
            this.grpRandevu.Controls.Add(this.label4);
            this.grpRandevu.Location = new System.Drawing.Point(12, 37);
            this.grpRandevu.Name = "grpRandevu";
            this.grpRandevu.Size = new System.Drawing.Size(402, 496);
            this.grpRandevu.TabIndex = 18;
            this.grpRandevu.TabStop = false;
            this.grpRandevu.Text = "Randevu Bilgileri";
            // 
            // btnSaatleriGoruntule
            // 
            this.btnSaatleriGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaatleriGoruntule.Location = new System.Drawing.Point(131, 397);
            this.btnSaatleriGoruntule.Name = "btnSaatleriGoruntule";
            this.btnSaatleriGoruntule.Size = new System.Drawing.Size(235, 23);
            this.btnSaatleriGoruntule.TabIndex = 15;
            this.btnSaatleriGoruntule.Text = "Saatleri Görüntüle ↺";
            this.btnSaatleriGoruntule.UseVisualStyleBackColor = true;
            this.btnSaatleriGoruntule.Click += new System.EventHandler(this.btnSaatleriGoruntule_Click);
            // 
            // btnMevcutRandevularim
            // 
            this.btnMevcutRandevularim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMevcutRandevularim.Location = new System.Drawing.Point(53, 24);
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
            this.label1.Location = new System.Drawing.Point(21, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Poliklinik :";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(132, 76);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(235, 28);
            this.cmbDepartman.TabIndex = 6;
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.CmbDepartman_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Departman :";
            // 
            // btnDoktorOnayliRandevu
            // 
            this.btnDoktorOnayliRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorOnayliRandevu.Location = new System.Drawing.Point(177, 426);
            this.btnDoktorOnayliRandevu.Name = "btnDoktorOnayliRandevu";
            this.btnDoktorOnayliRandevu.Size = new System.Drawing.Size(189, 54);
            this.btnDoktorOnayliRandevu.TabIndex = 14;
            this.btnDoktorOnayliRandevu.Text = "DOKTOR ONAYLI RANDEVU";
            this.btnDoktorOnayliRandevu.UseVisualStyleBackColor = true;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAl.Location = new System.Drawing.Point(14, 426);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(157, 54);
            this.btnRandevuAl.TabIndex = 13;
            this.btnRandevuAl.Text = "RANDEVU AL";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // cmbHastane
            // 
            this.cmbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(132, 110);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(235, 28);
            this.cmbHastane.TabIndex = 4;
            this.cmbHastane.SelectedIndexChanged += new System.EventHandler(this.cmbHastane_SelectedIndexChanged);
            // 
            // dtRandevuTarihi
            // 
            this.dtRandevuTarihi.Location = new System.Drawing.Point(132, 232);
            this.dtRandevuTarihi.Name = "dtRandevuTarihi";
            this.dtRandevuTarihi.TabIndex = 10;
            this.dtRandevuTarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtRandevuTarihi_DateChanged);
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(132, 148);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(235, 28);
            this.cmbPoliklinik.TabIndex = 5;
            this.cmbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinik_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Randevu Tarihi :";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(131, 187);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(235, 28);
            this.cmbDoktor.TabIndex = 8;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doktorlar :";
            // 
            // RandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 545);
            this.Controls.Add(this.grpRandevu);
            this.Controls.Add(this.panelRandevu);
            this.Controls.Add(this.lblHastaAdiSoyadi);
            this.Name = "RandevuEkrani";
            this.Text = "RandevuEkrani";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RandevuEkrani_FormClosed);
            this.Load += new System.EventHandler(this.RandevuEkrani_Load);
            this.grpRandevu.ResumeLayout(false);
            this.grpRandevu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblHastaAdiSoyadi;
        private System.Windows.Forms.Panel panelRandevu;
        private System.Windows.Forms.GroupBox grpRandevu;
        private System.Windows.Forms.Button btnMevcutRandevularim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnDoktorOnayliRandevu;
        public System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.ComboBox cmbHastane;
        private System.Windows.Forms.MonthCalendar dtRandevuTarihi;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaatleriGoruntule;
    }
}