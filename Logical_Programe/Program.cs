﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to programe");
            Console.WriteLine("1:Fibonacci Series");
            Console.WriteLine("Enter the Number:");

            var option=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------");

            switch(option)
            {
                case 1:
                    Assignment.Fibonacci_Series();
                    break;

                
            }
            
            Console.ReadLine();
        }
    }
}