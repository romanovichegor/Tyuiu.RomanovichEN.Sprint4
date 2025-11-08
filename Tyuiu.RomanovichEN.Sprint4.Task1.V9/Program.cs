using Tyuiu.RomanovichEN.Sprint4.Task1.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = " Спринт #4 | Выполнил: Романович Е. Н. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы(ввод с клавиатуры)                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
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
            Console.WriteLine("Введите значение "+ i + " элемента массива");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write(ds.Calculate(array));
        Console.ReadKey();
    }
}