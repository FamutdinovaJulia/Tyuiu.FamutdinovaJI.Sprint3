using Tyuiu.FamutdinovaJI.Sprint3.Task2.V6.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("* Переменная Х = " + value);
            Console.WriteLine("* Старт шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + res);

            Console.ReadLine();
        }
    }
}
