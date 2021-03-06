﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace rift_timer
{
    public partial class UpdateDialog : Form
    {
        public UpdateDialog(string latestVersion)
        {
            InitializeComponent();

            installedLabel.Text = currentVersion;
            latestLabel.Text = latestVersion;
            latestVersionExplode = latestVersion.Split('.');
        }

        string currentVersion = Application.ProductVersion;
        string[] latestVersionExplode;

        private void YesButton_Click(object sender, EventArgs e)
        {
            string updater = Environment.CurrentDirectory + @"\RiftTimerUpdater.exe";
            Process.Start(updater, "pause");
            Application.Exit();
            DialogResult = DialogResult.OK;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
