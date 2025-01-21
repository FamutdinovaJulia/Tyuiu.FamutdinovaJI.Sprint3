using Tyuiu.FamutdinovaJI.Sprint3.Task7.V22.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("* Исходная строка: " + startValue);
            Console.WriteLine("* Искомый символ: " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArrey;
            valueArrey = new double[len];

            valueArrey = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+---------------+---------------+");
            Console.WriteLine("|       X       |      F(x)     |");
            Console.WriteLine("+---------------+---------------+");
                             //  | {0,5:d}      |  {1,5:F2}    |
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|   {0,5:d}       |     {1,5:F2}     |", startValue, valueArrey[1]);
                startValue++;
            }
            Console.WriteLine("+---------------+---------------+");
            Console.ReadKey();
        }
    }
}
