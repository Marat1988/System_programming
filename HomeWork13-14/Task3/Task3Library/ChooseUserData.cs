using System.Text.RegularExpressions;

namespace Task3Library
{
    public class ChooseUserData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNumberTelephone(string telNumber) => Regex.IsMatch(telNumber, @"\+7\((\d{3})\)\d{3}-\d{2}-\d{2}");
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmailValid(string email)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            return Regex.IsMatch(email, pattern);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public static bool IsAgeValid(string age)
        {
            if (int.TryParse(age, out _))
                return true;
            return false;
        }

    }
}
