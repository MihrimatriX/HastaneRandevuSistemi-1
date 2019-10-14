namespace HastaKayitSistemi.UI
{
    partial class DoktorRandevuları
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
            this.grpRandevular = new System.Windows.Forms.GroupBox();
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.dtCalismaGunu = new System.Windows.Forms.DateTimePicker();
            this.grpRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışma Günü :";
            // 
            // grpRandevular
            // 
            this.grpRandevular.Controls.Add(this.dgvRandevular);
            this.grpRandevular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpRandevular.Location = new System.Drawing.Point(28, 101);
            this.grpRandevular.Name = "grpRandevular";
            this.grpRandevular.Size = new System.Drawing.Size(335, 171);
            this.grpRandevular.TabIndex = 2;
            this.grpRandevular.TabStop = false;
            this.grpRandevular.Text = "Randevular";
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRandevular.Location = new System.Drawing.Point(3, 22);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.Size = new System.Drawing.Size(329, 146);
            this.dgvRandevular.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hasta Kimliği";
            this.Column1.Name = "Column1";
            this.Column1.Width = 155;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Seanslar";
            this.Column2.Name = "Column2";
            this.Column2.Width = 152;
            // 
            // btnMuayene
            // 
            this.btnMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayene.Location = new System.Drawing.Point(115, 278);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Size = new System.Drawing.Size(187, 34);
            this.btnMuayene.TabIndex = 3;
            this.btnMuayene.Text = "MUAYENE OLUŞTUR";
            this.btnMuayene.UseVisualStyleBackColor = true;
            this.btnMuayene.Click += new System.EventHandler(this.BtnMuayene_Click);
            // 
            // dtCalismaGunu
            // 
            this.dtCalismaGunu.Location = new System.Drawing.Point(151, 53);
            this.dtCalismaGunu.Name = "dtCalismaGunu";
            this.dtCalismaGunu.Size = new System.Drawing.Size(200, 20);
            this.dtCalismaGunu.TabIndex = 4;
            this.dtCalismaGunu.ValueChanged += new System.EventHandler(this.dtCalısmaGunu_ValueChanged);
            // 
            // DoktorRandevuları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 413);
            this.Controls.Add(this.dtCalismaGunu);
            this.Controls.Add(this.btnMuayene);
            this.Controls.Add(this.grpRandevular);
            this.Controls.Add(this.label1);
            this.Name = "DoktorRandevuları";
            this.Text = "DoktorRandevuları";
            this.Load += new System.EventHandler(this.DoktorRandevuları_Load);
            this.grpRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRandevular;
        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnMuayene;
        private System.Windows.Forms.DateTimePicker dtCalismaGunu;
    }
}