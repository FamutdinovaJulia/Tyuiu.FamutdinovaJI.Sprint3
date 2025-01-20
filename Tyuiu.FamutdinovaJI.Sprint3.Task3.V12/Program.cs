using Tyuiu.FamutdinovaJI.Sprint3.Task3.V12.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "bkkrk ckkkcs ksr";
            char chr = 'k';

            Console.WriteLine("* Исходная строка: " + value);
            Console.WriteLine("* Искомый символ: " + chr);

            double res = ds.GetMaxCharCount(value, chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Максимльное кол-во = " + res);

            Console.ReadLine();
        }
    }
}
