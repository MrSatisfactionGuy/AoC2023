using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2023.D01
{
    public class ApplierD01
    {
        public ApplierD01() { }

        public bool Apply()
        {
            Console.WriteLine("Welcome to the first Advent of Code");

            string localPath = "C:\\Users\\eduard.wagner\\Desktop\\AoC2023_D1.txt";
            string input = "1abc2\r\npqr3stu8vwx\r\na1b2c3d4e5f\r\ntreb7uchet\r\n";
            string output = String.Empty;
            double val = 0;

            FileReadingClass frc = new FileReadingClass();
            string[] placeholder = frc.ReadAllLines(localPath);
            int one = 0;
            int two = 0;

            int sum = one + two;

            foreach (string i in placeholder)
            {
                var first = i.ToCharArray().ToList().First();
                var last = i.ToCharArray().ToList().Last();

                foreach (char y in i.ToCharArray())
                {
                    if (Char.IsDigit(y))
                    {
                        //Console.WriteLine(y);
                        output += y;
                        if (output.Length == 2)
                        {
                            val += Int32.Parse(output);
                            //Console.WriteLine(val);
                            output = "";
                        }
                    }
                }
            }

            Console.WriteLine(val);

            //Console.WriteLine(output);

            //Console.WriteLine(placeholder);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (Char.IsDigit(input[i]))
            //    {
            //        output += input[i];
            //    }

            //    var path = Path.GetDirectoryName(input);

            //    if (output.Length == 2)
            //    {
            //        val += int.Parse(output);
            //        output = "";
            //    }

            //}

            //Console.WriteLine(val);

            Console.ReadKey();


            return true;
        }
    }
}
