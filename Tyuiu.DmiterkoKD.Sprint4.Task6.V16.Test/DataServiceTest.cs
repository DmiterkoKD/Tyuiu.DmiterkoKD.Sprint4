using Tyuiu.DmiterkoKD.Sprint4.Task6.V16.Lib;
namespace Tyuiu.DmiterkoKD.Sprint4.Task6.V16.Test
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
            var week = new string[] { "����������", "���������", "�������", "�����", "�������", "����������", "�����" };
            string[] res = ds.Calculate(week);
            var wait = new string[] { "�������", "�������"};
            Assert.AreEqual(res, wait);
        }
    }
}