namespace SaglamGelseBari
{
    partial class VeriCekme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kargoUygulamasiDataSet = new SaglamGelseBari.KargoUygulamasiDataSet();
            this.raporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raporTableAdapter = new SaglamGelseBari.KargoUygulamasiDataSetTableAdapters.RaporTableAdapter();
            this.raporIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gondericiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gondericiSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gonderiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoUygulamasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raporIDDataGridViewTextBoxColumn,
            this.aliciAdDataGridViewTextBoxColumn,
            this.aliciSoyadDataGridViewTextBoxColumn,
            this.gondericiAdDataGridViewTextBoxColumn,
            this.gondericiSoyadDataGridViewTextBoxColumn,
            this.gonderiNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.raporBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 629);
            this.dataGridView1.TabIndex = 0;
            // 
            // kargoUygulamasiDataSet
            // 
            this.kargoUygulamasiDataSet.DataSetName = "KargoUygulamasiDataSet";
            this.kargoUygulamasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporBindingSource
            // 
            this.raporBindingSource.DataMember = "Rapor";
            this.raporBindingSource.DataSource = this.kargoUygulamasiDataSet;
            // 
            // raporTableAdapter
            // 
            this.raporTableAdapter.ClearBeforeFill = true;
            // 
            // raporIDDataGridViewTextBoxColumn
            // 
            this.raporIDDataGridViewTextBoxColumn.DataPropertyName = "RaporID";
            this.raporIDDataGridViewTextBoxColumn.HeaderText = "RaporID";
            this.raporIDDataGridViewTextBoxColumn.Name = "raporIDDataGridViewTextBoxColumn";
            this.raporIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aliciAdDataGridViewTextBoxColumn
            // 
            this.aliciAdDataGridViewTextBoxColumn.DataPropertyName = "AliciAd";
            this.aliciAdDataGridViewTextBoxColumn.HeaderText = "AliciAd";
            this.aliciAdDataGridViewTextBoxColumn.Name = "aliciAdDataGridViewTextBoxColumn";
            // 
            // aliciSoyadDataGridViewTextBoxColumn
            // 
            this.aliciSoyadDataGridViewTextBoxColumn.DataPropertyName = "AliciSoyad";
            this.aliciSoyadDataGridViewTextBoxColumn.HeaderText = "AliciSoyad";
            this.aliciSoyadDataGridViewTextBoxColumn.Name = "aliciSoyadDataGridViewTextBoxColumn";
            // 
            // gondericiAdDataGridViewTextBoxColumn
            // 
            this.gondericiAdDataGridViewTextBoxColumn.DataPropertyName = "GondericiAd";
            this.gondericiAdDataGridViewTextBoxColumn.HeaderText = "GondericiAd";
            this.gondericiAdDataGridViewTextBoxColumn.Name = "gondericiAdDataGridViewTextBoxColumn";
            // 
            // gondericiSoyadDataGridViewTextBoxColumn
            // 
            this.gondericiSoyadDataGridViewTextBoxColumn.DataPropertyName = "GondericiSoyad";
            this.gondericiSoyadDataGridViewTextBoxColumn.HeaderText = "GondericiSoyad";
            this.gondericiSoyadDataGridViewTextBoxColumn.Name = "gondericiSoyadDataGridViewTextBoxColumn";
            // 
            // gonderiNoDataGridViewTextBoxColumn
            // 
            this.gonderiNoDataGridViewTextBoxColumn.DataPropertyName = "GonderiNo";
            this.gonderiNoDataGridViewTextBoxColumn.HeaderText = "GonderiNo";
            this.gonderiNoDataGridViewTextBoxColumn.Name = "gonderiNoDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 139);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rapor Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VeriCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1164, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VeriCekme";
            this.Text = "VeriCekme";
            this.Load += new System.EventHandler(this.VeriCekme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoUygulamasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private KargoUygulamasiDataSet kargoUygulamasiDataSet;
        private System.Windows.Forms.BindingSource raporBindingSource;
        private KargoUygulamasiDataSetTableAdapters.RaporTableAdapter raporTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn raporIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gondericiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gondericiSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gonderiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}