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
                    Console.WriteLine();
                }
                else
                {
                    char[] resultArray = str.ToCharArray();
                    int firstIndexChar = Array.IndexOf(resultArray, searchChar);
                    int lastIndexChar = Array.LastIndexOf(resultArray, searchChar);
                    for (int i = firstIndexChar + 1; i < lastIndexChar; i++)
                    {
                        if (resultArray[i] == searchChar)
                        {
                            resultArray[i] = replaceChar;
                        }
                    }
                    //Мой изначальный способ
                    //string resultStr = str.Substring(str.IndexOf(searchChar) + 1, str.LastIndexOf(searchChar) - 1).Replace(searchChar, replaceChar);
                    //resultStr = str.Substring(0, str.IndexOf(searchChar) + 1) + resultStr + str.Substring(str.LastIndexOf(searchChar));
                    new string(resultArray);
                    Console.WriteLine(resultArray);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
