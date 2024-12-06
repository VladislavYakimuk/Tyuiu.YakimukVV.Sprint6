using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YakimukVV.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            for (int i = 0; i <= stopValue - startValue; i++)
            {
                int x = startValue + i;
                double fx;

                if (x == -2) 
                {
                    fx = 0;
                }
                else
                {
                    fx = Math.Cos(x) + Math.Cos(x) / (x + 2) - 3 * x;
                }

                result[i] = Math.Round(fx, 2); 
            }
            return result;
        }
    }
}
