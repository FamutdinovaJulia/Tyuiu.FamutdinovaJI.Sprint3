using Tyuiu.FamutdinovaJI.Sprint3.Task5.V6.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Старт шага 1-ой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага 1-ой суммы ряда = " + stopValue1);
            Console.WriteLine("Старт шага 2-ой суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага 2-ой суммы ряда = " + stopValue2);

            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма сумм ряда = " + res);

            Console.ReadLine();
        }
    }
}
