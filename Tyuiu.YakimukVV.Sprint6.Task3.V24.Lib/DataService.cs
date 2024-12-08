using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YakimukVV.Sprint6.Task3.V24.Lib
{
    public class DataService : ISprint6Task3V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5)
            {
                throw new ArgumentException("Матрица должна быть размером 5x5.");
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[1, j] % 2 == 0)
                {
                    matrix[1, j] = 0;
                }
            }
            return matrix;
        }
    }
}
