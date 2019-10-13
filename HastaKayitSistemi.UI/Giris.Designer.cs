namespace HastaKayitSistemi.UI
{
    partial class Giris
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
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnEczacı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.Location = new System.Drawing.Point(126, 38);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(126, 44);
            this.btnHasta.TabIndex = 5;
            this.btnHasta.Text = "HASTA GİRİŞİ";
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.BtnHasta_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.Location = new System.Drawing.Point(126, 92);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(126, 44);
            this.btnDoktor.TabIndex = 6;
            this.btnDoktor.Text = "DOKTOR GİRİŞİ";
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Click += new System.EventHandler(this.BtnDoktor_Click);
            // 
            // btnEczacı
            // 
            this.btnEczacı.Location = new System.Drawing.Point(126, 146);
            this.btnEczacı.Name = "btnEczacı";
            this.btnEczacı.Size = new System.Drawing.Size(126, 44);
            this.btnEczacı.TabIndex = 7;
            this.btnEczacı.Text = "ECZACI GİRİŞİ";
            this.btnEczacı.UseVisualStyleBackColor = true;
            this.btnEczacı.Click += new System.EventHandler(this.BtnEczacı_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 235);
            this.Controls.Add(this.btnEczacı);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnHasta);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnEczacı;
    }
}

