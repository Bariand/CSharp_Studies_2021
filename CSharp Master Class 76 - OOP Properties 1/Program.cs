using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Master_Class_76___OOP_Properties_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //Aqui embaixo está sendo usada a propriedade "SetLength" para alterar o
            //valor da variável privada length
            box.SetLength(3);
            box.SetHeight(2);
            box.Width = 5;
            box.Color = "green";

            //No código abaixo estamos "getting" o valor da variável privada length
            //com a propriedade "GetLength"
            Console.WriteLine("Box Length is " + box.GetLength());
            //Não há linha para height pois acredito que não é possível acessar seu valor
            //de fora da classe sem criar um "getter" para ele.
            //Abaixo acessando "Width"
            Console.WriteLine("Box Width is " + box.Width);
            //Perceba que "color" é declara sem o uso do parêntesis de método
            Console.WriteLine("Box Color is " + box.Color);
            //Cálculo da área frontal do cubo
            Console.WriteLine("Box Front Surface is " + box.FrontSurface());
            //No código abaixo estamos "getting" o valor da variável privada volume
            //com a propriedade "GetVolume"
            Console.WriteLine("Box Volume is " + box.GetVolume());
            
            

            box.DisplayInfo();
            Console.ReadKey();
        }
    }
}
