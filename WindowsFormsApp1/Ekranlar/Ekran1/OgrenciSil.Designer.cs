namespace WindowsFormsApp1
{
    partial class OgrenciSil
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
            this.OgrenciIDlabel = new System.Windows.Forms.Label();
            this.OgrenciIDrichText = new System.Windows.Forms.RichTextBox();
            this.SilButon = new System.Windows.Forms.Button();
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OgrenciIDlabel
            // 
            this.OgrenciIDlabel.BackColor = System.Drawing.Color.LightCoral;
            this.OgrenciIDlabel.Location = new System.Drawing.Point(230, 264);
            this.OgrenciIDlabel.Name = "OgrenciIDlabel";
            this.OgrenciIDlabel.Size = new System.Drawing.Size(196, 58);
            this.OgrenciIDlabel.TabIndex = 0;
            this.OgrenciIDlabel.Text = "Öğrenci ID";
            this.OgrenciIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciIDrichText
            // 
            this.OgrenciIDrichText.Location = new System.Drawing.Point(471, 264);
            this.OgrenciIDrichText.Name = "OgrenciIDrichText";
            this.OgrenciIDrichText.Size = new System.Drawing.Size(216, 58);
            this.OgrenciIDrichText.TabIndex = 1;
            this.OgrenciIDrichText.Text = "";
            // 
            // SilButon
            // 
            this.SilButon.BackColor = System.Drawing.Color.IndianRed;
            this.SilButon.Location = new System.Drawing.Point(551, 367);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(136, 49);
            this.SilButon.TabIndex = 2;
            this.SilButon.Text = "Sil";
            this.SilButon.UseVisualStyleBackColor = false;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(233, 65);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(454, 108);
            this.DersEkleLabel.TabIndex = 10;
            this.DersEkleLabel.Text = "ÖĞRENCİ SİL";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.OgrenciIDrichText);
            this.Controls.Add(this.OgrenciIDlabel);
            this.Name = "OgrenciSil";
            this.Text = "OgrenciSil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OgrenciIDlabel;
        private System.Windows.Forms.RichTextBox OgrenciIDrichText;
        private System.Windows.Forms.Button SilButon;
        private System.Windows.Forms.Label DersEkleLabel;
    }
}