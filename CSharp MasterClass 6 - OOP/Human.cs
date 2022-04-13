using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta é uma forma de instanciar um objeto. Esta forma usa mais código
namespace CSharp_MasterClass_6___OOP
{
    class Human
    {
        //variáveis membro
        public string firstName;
        public string lastName;

        //isso aqui embaixo é uma "member method, porque está dentro de um método
        public void IntroduceMyself() 
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}
