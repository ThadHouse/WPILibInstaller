﻿using ICSharpCode.SharpZipLib.Zip;
using SharedCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WPILibInstaller
{
    public partial class Selector : Form
    {
        public string ZipLocation { get; private set; }

        private VsCodeConfig config;
        public Selector(VsCodeConfig config)
        {
            this.config = config;
            InitializeComponent();
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar5.Visible = false;
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            progressBar3.Visible = true;
            progressBar4.Visible = true;
            progressBar5.Visible = true;
            selectButton.Visible = false;
            downloadButton.Enabled = false;
            downloadButton.Text = "Downloading";
            var origText = label1.Text;
            label1.Text = "This window will close when\ndownload finishes.";
            VsCodeFiles vsf = new VsCodeFiles(config);

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            var res = await vsf.DownloadAndZipFiles(progressBar1, progressBar2, progressBar3, progressBar4, progressBar5, CancellationToken.None);

            if (res == null)
            {
                MessageBox.Show("Download Failed. Click button to retry");
                downloadButton.Enabled = true;
                downloadButton.Text = "Download";
                label1.Text = origText;
                return;
            }

            ZipLocation = res;
            this.Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select VS Code Zip";
            // Get location of EXE
            var exeFullPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            // Get directory EXE is in
            var exePath = Path.GetDirectoryName(exeFullPath);
            ofd.InitialDirectory = exePath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bool valid = true;
                var file = ofd.FileName;
                using (ZipFile zfs = new ZipFile(file))
                {
                    foreach (ZipEntry entry in zfs)
                    {
                        
                    }
                }

                if (valid == true)
                {
                    ZipLocation = file;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Inavlid Zip Selected. Maybe out of date versions.");
                }
            }

        }
    }
}