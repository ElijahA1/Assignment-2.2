using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    public class MathyMath
    {
        public static void add(int num1, int num2)
        {
            Console.WriteLine($"\nThe sum is {num1 + num2}");
        }
        public static void add(decimal num1, decimal num2)
        {
            Console.WriteLine($"\nThe sum is {num1 + num2}");
        }
        public static void multiply(float num1, float num2)
        {
            Console.WriteLine($"\nThe product is {num1 * num2}");
        }
        public static void multiply(float num1, float num2, float num3)
        {
            Console.WriteLine($"\nThe product is {num1 * num2 * num3}");
        }
    }
}
