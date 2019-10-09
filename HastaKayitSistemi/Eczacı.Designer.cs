namespace HastaKayitSistemi
{
    partial class Eczacı
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
            this.txtEczacıAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEczacıSifre = new System.Windows.Forms.TextBox();
            this.btnEczacıGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtEczacıAdi
            // 
            this.txtEczacıAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEczacıAdi.Location = new System.Drawing.Point(149, 16);
            this.txtEczacıAdi.Name = "txtEczacıAdi";
            this.txtEczacıAdi.Size = new System.Drawing.Size(186, 26);
            this.txtEczacıAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // txtEczacıSifre
            // 
            this.txtEczacıSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEczacıSifre.Location = new System.Drawing.Point(149, 55);
            this.txtEczacıSifre.Name = "txtEczacıSifre";
            this.txtEczacıSifre.Size = new System.Drawing.Size(186, 26);
            this.txtEczacıSifre.TabIndex = 3;
            // 
            // btnEczacıGiris
            // 
            this.btnEczacıGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEczacıGiris.Location = new System.Drawing.Point(149, 99);
            this.btnEczacıGiris.Name = "btnEczacıGiris";
            this.btnEczacıGiris.Size = new System.Drawing.Size(186, 29);
            this.btnEczacıGiris.TabIndex = 4;
            this.btnEczacıGiris.Text = "GİRİŞ YAP";
            this.btnEczacıGiris.UseVisualStyleBackColor = true;
            // 
            // Eczacı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 140);
            this.Controls.Add(this.btnEczacıGiris);
            this.Controls.Add(this.txtEczacıSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEczacıAdi);
            this.Controls.Add(this.label1);
            this.Name = "Eczacı";
            this.Text = "Eczacı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEczacıAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEczacıSifre;
        private System.Windows.Forms.Button btnEczacıGiris;
    }
}