using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StroyModern
{
    public partial class BarcodeForm : Form
    {
        public Bitmap barcode;
        public string code;
        public BarcodeForm()
        {
            InitializeComponent();
            barcodeImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.Load += BarcodeForm_Load;
        }
        private void BarcodeForm_Load(object sender, EventArgs e)
        {
            barcodeImage.Image = barcode;
        }
        private void CreateBarCode(Image img, string code)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = code + ".pdf";
            saveFileDialog.Filter = "PDF файлы (*.pdf)|*.pdf";

            string filePath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, e) =>
            {
                RectangleF imageRect = new RectangleF(100, 100, 200, 150);
                e.Graphics.DrawImage(img, imageRect);
            };

            printDocument.PrinterSettings.PrintToFile = true;
            printDocument.PrinterSettings.PrintFileName = filePath;
            printDocument.Print();
        }
        private void yesBtn_Click(object sender, EventArgs e)
        {
            CreateBarCode(barcodeImage.Image, code);
            Hide();
            ProductsList productsList = new ProductsList();
            productsList.FormClosed += (s, args) => Close();
            productsList.Show();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ProductsList productsList = new ProductsList();
            productsList.FormClosed += (s, args) => Close();
            productsList.Show();
        }
    }
}
