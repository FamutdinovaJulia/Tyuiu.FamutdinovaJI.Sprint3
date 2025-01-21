using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task7.V22.Lib
{
    public class DataService : ISprint3Task7V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) + (Math.Cos(x * 2) / 2) - (1.5 * x)), 2);
                valueArray[count] = y;
                count++;
                
            }
            return valueArray;
        }
    }
}
