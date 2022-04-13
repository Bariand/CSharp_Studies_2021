using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter_MethodsExercise
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please, write a sentence about food to count the number of words. Be careful to not use spaces where they are not needed!");
            string input1 = Console.ReadLine();
            WordCounter(input1);

            Console.WriteLine("Now, write a sentence about videogames to count the number of words:");
            string input2 = Console.ReadLine();
            WordCounter(input2);

            Console.WriteLine("Maybe write a sentence about your faith now?");
            string input3 = Console.ReadLine();
            WordCounter(input3);
        }

        private static void WordCounter(string frase)
        {
            int number = frase.Split(' ').Length;
            Console.WriteLine("Your frase has {0} words total.", number);
            Console.ReadKey();
        }
    }
}
