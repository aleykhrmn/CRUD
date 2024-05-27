namespace WindowsFormsApp1
{
    partial class DersListele
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
            this.OgrenciYazı = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.föy5DataSet = new WindowsFormsApp1.föy5DataSet();
            this.tDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDersTableAdapter = new WindowsFormsApp1.föy5DataSetTableAdapters.tDersTableAdapter();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciYazı
            // 
            this.OgrenciYazı.BackColor = System.Drawing.Color.SeaShell;
            this.OgrenciYazı.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciYazı.Location = new System.Drawing.Point(220, 42);
            this.OgrenciYazı.Name = "OgrenciYazı";
            this.OgrenciYazı.Size = new System.Drawing.Size(419, 137);
            this.OgrenciYazı.TabIndex = 10;
            this.OgrenciYazı.Text = "DERSLER";
            this.OgrenciYazı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn,
            this.dersAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tDersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(220, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 175);
            this.dataGridView1.TabIndex = 11;
            // 
            // föy5DataSet
            // 
            this.föy5DataSet.DataSetName = "föy5DataSet";
            this.föy5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tDersBindingSource
            // 
            this.tDersBindingSource.DataMember = "tDers";
            this.tDersBindingSource.DataSource = this.föy5DataSet;
            // 
            // tDersTableAdapter
            // 
            this.tDersTableAdapter.ClearBeforeFill = true;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "dersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "dersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersAdDataGridViewTextBoxColumn
            // 
            this.dersAdDataGridViewTextBoxColumn.DataPropertyName = "dersAd";
            this.dersAdDataGridViewTextBoxColumn.HeaderText = "dersAd";
            this.dersAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersAdDataGridViewTextBoxColumn.Name = "dersAdDataGridViewTextBoxColumn";
            this.dersAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // DersListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OgrenciYazı);
            this.Name = "DersListele";
            this.Text = "DersListele";
            this.Load += new System.EventHandler(this.DersListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OgrenciYazı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private föy5DataSet föy5DataSet;
        private System.Windows.Forms.BindingSource tDersBindingSource;
        private föy5DataSetTableAdapters.tDersTableAdapter tDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdDataGridViewTextBoxColumn;
    }
}