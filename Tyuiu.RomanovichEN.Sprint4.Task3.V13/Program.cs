using Tyuiu.RomanovichEN.Sprint4.Task3.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = new int[5, 5] { { 4, 7, 4, 2, 1 },{ 6, 7, 3, 6, 5 },{ 6, 5, 3, 3, 5 },{ 4, 4, 6, 4, 7 },{ 2, 1, 2, 3, 4 } };
        int rows = array.GetUpperBound(0) + 1;
        int cols = array.Length / rows;
        DataService ds = new DataService();
        Console.Title = " Спринт #4 | Выполнил: Романович Е. Н. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы(статичный ввод)                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Романович Егор Николаевич | ПКТб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("Mассив:");       
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write(ds.Calculate(array));
        Console.ReadKey();
    }
}