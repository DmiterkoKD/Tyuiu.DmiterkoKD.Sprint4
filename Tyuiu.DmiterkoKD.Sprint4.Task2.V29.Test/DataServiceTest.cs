using Tyuiu.DmiterkoKD.Sprint4.Task2.V29.Lib;
namespace Tyuiu.DmiterkoKD.Sprint4.Task2.V29.Test
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

            int[] ar = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7};

            int res = ds.Calculate(ar);
            int wait = 12;

            Assert.AreEqual(res, wait);
        }
    }
}