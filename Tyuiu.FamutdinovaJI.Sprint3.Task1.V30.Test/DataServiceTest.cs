using Tyuiu.FamutdinovaJI.Sprint3.Task1.V30.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 12;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 1.959;

            Assert.AreEqual(wait, res);
        }
    }
}