namespace WindowsFormsApp1
{
    partial class OgrenciGüncelle
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
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.BolumIDTextBox = new System.Windows.Forms.RichTextBox();
            this.bolumIDrichtext = new System.Windows.Forms.Label();
            this.SoyadTextBox = new System.Windows.Forms.RichTextBox();
            this.OgrenciSoyadıLabel = new System.Windows.Forms.Label();
            this.AdTextBox = new System.Windows.Forms.RichTextBox();
            this.OgrenciIDTextBox = new System.Windows.Forms.RichTextBox();
            this.OgrenciAdi = new System.Windows.Forms.Label();
            this.Guncelle = new System.Windows.Forms.Button();
            this.OgrenciEkleLAbel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(214, 26);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(454, 132);
            this.DersEkleLabel.TabIndex = 19;
            this.DersEkleLabel.Text = "ÖĞRENCİ GÜNCELLEME";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BolumIDTextBox
            // 
            this.BolumIDTextBox.Location = new System.Drawing.Point(449, 405);
            this.BolumIDTextBox.Name = "BolumIDTextBox";
            this.BolumIDTextBox.Size = new System.Drawing.Size(219, 58);
            this.BolumIDTextBox.TabIndex = 18;
            this.BolumIDTextBox.Text = "";
            // 
            // bolumIDrichtext
            // 
            this.bolumIDrichtext.BackColor = System.Drawing.Color.LightCoral;
            this.bolumIDrichtext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bolumIDrichtext.Location = new System.Drawing.Point(219, 405);
            this.bolumIDrichtext.Name = "bolumIDrichtext";
            this.bolumIDrichtext.Size = new System.Drawing.Size(162, 58);
            this.bolumIDrichtext.TabIndex = 17;
            this.bolumIDrichtext.Text = "Bölüm ID";
            this.bolumIDrichtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Location = new System.Drawing.Point(449, 252);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(219, 58);
            this.SoyadTextBox.TabIndex = 16;
            this.SoyadTextBox.Text = "";
            // 
            // OgrenciSoyadıLabel
            // 
            this.OgrenciSoyadıLabel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciSoyadıLabel.Location = new System.Drawing.Point(219, 252);
            this.OgrenciSoyadıLabel.Name = "OgrenciSoyadıLabel";
            this.OgrenciSoyadıLabel.Size = new System.Drawing.Size(162, 58);
            this.OgrenciSoyadıLabel.TabIndex = 15;
            this.OgrenciSoyadıLabel.Text = "Soyadı";
            this.OgrenciSoyadıLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdTextBox
            // 
            this.AdTextBox.Location = new System.Drawing.Point(449, 179);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(219, 58);
            this.AdTextBox.TabIndex = 14;
            this.AdTextBox.Text = "";
            // 
            // OgrenciIDTextBox
            // 
            this.OgrenciIDTextBox.Location = new System.Drawing.Point(449, 327);
            this.OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            this.OgrenciIDTextBox.Size = new System.Drawing.Size(219, 58);
            this.OgrenciIDTextBox.TabIndex = 13;
            this.OgrenciIDTextBox.Text = "";
            // 
            // OgrenciAdi
            // 
            this.OgrenciAdi.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciAdi.Location = new System.Drawing.Point(219, 179);
            this.OgrenciAdi.Name = "OgrenciAdi";
            this.OgrenciAdi.Size = new System.Drawing.Size(162, 58);
            this.OgrenciAdi.TabIndex = 12;
            this.OgrenciAdi.Text = "Adı";
            this.OgrenciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Guncelle
            // 
            this.Guncelle.BackColor = System.Drawing.Color.IndianRed;
            this.Guncelle.Location = new System.Drawing.Point(565, 482);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(103, 44);
            this.Guncelle.TabIndex = 11;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // OgrenciEkleLAbel
            // 
            this.OgrenciEkleLAbel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciEkleLAbel.Location = new System.Drawing.Point(219, 327);
            this.OgrenciEkleLAbel.Name = "OgrenciEkleLAbel";
            this.OgrenciEkleLAbel.Size = new System.Drawing.Size(162, 58);
            this.OgrenciEkleLAbel.TabIndex = 10;
            this.OgrenciEkleLAbel.Text = "No ";
            this.OgrenciEkleLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.BolumIDTextBox);
            this.Controls.Add(this.bolumIDrichtext);
            this.Controls.Add(this.SoyadTextBox);
            this.Controls.Add(this.OgrenciSoyadıLabel);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.OgrenciIDTextBox);
            this.Controls.Add(this.OgrenciAdi);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.OgrenciEkleLAbel);
            this.Name = "OgrenciGüncelle";
            this.Text = "OgrenciGüncelle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DersEkleLabel;
        private System.Windows.Forms.RichTextBox BolumIDTextBox;
        private System.Windows.Forms.Label bolumIDrichtext;
        private System.Windows.Forms.RichTextBox SoyadTextBox;
        private System.Windows.Forms.Label OgrenciSoyadıLabel;
        private System.Windows.Forms.RichTextBox AdTextBox;
        private System.Windows.Forms.RichTextBox OgrenciIDTextBox;
        private System.Windows.Forms.Label OgrenciAdi;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Label OgrenciEkleLAbel;
    }
}