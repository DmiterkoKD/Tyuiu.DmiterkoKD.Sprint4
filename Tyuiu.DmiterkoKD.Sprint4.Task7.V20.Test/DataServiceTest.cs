using Tyuiu.DmiterkoKD.Sprint4.Task7.V20.Lib;
namespace Tyuiu.DmiterkoKD.Sprint4.Task7.V20.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            int rows = 5;
            int cols = 3;
            int[,] mtrx = new int[rows, cols];
            string str = "357951248632587";

            int res = ds.Calculate(rows, cols, str);
            int wait = 6144;
            Assert.AreEqual(res, wait);


        }
    }
}