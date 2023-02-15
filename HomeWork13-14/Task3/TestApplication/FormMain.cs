using System;
using System.Windows.Forms;
using Task3Library;

namespace TestApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonChooseFIO.Click += ButtonChooseFIO_Click;
            buttonChooseTelNumber.Click += ButtonChooseTelNumber_Click;
            buttonChooseEmail.Click += ButtonChooseEmail_Click;
            buttonChooseAge.Click += ButtonChooseAge_Click;
        }

        private void ButtonChooseAge_Click(object sender, EventArgs e) => MessageBox.Show(ChooseUserData.IsAgeValid(textBoxAge.Text).ToString());

        private void ButtonChooseEmail_Click(object sender, EventArgs e) => MessageBox.Show(ChooseUserData.IsEmailValid(textBoxEmail.Text).ToString());

        private void ButtonChooseTelNumber_Click(object sender, EventArgs e) => MessageBox.Show(ChooseUserData.IsNumberTelephoneValid(textBoxTelNumber.Text).ToString());

        private void ButtonChooseFIO_Click(object sender, EventArgs e) => MessageBox.Show(ChooseUserData.IsFIOValid(textBoxFIO.Text).ToString());
    }
}
