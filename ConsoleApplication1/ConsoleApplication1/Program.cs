﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ffx");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("GG");
            }
        }
        public static void(){};
    }
}
