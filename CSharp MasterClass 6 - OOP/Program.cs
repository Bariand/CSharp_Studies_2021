using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MasterClass_6___OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human denis = new Human();
            denis.firstName = "Denis";
            denis.lastName = "João";
            denis.IntroduceMyself();

            Human michael = new Human();
            michael.firstName = "Michael";
            michael.lastName = "Bráulio";
            michael.IntroduceMyself();
            Console.ReadKey();
            Console.Clear();

            SpaceShip battleSaucer = new SpaceShip("Battle Saucer", 2, 3, 6, "Laser Beam Cannon");
            battleSaucer.SpaceShipAction();
            Console.ReadKey();
        }
        
    }
}
