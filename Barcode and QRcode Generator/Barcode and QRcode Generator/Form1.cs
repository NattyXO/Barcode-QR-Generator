using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode_and_QRcode_Generator
{
    public partial class BarCodeQrcodeGenerator : Form
    {
        bool isGenerated = false;
        
        public BarCodeQrcodeGenerator()
        {
            InitializeComponent();
           
        }
        public void ToastShow(string type, string message)
        {
            TaostNotification toast = new TaostNotification(type, message);
            toast.Show();


        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
               
                ToastShow("WARNING", "Please enter some information!");
            }
            else
            {
          
                isGenerated = true;
                resultPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                resultPictureBox.Image = barcode.Draw(txtBarcode.Text, 200);
               
                ToastShow("SUCCESS", "Barcode generate successful.");
               
            }

                
        }

        private void btnQRcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQRcode.Text))
            {
                ToastShow("WARNING", "Please enter some information!");

            }
            else
            {
                isGenerated = true;
                resultPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                resultPictureBox.Image = qrcode.Draw(txtQRcode.Text, 200);
                
                ToastShow("SUCCESS", "QRcode generate successful.");


            }
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isGenerated)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                resultPictureBox.Image.Save(path + "\\" + DateTime.Now.Second.ToString()
                    + DateTime.Now.Millisecond.ToString() + ".jpg", ImageFormat.Jpeg);
               
                ToastShow("SUCCESS", "Save Successful.");
            }
            else
            {
              
                ToastShow("WARNING", "Please first generate the Barcode or QRcode!");
            }
                

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpText = @"1. **Enter Information:**
   - Input the desired text or information you want to encode into the QR code.
     - Use the ""Barcode Text"" field for generating a barcode.
     - Use the ""QR Code Text"" field for generating a QR code.

2. **Generate the QR Code or Barcode:**
   - For Barcode:
     - Click on the ""Generate Barcode"" button.
     - If the input field is empty, a warning will prompt you to enter information.
     - Upon successful input, a Code128 barcode will be generated and displayed in the designated area.

   - For QR Code:
     - Click on the ""Generate QR Code"" button.
     - If the input field is empty, a warning will prompt you to enter information.
     - Once valid input is provided, a QR code will be generated and displayed in the specified area.

3. **Save the Generated Code:**
   - Once a code (barcode or QR code) is generated, you can save it.
   - Click on the ""Save"" button to store the generated image on your desktop.
   - The application will create a JPEG image file with a unique name based on the current time.";

            MessageBox.Show(helpText);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

     

        private void lblAbout_Click(object sender, EventArgs e)
        {
            ToastShow("INFO", "For Developer Direct Contact\nuse Telegram Username :- @SniperRasMtat");
        }
    }
}
