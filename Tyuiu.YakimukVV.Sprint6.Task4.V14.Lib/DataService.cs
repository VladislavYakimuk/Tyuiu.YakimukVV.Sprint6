using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YakimukVV.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];
            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                try
                {
                    double denominator = Math.Sin(x) + 1;
                    if (Math.Abs(denominator) < 1e-10) 
                        results[i] = 0;
                    else
                        results[i] = Math.Round(2 * x - 4 + (2 * x - 1) / denominator, 2);
                }
                catch
                {
                    results[i] = 0;
                }
            }
            return results;
        }
    }
}
