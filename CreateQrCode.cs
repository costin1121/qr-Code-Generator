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
using System.Windows.Forms;

namespace QR_Code_Generator
{
    class CreateQrCode
    {
        private Bitmap imagePath = Properties.Resources.image003;
        public bool checkQR(Bitmap QrCode)
        {
            uMain frm = new uMain();
            var reader = new BarcodeReader();
            var result = reader.Decode(QrCode);
            if (result == null)
                return false;
            return result.Text == "mobilpay://35:" + frm.eCUComerciant.Text + "-" + frm.eCUMagister.Text + frm.eCUMagazin.Text;
        }


        public Bitmap GenerateQR(int width, int height, string text)
        {
            var bw = new ZXing.BarcodeWriter();

            var encOptions = new ZXing.Common.EncodingOptions
            {
                Width = width,
                Height = height,
                Margin = 0,
                PureBarcode = false
            };

            encOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            bw.Renderer = new BitmapRenderer();
            bw.Options = encOptions;
            bw.Format = ZXing.BarcodeFormat.QR_CODE;
            Bitmap bm = bw.Write(text);
            Bitmap overlay = new Bitmap(imagePath);
            int deltaHeigth = bm.Height - overlay.Height;
            int deltaWidth = bm.Width - overlay.Width;

            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(overlay, new Point(deltaWidth / 2, deltaHeigth / 2));

            return bm;
        }

    }
}

