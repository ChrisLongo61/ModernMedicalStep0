using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMedicalStep0
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = string.Empty;
            for (var number = 1; number < 101; number++)
            {
                if (number % 3 == 0)
                {
                    output = "Modern";
                }
                if (number % 5 == 0)
                {
                    output += "Medical";
                }
                if (string.IsNullOrEmpty(output))
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine(output);
                    output = string.Empty;
                }
            }
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
