using System;
using System.Text.RegularExpressions;


namespace HW_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Корректность электронной почты

            Console.Write("Input your email: ");
            string email = Console.ReadLine();

            Regex reg = new Regex(@"^[^\.]([\w\d_]\.?){1,18}[^\.]@[\w\d_]{1,20}\.\w{2,20}$");

            Match result = reg.Match(email);

            if (result.Success)
            {
                Console.WriteLine($"Found, email: {result.Value}");
            }
            else
            {
                Console.WriteLine("Not found!");
            }

            #endregion

            #region  Корректность времени

            /*Console.Write("Input text: ");
            string text = Console.ReadLine();

            Regex reg = new Regex(@"([01]\d|2[0-3]):[0-5]\d:[0-5]\d");

            MatchCollection collection = reg.Matches(text);

            foreach (Match m in collection)
            {
                Console.WriteLine(m.Value);
            }*/

            #endregion

            #region  Корректность даты

            /*Console.Write("Input text: ");
            string text = Console.ReadLine();

            Regex reg = new Regex(@"([01][1-9]|2\d|3[01])\.(0[13578]|1[02])\.((19|20)\d{2})|([01][1-9]|2\d|30)\.((0[469])|11)\.((19|20)\d{2})|([01][1-9]|2\d)\.02\.\d\d(?:[02468][048]|[13579][26])|([01][1-9]|2[0-8])\.02\.\d\d(?:[02468][1235679]|[13579][01345789])");

            MatchCollection collection = reg.Matches(text);

            foreach (Match m in collection)
            {
                Console.WriteLine(m.Value);
            }*/

            #endregion
        }
    }
}
