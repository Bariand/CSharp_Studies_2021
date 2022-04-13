using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create an application that takes 2 input values.
Any input value (1st input)
Asks the data type of the input value. (2nd input)
It will print to the console the options like below to take input for the 2nd input value:
Press 1 for String
Press 2 for integer
Press 3 for Boolean
If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)
If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.
Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.
Please make sure to use a switch statement. To check the valid string you can write your custom logic.
For example:
Enter a value: { here you can enter any value
Select the Data type to validate the input you have entered.
Press 1 for String
Press 2 for Integer
Press 3 for Boolean
Here, if you enter 1 it should return below message
You have entered a value: Denis Panjuta
It is a valid: String
Here, if you enter 2 it should return below message
You have entered a value: Denis Panjuta
It is an invalid: Integer */

namespace CSMC___Foreach_Loops_and_Switch_Statement_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert 1st value. It can be anything: ");
            string anything = Console.ReadLine();
            Console.WriteLine
                (
                "Insert 2nd value. It can be one of the following: \n" +
                "(1) String\n" +
                "(2) Integer\n" +
                "(3) Boolean\n" +
                "Now choose one of the above"
                );

            string varSelection = Console.ReadLine();
            int intVarSelection = int.Parse(varSelection);

            switch (intVarSelection)
            {
                case 1:
                    Console.WriteLine("You chosen String. Insert a value of this type: ");
                    string secondVariable = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Your 1st value was {0} and your second value was {1}.", anything, secondVariable);
                        Console.ReadKey();
                    }
                    catch
                    {
                        Console.WriteLine("You chose an invalid type! What's wrong with you?");
                        Console.ReadKey();
                    }
                    
                    break;
                case 2:
                    Console.WriteLine("You chosen Integer. Insert a value of this type: ");
                    string secondVariable2 = Console.ReadLine();
                    try
                    {
                        int intSecondVariable = int.Parse(secondVariable2);
                        Console.WriteLine("Your 1st value was {0} and your second value was {1}.", anything, intSecondVariable);
                        Console.ReadKey();
                    }
                    catch
                    {
                        Console.WriteLine("You chose an invalid type! What's wrong with you?");
                        Console.ReadKey();
                    }
                   
                    break;
                case 3:
                    Console.WriteLine("You chose Boolean. Insert a value of this type: ");
                    string secondVariable3 = Console.ReadLine();
                    try
                    {
                        bool boolSecondVariable = bool.Parse(secondVariable3);
                        Console.WriteLine("Your 1st value was {0} and your second value was {1}.", anything, boolSecondVariable);
                        Console.ReadKey();
                    }
                    catch
                    {
                        Console.WriteLine("You chose an invalid type! What's wrong with you?");
                        Console.ReadKey();
                    }
                    break;
                    default:
                    try
                    {
                        Console.WriteLine("You chose an invalid type! What's wrong with you?");
                        Console.ReadKey();
                    }
                    catch 
                    {

                    }
                    break;
            }
        }
    }
}
