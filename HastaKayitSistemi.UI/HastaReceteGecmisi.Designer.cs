namespace HastaKayitSistemi.UI
{
    partial class HastaReceteGecmisi
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIlacKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(22, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastanın Kullandığı İlaçlar";
            // 
            // btnIlacKontrol
            // 
            this.btnIlacKontrol.Location = new System.Drawing.Point(82, 159);
            this.btnIlacKontrol.Name = "btnIlacKontrol";
            this.btnIlacKontrol.Size = new System.Drawing.Size(206, 23);
            this.btnIlacKontrol.TabIndex = 2;
            this.btnIlacKontrol.Text = "İLAÇLAR KONTROL EDİLDİ";
            this.btnIlacKontrol.UseVisualStyleBackColor = true;
            this.btnIlacKontrol.Click += new System.EventHandler(this.BtnIlacKontrol_Click);
            // 
            // HastaReceteGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 201);
            this.Controls.Add(this.btnIlacKontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "HastaReceteGecmisi";
            this.Text = "HastaReceteGecmisi";
            this.Load += new System.EventHandler(this.HastaReceteGecmisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIlacKontrol;
    }
}