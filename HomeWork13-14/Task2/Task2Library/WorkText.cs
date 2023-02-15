using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task2Library
{
    public static class WorkText
    {
        /// <summary>
        /// Проверка, является ли текст полиндромом
        /// </summary>
        /// <param name="text">Текстовая строка</param>
        /// <returns>Истина, если слово или предложение является полиндром. В противном случае ложь</returns>
        public static bool IsPolydrome(string text)
        {
            string modifiedText = text.Replace(" ", "");
            string newText = ReverseStr(modifiedText);
            return modifiedText.Equals(newText);
        }
        /// <summary>
        /// Количество предложений в строке
        /// </summary>
        /// <param name="text">Текстовая строка</param>
        /// <returns>Количество предложений в строке</returns>
        public static int NumberSentencesInText(string text)
        {
            string[] arr = text.Split(new char[] { '.', '?', '!' });
            return arr.Count(i => i.Length > 0);
        }
        /// <summary>
        /// Выводит перевернутую строку. Если слов несколько, то переворачивает каждое слово.
        /// </summary>
        /// <param name="text">Текст или предложение</param>
        /// <returns>Выводит перевернутую строку.</returns>
        public static string ReverseStr(string text)
        {
            string modifiedText = Regex.Replace(text, "[ ]+", " ");
            string[] arr = modifiedText.Split(' ').ToArray();
            string modifiArr = String.Join(" ",arr.Select(i => String.Join("",i.ToCharArray().Reverse())));
            return modifiArr;
        }
    }
}
