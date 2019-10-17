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
            this.label3 = new System.Windows.Forms.Label();
            this.btnMuayeneTamamlandi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIlac = new System.Windows.Forms.TextBox();
            this.txtReceteNumarasi = new System.Windows.Forms.TextBox();
            this.chkMuayeneyeGelmedi = new System.Windows.Forms.CheckBox();
            this.dgvIlaclar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIlacEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlaclar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reçete Numarası :";
            // 
            // btnMuayeneTamamlandi
            // 
            this.btnMuayeneTamamlandi.Location = new System.Drawing.Point(40, 351);
            this.btnMuayeneTamamlandi.Name = "btnMuayeneTamamlandi";
            this.btnMuayeneTamamlandi.Size = new System.Drawing.Size(215, 35);
            this.btnMuayeneTamamlandi.TabIndex = 7;
            this.btnMuayeneTamamlandi.Text = "MUAYENE TAMAMLANDI";
            this.btnMuayeneTamamlandi.UseVisualStyleBackColor = true;
            this.btnMuayeneTamamlandi.Click += new System.EventHandler(this.btnMuayeneTamamlandi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "İlaçlar :";
            // 
            // txtIlac
            // 
            this.txtIlac.Location = new System.Drawing.Point(105, 90);
            this.txtIlac.Name = "txtIlac";
            this.txtIlac.Size = new System.Drawing.Size(215, 20);
            this.txtIlac.TabIndex = 12;
            // 
            // txtReceteNumarasi
            // 
            this.txtReceteNumarasi.Location = new System.Drawing.Point(182, 52);
            this.txtReceteNumarasi.Name = "txtReceteNumarasi";
            this.txtReceteNumarasi.Size = new System.Drawing.Size(138, 20);
            this.txtReceteNumarasi.TabIndex = 13;
            // 
            // chkMuayeneyeGelmedi
            // 
            this.chkMuayeneyeGelmedi.AutoSize = true;
            this.chkMuayeneyeGelmedi.Location = new System.Drawing.Point(40, 12);
            this.chkMuayeneyeGelmedi.Name = "chkMuayeneyeGelmedi";
            this.chkMuayeneyeGelmedi.Size = new System.Drawing.Size(153, 17);
            this.chkMuayeneyeGelmedi.TabIndex = 14;
            this.chkMuayeneyeGelmedi.Text = "Hasta Muayeneye Gelmedi";
            this.chkMuayeneyeGelmedi.UseVisualStyleBackColor = true;
            this.chkMuayeneyeGelmedi.CheckedChanged += new System.EventHandler(this.chkMuayeneyeGelmedi_CheckedChanged);
            // 
            // dgvIlaclar
            // 
            this.dgvIlaclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIlaclar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlaclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvIlaclar.Location = new System.Drawing.Point(40, 245);
            this.dgvIlaclar.Name = "dgvIlaclar";
            this.dgvIlaclar.Size = new System.Drawing.Size(126, 86);
            this.dgvIlaclar.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Eklenenler";
            this.Column1.Name = "Column1";
            this.Column1.Width = 82;
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.Location = new System.Drawing.Point(40, 216);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(75, 23);
            this.btnIlacEkle.TabIndex = 17;
            this.btnIlacEkle.Text = "Ilac Ekle";
            this.btnIlacEkle.UseVisualStyleBackColor = true;
            this.btnIlacEkle.Click += new System.EventHandler(this.btnIlacEkle_Click);
            // 
            // MuayeneEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 416);
            this.Controls.Add(this.btnIlacEkle);
            this.Controls.Add(this.dgvIlaclar);
            this.Controls.Add(this.chkMuayeneyeGelmedi);
            this.Controls.Add(this.txtReceteNumarasi);
            this.Controls.Add(this.txtIlac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMuayeneTamamlandi);
            this.Controls.Add(this.label3);
            this.Name = "MuayeneEkrani";
            this.Text = "MuayeneEkrani";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MuayeneEkrani_FormClosed);
            this.Load += new System.EventHandler(this.MuayeneEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlaclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMuayeneTamamlandi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIlac;
        private System.Windows.Forms.TextBox txtReceteNumarasi;
        private System.Windows.Forms.CheckBox chkMuayeneyeGelmedi;
        private System.Windows.Forms.DataGridView dgvIlaclar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnIlacEkle;
    }
}