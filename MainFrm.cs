using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using FreeCA.Properties;

namespace FreeCA
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            if (Settings.Default.firstStart)
            {
                new LicFrm().ShowDialog();
            }
        }

        private void btnCertSelect_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Security Certificate|*.crt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtCertLoc.Text = sfd.FileName;
            }
        }

        private void btnPkeySelect_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Private Key|*.key";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtKeyLoc.Text = sfd.FileName;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GotoWebsite();
        }

        private void exportCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CAExportFrm().ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (textBoxControl())
            {
                CreateCert();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "FreeCA");
            }
        }

        private bool textBoxControl()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        return false;
                    }
                }
            }
            foreach (Control item in this.saveBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void CreateCert()
        {
            string csr = "CN=" + txtCN.Text + ",O=" + txtO.Text + ",OU=" + txtOU.Text + ",L=" + txtL.Text + ",S=" + txtS.Text + ",C=" + txtC.Text;
            using (RSA rsa = new RSACryptoServiceProvider(2048))
            {
                using (X509Certificate2 fRootCA = new X509Certificate2())
                {
                    fRootCA.Import(Resources.RootCA, "FreeCA", X509KeyStorageFlags.DefaultKeySet);
                    CertificateRequest req = new CertificateRequest(csr,
                        rsa,
                        HashAlgorithmName.SHA256,
                        RSASignaturePadding.Pkcs1);
                    req.CertificateExtensions.Add(new X509BasicConstraintsExtension(false,
                        false,
                        0,
                        true));
                    req.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature, false));
                    req.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(
                        new OidCollection
                        {
                            new Oid("1.3.6.1.5.5.7.3.3") // Code Sign
                        }, true));
                    req.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(req.PublicKey, false));
                    using (X509Certificate2 cert = req.Create(fRootCA,
                        DateTimeOffset.UtcNow,
                        DateTimeOffset.UtcNow.AddDays(365),
                        new byte[] { 1, 4, 5, 3 }))
                    {
                        byte[] cdata = cert.Export(X509ContentType.Cert);
                        File.WriteAllText(txtCertLoc.Text, GetCert(cdata));
                        File.WriteAllText(txtKeyLoc.Text, GetKey(rsa));
                        MessageBox.Show("Files have been saved successfully.","FreeCA");
                    }
                }
            }
        }

        private string GetCert(byte[] crtdata)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----BEGIN CERTIFICATE-----");
            sb.AppendLine(Convert.ToBase64String(crtdata, Base64FormattingOptions.InsertLineBreaks));
            sb.Append("-----END CERTIFICATE-----");
            return sb.ToString();
        }

        private string GetKey(RSA rcsp)
        {
            return ExportPrivateKey((RSACryptoServiceProvider)rcsp);
        }

        private string ExportPrivateKey(RSACryptoServiceProvider csp)
        {
            if (csp.PublicOnly) throw new ArgumentException("CSP does not contain a private key", "csp");
            StringBuilder sb = new StringBuilder();
            var parameters = csp.ExportParameters(true);
            using (var stream = new MemoryStream())
            {
                var writer = new BinaryWriter(stream);
                writer.Write((byte)0x30); // SEQUENCE
                using (var innerStream = new MemoryStream())
                {
                    var innerWriter = new BinaryWriter(innerStream);
                    EncodeIntegerBigEndian(innerWriter, new byte[] { 0x00 }); // Version
                    EncodeIntegerBigEndian(innerWriter, parameters.Modulus);
                    EncodeIntegerBigEndian(innerWriter, parameters.Exponent);
                    EncodeIntegerBigEndian(innerWriter, parameters.D);
                    EncodeIntegerBigEndian(innerWriter, parameters.P);
                    EncodeIntegerBigEndian(innerWriter, parameters.Q);
                    EncodeIntegerBigEndian(innerWriter, parameters.DP);
                    EncodeIntegerBigEndian(innerWriter, parameters.DQ);
                    EncodeIntegerBigEndian(innerWriter, parameters.InverseQ);
                    var length = (int)innerStream.Length;
                    EncodeLength(writer, length);
                    writer.Write(innerStream.GetBuffer(), 0, length);
                }

                var base64 = Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length).ToCharArray();
                sb.AppendLine("-----BEGIN RSA PRIVATE KEY-----");
                // Output as Base64 with lines chopped at 64 characters
                for (var i = 0; i < base64.Length; i += 64)
                {
                    string dt = new string(base64, i, Math.Min(64, base64.Length - i));
                    sb.AppendLine(dt);
                }
                sb.Append("-----END RSA PRIVATE KEY-----");
                return sb.ToString();
            }
        }

        private void EncodeLength(BinaryWriter stream, int length)
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length", "Length must be non-negative");
            if (length < 0x80)
            {
                // Short form
                stream.Write((byte)length);
            }
            else
            {
                // Long form
                var temp = length;
                var bytesRequired = 0;
                while (temp > 0)
                {
                    temp >>= 8;
                    bytesRequired++;
                }
                stream.Write((byte)(bytesRequired | 0x80));
                for (var i = bytesRequired - 1; i >= 0; i--)
                {
                    stream.Write((byte)(length >> (8 * i) & 0xff));
                }
            }
        }

        private void EncodeIntegerBigEndian(BinaryWriter stream, byte[] value, bool forceUnsigned = true)
        {
            stream.Write((byte)0x02); // INTEGER
            var prefixZeros = 0;
            for (var i = 0; i < value.Length; i++)
            {
                if (value[i] != 0) break;
                prefixZeros++;
            }
            if (value.Length - prefixZeros == 0)
            {
                EncodeLength(stream, 1);
                stream.Write((byte)0);
            }
            else
            {
                if (forceUnsigned && value[prefixZeros] > 0x7f)
                {
                    // Add a prefix zero to force unsigned if the MSB is 1
                    EncodeLength(stream, value.Length - prefixZeros + 1);
                    stream.Write((byte)0);
                }
                else
                {
                    EncodeLength(stream, value.Length - prefixZeros);
                }
                for (var i = prefixZeros; i < value.Length; i++)
                {
                    stream.Write(value[i]);
                }
            }
        }

        private void GotoWebsite()
        {
            Process.Start("https://github.com/korayustundag/FreeCA");
        }
    }
}