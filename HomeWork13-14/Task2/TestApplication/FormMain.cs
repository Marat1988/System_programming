using System;
using System.Windows.Forms;
using Task2Library;

namespace TestApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonInfo.Click += ButtonInfo_Click;
            textBoxInfo.Text = "Самая лучшая преподаватель в академии ТОП. Догадайтесь, кто это?";
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WorkText.IsPolydrome(textBoxInfo.Text).ToString(), "Проверка на палиндром", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"{WorkText.NumberSentencesInText(textBoxInfo.Text)}", "Количество предложений в тексте", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(WorkText.ReverseStr(textBoxInfo.Text), "Переворот строки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
