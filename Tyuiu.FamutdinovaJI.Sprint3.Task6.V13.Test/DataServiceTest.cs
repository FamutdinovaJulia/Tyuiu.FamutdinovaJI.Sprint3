using Tyuiu.FamutdinovaJI.Sprint3.Task6.V13.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 8;
            int stopValue = 17;

            double res = ds.GetSumTheDivisors(startValue, stopValue);

            double wait = 117;

            Assert.AreEqual(wait, res);
        }
    }
}