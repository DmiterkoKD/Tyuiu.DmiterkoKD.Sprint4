using Tyuiu.DmiterkoKD.Sprint4.Task4.V19.Lib;
namespace Tyuiu.DmiterkoKD.Sprint4.Task4.V19.Test
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
            int[,] mas = new int[5, 5] {{ 6, 7, 3, 5, 1 },
                                        {6, 5, 2, 2, 7},
                                        {2, 6, 4, 6, 6},
                                        {7, 5, 5, 2, 6},
                                        {3, 1, 5, 7, 7} };

            int res = ds.Calculate(mas);
            int wait = 68;
            Assert.AreEqual(res, wait);
        }
    }
}