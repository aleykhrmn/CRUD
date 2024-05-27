namespace WindowsFormsApp1
{
    partial class Ekran5
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
            this.YBListeleme = new System.Windows.Forms.Button();
            this.OBListeleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(194, 79);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(508, 125);
            this.DersEkleLabel.TabIndex = 17;
            this.DersEkleLabel.Text = "LİSTELEME EKRANI";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YBListeleme
            // 
            this.YBListeleme.BackColor = System.Drawing.Color.LightCoral;
            this.YBListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YBListeleme.Location = new System.Drawing.Point(469, 271);
            this.YBListeleme.Name = "YBListeleme";
            this.YBListeleme.Size = new System.Drawing.Size(233, 100);
            this.YBListeleme.TabIndex = 19;
            this.YBListeleme.Text = "Yıl Bazlı\r\nListeleme";
            this.YBListeleme.UseVisualStyleBackColor = false;
            this.YBListeleme.Click += new System.EventHandler(this.YBListeleme_Click);
            // 
            // OBListeleme
            // 
            this.OBListeleme.BackColor = System.Drawing.Color.LightCoral;
            this.OBListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OBListeleme.Location = new System.Drawing.Point(199, 271);
            this.OBListeleme.Name = "OBListeleme";
            this.OBListeleme.Size = new System.Drawing.Size(233, 100);
            this.OBListeleme.TabIndex = 20;
            this.OBListeleme.Text = "Öğrenci Bazlı\r\nListeleme";
            this.OBListeleme.UseVisualStyleBackColor = false;
            this.OBListeleme.Click += new System.EventHandler(this.OBListeleme_Click_1);
            // 
            // Ekran5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.OBListeleme);
            this.Controls.Add(this.YBListeleme);
            this.Controls.Add(this.DersEkleLabel);
            this.Name = "Ekran5";
            this.Text = "Ekran5";
            this.Load += new System.EventHandler(this.Ekran5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DersEkleLabel;
        private System.Windows.Forms.Button YBListeleme;
        private System.Windows.Forms.Button OBListeleme;
    }
}