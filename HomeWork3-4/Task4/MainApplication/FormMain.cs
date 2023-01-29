using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxPathToTheFile_TextChanged(this, null);
        }

        private void textBoxPathToTheFile_TextChanged(object sender, EventArgs e)
        {
            buttonRunProcess.Enabled = textBoxPathToTheFile.Text.Length > 0 && textBoxWord.Text.Length > 0;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathToTheFile.Text = openFileDialog.FileName;
            }
        }

        private void buttonRunProcess_Click(object sender, EventArgs e)
        {
            if (File.Exists("childApplication.exe"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("childApplication.exe")
                {
                    ArgumentList =
                    {
                        textBoxPathToTheFile.Text,
                        textBoxWord.Text
                    }
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("Файл не существует. Продолжение не возможно!", "iNFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
