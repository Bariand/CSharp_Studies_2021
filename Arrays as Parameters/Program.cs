using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_as_Parameters
{
    //Criar um array de "happiness" no "main method" e colocar 5 valores;
    //Criar um método "SunIsShining" do tipo int;
    //Este método deve aumentar o argumento para +2 para cada entrada;
    //Chame o método no método "main" e use "happiness" como argumento;
    //Crie um loop foreach no método principal para escrever todos os valores no console.

    static class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 1, 2, 3, 4, 5 };
            double averageResult = GetAverage(studentsGrades);

            int[] happiness = { 2, 3, 4, 5, 6 };
            SunIsShinning(happiness);

            foreach (int y in happiness) 
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();

            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            Console.WriteLine("The average is: {0}", averageResult);
            Console.ReadKey();

            SunIsShinning(happiness);
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[1];
            }
            average = (double)sum / size;
            return average;
        }

        static void SunIsShinning(int[] x) 
        {
            for (int i = 0; i < x.Length; i++)
                x[1] += 2;
        }
    }
}
