using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using System.Drawing.Printing;

namespace QR_Code_Generator
{
    public partial class uMain : Form
    {
        Image File;
        private int size = 300;
        public uMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.plugin_import_export;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eCUComerciant.Text == "" || eCUMagister.Text == "" || eCUMagazin.Text == "" )
            {
                MessageBox.Show("Codul de identificare Magister sau Codul Comerciantului nu poate fi gol!");
            }
            else
            {
                CreateQrCode qrCode = new CreateQrCode();
                pictureBox1.Image = qrCode.GenerateQR(size, size, "mobilpay://35:" + eCUComerciant.Text + "-" + eCUMagister.Text + eCUMagazin.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += printDocument_PrintPage;
            pd.Document = doc;
            if(pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (eCUMagister.Text == "" || eCUMagazin.Text == "")
            {
                MessageBox.Show("Nu se poate salva un QR Code gol!");

            }
            else
            {
                save.FileName = "QR Code POS - " + eCUMagister.Text + eCUMagazin.Text;
                save.Title = "Salveaza QR Code Generat";
                save.Filter = "Images|*.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(save.FileName);
                }
            }
        }
    }
}
