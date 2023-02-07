using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4_5
{
    public class Worker
    {
        public struct Report
        {
            public int countNumber;
            public long sizeFile;
            public string fileСontent;
        }

        private string[] fileNames = { "Thread1.txt", "Thread2.txt", "Thread3.txt" };
        private Mutex mutex;
        public static List<Report> reports { get; private set; }

        public Worker()
        {
            mutex = new Mutex();
        }

        public void Start(object number)
        {
            mutex.WaitOne();
            WorkBegin(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            switch ((int)number)
            {
                case 1: WriteNumberToFile();
                        break;
                case 2: ReadWritePrimeNumberToFile(fileNames[0], fileNames[1], false);
                        break;
                case 3: ReadWritePrimeNumberToFile(fileNames[1], fileNames[2], true);
                        break;
            }
            WorkEnd(Thread.CurrentThread.Name + " завершил свою работу");
            mutex.ReleaseMutex();
            reports = ShowStatistic();
        }

        private List<Report> ShowStatistic()
        {
            reports = new List<Report>();
            if (File.Exists(fileNames[0]) && File.Exists(fileNames[1]) && File.Exists(fileNames[2]))
            {
                for (int i = 0; i < fileNames.Length; i++)
                {
                    FileInfo fileInfo = new FileInfo(fileNames[i]);
                    reports.Add(new Report
                    {
                        countNumber = File.ReadAllLines(fileNames[i]).Length,
                        sizeFile = fileInfo.Length,
                        fileСontent = File.ReadAllText(fileNames[i])
                    });
                }
                return reports;
            }
            else
                throw new FileNotFoundException("Нет необходимые файлов для генерации отчета");
           
        }

        //выполнение первого потока
        private void WriteNumberToFile()
        {
            Random random = new Random();
            using (StreamWriter writer = new StreamWriter(fileNames[0], false))
            {
                for (int i = 0; i < 100000; i++)
                {
                    int number = random.Next(1000);
                    writer.WriteLine(number.ToString());
                }
            }
        }
        //Выполнение второго потока (additionalVerification==false) и третьего потока (additionalVerification==true)
        private void ReadWritePrimeNumberToFile(string readerFile, string writeFile, bool additionalVerification)
        {
            using (StreamWriter writer = new StreamWriter(writeFile, false))
            {
                using (StreamReader reader = new StreamReader(readerFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (additionalVerification == false)
                        {
                            if (ulong.TryParse(line, out ulong number) & checkPrimeNumber(number))
                            {
                                writer.WriteLine(number.ToString());
                            }
                        }
                        else
                        {
                            //Выполнение третьего потока с условием. 
                            //Числа, наиденные во втором потоке уже по-любому простые.
                            //Поэтому дополнительные проверок (ulong.TryParse(line, out ulong number) & checkPrimeNumber(number)) проводить нет смысла
                            if (line[line.Length - 1] == '7')
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                }
            }
        }

        //Функция проверки является ли число простым
        private bool checkPrimeNumber(ulong number)
        {
            if (number < 2)
                return false;
            for (ulong i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public event Action<string> WorkBegin;
        public event Action<string> WorkEnd;
    }
}
