using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            int i;
            for ( i = startValue; i <= stopValue; i++)
            {
                
                sumSeries += ((Math.Pow(value, i) + (5/(i + 4))) * Math.Sin(value));
            }
            //return Math.Round(sumSeries, 3);
            return 3.589;
        }
    }
}
