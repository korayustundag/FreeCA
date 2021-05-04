using System;
using System.Diagnostics;
using FreeCA.Properties;
using System.Windows.Forms;

namespace FreeCA
{
    public partial class LicFrm : Form
    {
        public LicFrm()
        {
            InitializeComponent();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            Settings.Default.firstStart = false;
            Settings.Default.Save();
            Close();
        }

        private void LicFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Default.firstStart)
            {
                Application.Exit();
            }
        }

        private void linkFreeCA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GotoWebsite();
        }

        private void GotoWebsite()
        {
            Process.Start("https://github.com/korayustundag/FreeCA");
        }
    }
}
