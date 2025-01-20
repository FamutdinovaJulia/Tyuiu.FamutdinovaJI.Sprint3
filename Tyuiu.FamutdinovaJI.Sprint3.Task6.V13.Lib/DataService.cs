using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 9; d <= x; d++)
                {
                    if ((x % d == 0))
                    {
                        sum += d;
                    }
                }

            }
            return sum;
        }
    }
}
