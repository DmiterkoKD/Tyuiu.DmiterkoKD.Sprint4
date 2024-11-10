using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DmiterkoKD.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            List<string> filteredModes = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 7)
                {
                    filteredModes.Add(array[i]);
                }
            }
            string[] resultArray = filteredModes.ToArray();
            return resultArray;
        }
    }
}
