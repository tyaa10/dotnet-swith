using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input smth: ");
            string numString = Console.ReadLine();
            Console.WriteLine(
                Regex.IsMatch(numString, @"^[0-9A-z]{1,50}[@][0-9A-z]{1,50}([\.][A-z]{2,3}){1,2}$")
                );
        }
    }
}
