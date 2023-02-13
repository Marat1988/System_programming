using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

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

        private static string[] fileNames = { "Thread1.txt", "Thread2.txt", "Thread3.txt" };
        Random random = new Random();
        private Mutex mutex1;
        private int expectedOperationNumber = 0;

        public Worker()
        {
            mutex1 = new Mutex();
        }

        public void Start(object numberOperation)
        {
            try
            {
                mutex1.WaitOne();
            }
            catch {}
            if ((int)numberOperation == expectedOperationNumber)
            {
                switch ((int)numberOperation)
                {
                    case 0: Work1();
                            break;
                    case 1: Work2();
                            break;
                    case 2: Work3();
                            break;
                }
                expectedOperationNumber++;
            }
            else
            {
                mutex1.ReleaseMutex();
                Thread.Sleep(3000);
                Start(expectedOperationNumber);
            }

        }
        //Поток 1. Заполнение файла числами
        private void Work1()
        {
            WorkBegin(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using (StreamWriter writer = new StreamWriter(fileNames[0], false))
            {
                for (int i = 0; i < 100000; i++)
                {
                    int number1 = random.Next(1000);
                    writer.WriteLine(number1.ToString());
                }
            }    
            WorkEnd(Thread.CurrentThread.Name + " завершил свою работу");
        }
        //Поток 2. Перебор чисел для выявления простых чисел
        private void Work2()
        {
            WorkBegin(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using (StreamWriter writer = new StreamWriter(fileNames[1], false))
            {
                using (StreamReader reader = new StreamReader(fileNames[0]))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (ulong.TryParse(line, out ulong number) & checkPrimeNumber(number))
                        {
                            writer.WriteLine(number.ToString());
                        }
                    }
                }
            }
            WorkEnd(Thread.CurrentThread.Name + " завершил свою работу");
        }
        //Поток 3. Перебор простых чисел по условию (7 на конце)
        public void Work3()
        {
            WorkBegin(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using (StreamWriter writer = new StreamWriter(fileNames[2], false))
            {
                using (StreamReader reader = new StreamReader(fileNames[1]))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line[line.Length - 1] == '7')
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            WorkEnd(Thread.CurrentThread.Name + " завершил свою работу");
            WorkEnd("Happy end");
        }

        public static List<Report> ShowStatistic()
        {
            List<Report> reports = new List<Report>();
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
