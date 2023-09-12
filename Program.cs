using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("50");
            // you can use all the normal operators straight into the brackets 

            Console.WriteLine(5 + 2);
            Console.WriteLine(5 - 2);
            Console.WriteLine(5 * 2);
            Console.WriteLine(5/2.0);
            Console.WriteLine("5 divided by 2 is " + " " + 5 / 2 + " remainder " + 5 % 2);

            int num1 = 2;
            num1 = num1 + 1;
            num1+=3;
            Console.WriteLine("num1=  " + num1);

            //an easy way of doing it

            int num2 = 2;
            num2++;
            Console.WriteLine("Num2= " +num2);

            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Min(5, 40));
            Console.WriteLine(Math.Pow(2, 2));

             





           









            Console.ReadLine();


        }
    }
}
