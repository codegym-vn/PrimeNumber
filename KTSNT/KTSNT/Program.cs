using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTSNT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number: ");
            var input = Console.ReadLine();
            var isNumber = int.TryParse(input, out int number);

            if (isNumber)
            {
                if (Is_Prime_01(number))
                    Console.WriteLine(number + " is Prime");
                else
                    Console.WriteLine(number + " is NOT Prime");
            }
            else
                Console.WriteLine("Invalid number");

            Console.ReadLine();
        }

        /// <summary>
        /// Cach 1
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool Is_Prime_01(int number)
        {
            if (number < 2)
                return false;

            if (number == 2)
                return true;

            var sqrt_n = Math.Sqrt(number);
            int i = 3;
            do
            {
                i += 2;
                if (number % i == 0)
                    return false;
            } while (i <= sqrt_n);

            return true;
        }

        /// <summary>
        /// Cach 2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool Is_Prime_02(int n)
        {
            if ((n == 2) || (n == 3))
            {
                return true;
            }
            if ((n % 2 == 0) || (n % 3 == 0) || (n < 2))
            {
                return false;
            }
            int i = -1;
            var sqrt_n = Math.Sqrt(n);
            do
            {
                i += 6;
                if ((n % i == 0) || (n % (i + 2) == 0))
                {
                    break;
                }
            } while (i <= sqrt_n);
            return (i > sqrt_n);
        }
    }
}
