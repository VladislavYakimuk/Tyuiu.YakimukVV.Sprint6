using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YakimukVV.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task1V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue) throw new ArgumentException("Начальное значение не может быть больше стопового значения.");

            int size = stopValue - startValue + 1;
            double[] results = new double[size];

            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double fx;
                try
                {
                    fx = Math.Sin(x) + Math.Cos(2 * x) / 2 - 1.5 * x;
                }
                catch (DivideByZeroException)
                {
                    fx = 0; 
                }
                results[i] = Math.Round(fx, 2); 
            }

            return results;
        }
    }
}
