using QRCoder;
using System;
using System.Windows.Forms;

namespace WindowsFormQRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarQRCode_Click(object sender, EventArgs e)
        {
            Gerador();
        }

        //método gerador usando QRCoder
        // https://www.nuget.org/packages/QRCoder/ 
        private void Gerador()
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQRCode.Image = code.GetGraphic(5);
        }

        private void btnLimparQRCode_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtQRCode.Clear();
            picQRCode.Image = null;
        }
    }
}
