using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mgi4eskiDumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');

            string s = num[0];
            string s1 = num[1];

            bool rep = AStringsR(s1, s);

            Console.WriteLine(rep);
        }

        static bool AStringsR(string str, string str1)
        {
            if (str.Length != str1.Length && str1.Length > str.Distinct().Count())
            {
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                char c1 = str[i];
                char c2 = str1[i];

                if (c1 != c2)
                {
                    if (str.IndexOf(c1) != str1.IndexOf(c2))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
