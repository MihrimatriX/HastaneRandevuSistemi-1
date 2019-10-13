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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReceteNumarasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIlaclarıGoruntule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "HASTA REÇETE GEÇMİŞİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "HASTAYA İLAÇLAR TESLİM EDİLDİ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 136);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaçlar";
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
            // btnIlaclarıGoruntule
            // 
            this.btnIlaclarıGoruntule.Location = new System.Drawing.Point(158, 39);
            this.btnIlaclarıGoruntule.Name = "btnIlaclarıGoruntule";
            this.btnIlaclarıGoruntule.Size = new System.Drawing.Size(186, 23);
            this.btnIlaclarıGoruntule.TabIndex = 14;
            this.btnIlaclarıGoruntule.Text = "İLAÇLARI LİSTELE";
            this.btnIlaclarıGoruntule.UseVisualStyleBackColor = true;
            // 
            // EczaciReceteBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 275);
            this.Controls.Add(this.btnIlaclarıGoruntule);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtReceteNumarasi);
            this.Controls.Add(this.label3);
            this.Name = "EczaciReceteBilgileri";
            this.Text = "EczacıReceteBilgileri";
            this.Load += new System.EventHandler(this.EczaciReceteBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReceteNumarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIlaclarıGoruntule;
    }
}