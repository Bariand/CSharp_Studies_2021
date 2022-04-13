using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Master_Class___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays podem ser criados como exposto abaixo, insicando que o array tem 5 valores
            int[] numbers = new int[5];
            //Ele pode ser declarado sem dizer nem valores, nem tamanho
            int[] coisasVelhas;
            //Ele pode decralar seu conteúdo todo de início
            string[] friends = { "Kur", "Alistair", "Sarhu", "Malakaye", "Ereshkigal" };

            //Foreach é usado para modificar, acessar ou utilizar todos os membros de um array
            //Ele faz a contagem automática de todos os elementos até seu "length".
            //Pode-se utilizar o "for" também.
            foreach (string y in friends) 
            {
                Console.WriteLine("Hi, I'm {0}", y);
                
            }
            Console.ReadKey();
        }
    }
}
