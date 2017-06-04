using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {


            var number = byte.Parse(Console.ReadLine());
            var multiplier = byte.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("{0} X {1} = {2}",
                number, multiplier, number * multiplier);
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
