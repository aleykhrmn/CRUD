namespace WindowsFormsApp1
{
    partial class BolumSil
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
            this.SilButon = new System.Windows.Forms.Button();
            this.BolumIDTextBox = new System.Windows.Forms.RichTextBox();
            this.BölümIDLabel = new System.Windows.Forms.Label();
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SilButon
            // 
            this.SilButon.BackColor = System.Drawing.Color.IndianRed;
            this.SilButon.Location = new System.Drawing.Point(557, 328);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(107, 51);
            this.SilButon.TabIndex = 5;
            this.SilButon.Text = "Sil";
            this.SilButon.UseVisualStyleBackColor = false;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // BolumIDTextBox
            // 
            this.BolumIDTextBox.Location = new System.Drawing.Point(446, 253);
            this.BolumIDTextBox.Name = "BolumIDTextBox";
            this.BolumIDTextBox.Size = new System.Drawing.Size(218, 57);
            this.BolumIDTextBox.TabIndex = 4;
            this.BolumIDTextBox.Text = "";
            // 
            // BölümIDLabel
            // 
            this.BölümIDLabel.BackColor = System.Drawing.Color.LightCoral;
            this.BölümIDLabel.Location = new System.Drawing.Point(207, 252);
            this.BölümIDLabel.Name = "BölümIDLabel";
            this.BölümIDLabel.Size = new System.Drawing.Size(177, 58);
            this.BölümIDLabel.TabIndex = 3;
            this.BölümIDLabel.Text = "Bölüm ID";
            this.BölümIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(210, 67);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(454, 122);
            this.DersEkleLabel.TabIndex = 16;
            this.DersEkleLabel.Text = "BÖLÜM SİL";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BolumSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.BolumIDTextBox);
            this.Controls.Add(this.BölümIDLabel);
            this.Name = "BolumSil";
            this.Text = "BolumSil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SilButon;
        private System.Windows.Forms.RichTextBox BolumIDTextBox;
        private System.Windows.Forms.Label BölümIDLabel;
        private System.Windows.Forms.Label DersEkleLabel;
    }
}