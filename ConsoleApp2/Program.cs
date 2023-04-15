
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class KmmBmm
    {
        static void Main()
        {
            Console.Write("Please enter num 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter num 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("KMM = " + Kmm(num1, num2));
            Console.WriteLine("BMM = " + Bmm(num1, num2));
        }

        public static int Kmm(int a, int b)
        {
            int max;
            if (a > b)
                max = a;
            else
                max = b;

            while (true)
            {
                if (max % a == 0 && max % b == 0)
                    break;
                else
                    ++max;
            }
            return max;
        }

        public static int Bmm(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
}
