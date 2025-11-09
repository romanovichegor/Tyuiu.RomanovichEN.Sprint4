using Tyuiu.RomanovichEN.Sprint4.Task4.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = " Спринт #4 | Выполнил: Романович Е. Н. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы(ввод с клавиатуры)                              *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Романович Егор Николаевич | ПКТб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        int rows,columns;
        Console.WriteLine("Количество строк массива:");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Количество столбцов массива:");
        columns = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[rows,columns];
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine("Введите " + i + "," + j + " элемент массива");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        array = ds.Calculate(array);
        for (int i = 0; i < rows; i ++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} \t ");
            }
            Console.WriteLine();
        }
        Console.Write(ds.Calculate(array));
        Console.ReadKey();
    }
}