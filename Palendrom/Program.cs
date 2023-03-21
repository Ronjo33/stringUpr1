using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palendrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            bool Palindrome = IPalindrome(num);

            Console.WriteLine(Palindrome);
        }

        static bool IPalindrome(string num)
        {
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
