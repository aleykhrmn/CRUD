namespace WindowsFormsApp1
{
    partial class OgrenciEkle
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
            this.OgrenciEkleLAbel = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.OgrenciAdi = new System.Windows.Forms.Label();
            this.OgrenciNorichText = new System.Windows.Forms.RichTextBox();
            this.OgrenciAdiRichText = new System.Windows.Forms.RichTextBox();
            this.OgrenciSoyadıLabel = new System.Windows.Forms.Label();
            this.OgrenciSoyadıRichtext = new System.Windows.Forms.RichTextBox();
            this.bolumIDrichtext = new System.Windows.Forms.Label();
            this.Bıdrichtext = new System.Windows.Forms.RichTextBox();
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OgrenciEkleLAbel
            // 
            this.OgrenciEkleLAbel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciEkleLAbel.Location = new System.Drawing.Point(210, 325);
            this.OgrenciEkleLAbel.Name = "OgrenciEkleLAbel";
            this.OgrenciEkleLAbel.Size = new System.Drawing.Size(162, 58);
            this.OgrenciEkleLAbel.TabIndex = 0;
            this.OgrenciEkleLAbel.Text = "No ";
            this.OgrenciEkleLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OgrenciEkleLAbel.Click += new System.EventHandler(this.OgrenciEkleLAbel_Click);
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.IndianRed;
            this.Ekle.Location = new System.Drawing.Point(556, 480);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(103, 44);
            this.Ekle.TabIndex = 1;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // OgrenciAdi
            // 
            this.OgrenciAdi.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciAdi.Location = new System.Drawing.Point(210, 177);
            this.OgrenciAdi.Name = "OgrenciAdi";
            this.OgrenciAdi.Size = new System.Drawing.Size(162, 58);
            this.OgrenciAdi.TabIndex = 2;
            this.OgrenciAdi.Text = "Adı";
            this.OgrenciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciNorichText
            // 
            this.OgrenciNorichText.Location = new System.Drawing.Point(440, 325);
            this.OgrenciNorichText.Name = "OgrenciNorichText";
            this.OgrenciNorichText.Size = new System.Drawing.Size(219, 58);
            this.OgrenciNorichText.TabIndex = 3;
            this.OgrenciNorichText.Text = "";
            // 
            // OgrenciAdiRichText
            // 
            this.OgrenciAdiRichText.Location = new System.Drawing.Point(440, 177);
            this.OgrenciAdiRichText.Name = "OgrenciAdiRichText";
            this.OgrenciAdiRichText.Size = new System.Drawing.Size(219, 58);
            this.OgrenciAdiRichText.TabIndex = 4;
            this.OgrenciAdiRichText.Text = "";
            // 
            // OgrenciSoyadıLabel
            // 
            this.OgrenciSoyadıLabel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciSoyadıLabel.Location = new System.Drawing.Point(210, 250);
            this.OgrenciSoyadıLabel.Name = "OgrenciSoyadıLabel";
            this.OgrenciSoyadıLabel.Size = new System.Drawing.Size(162, 58);
            this.OgrenciSoyadıLabel.TabIndex = 5;
            this.OgrenciSoyadıLabel.Text = "Soyadı";
            this.OgrenciSoyadıLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciSoyadıRichtext
            // 
            this.OgrenciSoyadıRichtext.Location = new System.Drawing.Point(440, 250);
            this.OgrenciSoyadıRichtext.Name = "OgrenciSoyadıRichtext";
            this.OgrenciSoyadıRichtext.Size = new System.Drawing.Size(219, 58);
            this.OgrenciSoyadıRichtext.TabIndex = 6;
            this.OgrenciSoyadıRichtext.Text = "";
            // 
            // bolumIDrichtext
            // 
            this.bolumIDrichtext.BackColor = System.Drawing.Color.LightCoral;
            this.bolumIDrichtext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bolumIDrichtext.Location = new System.Drawing.Point(210, 403);
            this.bolumIDrichtext.Name = "bolumIDrichtext";
            this.bolumIDrichtext.Size = new System.Drawing.Size(162, 58);
            this.bolumIDrichtext.TabIndex = 7;
            this.bolumIDrichtext.Text = "Bölüm ID";
            this.bolumIDrichtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bıdrichtext
            // 
            this.Bıdrichtext.Location = new System.Drawing.Point(440, 403);
            this.Bıdrichtext.Name = "Bıdrichtext";
            this.Bıdrichtext.Size = new System.Drawing.Size(219, 58);
            this.Bıdrichtext.TabIndex = 8;
            this.Bıdrichtext.Text = "";
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(205, 24);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(454, 132);
            this.DersEkleLabel.TabIndex = 9;
            this.DersEkleLabel.Text = "ÖĞRENCİ EKLE";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.Bıdrichtext);
            this.Controls.Add(this.bolumIDrichtext);
            this.Controls.Add(this.OgrenciSoyadıRichtext);
            this.Controls.Add(this.OgrenciSoyadıLabel);
            this.Controls.Add(this.OgrenciAdiRichText);
            this.Controls.Add(this.OgrenciNorichText);
            this.Controls.Add(this.OgrenciAdi);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.OgrenciEkleLAbel);
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OgrenciEkleLAbel;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Label OgrenciAdi;
        private System.Windows.Forms.RichTextBox OgrenciNorichText;
        private System.Windows.Forms.RichTextBox OgrenciAdiRichText;
        private System.Windows.Forms.Label OgrenciSoyadıLabel;
        private System.Windows.Forms.RichTextBox OgrenciSoyadıRichtext;
        private System.Windows.Forms.Label bolumIDrichtext;
        private System.Windows.Forms.RichTextBox Bıdrichtext;
        private System.Windows.Forms.Label DersEkleLabel;
    }
}