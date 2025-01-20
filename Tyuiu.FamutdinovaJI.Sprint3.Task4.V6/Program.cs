using Tyuiu.FamutdinovaJI.Sprint3.Task4.V6.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task4.V6
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

            Console.WriteLine("* Старт шага: " + startValue);
            Console.WriteLine("* Конец шага: " + stopValue);

            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + res);

            Console.ReadLine();
        }
    }
}
