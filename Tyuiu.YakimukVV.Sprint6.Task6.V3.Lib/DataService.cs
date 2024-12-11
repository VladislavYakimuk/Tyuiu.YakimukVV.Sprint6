using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YakimukVV.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        public string CollectTextFromFile(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Path cannot be null or empty");

            if (!File.Exists(path))
                throw new FileNotFoundException($"File not found at path: {path}");

            try
            {
                var content = File.ReadAllText(path);
                var wordsWithR = content
                    .Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(word => word.Contains('r') || word.Contains('R'))
                    .ToArray();
                return string.Join(" ", wordsWithR);
            }
            catch (Exception ex)
            {
                throw new IOException("An error occurred while processing the file.", ex);
            }
        }
    }
}
