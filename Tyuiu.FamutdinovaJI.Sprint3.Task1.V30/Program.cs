using Tyuiu.FamutdinovaJI.Sprint3.Task1.V30.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 12;

            Console.WriteLine("* Переменная Х = ", +value);
            Console.WriteLine("* Старт шага = ", +startValue);
            Console.WriteLine("* Конец шага = ", +stopValue);

            double res = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + res);

            Console.ReadLine();
        }
    }
}
