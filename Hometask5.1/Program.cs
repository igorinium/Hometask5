using System;

namespace Hometask5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix;
            while (true)
            {
                Console.Write("Введите размер квадратной матрицы: ");
                bool isParseSuccess = int.TryParse(Console.ReadLine(), out sizeMatrix);
                if (isParseSuccess && sizeMatrix > 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное число");
                }
            }

            int[,] matrix = new int[sizeMatrix, sizeMatrix];
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    Console.WriteLine($"Введите элемент {i + 1} строки, {j + 1} столбца");
                    bool isParseSuccess = int.TryParse(Console.ReadLine(), out matrix[i, j]);
                    if (!isParseSuccess)
                    {
                        Console.WriteLine("Вы ввели неправильное число");
                        j--;
                    }
                }
            }

            int sumSideDiagonal = 0;
            for (int i = 0, j = sizeMatrix - 1; i < sizeMatrix; i++, j--)
            {
                sumSideDiagonal += matrix[i, j];
            }

            Console.WriteLine($"Сумма побочной диагонали равна: {sumSideDiagonal}");
            int sumUnderSideDiagonal = 0;
            for (int i = 1; i < sizeMatrix; i++)
            {
                int j = 0;
                while (j < i)
                {
                    sumUnderSideDiagonal += matrix[i, sizeMatrix - 1 - j];
                    j++;
                }
            }

            Console.WriteLine($"Сумма элементов ниже побочной диагонали равна: {sumUnderSideDiagonal}");
            Console.ReadLine();
        }
    }
}
