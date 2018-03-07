using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeRearranging pr = new PalindromeRearranging();
            Console.WriteLine(pr.IsPalindromeRearrangin("abbcdac"));
            Console.WriteLine(pr.IsPalindromeRearrangin("abccba"));
        }
    }
}
