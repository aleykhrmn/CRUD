namespace WindowsFormsApp1
{
    partial class Ders
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
            this.Dguncellestirmebuton = new System.Windows.Forms.Button();
            this.DsilButon = new System.Windows.Forms.Button();
            this.DlisteleButon = new System.Windows.Forms.Button();
            this.DekleButon = new System.Windows.Forms.Button();
            this.OgrenciYazı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dguncellestirmebuton
            // 
            this.Dguncellestirmebuton.BackColor = System.Drawing.Color.LightCoral;
            this.Dguncellestirmebuton.Location = new System.Drawing.Point(455, 366);
            this.Dguncellestirmebuton.Name = "Dguncellestirmebuton";
            this.Dguncellestirmebuton.Size = new System.Drawing.Size(200, 70);
            this.Dguncellestirmebuton.TabIndex = 9;
            this.Dguncellestirmebuton.Text = "Güncelleştirme";
            this.Dguncellestirmebuton.UseVisualStyleBackColor = false;
            this.Dguncellestirmebuton.Click += new System.EventHandler(this.Dguncellestirmebuton_Click);
            // 
            // DsilButon
            // 
            this.DsilButon.BackColor = System.Drawing.Color.LightCoral;
            this.DsilButon.Location = new System.Drawing.Point(455, 267);
            this.DsilButon.Name = "DsilButon";
            this.DsilButon.Size = new System.Drawing.Size(200, 70);
            this.DsilButon.TabIndex = 8;
            this.DsilButon.Text = "Sil";
            this.DsilButon.UseVisualStyleBackColor = false;
            this.DsilButon.Click += new System.EventHandler(this.DsilButon_Click);
            // 
            // DlisteleButon
            // 
            this.DlisteleButon.BackColor = System.Drawing.Color.LightCoral;
            this.DlisteleButon.Location = new System.Drawing.Point(225, 366);
            this.DlisteleButon.Name = "DlisteleButon";
            this.DlisteleButon.Size = new System.Drawing.Size(200, 70);
            this.DlisteleButon.TabIndex = 7;
            this.DlisteleButon.Text = "Listele";
            this.DlisteleButon.UseVisualStyleBackColor = false;
            this.DlisteleButon.Click += new System.EventHandler(this.DlisteleButon_Click);
            // 
            // DekleButon
            // 
            this.DekleButon.BackColor = System.Drawing.Color.LightCoral;
            this.DekleButon.Location = new System.Drawing.Point(225, 267);
            this.DekleButon.Name = "DekleButon";
            this.DekleButon.Size = new System.Drawing.Size(200, 70);
            this.DekleButon.TabIndex = 6;
            this.DekleButon.Text = "Ekle";
            this.DekleButon.UseVisualStyleBackColor = false;
            this.DekleButon.Click += new System.EventHandler(this.DekleButon_Click);
            // 
            // OgrenciYazı
            // 
            this.OgrenciYazı.BackColor = System.Drawing.Color.SeaShell;
            this.OgrenciYazı.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciYazı.Location = new System.Drawing.Point(225, 84);
            this.OgrenciYazı.Name = "OgrenciYazı";
            this.OgrenciYazı.Size = new System.Drawing.Size(430, 123);
            this.OgrenciYazı.TabIndex = 5;
            this.OgrenciYazı.Text = "Ders CRUD";
            this.OgrenciYazı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.Dguncellestirmebuton);
            this.Controls.Add(this.DsilButon);
            this.Controls.Add(this.DlisteleButon);
            this.Controls.Add(this.DekleButon);
            this.Controls.Add(this.OgrenciYazı);
            this.Name = "Ders";
            this.Text = "Ders";
            this.Load += new System.EventHandler(this.Ders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dguncellestirmebuton;
        private System.Windows.Forms.Button DsilButon;
        private System.Windows.Forms.Button DlisteleButon;
        private System.Windows.Forms.Button DekleButon;
        private System.Windows.Forms.Label OgrenciYazı;
    }
}