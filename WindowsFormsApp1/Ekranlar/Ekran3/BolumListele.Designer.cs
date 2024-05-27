namespace WindowsFormsApp1
{
    partial class BolumListele
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
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakulteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foy5DataSet2 = new WindowsFormsApp1.foy5DataSet2();
            this.tBolumTableAdapter = new WindowsFormsApp1.foy5DataSet2TableAdapters.tBolumTableAdapter();
            this.föy5DataSet = new WindowsFormsApp1.föy5DataSet();
            this.tBolumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBolumTableAdapter1 = new WindowsFormsApp1.föy5DataSetTableAdapters.tBolumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foy5DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBolumBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(186, 45);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(503, 121);
            this.DersEkleLabel.TabIndex = 16;
            this.DersEkleLabel.Text = "BÖLÜMLER";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn,
            this.fakulteIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBolumBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(191, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 205);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "bolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "bolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // fakulteIDDataGridViewTextBoxColumn
            // 
            this.fakulteIDDataGridViewTextBoxColumn.DataPropertyName = "fakulteID";
            this.fakulteIDDataGridViewTextBoxColumn.HeaderText = "fakulteID";
            this.fakulteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fakulteIDDataGridViewTextBoxColumn.Name = "fakulteIDDataGridViewTextBoxColumn";
            // 
            // tBolumBindingSource
            // 
            this.tBolumBindingSource.DataMember = "tBolum";
            this.tBolumBindingSource.DataSource = this.foy5DataSet2;
            // 
            // foy5DataSet2
            // 
            this.foy5DataSet2.DataSetName = "foy5DataSet2";
            this.foy5DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBolumTableAdapter
            // 
            this.tBolumTableAdapter.ClearBeforeFill = true;
            // 
            // föy5DataSet
            // 
            this.föy5DataSet.DataSetName = "föy5DataSet";
            this.föy5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBolumBindingSource1
            // 
            this.tBolumBindingSource1.DataMember = "tBolum";
            this.tBolumBindingSource1.DataSource = this.föy5DataSet;
            // 
            // tBolumTableAdapter1
            // 
            this.tBolumTableAdapter1.ClearBeforeFill = true;
            // 
            // BolumListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DersEkleLabel);
            this.Name = "BolumListele";
            this.Text = "BolumListele";
            this.Load += new System.EventHandler(this.BolumListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foy5DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBolumBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DersEkleLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private foy5DataSet2 foy5DataSet2;
        private System.Windows.Forms.BindingSource tBolumBindingSource;
        private foy5DataSet2TableAdapters.tBolumTableAdapter tBolumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteIDDataGridViewTextBoxColumn;
        private föy5DataSet föy5DataSet;
        private System.Windows.Forms.BindingSource tBolumBindingSource1;
        private föy5DataSetTableAdapters.tBolumTableAdapter tBolumTableAdapter1;
    }
}