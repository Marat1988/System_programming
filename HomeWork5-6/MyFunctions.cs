using System;

namespace HomeWork5_6
{
    public class MyFunctions
    {
        //Функция числа Фибоначчи
        public static ulong fibonachi(ulong n)
        {
            if (n == 0 || n == 1) return n;

            return fibonachi(n - 1) + fibonachi(n - 2);
        }
        //Функция проверки является ли число простым
        public static bool checkPrimeNumber(ulong number)
        {
            if (number < 2)
                throw new ArgumentException("Число должно быть больше либо равно 2");
            for (ulong i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
