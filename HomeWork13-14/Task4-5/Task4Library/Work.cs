using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task4Library
{
    public class Work
    {
        public static event Action<string> infoMessage;
        /// <summary>
        /// Копирование файла
        /// </summary>
        /// <param name="sourceFileName">Исходный файл</param>
        /// <param name="destFileName">Новый файл</param>
        public static void CopyFile(string sourceFileName, string destFileName, bool overWrite)
        {
            if (!File.Exists(sourceFileName))
                throw new FileNotFoundException($"Исходный файл {sourceFileName} не существует");
            try
            {
                FileInfo fileInfo = new FileInfo(sourceFileName);
                fileInfo.CopyTo(destFileName, overWrite);
                infoMessage("Копирование успешно выполнено");
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }
        /// <summary>
        /// Копирование директорий
        /// </summary>
        /// <param name="sourceDir">Исходная папка</param>
        /// <param name="destinationDir">Место назначения</param>
        /// <param name="recursive">Истина для копирования поддиректорий</param>
        public static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);
            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Исходная папка не существует: {dir.FullName}");
            // Cache direfore we start copyingctories be
            DirectoryInfo[] dirs = dir.GetDirectories();
            // Create the destination directory
            Directory.CreateDirectory(destinationDir);
            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }
            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
        /// <summary>
        /// Удаление файла по имени
        /// </summary>
        /// <param name="path">Исходный файл</param>
        public static void FileRemove(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Исходный файл {path} не существует");
            try
            {
                File.Delete(path);
                infoMessage($"Удаление {path} успешно выполнено.");
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }
        /// <summary>
        /// Удаление файлов по набору имен;
        /// </summary>
        /// <param name="fileName">Массив путей файлов</param>
        public static void FilesRemove(string path, string fileNameDelete)
        {
            var dir = new DirectoryInfo(path);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Исходная папка не существует: {dir.FullName}");
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (file.ToUpper().Contains(fileNameDelete.ToUpper()))
                    FileRemove(file);
            }
        }
        /// <summary>
        /// Удаление файлов по маске
        /// </summary>
        /// <param name="sourceDir">Исходная папка</param>
        /// <param name="extension">Расширение. Например, *.txt</param>
        public static void DemandingExpansionFile(string sourceDir, string extension)
        {
            var dir = new DirectoryInfo(sourceDir);
            foreach (var file in dir.EnumerateFiles(extension))
            {
                try
                {
                    FileRemove(file.FullName);
                }
                catch (Exception ex)
                {
                    infoMessage(ex.Message);
                }
            }
        }
        /// <summary>
        /// Перенос файла.
        /// </summary>
        /// <param name="sourceFileName">Исходный файл</param>
        /// <param name="destFileName">Новое расположение файла</param>
        public static void FileMove(string sourceFileName, string destFileName)
        {
            if (!File.Exists(sourceFileName))
                throw new FileNotFoundException($"Исходный файл {sourceFileName} не существует");
            try
            {
                File.Move(sourceFileName, destFileName);
                infoMessage($"Файл {sourceFileName} перемещен в {sourceFileName}.");
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }
        /// <summary>
        /// Функция для поиска слова в текстовом файле
        /// </summary>
        /// <param name="path">исходный файл</param>
        /// <param name="word">слово для поиска</param>
        /// <returns></returns>
        private static int GetCountWordInTextFile(string path, string word)
        {
            string text = File.ReadAllText(path);
            Regex regex = new Regex(word, RegexOptions.IgnoreCase);
            MatchCollection rtg = regex.Matches(text);
            int countWord = rtg.Count;
            return countWord;
        }
        /// <summary>
        /// Создает файл отчета с информацией сколько раз слово встречается в файле
        /// </summary>
        /// <param name="path">исходный файл</param>
        /// <param name="word">слово для поиска</param>
        public static void ReportCountWordInTextFile(string path, string word)
        {
            try
            {
                int countWord = GetCountWordInTextFile(path, word);
                using (StreamWriter writer = new StreamWriter("Report.txt", false))
                {
                    writer.WriteLine("=====================================================");
                    writer.WriteLine($"Исходный файл: {path}");
                    writer.WriteLine($"Слово для поиска: {word}");
                    writer.WriteLine($"Кол-во слов в файле: {countWord}");
                    writer.WriteLine("=====================================================");
                }
                infoMessage($"Файл отчета {Environment.CurrentDirectory}\\Report.txt успешно создан");
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }
        /// <summary>
        /// Поиск слова в текстовых файлах в папке
        /// </summary>
        /// <param name="pathFolder">папка для поиска</param>
        /// <param name="word">слово для поиска</param>
        public static void SearchWordInTextFilesInTheFolder(string pathFolder, string word)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(pathFolder);
                using (StreamWriter writer = new StreamWriter("Report.txt", false))
                {
                    foreach (var s in directoryInfo.GetFiles("*.txt", SearchOption.AllDirectories))
                    {
                        writer.WriteLine("=====================================================");
                        writer.WriteLine($"Исходный файл: {s.FullName}");
                        writer.WriteLine($"Слово для поиска: {word}");
                        writer.WriteLine($"Кол-во слов в файле: {GetCountWordInTextFile(s.FullName, word)}");
                        writer.WriteLine("=====================================================");
                    }                   
                }
                infoMessage($"Файл отчета {Environment.CurrentDirectory}\\Report.txt успешно создан");
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }
    }
}
