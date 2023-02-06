using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class FormMain : Form
    {
        public event Action<List<InfoWord>> Statistic;

        public FormMain()
        {
            InitializeComponent();
            textBoxFolderPath.TextChanged += TextBoxFolderPath_TextChanged;
            textBoxWord.TextChanged += TextBoxFolderPath_TextChanged;
            buttonOpenFolder.Click += ButtonOpenFolder_Click;
            buttonSearchWordInTextFile.Click += ButtonSearchWordInTextFile_Click;
            Statistic += FormMain_statistic;
        }
        private void ButtonSearchWordInTextFile_Click(object sender, EventArgs e)
        {
             SearchTextFile();
             labelInfo.Text = "Осуществляю поиск. Ждите.....";
             dataGridViewStatistic.DataSource = null;
        }
        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                    textBoxFolderPath.Text = folderBrowser.SelectedPath;
            }
        }
        private void TextBoxFolderPath_TextChanged(object sender, EventArgs e)
        {
            buttonSearchWordInTextFile.Enabled = textBoxFolderPath.Text.Length > 0 && textBoxWord.Text.Length > 0;
        }
        private async void SearchTextFile()
        {
            List<InfoWord> textFiles = new List<InfoWord>();
            await Task.Run(() =>
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(textBoxFolderPath.Text);
                foreach (var s in directoryInfo.GetFiles("*.txt", SearchOption.AllDirectories))
                {
                    Thread.Sleep(3000);
                    textFiles.Add(new InfoWord()
                    {
                        filePath = s.DirectoryName,
                        name = s.Name,
                        countWord = CountWordInTextFile(s.FullName)
                    });
                }
            });
            Statistic.Invoke(textFiles);
        }
        private int CountWordInTextFile(string path)
        {
            string text = File.ReadAllText(path);
            Regex regex = new Regex(textBoxWord.Text, RegexOptions.IgnoreCase);
            MatchCollection rtg = regex.Matches(text);
            int countWord = rtg.Count;       
            return countWord;
        }
        private void FormMain_statistic(List<InfoWord> list)
        {
            if (list.Count > 0)
            {
                var sql = (from world in list
                           select new
                           {
                               Путь_к_файлу = world.filePath,
                               Имя_файла = world.name,
                               Количество_слов = world.countWord
                           }).ToList();
                dataGridViewStatistic.DataSource = sql;
                labelInfo.Text = "Поиск осуществлен";
            }
            else
            {
                labelInfo.Text = "Текстовых файлов в указанной Вами папке не было найдено!";
            }
        }
    }
}
