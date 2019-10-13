namespace HastaKayitSistemi.UI
{
    partial class Eczaci
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
            this.txtEczaciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEczaciSifre = new System.Windows.Forms.TextBox();
            this.btnEczaciGiris = new System.Windows.Forms.Button();
            this.grpEczaci = new System.Windows.Forms.GroupBox();
            this.grpEczaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtEczaciAdi
            // 
            this.txtEczaciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEczaciAdi.Location = new System.Drawing.Point(119, 21);
            this.txtEczaciAdi.Name = "txtEczaciAdi";
            this.txtEczaciAdi.Size = new System.Drawing.Size(186, 26);
            this.txtEczaciAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // txtEczaciSifre
            // 
            this.txtEczaciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEczaciSifre.Location = new System.Drawing.Point(119, 60);
            this.txtEczaciSifre.Name = "txtEczaciSifre";
            this.txtEczaciSifre.Size = new System.Drawing.Size(186, 26);
            this.txtEczaciSifre.TabIndex = 3;
            // 
            // btnEczaciGiris
            // 
            this.btnEczaciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEczaciGiris.Location = new System.Drawing.Point(119, 104);
            this.btnEczaciGiris.Name = "btnEczaciGiris";
            this.btnEczaciGiris.Size = new System.Drawing.Size(186, 29);
            this.btnEczaciGiris.TabIndex = 4;
            this.btnEczaciGiris.Text = "GİRİŞ YAP";
            this.btnEczaciGiris.UseVisualStyleBackColor = true;
            this.btnEczaciGiris.Click += new System.EventHandler(this.BtnEczaciGiris_Click);
            // 
            // grpEczaci
            // 
            this.grpEczaci.Controls.Add(this.txtEczaciSifre);
            this.grpEczaci.Controls.Add(this.btnEczaciGiris);
            this.grpEczaci.Controls.Add(this.label1);
            this.grpEczaci.Controls.Add(this.txtEczaciAdi);
            this.grpEczaci.Controls.Add(this.label2);
            this.grpEczaci.Location = new System.Drawing.Point(12, 12);
            this.grpEczaci.Name = "grpEczaci";
            this.grpEczaci.Size = new System.Drawing.Size(380, 180);
            this.grpEczaci.TabIndex = 5;
            this.grpEczaci.TabStop = false;
            this.grpEczaci.Text = "Eczacı Giriş";
            // 
            // Eczaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 228);
            this.Controls.Add(this.grpEczaci);
            this.Name = "Eczaci";
            this.Text = "Eczacı";
            this.Load += new System.EventHandler(this.Eczaci_Load);
            this.grpEczaci.ResumeLayout(false);
            this.grpEczaci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEczaciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEczaciSifre;
        private System.Windows.Forms.Button btnEczaciGiris;
        private System.Windows.Forms.GroupBox grpEczaci;
    }
}