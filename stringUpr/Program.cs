using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringUpr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int decimal2 = int.Parse(input[1]);

            string result = "";
            if (decimal2 > 0)
            {
                int remainder = decimal2 % n;
                result = remainder.ToString() + result;
                decimal2 /= n;
            }
            
            Console.WriteLine(result);
        }
    }
}
