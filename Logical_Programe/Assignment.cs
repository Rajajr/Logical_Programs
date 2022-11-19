using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programe
{
    public class Assignment
    {
        public static void Fibonacci_Series()
        {
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
        public static void Prime_Number()
        {
            int number;
            int result = 0;
            Console.WriteLine("Enter the Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------");
            for (int i = 1; i <=number; i++)
            {
                if (number % i==0)
                {
                    result++;
                }
            }
            if(result ==2)
            {
                Console.WriteLine("The entered number is a Prime Number");
            }
            else
            {
                Console.WriteLine("The entered number is not a Prime Number");
            }
        }
    }
}
