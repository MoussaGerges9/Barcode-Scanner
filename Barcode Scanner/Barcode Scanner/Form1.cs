using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace Barcode_Scanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an object of OpenFileDialog to be able to choose the image with extensions: jpg, png
            using(OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png" })
            {
                // If the image has been selected
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    BarcodePictureBox.Image = Image.FromFile(openFileDialog.FileName); // Put the image in the picture box
                    BarcodePictureBox.SizeMode = PictureBoxSizeMode.AutoSize; // Change size property of picturebox
                    BarcodeResult result = BarcodeReader.QuicklyReadOneBarcode(BarcodePictureBox.Image, BarcodeEncoding.QRCode
                        | BarcodeEncoding.Code128, true);

                    if (result != null)
                        resultTextBox.Text = result.ToString(); // Put the result text in the text box
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
