using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RomanovichEN.Sprint4.Task1.V9.Lib
{
    public class DataService : ISprint4Task1V9
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i =0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    p*=array[i];
            }
            return p;
        }
    }
}
