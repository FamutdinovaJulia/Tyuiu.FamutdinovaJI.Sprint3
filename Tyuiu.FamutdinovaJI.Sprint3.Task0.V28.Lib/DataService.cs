using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries *= (Math.Pow(value, 3) * startValue) + 2;
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
