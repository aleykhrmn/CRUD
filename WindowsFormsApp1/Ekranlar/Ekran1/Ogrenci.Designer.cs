namespace WindowsFormsApp1
{
    partial class Ogrenci
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
            this.OekleButon = new System.Windows.Forms.Button();
            this.OlisteleButon = new System.Windows.Forms.Button();
            this.OsilButon = new System.Windows.Forms.Button();
            this.Oguncellestirmebuton = new System.Windows.Forms.Button();
            this.OgrenciYazı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OekleButon
            // 
            this.OekleButon.BackColor = System.Drawing.Color.LightCoral;
            this.OekleButon.Location = new System.Drawing.Point(241, 248);
            this.OekleButon.Name = "OekleButon";
            this.OekleButon.Size = new System.Drawing.Size(200, 70);
            this.OekleButon.TabIndex = 1;
            this.OekleButon.Text = "Ekle";
            this.OekleButon.UseVisualStyleBackColor = false;
            this.OekleButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // OlisteleButon
            // 
            this.OlisteleButon.BackColor = System.Drawing.Color.LightCoral;
            this.OlisteleButon.Location = new System.Drawing.Point(241, 347);
            this.OlisteleButon.Name = "OlisteleButon";
            this.OlisteleButon.Size = new System.Drawing.Size(200, 70);
            this.OlisteleButon.TabIndex = 2;
            this.OlisteleButon.Text = "Listele";
            this.OlisteleButon.UseVisualStyleBackColor = false;
            this.OlisteleButon.Click += new System.EventHandler(this.OlisteleButon_Click);
            // 
            // OsilButon
            // 
            this.OsilButon.BackColor = System.Drawing.Color.LightCoral;
            this.OsilButon.Location = new System.Drawing.Point(471, 248);
            this.OsilButon.Name = "OsilButon";
            this.OsilButon.Size = new System.Drawing.Size(200, 70);
            this.OsilButon.TabIndex = 3;
            this.OsilButon.Text = "Sil";
            this.OsilButon.UseVisualStyleBackColor = false;
            this.OsilButon.Click += new System.EventHandler(this.OsilButon_Click);
            // 
            // Oguncellestirmebuton
            // 
            this.Oguncellestirmebuton.BackColor = System.Drawing.Color.LightCoral;
            this.Oguncellestirmebuton.Location = new System.Drawing.Point(471, 347);
            this.Oguncellestirmebuton.Name = "Oguncellestirmebuton";
            this.Oguncellestirmebuton.Size = new System.Drawing.Size(200, 70);
            this.Oguncellestirmebuton.TabIndex = 4;
            this.Oguncellestirmebuton.Text = "Güncelleştirme";
            this.Oguncellestirmebuton.UseVisualStyleBackColor = false;
            this.Oguncellestirmebuton.Click += new System.EventHandler(this.Oguncellestirmebuton_Click);
            // 
            // OgrenciYazı
            // 
            this.OgrenciYazı.BackColor = System.Drawing.Color.SeaShell;
            this.OgrenciYazı.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciYazı.Location = new System.Drawing.Point(241, 85);
            this.OgrenciYazı.Name = "OgrenciYazı";
            this.OgrenciYazı.Size = new System.Drawing.Size(430, 95);
            this.OgrenciYazı.TabIndex = 0;
            this.OgrenciYazı.Text = "Öğrenci CRUD";
            this.OgrenciYazı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OgrenciYazı.Click += new System.EventHandler(this.OgrenciYazı_Click);
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.Oguncellestirmebuton);
            this.Controls.Add(this.OsilButon);
            this.Controls.Add(this.OlisteleButon);
            this.Controls.Add(this.OekleButon);
            this.Controls.Add(this.OgrenciYazı);
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OekleButon;
        private System.Windows.Forms.Button OlisteleButon;
        private System.Windows.Forms.Button OsilButon;
        private System.Windows.Forms.Button Oguncellestirmebuton;
        private System.Windows.Forms.Label OgrenciYazı;
    }
}