using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberDetector
{
    internal class Program
    {
        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            int sqrt = (int)Math.Sqrt(num);
            for (int i = 2; i <= sqrt; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(3));
            Console.WriteLine(IsPrime(5));
            Console.WriteLine(IsPrime(7));
            Console.WriteLine(IsPrime(11));
            Console.WriteLine(IsPrime(13));
            Console.WriteLine(IsPrime(17));
            Console.WriteLine(IsPrime(19));
            Console.WriteLine(IsPrime(-2));
            Console.WriteLine(IsPrime(1234));
        }
    }
}
