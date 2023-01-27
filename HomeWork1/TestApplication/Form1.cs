using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e) => MessageBox.Show((sender as Button).Text, "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
}
