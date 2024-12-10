using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YakimukVV.Sprint6.Task5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"File not found at path: {path}");

            var lines = File.ReadAllLines(path);
            var data = new List<double>();

            foreach (var line in lines)
            {
                if (double.TryParse(line, NumberStyles.Any, CultureInfo.InvariantCulture, out var value))
                {
                    data.Add(Math.Round(value, 3));
                }
            }

            return data.ToArray();
        }
    }
}
