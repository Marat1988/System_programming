using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonOpenFile.Click += ButtonOpenFile_Click;
            buttonSearch.Click += ButtonSearch_Click;
            textBoxFilePath.TextChanged += TextBoxFilePath_TextChanged;
            textBoxWord.TextChanged += TextBoxFilePath_TextChanged;
        }

        private void TextBoxFilePath_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = textBoxFilePath.Text.Length > 0 && textBoxWord.Text.Length > 0;
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog.FileName;
            }
        }
        private async void Search()
        {
            int countWord = 0;
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                string textFile = File.ReadAllText(textBoxFilePath.Text);
                Regex regex = new Regex(textBoxWord.Text, RegexOptions.IgnoreCase);
                MatchCollection rtg = regex.Matches(textFile);
                countWord = rtg.Count;
                
            });
            labelStatisticInfo.Text = $"Заданное слово: {textBoxWord.Text}\nИсходный файл: {textBoxFilePath.Text}\nКоличество слов в файле: {countWord}";
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search();
            labelStatisticInfo.Text = "Идет поиск слова в файле. Ждите.......";
        }
    }
}
