using System;

namespace Hometask5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char searchChar = 'h';
            char replaceChar = 'H';
            while (true)
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Вы ввели пустую строку");
                }
                else if (str.IndexOf(searchChar) == -1)
                {
                    Console.WriteLine($"В строке нет символа '{searchChar}'");
                }
                else if (str.IndexOf(searchChar) == str.LastIndexOf(searchChar))
                {
                    break;
                }
                else
                {
                    string resultStr = str.Substring(str.IndexOf(searchChar) + 1, str.LastIndexOf(searchChar) - 1).Replace(searchChar, replaceChar);
                    resultStr = str.Substring(0, str.IndexOf(searchChar) + 1) + resultStr + str.Substring(str.LastIndexOf(searchChar));
                    Console.WriteLine(resultStr);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
