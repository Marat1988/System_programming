using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task4Library;

namespace ApplicationTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonStartCopy.Click += ButtonStartCopy_Click;
            buttonDirectoryCopy.Click += ButtonDirectoryCopy_Click;
            buttonDeleteFile.Click += ButtonDeleteFile_Click;
            buttonDeleteFiles.Click += ButtonDeleteFiles_Click;
            buttonDeleteFileExtension.Click += ButtonDeleteFileExtension_Click;
            buttonFileMove.Click += ButtonFileMove_Click;
            Work.infoMessage += Work_infoMessage;
        }

        private void ButtonFileMove_Click(object sender, EventArgs e)
        {
            Work.FileMove(textBoxSourceFile.Text, textBoxMoveTheFile.Text);
        }

        private void ButtonDeleteFileExtension_Click(object sender, EventArgs e)
        {
            Work.DemandingExpansionFile(textBoxFolderPathMask.Text, textBoxExtension.Text);
        }

        private void ButtonDeleteFiles_Click(object sender, EventArgs e)
        {
            Work.FilesRemove(textBoxFolderPath.Text, textBoxFilePartName.Text);
        }

        private void ButtonDeleteFile_Click(object sender, EventArgs e)
        {
            Work.FileRemove(textBoxPathFile.Text);
        }

        private void ButtonDirectoryCopy_Click(object sender, EventArgs e)
        {
            Work.CopyDirectory(textBoxSourceDir.Text, textBoxDestinationDir.Text, checkBoxRecursive.Checked);
        }

        private void ButtonStartCopy_Click(object sender, EventArgs e)
        {
            Work.CopyFile(textBoxSourceFileName.Text, textBoxDestFileName.Text, checkBoxOverWrile.Checked);
        }

        private void Work_infoMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
