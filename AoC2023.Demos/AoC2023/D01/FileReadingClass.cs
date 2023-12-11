using System.Xml.Serialization;

namespace AoC2023.D01
{
    public class FileReadingClass
    {
        public string[] ReadAllLines(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                return lines;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
