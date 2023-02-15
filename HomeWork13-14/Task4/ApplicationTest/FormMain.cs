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
            Work.infoMessage += Work_infoMessage;
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
