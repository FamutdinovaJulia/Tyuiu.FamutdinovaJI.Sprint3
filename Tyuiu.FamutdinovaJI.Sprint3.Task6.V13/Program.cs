using Tyuiu.FamutdinovaJI.Sprint3.Task6.V13.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 8;
            int stopValue = 17;

            Console.WriteLine("* Начало отрезка: " + startValue);
            Console.WriteLine("* Конец отрезка: " + stopValue);

            double res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма делителей = " + res);

            Console.ReadLine();
        }
    }
}
