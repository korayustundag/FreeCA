using System;
using System.Windows.Forms;

namespace FreeCA
{
    public partial class CAExportFrm : Form
    {
        public CAExportFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Security Certificate|*.crt";
            sfd.FileName = "FreeCA.crt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                certTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Security Certificate have been saved successfully.");
                Close();
            }
        }
    }
}
