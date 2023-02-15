using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Library
{
    public class Work
    {
        public static event Action<string> infoMessage;

        public static void CopyFile(string sourceFileName, string destFileName)
        {
            if (!File.Exists(sourceFileName))
                throw new FileNotFoundException($"Исходный файл {sourceFileName} не существует");
            try
            {
                File.Copy(sourceFileName, destFileName, true);
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }

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

        public static void FileRemove(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Исходный файл {path} не существует");
            try
            {
                File.Delete(path);
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }

        public static void FilesRemove(string[] fileName)
        {
            if (fileName.Length > 0)
            {
                for (int i = 0; i < fileName.Length; i++)
                {
                    try
                    {
                        FileRemove(fileName[i]);
                    }
                    catch (Exception ex)
                    {
                        infoMessage(ex.Message);
                    }
                }
            }
        }

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

        public static void FileMove(string path, string newPath)
        {
            if (File.Exists(path))
                throw new FileNotFoundException($"Исходный файл {path} не существует");
            try
            {
                File.Move(path, newPath);
            }
            catch (Exception ex)
            {
                infoMessage(ex.Message);
            }
        }

    }
}
