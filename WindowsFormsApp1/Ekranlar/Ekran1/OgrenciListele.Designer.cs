namespace WindowsFormsApp1
{
    partial class OgrenciListele
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
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.föy5DataSet = new WindowsFormsApp1.föy5DataSet();
            this.tOgrenciTableAdapter = new WindowsFormsApp1.föy5DataSetTableAdapters.tOgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciYazı
            // 
            this.OgrenciYazı.BackColor = System.Drawing.Color.SeaShell;
            this.OgrenciYazı.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciYazı.Location = new System.Drawing.Point(184, 35);
            this.OgrenciYazı.Name = "OgrenciYazı";
            this.OgrenciYazı.Size = new System.Drawing.Size(552, 137);
            this.OgrenciYazı.TabIndex = 9;
            this.OgrenciYazı.Text = "ÖĞRENCİLER";
            this.OgrenciYazı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.bolumIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tOgrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(110, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 213);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tOgrenciBindingSource
            // 
            this.tOgrenciBindingSource.DataMember = "tOgrenci";
            this.tOgrenciBindingSource.DataSource = this.föy5DataSet;
            // 
            // föy5DataSet
            // 
            this.föy5DataSet.DataSetName = "föy5DataSet";
            this.föy5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOgrenciTableAdapter
            // 
            this.tOgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // OgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OgrenciYazı);
            this.Name = "OgrenciListele";
            this.Text = "OgrenciListele";
            this.Load += new System.EventHandler(this.OgrenciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OgrenciYazı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private föy5DataSet föy5DataSet;
        private System.Windows.Forms.BindingSource tOgrenciBindingSource;
        private föy5DataSetTableAdapters.tOgrenciTableAdapter tOgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
    }
}