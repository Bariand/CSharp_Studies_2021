using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    internal static class Program
    {
        //Criar jagged array com 3 pessoas, onde cada pessoa tem dois parentes;
        //Fazer com que as pessoas introduzam os parentes para cada uma pelo console.
        

        private static void Main(string[] args)
        {
            string[][] FriendsJaggedArray3 = new string [][]
            {
                new string[] {"Robocop", "Terminator"},
                new string[] {"Alien", "Predator"},
                new string[] {"Billy", "Jimmy"}
            };

            const int i = 0;
            do
            {
                Console.Clear();
                Console.WriteLine
                (
                    "Who will introduce his'/her's relatives?\n" +
                    "(1) Murphy O'Connor \n" +
                    "(2) Rippley Dutch \n" +
                    "(3) Mr. Lee"
                );
                string input = Console.ReadLine();
                int intInput;
                bool tryParseResult = int.TryParse(input, out intInput);
                

                if (tryParseResult)
                {
                    if (intInput == 1)
                    {
                        Console.WriteLine("This are my relatives, {0} and {1}.", FriendsJaggedArray3[0][0], FriendsJaggedArray3[0][1]);
                        Console.ReadLine();
                    }
                    else if (intInput == 2)
                    {
                        Console.WriteLine("This are my relatives, {0} and {1}.", FriendsJaggedArray3[1][0], FriendsJaggedArray3[1][1]);
                        Console.ReadLine();
                    }
                    else if (intInput == 3)
                    {
                        Console.WriteLine("This are my relatives, {0} and {1}.", FriendsJaggedArray3[2][0], FriendsJaggedArray3[2][1]);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Use only numeral keys from 1 to 3.");
                        Console.ReadLine();
                    }
                }
                else 
                {
                    Console.WriteLine("Oh, come on! You didn't even type a number? Are you trying to crash the program, my dude? :/");
                    Console.ReadLine();
                }
          
            }
            while (i == 0);
        }
    }
}
