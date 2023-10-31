using System;
using System.Text;

namespace Hometask5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "1234567890";
            string rusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string engAlphabet = "abcdefghijklmnopqrstuvwxyz";
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
                int indexAlphabet;
                if (rusAlphabet.IndexOf(inputStr[i]) != -1)
                {
                    indexAlphabet = rusAlphabet.IndexOf(inputStr[i]);
                    int encryptIndex = (rusAlphabet.Length + indexAlphabet + step) % rusAlphabet.Length;
                    encryptStr.Append(rusAlphabet[encryptIndex]);
                }
                else if (numbers.IndexOf(inputStr[i]) != -1)
                {
                    indexAlphabet = numbers.IndexOf(inputStr[i]);
                    int encryptIndex = (numbers.Length + indexAlphabet + step) % numbers.Length;
                    encryptStr.Append(numbers[encryptIndex]);
                }
                else if (engAlphabet.IndexOf(inputStr[i]) != -1)
                {
                    indexAlphabet = engAlphabet.IndexOf(inputStr[i]);
                    int encryptIndex = (engAlphabet.Length + indexAlphabet + step) % engAlphabet.Length;
                    encryptStr.Append(engAlphabet[encryptIndex]);
                }
                else
                {
                    encryptStr.Append(inputStr[i]);
                }
            }

            Console.WriteLine(encryptStr);
            Console.ReadLine();
        }
    }
}
