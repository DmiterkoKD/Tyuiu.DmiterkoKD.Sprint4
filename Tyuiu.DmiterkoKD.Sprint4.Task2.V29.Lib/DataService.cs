using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DmiterkoKD.Sprint4.Task2.V29.Lib
{
    public class DataService : ISprint4Task2V29
    {
        public int Calculate(int[] array)
        {
            int s = 1;
            for (int i = 0; i < array.Length; i++)
            {
                int k = array[i];
                if (k % 2 == 0)
                {
                    s *= k;
                }
            }
            return s;
        }
    }
}
