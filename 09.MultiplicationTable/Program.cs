﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var times = 1;
            while (times <= 10)
            {
                Console.WriteLine("{0} X {1} = {2}",
                    number,times,number*times);
                times++;
            }
        }
    }
}
