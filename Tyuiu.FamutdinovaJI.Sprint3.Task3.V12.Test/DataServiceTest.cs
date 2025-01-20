using Tyuiu.FamutdinovaJI.Sprint3.Task3.V12.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "bkkrk ckkkcs ksr";
            char chr = 'k';

            int res = ds.GetMaxCharCount(str, chr);

            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}