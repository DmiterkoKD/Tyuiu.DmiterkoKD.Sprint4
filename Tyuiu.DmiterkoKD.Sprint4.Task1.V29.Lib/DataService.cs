using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DmiterkoKD.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task1V29
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int k = array[i];
                if (k%2!=0)
                {
                    s += k;
                }
            }
            return s;
        }
    }
}
