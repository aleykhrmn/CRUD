namespace WindowsFormsApp1
{
    partial class DersSil
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
            this.DersIDLabel = new System.Windows.Forms.Label();
            this.DersIDRichText = new System.Windows.Forms.RichTextBox();
            this.SilButon = new System.Windows.Forms.Button();
            this.DersEkleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DersIDLabel
            // 
            this.DersIDLabel.BackColor = System.Drawing.Color.LightCoral;
            this.DersIDLabel.Location = new System.Drawing.Point(231, 274);
            this.DersIDLabel.Name = "DersIDLabel";
            this.DersIDLabel.Size = new System.Drawing.Size(157, 70);
            this.DersIDLabel.TabIndex = 0;
            this.DersIDLabel.Text = "Ders ID";
            this.DersIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersIDRichText
            // 
            this.DersIDRichText.Location = new System.Drawing.Point(464, 274);
            this.DersIDRichText.Name = "DersIDRichText";
            this.DersIDRichText.Size = new System.Drawing.Size(231, 70);
            this.DersIDRichText.TabIndex = 1;
            this.DersIDRichText.Text = "";
            // 
            // SilButon
            // 
            this.SilButon.BackColor = System.Drawing.Color.IndianRed;
            this.SilButon.Location = new System.Drawing.Point(604, 384);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(91, 43);
            this.SilButon.TabIndex = 2;
            this.SilButon.Text = "Sil";
            this.SilButon.UseVisualStyleBackColor = false;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // DersEkleLabel
            // 
            this.DersEkleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.DersEkleLabel.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersEkleLabel.Location = new System.Drawing.Point(229, 98);
            this.DersEkleLabel.Name = "DersEkleLabel";
            this.DersEkleLabel.Size = new System.Drawing.Size(466, 127);
            this.DersEkleLabel.TabIndex = 6;
            this.DersEkleLabel.Text = "DERS SİL";
            this.DersEkleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DersSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.DersEkleLabel);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.DersIDRichText);
            this.Controls.Add(this.DersIDLabel);
            this.Name = "DersSil";
            this.Text = "DersSil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DersIDLabel;
        private System.Windows.Forms.RichTextBox DersIDRichText;
        private System.Windows.Forms.Button SilButon;
        private System.Windows.Forms.Label DersEkleLabel;
    }
}