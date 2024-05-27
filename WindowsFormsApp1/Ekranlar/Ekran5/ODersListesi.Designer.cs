namespace WindowsFormsApp1
{
    partial class ODersListesi
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
            this.OgrenciEkleLAbel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yariyilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOgrenciDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.föy5DataSet = new WindowsFormsApp1.föy5DataSet();
            this.tOgrenciDersTableAdapter = new WindowsFormsApp1.föy5DataSetTableAdapters.tOgrenciDersTableAdapter();
            this.Lıstele = new System.Windows.Forms.Button();
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.tOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOgrenciTableAdapter = new WindowsFormsApp1.föy5DataSetTableAdapters.tOgrenciTableAdapter();
            this.OgrenciIDTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciEkleLAbel
            // 
            this.OgrenciEkleLAbel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciEkleLAbel.Location = new System.Drawing.Point(195, 246);
            this.OgrenciEkleLAbel.Name = "OgrenciEkleLAbel";
            this.OgrenciEkleLAbel.Size = new System.Drawing.Size(162, 58);
            this.OgrenciEkleLAbel.TabIndex = 4;
            this.OgrenciEkleLAbel.Text = "No ";
            this.OgrenciEkleLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.yariyilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tOgrenciDersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(198, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 6;
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
            // tOgrenciDersBindingSource
            // 
            this.tOgrenciDersBindingSource.DataMember = "tOgrenciDers";
            this.tOgrenciDersBindingSource.DataSource = this.föy5DataSet;
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
            // Lıstele
            // 
            this.Lıstele.BackColor = System.Drawing.Color.IndianRed;
            this.Lıstele.Location = new System.Drawing.Point(652, 255);
            this.Lıstele.Name = "Lıstele";
            this.Lıstele.Size = new System.Drawing.Size(85, 40);
            this.Lıstele.TabIndex = 7;
            this.Lıstele.Text = "Listele";
            this.Lıstele.UseVisualStyleBackColor = false;
            this.Lıstele.Click += new System.EventHandler(this.Lıstele_Click);
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(193, 40);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(544, 125);
            this.DersEkleLabel.TabIndex = 18;
            this.DersEkleLabel.Text = "Öğrenci Bazlı\r\nListeleme";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tOgrenciBindingSource
            // 
            this.tOgrenciBindingSource.DataMember = "tOgrenci";
            this.tOgrenciBindingSource.DataSource = this.föy5DataSet;
            // 
            // tOgrenciTableAdapter
            // 
            this.tOgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // OgrenciIDTextBox
            // 
            this.OgrenciIDTextBox.Location = new System.Drawing.Point(424, 255);
            this.OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            this.OgrenciIDTextBox.Size = new System.Drawing.Size(168, 48);
            this.OgrenciIDTextBox.TabIndex = 19;
            this.OgrenciIDTextBox.Text = "";
            // 
            // ODersListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.OgrenciIDTextBox);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.Lıstele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OgrenciEkleLAbel);
            this.Name = "ODersListesi";
            this.Text = "OBLİSTE";
            this.Load += new System.EventHandler(this.OBLİSTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label OgrenciEkleLAbel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private föy5DataSet föy5DataSet;
        private System.Windows.Forms.BindingSource tOgrenciDersBindingSource;
        private föy5DataSetTableAdapters.tOgrenciDersTableAdapter tOgrenciDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yariyilDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Lıstele;
        private System.Windows.Forms.Label DersEkleLabel;
        private System.Windows.Forms.BindingSource tOgrenciBindingSource;
        private föy5DataSetTableAdapters.tOgrenciTableAdapter tOgrenciTableAdapter;
        private System.Windows.Forms.RichTextBox OgrenciIDTextBox;
    }
}