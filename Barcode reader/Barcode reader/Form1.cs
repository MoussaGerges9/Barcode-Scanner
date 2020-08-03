using System;
using System.Drawing;
using System.Windows.Forms;
using IronBarCode;

namespace Barcode_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog(){Filter = "JPG|*.jpg|PNG|*.png" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    BarcodeResult result = BarcodeReader.QuicklyReadOneBarcode(pictureBox1.Image, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);

                    if (result != null)
                        barCodeTxtBox.Text = result.ToString();
                }
            }
        }
    }
}
