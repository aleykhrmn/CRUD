namespace WindowsFormsApp1
{
    partial class Kayıt
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
            this.DersAtamaButon = new System.Windows.Forms.Button();
            this.DersSilmeButon = new System.Windows.Forms.Button();
            this.DersDegistirmeButon = new System.Windows.Forms.Button();
            this.anasayfaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DersAtamaButon
            // 
            this.DersAtamaButon.BackColor = System.Drawing.Color.LightCoral;
            this.DersAtamaButon.Location = new System.Drawing.Point(326, 239);
            this.DersAtamaButon.Name = "DersAtamaButon";
            this.DersAtamaButon.Size = new System.Drawing.Size(257, 83);
            this.DersAtamaButon.TabIndex = 0;
            this.DersAtamaButon.Text = "Ders Atama";
            this.DersAtamaButon.UseVisualStyleBackColor = false;
            this.DersAtamaButon.Click += new System.EventHandler(this.DersAtamaButon_Click);
            // 
            // DersSilmeButon
            // 
            this.DersSilmeButon.BackColor = System.Drawing.Color.LightCoral;
            this.DersSilmeButon.Location = new System.Drawing.Point(326, 328);
            this.DersSilmeButon.Name = "DersSilmeButon";
            this.DersSilmeButon.Size = new System.Drawing.Size(257, 83);
            this.DersSilmeButon.TabIndex = 1;
            this.DersSilmeButon.Text = "Ders Silme";
            this.DersSilmeButon.UseVisualStyleBackColor = false;
            this.DersSilmeButon.Click += new System.EventHandler(this.DersSilmeButon_Click);
            // 
            // DersDegistirmeButon
            // 
            this.DersDegistirmeButon.BackColor = System.Drawing.Color.LightCoral;
            this.DersDegistirmeButon.Location = new System.Drawing.Point(326, 417);
            this.DersDegistirmeButon.Name = "DersDegistirmeButon";
            this.DersDegistirmeButon.Size = new System.Drawing.Size(257, 83);
            this.DersDegistirmeButon.TabIndex = 2;
            this.DersDegistirmeButon.Text = "Ders Değiştirme";
            this.DersDegistirmeButon.UseVisualStyleBackColor = false;
            this.DersDegistirmeButon.Click += new System.EventHandler(this.DersDegistirmeButon_Click);
            // 
            // anasayfaLabel
            // 
            this.anasayfaLabel.BackColor = System.Drawing.Color.SeaShell;
            this.anasayfaLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaLabel.Location = new System.Drawing.Point(197, 44);
            this.anasayfaLabel.Name = "anasayfaLabel";
            this.anasayfaLabel.Size = new System.Drawing.Size(510, 158);
            this.anasayfaLabel.TabIndex = 25;
            this.anasayfaLabel.Text = "ÖĞRENCİ DERS\r\nİŞLEMLERİ";
            this.anasayfaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.anasayfaLabel);
            this.Controls.Add(this.DersDegistirmeButon);
            this.Controls.Add(this.DersSilmeButon);
            this.Controls.Add(this.DersAtamaButon);
            this.Name = "Kayıt";
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.Kayıt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DersAtamaButon;
        private System.Windows.Forms.Button DersSilmeButon;
        private System.Windows.Forms.Button DersDegistirmeButon;
        private System.Windows.Forms.Label anasayfaLabel;
    }
}