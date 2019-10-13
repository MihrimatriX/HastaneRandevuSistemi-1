namespace HastaKayitSistemi.UI
{
    partial class MuayeneEkrani
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
            this.rdoHastaGelmedi = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoTeshisKonulamadi = new System.Windows.Forms.RadioButton();
            this.btnMuayeneTamamlandi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxIlaclar = new System.Windows.Forms.ListBox();
            this.txtTeshis = new System.Windows.Forms.TextBox();
            this.txtIlac = new System.Windows.Forms.TextBox();
            this.txtReceteNumarasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // rdoHastaGelmedi
            // 
            this.rdoHastaGelmedi.AutoSize = true;
            this.rdoHastaGelmedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoHastaGelmedi.Location = new System.Drawing.Point(17, 12);
            this.rdoHastaGelmedi.Name = "rdoHastaGelmedi";
            this.rdoHastaGelmedi.Size = new System.Drawing.Size(218, 24);
            this.rdoHastaGelmedi.TabIndex = 1;
            this.rdoHastaGelmedi.TabStop = true;
            this.rdoHastaGelmedi.Text = "Hasta Muayeneye Gelmedi";
            this.rdoHastaGelmedi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teşhis :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reçete Numarası :";
            // 
            // rdoTeshisKonulamadi
            // 
            this.rdoTeshisKonulamadi.AutoSize = true;
            this.rdoTeshisKonulamadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoTeshisKonulamadi.Location = new System.Drawing.Point(22, 78);
            this.rdoTeshisKonulamadi.Name = "rdoTeshisKonulamadi";
            this.rdoTeshisKonulamadi.Size = new System.Drawing.Size(264, 24);
            this.rdoTeshisKonulamadi.TabIndex = 6;
            this.rdoTeshisKonulamadi.TabStop = true;
            this.rdoTeshisKonulamadi.Text = "Teşhis Konulamadı Tahlil İsteniyor";
            this.rdoTeshisKonulamadi.UseVisualStyleBackColor = true;
            this.rdoTeshisKonulamadi.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // btnMuayeneTamamlandi
            // 
            this.btnMuayeneTamamlandi.Location = new System.Drawing.Point(87, 267);
            this.btnMuayeneTamamlandi.Name = "btnMuayeneTamamlandi";
            this.btnMuayeneTamamlandi.Size = new System.Drawing.Size(215, 35);
            this.btnMuayeneTamamlandi.TabIndex = 7;
            this.btnMuayeneTamamlandi.Text = "MUAYENE TAMAMLANDI";
            this.btnMuayeneTamamlandi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "İlaçlar :";
            // 
            // lbxIlaclar
            // 
            this.lbxIlaclar.FormattingEnabled = true;
            this.lbxIlaclar.Location = new System.Drawing.Point(17, 192);
            this.lbxIlaclar.Name = "lbxIlaclar";
            this.lbxIlaclar.Size = new System.Drawing.Size(285, 69);
            this.lbxIlaclar.TabIndex = 10;
            // 
            // txtTeshis
            // 
            this.txtTeshis.Location = new System.Drawing.Point(87, 52);
            this.txtTeshis.Name = "txtTeshis";
            this.txtTeshis.Size = new System.Drawing.Size(215, 20);
            this.txtTeshis.TabIndex = 11;
            // 
            // txtIlac
            // 
            this.txtIlac.Location = new System.Drawing.Point(87, 165);
            this.txtIlac.Name = "txtIlac";
            this.txtIlac.Size = new System.Drawing.Size(215, 20);
            this.txtIlac.TabIndex = 12;
            // 
            // txtReceteNumarasi
            // 
            this.txtReceteNumarasi.Location = new System.Drawing.Point(164, 121);
            this.txtReceteNumarasi.Name = "txtReceteNumarasi";
            this.txtReceteNumarasi.Size = new System.Drawing.Size(138, 20);
            this.txtReceteNumarasi.TabIndex = 13;
            this.txtReceteNumarasi.TextChanged += new System.EventHandler(this.txtReceteNumarası_TextChanged);
            // 
            // MuayeneEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 477);
            this.Controls.Add(this.txtReceteNumarasi);
            this.Controls.Add(this.txtIlac);
            this.Controls.Add(this.txtTeshis);
            this.Controls.Add(this.lbxIlaclar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMuayeneTamamlandi);
            this.Controls.Add(this.rdoTeshisKonulamadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoHastaGelmedi);
            this.Controls.Add(this.label1);
            this.Name = "MuayeneEkrani";
            this.Text = "MuayeneEkrani";
            this.Load += new System.EventHandler(this.MuayeneEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoHastaGelmedi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoTeshisKonulamadi;
        private System.Windows.Forms.Button btnMuayeneTamamlandi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxIlaclar;
        private System.Windows.Forms.TextBox txtTeshis;
        private System.Windows.Forms.TextBox txtIlac;
        private System.Windows.Forms.TextBox txtReceteNumarasi;
    }
}