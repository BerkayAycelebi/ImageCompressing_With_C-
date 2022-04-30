namespace ResimSikistirma
{
    partial class Form1
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
            this.aquaGauge1 = new AquaControls.AquaGauge();
            this.Sikistir_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ResimSec_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CCITT4_radioButton = new System.Windows.Forms.RadioButton();
            this.CCITT3_radioButton = new System.Windows.Forms.RadioButton();
            this.LZW_radioButton = new System.Windows.Forms.RadioButton();
            this.RLE_radioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResimAd_label = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aquaGauge1
            // 
            this.aquaGauge1.BackColor = System.Drawing.Color.Transparent;
            this.aquaGauge1.DialColor = System.Drawing.Color.Lavender;
            this.aquaGauge1.DialText = null;
            this.aquaGauge1.Glossiness = 11.36364F;
            this.aquaGauge1.Location = new System.Drawing.Point(12, 276);
            this.aquaGauge1.MaxValue = 100F;
            this.aquaGauge1.MinValue = 0F;
            this.aquaGauge1.Name = "aquaGauge1";
            this.aquaGauge1.RecommendedValue = 0F;
            this.aquaGauge1.Size = new System.Drawing.Size(150, 150);
            this.aquaGauge1.TabIndex = 0;
            this.aquaGauge1.ThresholdPercent = 1F;
            this.aquaGauge1.Value = 0F;
            // 
            // Sikistir_button
            // 
            this.Sikistir_button.Location = new System.Drawing.Point(6, 153);
            this.Sikistir_button.Name = "Sikistir_button";
            this.Sikistir_button.Size = new System.Drawing.Size(138, 40);
            this.Sikistir_button.TabIndex = 1;
            this.Sikistir_button.Text = "SIKIŞTIR";
            this.Sikistir_button.UseVisualStyleBackColor = true;
            this.Sikistir_button.Click += new System.EventHandler(this.Sikistir_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ResimSec_button
            // 
            this.ResimSec_button.Location = new System.Drawing.Point(12, 12);
            this.ResimSec_button.Name = "ResimSec_button";
            this.ResimSec_button.Size = new System.Drawing.Size(150, 40);
            this.ResimSec_button.TabIndex = 2;
            this.ResimSec_button.Text = "Resim Seç";
            this.ResimSec_button.UseVisualStyleBackColor = true;
            this.ResimSec_button.Click += new System.EventHandler(this.ResimSec_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CCITT4_radioButton);
            this.groupBox1.Controls.Add(this.CCITT3_radioButton);
            this.groupBox1.Controls.Add(this.LZW_radioButton);
            this.groupBox1.Controls.Add(this.RLE_radioButton);
            this.groupBox1.Controls.Add(this.Sikistir_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıkıştırma Türü";
            // 
            // CCITT4_radioButton
            // 
            this.CCITT4_radioButton.AutoSize = true;
            this.CCITT4_radioButton.Location = new System.Drawing.Point(28, 116);
            this.CCITT4_radioButton.Name = "CCITT4_radioButton";
            this.CCITT4_radioButton.Size = new System.Drawing.Size(65, 17);
            this.CCITT4_radioButton.TabIndex = 5;
            this.CCITT4_radioButton.TabStop = true;
            this.CCITT4_radioButton.Text = "CCITT-4";
            this.CCITT4_radioButton.UseVisualStyleBackColor = true;
            // 
            // CCITT3_radioButton
            // 
            this.CCITT3_radioButton.AutoSize = true;
            this.CCITT3_radioButton.Location = new System.Drawing.Point(28, 87);
            this.CCITT3_radioButton.Name = "CCITT3_radioButton";
            this.CCITT3_radioButton.Size = new System.Drawing.Size(65, 17);
            this.CCITT3_radioButton.TabIndex = 4;
            this.CCITT3_radioButton.TabStop = true;
            this.CCITT3_radioButton.Text = "CCITT-3";
            this.CCITT3_radioButton.UseVisualStyleBackColor = true;
            // 
            // LZW_radioButton
            // 
            this.LZW_radioButton.AutoSize = true;
            this.LZW_radioButton.Location = new System.Drawing.Point(28, 59);
            this.LZW_radioButton.Name = "LZW_radioButton";
            this.LZW_radioButton.Size = new System.Drawing.Size(49, 17);
            this.LZW_radioButton.TabIndex = 3;
            this.LZW_radioButton.TabStop = true;
            this.LZW_radioButton.Text = "LZW";
            this.LZW_radioButton.UseVisualStyleBackColor = true;
            // 
            // RLE_radioButton
            // 
            this.RLE_radioButton.AutoSize = true;
            this.RLE_radioButton.Location = new System.Drawing.Point(28, 30);
            this.RLE_radioButton.Name = "RLE_radioButton";
            this.RLE_radioButton.Size = new System.Drawing.Size(46, 17);
            this.RLE_radioButton.TabIndex = 2;
            this.RLE_radioButton.TabStop = true;
            this.RLE_radioButton.Text = "RLE";
            this.RLE_radioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(168, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ResimAd_label
            // 
            this.ResimAd_label.AutoSize = true;
            this.ResimAd_label.ForeColor = System.Drawing.Color.Red;
            this.ResimAd_label.Location = new System.Drawing.Point(168, 418);
            this.ResimAd_label.Name = "ResimAd_label";
            this.ResimAd_label.Size = new System.Drawing.Size(91, 13);
            this.ResimAd_label.TabIndex = 5;
            this.ResimAd_label.Text = "Resim seçilmedi...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(617, 435);
            this.Controls.Add(this.ResimAd_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResimSec_button);
            this.Controls.Add(this.aquaGauge1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Resim Sıkıştırma Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AquaControls.AquaGauge aquaGauge1;
        private System.Windows.Forms.Button Sikistir_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ResimSec_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton CCITT4_radioButton;
        private System.Windows.Forms.RadioButton CCITT3_radioButton;
        private System.Windows.Forms.RadioButton LZW_radioButton;
        private System.Windows.Forms.RadioButton RLE_radioButton;
        private System.Windows.Forms.Label ResimAd_label;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

