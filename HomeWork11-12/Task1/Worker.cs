using System;
using System.IO;
using System.Threading;

namespace Task1
{
    public class Worker
    {
        private string[] fileNames = { "Thread1.txt", "Thread2.txt", "Thread3.txt" };
        private static Random random = new Random();
        const char separator = ';';
        private ManualResetEvent manualResetEvent1 = new ManualResetEvent(false);
        private ManualResetEvent manualResetEvent2 = new ManualResetEvent(false);
        private int maxNumber;

        public Worker(int maxNumber)
        {
            this.maxNumber = maxNumber;
        }

        public void Start(object numberOperation)
        {         
            switch ((int)numberOperation)
            {
                case 0: Work1();
                        manualResetEvent1.Set();
                        break;
                case 1: manualResetEvent1.WaitOne();
                        Work2();
                        manualResetEvent2.Set();
                        break;
                case 2: manualResetEvent2.WaitOne();
                        Work3();
                        break;
            }  
        }
        //Поток 1. Заполнение файла числами
        private void Work1()
        {
            WorkInfo(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using(StreamWriter writer = new StreamWriter(fileNames[0], false))
            {
                for (int i = 0; i < maxNumber; i++)
                {
                    int number1 = random.Next(0, 1000);
                    int number2 = random.Next(0, 1000);
                    string line = String.Concat(number1, separator, number2);
                    writer.WriteLine(line);
                }
            }
            WorkInfo(Thread.CurrentThread.Name + " завершил свою работу");
        }
        //Поток 2. Сложение чисел
        private void Work2()
        {
            WorkInfo(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using (StreamWriter writer = new StreamWriter(fileNames[1], false))
            {
                using(StreamReader reader = new StreamReader(fileNames[0]))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = line.Split(separator);
                        int number = int.Parse(arr[0]) + int.Parse(arr[1]);
                        writer.WriteLine(number.ToString());
                    }
                }
            }
            WorkInfo(Thread.CurrentThread.Name + " завершил свою работу");
        }
        //Поток 3. Произведение чисел
        private void Work3()
        {
            WorkInfo(Thread.CurrentThread.Name + " начал свою работу");
            Thread.Sleep(3000);
            using (StreamWriter writer = new StreamWriter(fileNames[2], false))
            {
                using (StreamReader reader = new StreamReader(fileNames[0]))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = line.Split(separator);
                        ulong number = ulong.Parse(arr[0]) * ulong.Parse(arr[1]);
                        writer.WriteLine(number.ToString());
                    }
                }
            }
            WorkInfo(Thread.CurrentThread.Name + " завершил свою работу");
        }

        public event Action<string> WorkInfo;
    }
}
