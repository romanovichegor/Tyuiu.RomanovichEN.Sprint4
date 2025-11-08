using Tyuiu.RomanovichEN.Sprint4.Task0.V15.Lib;
namespace Tyuiu.RomanovichEN.Sprint4.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int a, b, c;
            a = 1;
            b = 2;
            c = 3;
            int[] array = new int[] { a, b, c };
            int wait = 3;
            int res = ds.GetMultOddArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}
