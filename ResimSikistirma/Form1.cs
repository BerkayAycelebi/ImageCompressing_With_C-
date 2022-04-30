using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace ResimSikistirma
{
    public partial class Form1 : Form
    {

        private long dosyaBoyutu1, dosyaBoyutu2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RLE_radioButton.Checked = true;
        }

        ImageCodecInfo bul(string MimeType)
        {
            int i;
            for (i = 0; i <= ImageCodecInfo.GetImageEncoders().Length - 1; i++)
                if (ImageCodecInfo.GetImageEncoders()[i].MimeType == MimeType)
                {
                    return ImageCodecInfo.GetImageEncoders()[i];
                }
            return null;
        }

        private void ResimSec_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim dosyaları | *.bmp; *.jpg; *.gif; *.wmf; *.tif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    FileInfo info = new FileInfo(openFileDialog1.FileName);
	                dosyaBoyutu1 = info.Length;
                    ResimAd_label.Text = openFileDialog1.FileName;

                }
                catch
                {
                    MessageBox.Show(openFileDialog1.FileName + "Geçerli resim dosyası değil");
                }
        }

        private void Sikistir_button_Click(object sender, EventArgs e)
        {
            
            //BMP Kaydet
            saveFileDialog1.Filter = "Bmp Dosyası | *.bmp";
            saveFileDialog1.DefaultExt = "bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image resim;
                resim = pictureBox1.Image;
                ImageCodecInfo Codec_Bilgisi;
                //bmp encoderini bul
                Codec_Bilgisi = bul("image/bmp");
                EncoderParameter parametre;
                //sıkıştırma
                if (LZW_radioButton.Checked)
                {
                    parametre = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (int)EncoderValue.CompressionLZW);
                }
                if (CCITT3_radioButton.Checked)
                {
                    parametre = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (int)EncoderValue.CompressionCCITT3);
                }
                if (CCITT4_radioButton.Checked)
                {
                    parametre = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (int)EncoderValue.CompressionCCITT4);
                }

                else
                    parametre = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (int)EncoderValue.CompressionRle);
               
                
                EncoderParameters parametreler;
                //1 parametremiz var
                parametreler = new EncoderParameters(1);
                //parametreleri ata
                parametreler.Param[0] = parametre;
                //kaydet


                 resim.Save(saveFileDialog1.FileName, Codec_Bilgisi, parametreler);

                 FileInfo info2 = new FileInfo(saveFileDialog1.FileName);
	             dosyaBoyutu2 = info2.Length;

                 if (dosyaBoyutu1 > dosyaBoyutu2)
                 {
                    int sikistirmaOrani = Convert.ToInt32(dosyaBoyutu2 / dosyaBoyutu1) * 100;
                    aquaGauge1.Value = Convert.ToInt16(sikistirmaOrani) ;

                   
                    MessageBox.Show("sıkıştırma oranı:" +sikistirmaOrani.ToString());
                 }

                 if (dosyaBoyutu1 <= dosyaBoyutu2)
                 {
                     MessageBox.Show("Resim sıkıştırma başarısız!");
                 }


                
            } 
           
        }
    }
}