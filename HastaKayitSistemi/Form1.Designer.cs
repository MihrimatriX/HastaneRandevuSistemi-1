namespace HastaKayitSistemi
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.btnHastaGirisi = new System.Windows.Forms.Button();
            this.btnUye = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnEczacı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(139, 70);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(144, 20);
            this.txtHastaAdi.TabIndex = 1;
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(139, 111);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(144, 20);
            this.txtHastaSifre.TabIndex = 2;
            // 
            // btnHastaGirisi
            // 
            this.btnHastaGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGirisi.Location = new System.Drawing.Point(139, 147);
            this.btnHastaGirisi.Name = "btnHastaGirisi";
            this.btnHastaGirisi.Size = new System.Drawing.Size(144, 29);
            this.btnHastaGirisi.TabIndex = 3;
            this.btnHastaGirisi.Text = "GİRİŞ YAP";
            this.btnHastaGirisi.UseVisualStyleBackColor = true;
            // 
            // btnUye
            // 
            this.btnUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUye.Location = new System.Drawing.Point(157, 182);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(115, 29);
            this.btnUye.TabIndex = 4;
            this.btnUye.Text = "ÜYE OL";
            this.btnUye.UseVisualStyleBackColor = true;
            // 
            // btnHasta
            // 
            this.btnHasta.Location = new System.Drawing.Point(13, 13);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(100, 23);
            this.btnHasta.TabIndex = 5;
            this.btnHasta.Text = "HASTA GİRİŞİ";
            this.btnHasta.UseVisualStyleBackColor = true;
            // 
            // btnDoktor
            // 
            this.btnDoktor.Location = new System.Drawing.Point(129, 13);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(100, 23);
            this.btnDoktor.TabIndex = 6;
            this.btnDoktor.Text = "DOKTOR GİRİŞİ";
            this.btnDoktor.UseVisualStyleBackColor = true;
            // 
            // btnEczacı
            // 
            this.btnEczacı.Location = new System.Drawing.Point(249, 13);
            this.btnEczacı.Name = "btnEczacı";
            this.btnEczacı.Size = new System.Drawing.Size(100, 23);
            this.btnEczacı.TabIndex = 7;
            this.btnEczacı.Text = "ECZACI GİRİŞİ";
            this.btnEczacı.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 235);
            this.Controls.Add(this.btnEczacı);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.btnUye);
            this.Controls.Add(this.btnHastaGirisi);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtHastaSifre;
        private System.Windows.Forms.Button btnHastaGirisi;
        private System.Windows.Forms.Button btnUye;
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnEczacı;
    }
}

