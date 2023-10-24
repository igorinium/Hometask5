using System;
using System.Text;

namespace Hometask5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string inputStr;
            while (true)
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Вы ввели пустую строку");
                }
                else
                {
                    inputStr = str.ToLower();
                    break;
                }
            }

            int step;
            while (true)
            {
                Console.Write("Введите шаг шифрования (для дешифровки введите с противоположным знаком): ");
                bool isParseSuccess = int.TryParse(Console.ReadLine(), out step);
                if (isParseSuccess)
                {
                    break;
                }
            }

            StringBuilder encryptStr = new StringBuilder();
            for (int i = 0; i < inputStr.Length; i++)
            {

                int indexAlphabet = alphabet.IndexOf(inputStr[i]);
                if (indexAlphabet < 0)
                {
                    encryptStr.Append(inputStr[i]);
                }
                else
                {
                    int encryptIndex = (alphabet.Length + indexAlphabet + step) % alphabet.Length;
                    encryptStr.Append(alphabet[encryptIndex]);
                }
            }

            Console.WriteLine(encryptStr);
            Console.ReadLine();
        }
    }
}
