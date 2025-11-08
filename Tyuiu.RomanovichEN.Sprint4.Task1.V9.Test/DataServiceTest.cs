using Tyuiu.RomanovichEN.Sprint4.Task1.V9.Lib;
namespace Tyuiu.RomanovichEN.Sprint4.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a, b, c;
            a = 1;b = 2;c = 3;
            int[] array = new int[] { a, b, c };
            int wait = 2;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
