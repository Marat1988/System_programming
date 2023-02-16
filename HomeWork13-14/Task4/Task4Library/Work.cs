using System;
using System.IO;
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
            if (File.Exists(sourceFileName))
                throw new FileNotFoundException($"Исходный файл {sourceFileName} не существует");
            try
            {
                File.Move(sourceFileName, destFileName);
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }
    }
}
