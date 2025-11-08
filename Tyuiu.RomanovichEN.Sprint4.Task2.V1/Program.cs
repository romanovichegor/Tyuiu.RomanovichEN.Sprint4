using System.Security.Cryptography;
using Tyuiu.RomanovichEN.Sprint4.Task2.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = " Спринт #4 | Выполнил: Романович Е. Н. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы(генератор случайных чисел)                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Романович Егор Николаевич | ПКТб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        int len;
        Console.WriteLine("Количество элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = rnd.Next(1,9);
        }
        Console.WriteLine("Mассив:");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(array[i] + "\t");
        }
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write(ds.Calculate(array));
        Console.ReadKey();
    }
}