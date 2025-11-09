using System.Data.Common;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RomanovichEN.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] array = new int[n, m];
            int ind = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(value.Substring(i * m + j, 1));
                    ind++;
                }
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count += array[i, j];
                    }

                }
            }
            return count;
        }
    }
}
