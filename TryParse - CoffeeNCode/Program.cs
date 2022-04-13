using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse___CoffeeNCode
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bContinue = true;

            while (bContinue) 
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();
                
                //linha abaixo é a mesma int num dentro do if statement
                //int num = 0;

                //"out num" faz o output do método (um "int" se a conversão der certo,
                //ou "zero" se não for possível. "num" é uma variável que criamos acima.
                //Pode ser qualquer nome.

                //linha abaixo pode ser colocada dentro do if statement ou ficar acima,
                //como ná linha abaixo
                //bool success = Int32.TryParse(numInput, out num);

                //este seria o if statement se as duas linhas acima ficarem fora
                //do if statement
                //if (success)

                //Este é o if statement condensado, sem necessitar das linhas acima
                if(Int32.TryParse(numInput, out int num))
                {
                    bContinue = false;
                    Console.WriteLine(num);
                }
                else 
                {
                    Console.WriteLine("Incorrect value entered.");
                }
            }
            Console.WriteLine("Good bye");

            Console.ReadLine();
        }
    }
}
