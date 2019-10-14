namespace HastaKayitSistemi.UI
{
    partial class Doktor
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
            this.btnDoktorGirisi = new System.Windows.Forms.Button();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDoktor = new System.Windows.Forms.GroupBox();
            this.grpDoktor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoktorGirisi
            // 
            this.btnDoktorGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGirisi.Location = new System.Drawing.Point(116, 119);
            this.btnDoktorGirisi.Name = "btnDoktorGirisi";
            this.btnDoktorGirisi.Size = new System.Drawing.Size(144, 29);
            this.btnDoktorGirisi.TabIndex = 8;
            this.btnDoktorGirisi.Text = "GİRİŞ YAP";
            this.btnDoktorGirisi.UseVisualStyleBackColor = true;
            this.btnDoktorGirisi.Click += new System.EventHandler(this.BtnDoktorGirisi_Click);
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(116, 83);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.PasswordChar = '*';
            this.txtDoktorSifre.Size = new System.Drawing.Size(144, 20);
            this.txtDoktorSifre.TabIndex = 7;
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(116, 42);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(144, 20);
            this.txtDoktorAdi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // grpDoktor
            // 
            this.grpDoktor.Controls.Add(this.label1);
            this.grpDoktor.Controls.Add(this.btnDoktorGirisi);
            this.grpDoktor.Controls.Add(this.label2);
            this.grpDoktor.Controls.Add(this.txtDoktorSifre);
            this.grpDoktor.Controls.Add(this.txtDoktorAdi);
            this.grpDoktor.Location = new System.Drawing.Point(12, 12);
            this.grpDoktor.Name = "grpDoktor";
            this.grpDoktor.Size = new System.Drawing.Size(271, 206);
            this.grpDoktor.TabIndex = 9;
            this.grpDoktor.TabStop = false;
            this.grpDoktor.Text = "Doktor Giriş";
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 262);
            this.Controls.Add(this.grpDoktor);
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Doktor_FormClosed);
            this.Load += new System.EventHandler(this.Doktor_Load);
            this.grpDoktor.ResumeLayout(false);
            this.grpDoktor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorGirisi;
        private System.Windows.Forms.TextBox txtDoktorSifre;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDoktor;
    }
}