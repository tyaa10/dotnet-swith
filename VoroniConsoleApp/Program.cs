using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VoroniConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool theEnd;
            do
            {
                theEnd = false;
                Console.WriteLine("Input a number: ");
                string numString = Console.ReadLine();
                //TODO validate string
                string template = "^[0-9]{1,10}$";
                if (!Regex.IsMatch(numString, template))
                {
                    continue;
                }
                int num = Int32.Parse(numString);
                int num100 = num % 100;
                if (num100 >= 11 && num100 <= 14)
                {
                    Console.WriteLine("Voron");
                }
                else
                {
                    int num10 = num % 10;
                    switch (num10)
                    {
                        case 1:
                            {
                                Console.WriteLine("Vorona");
                                break;
                            }
                        case 2:
                        case 3:
                        case 4:
                            {
                                Console.WriteLine("Voroni");
                                break;
                            }
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 0:
                            {
                                Console.WriteLine("Voron");
                                break;
                            }
                        default:
                            break;
                    }
                }

                
                do
                {
                    Console.WriteLine("Continue? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        break;
                    }
                    else if (answer == "n")
                    {
                        theEnd = true;
                        break;
                    }
                } while (true);
            } while (!theEnd);

            
        }
    }
}
