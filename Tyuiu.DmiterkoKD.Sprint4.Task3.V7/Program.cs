using Tyuiu.DmiterkoKD.Sprint4.Task3.V7.Lib;
namespace Tyuiu.DmiterkoKD.Sprint4.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая из целочисленного двумерного статического   *");
            Console.WriteLine("* массива подсчитает количество нечетных элементов массива.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mas = new int[5, 5] {{ 9, 6, 9, 3, 7 },
                                        {3, 3, 3, 8, 2 },
                                        {2, 1, 3, 5, 2 },
                                        {6, 2, 3, 2, 5 },
                                        {4, 5, 6, 9, 5 } };

            int rows = mas.GetUpperBound(0) + 1;
            int cols = mas.Length / rows;
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j<cols; j++)
                {
                    Console.WriteLine($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mas);
            Console.WriteLine("Количество нечетных элементов = "+res);
        }
    }
}
