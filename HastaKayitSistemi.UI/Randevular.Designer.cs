namespace HastaKayitSistemi.UI
{
    partial class Randevular
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
            this.components = new System.ComponentModel.Container();
            this.grpRandevular = new System.Windows.Forms.GroupBox();
            this.dgvRandevuListesi = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSil = new System.Windows.Forms.ToolStripMenuItem();
            this.RandevuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaneAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmanAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRandevular
            // 
            this.grpRandevular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRandevular.ContextMenuStrip = this.ContextMenuStrip1;
            this.grpRandevular.Controls.Add(this.dgvRandevuListesi);
            this.grpRandevular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpRandevular.Location = new System.Drawing.Point(12, 12);
            this.grpRandevular.Name = "grpRandevular";
            this.grpRandevular.Size = new System.Drawing.Size(588, 409);
            this.grpRandevular.TabIndex = 1;
            this.grpRandevular.TabStop = false;
            this.grpRandevular.Text = "Alınan Randevuların Listesi :";
            // 
            // dgvRandevuListesi
            // 
            this.dgvRandevuListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevuListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RandevuID,
            this.HastaneAdi,
            this.DepartmanAdi,
            this.Column1,
            this.Column2});
            this.dgvRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRandevuListesi.Location = new System.Drawing.Point(3, 22);
            this.dgvRandevuListesi.MultiSelect = false;
            this.dgvRandevuListesi.Name = "dgvRandevuListesi";
            this.dgvRandevuListesi.ReadOnly = true;
            this.dgvRandevuListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevuListesi.Size = new System.Drawing.Size(582, 384);
            this.dgvRandevuListesi.TabIndex = 0;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSil});
            this.ContextMenuStrip1.Name = "CM";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(90, 26);
            // 
            // cmsSil
            // 
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(89, 22);
            this.cmsSil.Text = "SİL";
            this.cmsSil.Click += new System.EventHandler(this.CmsSil_Click);
            // 
            // RandevuID
            // 
            this.RandevuID.FillWeight = 126.9035F;
            this.RandevuID.HeaderText = "RandevuID";
            this.RandevuID.Name = "RandevuID";
            this.RandevuID.ReadOnly = true;
            // 
            // HastaneAdi
            // 
            this.HastaneAdi.FillWeight = 93.27412F;
            this.HastaneAdi.HeaderText = "Hastane Adı";
            this.HastaneAdi.Name = "HastaneAdi";
            this.HastaneAdi.ReadOnly = true;
            // 
            // DepartmanAdi
            // 
            this.DepartmanAdi.FillWeight = 93.27412F;
            this.DepartmanAdi.HeaderText = "Departman";
            this.DepartmanAdi.Name = "DepartmanAdi";
            this.DepartmanAdi.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 93.27412F;
            this.Column1.HeaderText = "Doktor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 93.27412F;
            this.Column2.HeaderText = "Randevu Tarihi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 433);
            this.Controls.Add(this.grpRandevular);
            this.Name = "Randevular";
            this.Text = "Randevular";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Randevular_FormClosed);
            this.Load += new System.EventHandler(this.Randevular_Load);
            this.grpRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRandevular;
        private System.Windows.Forms.DataGridView dgvRandevuListesi;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaneAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmanAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}