using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3Library
{
    public class ChooseUserData
    {
        /// <summary>
        /// Истина, если номер соответствует формат +7(XXX)XXX-XX-XX где X - это цифры. В противном случае Ложь
        /// </summary>
        /// <param name="text">Номер телефона</param>
        /// <returns>Истина, если номер соответствует формат +7(XXX)XXX-XX-XX где X - это цифры. В противном случае Ложь</returns>
        public static bool IsNumberTelephoneValid(string telNumber) => Regex.IsMatch(telNumber, @"\+7\((\d{3})\)\d{3}-\d{2}-\d{2}");
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmailValid(string email)
        {
            string pattern = @"^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@(?:[a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(?:aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$";
            return Regex.IsMatch(email, pattern);
        }
        /// <summary>
        /// Истина, если в введенном значении содержаться цифры. В противном случае Ложь
        /// </summary>
        /// <param name="age">Текстовое значение</param>
        /// <returns>Истина, если в введенном значении содержаться цифры. В противном случае Ложь</returns>
        public static bool IsAgeValid(string age)
        {
            if (int.TryParse(age, out _))
                return true;
            return false;
        }
        /// <summary>
        /// Истина, если в введенном значении содержаться только буквы или пробел. В противном случае ЛОЖЬ
        /// </summary>
        /// <param name="FIO"></param>
        /// <returns>Истина, если в введенном значении содержаться только буквы или пробел. В противном случае ЛОЖЬ</returns>
        public static bool IsFIOValid(string FIO)
        {
            return FIO.ToCharArray().Where(s => Char.IsLetter(s) || s == ' ').Count() == FIO.Length;
        }

    }
}
