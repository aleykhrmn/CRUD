namespace WindowsFormsApp1
{
    partial class DersDegistirme
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
            this.OnaylaButon = new System.Windows.Forms.Button();
            this.SDersIDTextBox = new System.Windows.Forms.RichTextBox();
            this.SdersIDlabel = new System.Windows.Forms.Label();
            this.YılLabel = new System.Windows.Forms.Label();
            this.DonemLabel = new System.Windows.Forms.Label();
            this.OgrenciIDTextBox = new System.Windows.Forms.RichTextBox();
            this.OgrenciIDLabel = new System.Windows.Forms.Label();
            this.EDersIDTextBox = new System.Windows.Forms.RichTextBox();
            this.EDersIDlabel = new System.Windows.Forms.Label();
            this.anasayfaLabel = new System.Windows.Forms.Label();
            this.tOgrenciDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.föy5DataSet = new WindowsFormsApp1.föy5DataSet();
            this.föy5DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tOgrenciDersTableAdapter = new WindowsFormsApp1.föy5DataSetTableAdapters.tOgrenciDersTableAdapter();
            this.föy5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOgrenciDersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yariyilTextBox = new System.Windows.Forms.RichTextBox();
            this.yilTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // OnaylaButon
            // 
            this.OnaylaButon.BackColor = System.Drawing.Color.IndianRed;
            this.OnaylaButon.Location = new System.Drawing.Point(528, 491);
            this.OnaylaButon.Name = "OnaylaButon";
            this.OnaylaButon.Size = new System.Drawing.Size(112, 51);
            this.OnaylaButon.TabIndex = 17;
            this.OnaylaButon.Text = "Onayla";
            this.OnaylaButon.UseVisualStyleBackColor = false;
            this.OnaylaButon.Click += new System.EventHandler(this.OnaylaButon_Click);
            // 
            // SDersIDTextBox
            // 
            this.SDersIDTextBox.Location = new System.Drawing.Point(463, 359);
            this.SDersIDTextBox.Name = "SDersIDTextBox";
            this.SDersIDTextBox.Size = new System.Drawing.Size(177, 55);
            this.SDersIDTextBox.TabIndex = 16;
            this.SDersIDTextBox.Text = "";
            // 
            // SdersIDlabel
            // 
            this.SdersIDlabel.BackColor = System.Drawing.Color.LightCoral;
            this.SdersIDlabel.Location = new System.Drawing.Point(243, 359);
            this.SdersIDlabel.Name = "SdersIDlabel";
            this.SdersIDlabel.Size = new System.Drawing.Size(132, 55);
            this.SdersIDlabel.TabIndex = 15;
            this.SdersIDlabel.Text = "Silinecek Ders ID";
            this.SdersIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YılLabel
            // 
            this.YılLabel.BackColor = System.Drawing.Color.LightCoral;
            this.YılLabel.Location = new System.Drawing.Point(243, 298);
            this.YılLabel.Name = "YılLabel";
            this.YılLabel.Size = new System.Drawing.Size(132, 55);
            this.YılLabel.TabIndex = 13;
            this.YılLabel.Text = "Yıl";
            this.YılLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DonemLabel
            // 
            this.DonemLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DonemLabel.Location = new System.Drawing.Point(243, 237);
            this.DonemLabel.Name = "DonemLabel";
            this.DonemLabel.Size = new System.Drawing.Size(132, 55);
            this.DonemLabel.TabIndex = 11;
            this.DonemLabel.Text = "Dönem";
            this.DonemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciIDTextBox
            // 
            this.OgrenciIDTextBox.Location = new System.Drawing.Point(463, 176);
            this.OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            this.OgrenciIDTextBox.Size = new System.Drawing.Size(177, 55);
            this.OgrenciIDTextBox.TabIndex = 10;
            this.OgrenciIDTextBox.Text = "";
            // 
            // OgrenciIDLabel
            // 
            this.OgrenciIDLabel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciIDLabel.Location = new System.Drawing.Point(243, 176);
            this.OgrenciIDLabel.Name = "OgrenciIDLabel";
            this.OgrenciIDLabel.Size = new System.Drawing.Size(132, 55);
            this.OgrenciIDLabel.TabIndex = 9;
            this.OgrenciIDLabel.Text = "Öğrenci ID";
            this.OgrenciIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EDersIDTextBox
            // 
            this.EDersIDTextBox.Location = new System.Drawing.Point(463, 420);
            this.EDersIDTextBox.Name = "EDersIDTextBox";
            this.EDersIDTextBox.Size = new System.Drawing.Size(177, 55);
            this.EDersIDTextBox.TabIndex = 19;
            this.EDersIDTextBox.Text = "";
            // 
            // EDersIDlabel
            // 
            this.EDersIDlabel.BackColor = System.Drawing.Color.LightCoral;
            this.EDersIDlabel.Location = new System.Drawing.Point(243, 420);
            this.EDersIDlabel.Name = "EDersIDlabel";
            this.EDersIDlabel.Size = new System.Drawing.Size(132, 55);
            this.EDersIDlabel.TabIndex = 18;
            this.EDersIDlabel.Text = "Eklencek Ders ID";
            this.EDersIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anasayfaLabel
            // 
            this.anasayfaLabel.BackColor = System.Drawing.Color.SeaShell;
            this.anasayfaLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaLabel.Location = new System.Drawing.Point(187, 31);
            this.anasayfaLabel.Name = "anasayfaLabel";
            this.anasayfaLabel.Size = new System.Drawing.Size(510, 128);
            this.anasayfaLabel.TabIndex = 26;
            this.anasayfaLabel.Text = "DERS DEĞİŞTİRME";
            this.anasayfaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // föy5DataSetBindingSource1
            // 
            this.föy5DataSetBindingSource1.DataSource = this.föy5DataSet;
            this.föy5DataSetBindingSource1.Position = 0;
            // 
            // tOgrenciDersTableAdapter
            // 
            this.tOgrenciDersTableAdapter.ClearBeforeFill = true;
            // 
            // föy5DataSetBindingSource
            // 
            this.föy5DataSetBindingSource.DataSource = this.föy5DataSet;
            this.föy5DataSetBindingSource.Position = 0;
            // 
            // tOgrenciDersBindingSource1
            // 
            this.tOgrenciDersBindingSource1.DataMember = "tOgrenciDers";
            this.tOgrenciDersBindingSource1.DataSource = this.föy5DataSet;
            // 
            // yariyilTextBox
            // 
            this.yariyilTextBox.Location = new System.Drawing.Point(463, 237);
            this.yariyilTextBox.Name = "yariyilTextBox";
            this.yariyilTextBox.Size = new System.Drawing.Size(177, 55);
            this.yariyilTextBox.TabIndex = 27;
            this.yariyilTextBox.Text = "";
            // 
            // yilTextBox
            // 
            this.yilTextBox.Location = new System.Drawing.Point(463, 298);
            this.yilTextBox.Name = "yilTextBox";
            this.yilTextBox.Size = new System.Drawing.Size(177, 55);
            this.yilTextBox.TabIndex = 28;
            this.yilTextBox.Text = "";
            // 
            // DersDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.yilTextBox);
            this.Controls.Add(this.yariyilTextBox);
            this.Controls.Add(this.anasayfaLabel);
            this.Controls.Add(this.EDersIDTextBox);
            this.Controls.Add(this.EDersIDlabel);
            this.Controls.Add(this.OnaylaButon);
            this.Controls.Add(this.SDersIDTextBox);
            this.Controls.Add(this.SdersIDlabel);
            this.Controls.Add(this.YılLabel);
            this.Controls.Add(this.DonemLabel);
            this.Controls.Add(this.OgrenciIDTextBox);
            this.Controls.Add(this.OgrenciIDLabel);
            this.Name = "DersDegistirme";
            this.Text = "DersDegistirme";
            this.Load += new System.EventHandler(this.DersDegistirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.föy5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrenciDersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OnaylaButon;
        private System.Windows.Forms.RichTextBox SDersIDTextBox;
        private System.Windows.Forms.Label SdersIDlabel;
        private System.Windows.Forms.Label YılLabel;
        private System.Windows.Forms.Label DonemLabel;
        private System.Windows.Forms.RichTextBox OgrenciIDTextBox;
        private System.Windows.Forms.Label OgrenciIDLabel;
        private System.Windows.Forms.RichTextBox EDersIDTextBox;
        private System.Windows.Forms.Label EDersIDlabel;
        private System.Windows.Forms.Label anasayfaLabel;
        private föy5DataSet föy5DataSet;
        private System.Windows.Forms.BindingSource tOgrenciDersBindingSource;
        private föy5DataSetTableAdapters.tOgrenciDersTableAdapter tOgrenciDersTableAdapter;
        private System.Windows.Forms.BindingSource tOgrenciDersBindingSource1;
        private System.Windows.Forms.BindingSource föy5DataSetBindingSource1;
        private System.Windows.Forms.BindingSource föy5DataSetBindingSource;
        private System.Windows.Forms.RichTextBox yariyilTextBox;
        private System.Windows.Forms.RichTextBox yilTextBox;
    }
}