using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevejdaneotNdo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] probno = Console.ReadLine().Split(' ');

            int sbase = int.Parse(probno[0]);
            string sourceNum = probno[1];

            int decimalNum = 0;
            for (int i = 0; i < sourceNum.Length; i++)
            {
                int digit = sourceNum[i] - '0';
                decimalNum = decimalNum * sbase + digit;
            }

            Console.WriteLine(decimalNum);
        }
    }
}
