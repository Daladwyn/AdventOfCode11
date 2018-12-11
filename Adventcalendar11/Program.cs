using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventcalendar11
{
    class Program
    {
        static void Main(string[] args)
        {
            int frequency = 0;
            var fileToCalculate = File.ReadAllLines("c:/Input.txt");
            foreach (var changeInfrequency in fileToCalculate)
            {
                frequency = frequency + Convert.ToInt32(changeInfrequency);
            }
            Console.WriteLine(frequency);
            Console.ReadKey();
        }
    }
}
