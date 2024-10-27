using Tyuiu.DmiterkoKD.Sprint4.Task0.V15.Lib;
namespace Tyuiu.DmiterkoKD.Sprint4.Task0.V15.Test
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
            int[] k = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int wait = 138915;
            int res = ds.GetMultOddArrEl(k);
            Assert.AreEqual(wait, res);
        }
    }
}