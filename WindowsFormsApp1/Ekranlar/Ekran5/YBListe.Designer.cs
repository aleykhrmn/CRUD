namespace WindowsFormsApp1
{
    partial class YBListe
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
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.OgrenciEkleLAbel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.föy5DataSet = new WindowsFormsApp1.föy5DataSet();
            this.tOgrenciDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.föy5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.ListeleButon = new System.Windows.Forms.Button();
            this.tOgrenciDersTableAdapter = new WindowsFormsApp1.föy5DataSetTableAdapters.tOgrenciDersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(313, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(155, 32);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(544, 125);
            this.DersEkleLabel.TabIndex = 19;
            this.DersEkleLabel.Text = "Yıl Bazlı\r\nListeleme";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciEkleLAbel
            // 
            this.OgrenciEkleLAbel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciEkleLAbel.Location = new System.Drawing.Point(157, 194);
            this.OgrenciEkleLAbel.Name = "OgrenciEkleLAbel";
            this.OgrenciEkleLAbel.Size = new System.Drawing.Size(162, 51);
            this.OgrenciEkleLAbel.TabIndex = 20;
            this.OgrenciEkleLAbel.Text = "Yıl";
            this.OgrenciEkleLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(157, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 51);
            this.label1.TabIndex = 21;
            this.label1.Text = "Yarıyıl";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearComboBox
            // 
            this.YearComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.föy5DataSet, "tOgrenciDers.yil", true));
            this.YearComboBox.DataSource = this.tOgrenciDersBindingSource;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.ItemHeight = 16;
            this.YearComboBox.Location = new System.Drawing.Point(423, 208);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(165, 24);
            this.YearComboBox.TabIndex = 22;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // föy5DataSet
            // 
            this.föy5DataSet.DataSetName = "föy5DataSet";
            this.föy5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // SemesterComboBox
            // 
            this.SemesterComboBox.DataSource = this.föy5DataSetBindingSource;
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(423, 274);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(165, 24);
            this.SemesterComboBox.TabIndex = 23;
            // 
            // ListeleButon
            // 
            this.ListeleButon.BackColor = System.Drawing.Color.IndianRed;
            this.ListeleButon.Location = new System.Drawing.Point(649, 223);
            this.ListeleButon.Name = "ListeleButon";
            this.ListeleButon.Size = new System.Drawing.Size(135, 55);
            this.ListeleButon.TabIndex = 24;
            this.ListeleButon.Text = "Listele";
            this.ListeleButon.UseVisualStyleBackColor = false;
            this.ListeleButon.Click += new System.EventHandler(this.ListeleButon_Click);
            // 
            // tOgrenciDersTableAdapter
            // 
            this.tOgrenciDersTableAdapter.ClearBeforeFill = true;
            // 
            // YBListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.ListeleButon);
            this.Controls.Add(this.SemesterComboBox);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OgrenciEkleLAbel);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YBListe";
            this.Text = "YBListe";
            this.Load += new System.EventHandler(this.YBListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DersEkleLabel;
        private System.Windows.Forms.Label OgrenciEkleLAbel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.Button ListeleButon;
        private System.Windows.Forms.BindingSource föy5DataSetBindingSource;
        private föy5DataSet föy5DataSet;
        private System.Windows.Forms.BindingSource tOgrenciDersBindingSource;
        private föy5DataSetTableAdapters.tOgrenciDersTableAdapter tOgrenciDersTableAdapter;
    }
}