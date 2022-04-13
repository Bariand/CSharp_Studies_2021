using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta é outra forma de instanciar um objeto. Esta usa encapsulamento, com variáveis privadas, sendo mais avançada.
namespace CSharp_MasterClass_6___OOP
{
    class SpaceShip
    {
        //Estas são chamadas de "variáveis membro"
        private string spaceShipName;
        private int speed;
        private int hull;
        private int gearSpace;
        private string mainWeapon;

        //Constructor abaixo
        //Há duas formas de fazê-lo: usando "my"+"nome da variável local" após o sinal de igual
        //Ou usando "this."+"noma da variável membro" antes do sinal de igual para indicar que
        //esta é a variável membro.
        //As variáveis nos parênteses do método são chamadas "variáveis locais".
        public SpaceShip(string mySpaceShipName, int mySpeed, int hull, int gearSpace, string mainWeapon) 
        {
            spaceShipName = mySpaceShipName;
            speed = mySpeed;
            this.hull = hull;
            this.gearSpace = gearSpace;
            this.mainWeapon = mainWeapon;
        }

        public void SpaceShipAction() 
        {
            Console.WriteLine
                (
                "Designation: {0} \n" +
                "Speed: {1} \n" +
                "Hull Strength: {2} \n" +
                "Total Gear Slots: {3} \n" +
                "Main Weapon: {4} "
                , spaceShipName, speed, hull, gearSpace, mainWeapon
                );
        }
    }
}
