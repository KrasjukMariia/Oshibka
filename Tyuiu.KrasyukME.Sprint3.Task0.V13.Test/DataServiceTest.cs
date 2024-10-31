    using Tyuiu.KrasyukME.Sprint3.Task0.V13.Lib;
    namespace Tyuiu.KrasyukME.Sprint3.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int StartValue = 1;
            int StopValue = 20;

            double res = ds.GetSumSeries(value, StartValue, StopValue);

            double wait = 0.298;

            Assert.AreEqual(wait, res);
        }
    }
}