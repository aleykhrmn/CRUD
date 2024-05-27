namespace WindowsFormsApp1
{
    partial class Ekran6
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
            this.anasayfaLabel = new System.Windows.Forms.Label();
            this.DersIDLabel = new System.Windows.Forms.Label();
            this.DersIDComboBox = new System.Windows.Forms.ComboBox();
            this.ListeleButon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yariyilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOgrenciDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.föy5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.föy5DataSet = new WindowsFormsApp1.föy5DataSet();
            this.tOgrenciDersTableAdapter = new WindowsFormsApp1.föy5DataSetTableAdapters.tOgrenciDersTableAdapter();
            this.KaydetButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // anasayfaLabel
            // 
            this.anasayfaLabel.BackColor = System.Drawing.Color.SeaShell;
            this.anasayfaLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaLabel.Location = new System.Drawing.Point(240, 43);
            this.anasayfaLabel.Name = "anasayfaLabel";
            this.anasayfaLabel.Size = new System.Drawing.Size(412, 138);
            this.anasayfaLabel.TabIndex = 30;
            this.anasayfaLabel.Text = "NOT GİRİŞ\r\nEKRANI";
            this.anasayfaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersIDLabel
            // 
            this.DersIDLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DersIDLabel.Location = new System.Drawing.Point(76, 248);
            this.DersIDLabel.Name = "DersIDLabel";
            this.DersIDLabel.Size = new System.Drawing.Size(138, 55);
            this.DersIDLabel.TabIndex = 31;
            this.DersIDLabel.Text = "Ders ID";
            this.DersIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersIDComboBox
            // 
            this.DersIDComboBox.FormattingEnabled = true;
            this.DersIDComboBox.Location = new System.Drawing.Point(255, 264);
            this.DersIDComboBox.Name = "DersIDComboBox";
            this.DersIDComboBox.Size = new System.Drawing.Size(162, 24);
            this.DersIDComboBox.TabIndex = 32;
            // 
            // ListeleButon
            // 
            this.ListeleButon.BackColor = System.Drawing.Color.IndianRed;
            this.ListeleButon.Location = new System.Drawing.Point(462, 248);
            this.ListeleButon.Name = "ListeleButon";
            this.ListeleButon.Size = new System.Drawing.Size(125, 54);
            this.ListeleButon.TabIndex = 33;
            this.ListeleButon.Text = "Listele";
            this.ListeleButon.UseVisualStyleBackColor = false;
            this.ListeleButon.Click += new System.EventHandler(this.ListeleButon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.dersIDDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.yariyilDataGridViewTextBoxColumn,
            this.vizeDataGridViewTextBoxColumn,
            this.finalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tOgrenciDersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "dersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "dersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "yil";
            this.yilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            this.yilDataGridViewTextBoxColumn.Width = 125;
            // 
            // yariyilDataGridViewTextBoxColumn
            // 
            this.yariyilDataGridViewTextBoxColumn.DataPropertyName = "yariyil";
            this.yariyilDataGridViewTextBoxColumn.HeaderText = "yariyil";
            this.yariyilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yariyilDataGridViewTextBoxColumn.Name = "yariyilDataGridViewTextBoxColumn";
            this.yariyilDataGridViewTextBoxColumn.Width = 125;
            // 
            // vizeDataGridViewTextBoxColumn
            // 
            this.vizeDataGridViewTextBoxColumn.DataPropertyName = "vize";
            this.vizeDataGridViewTextBoxColumn.HeaderText = "vize";
            this.vizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vizeDataGridViewTextBoxColumn.Name = "vizeDataGridViewTextBoxColumn";
            this.vizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalDataGridViewTextBoxColumn
            // 
            this.finalDataGridViewTextBoxColumn.DataPropertyName = "final";
            this.finalDataGridViewTextBoxColumn.HeaderText = "final";
            this.finalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalDataGridViewTextBoxColumn.Name = "finalDataGridViewTextBoxColumn";
            this.finalDataGridViewTextBoxColumn.Width = 125;
            // 
            // tOgrenciDersBindingSource
            // 
            this.tOgrenciDersBindingSource.DataMember = "tOgrenciDers";
            this.tOgrenciDersBindingSource.DataSource = this.föy5DataSetBindingSource;
            // 
            // föy5DataSetBindingSource
            // 
            this.föy5DataSetBindingSource.DataSource = this.föy5DataSet;
            this.föy5DataSetBindingSource.Position = 0;
            // 
            // föy5DataSet
            // 
            this.föy5DataSet.DataSetName = "föy5DataSet";
            this.föy5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOgrenciDersTableAdapter
            // 
            this.tOgrenciDersTableAdapter.ClearBeforeFill = true;
            // 
            // KaydetButon
            // 
            this.KaydetButon.BackColor = System.Drawing.Color.IndianRed;
            this.KaydetButon.Location = new System.Drawing.Point(656, 249);
            this.KaydetButon.Name = "KaydetButon";
            this.KaydetButon.Size = new System.Drawing.Size(125, 54);
            this.KaydetButon.TabIndex = 35;
            this.KaydetButon.Text = "Kaydet";
            this.KaydetButon.UseVisualStyleBackColor = false;
            this.KaydetButon.Click += new System.EventHandler(this.KaydetButon_Click);
            // 
            // Ekran6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.KaydetButon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListeleButon);
            this.Controls.Add(this.DersIDComboBox);
            this.Controls.Add(this.DersIDLabel);
            this.Controls.Add(this.anasayfaLabel);
            this.Name = "Ekran6";
            this.Text = "Ekran6";
            this.Load += new System.EventHandler(this.Ekran6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label anasayfaLabel;
        private System.Windows.Forms.Label DersIDLabel;
        private System.Windows.Forms.ComboBox DersIDComboBox;
        private System.Windows.Forms.Button ListeleButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource föy5DataSetBindingSource;
        private föy5DataSet föy5DataSet;
        private System.Windows.Forms.BindingSource tOgrenciDersBindingSource;
        private föy5DataSetTableAdapters.tOgrenciDersTableAdapter tOgrenciDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yariyilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button KaydetButon;
    }
}