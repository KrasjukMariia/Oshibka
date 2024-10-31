using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KrasyukME.Sprint3.Task0.V13.Lib
{

    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double S = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                S = S + ((Math.Pow(value, i)) + (0.5)) * Math.Cos(i);

            }

            return Math.Round(S, 3);

        }
    }
}
