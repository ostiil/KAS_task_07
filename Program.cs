using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAS_Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; 
            Console.Write("Укажите количество элементов в массиве: ");
            n = Convert.ToInt32(Console.ReadLine());
            double[] massiv = new double[n];
            Random random = new Random();
            for (int i = 0; i<n; i++)
            {
                massiv[i] = random.Next();
            }
            Console.WriteLine($"Изначальный массив: {string.Join("  ", massiv)}");
            Shuffle(massiv);
            Console.WriteLine($"Измененный массив: { string.Join("  ", massiv)}");
            Console.ReadKey();
        }
        public static void Shuffle(double[] massiv)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                var index = rnd.Next(0, massiv.Count());
                var index2 = rnd.Next(0, massiv.Count());
                var temp = massiv[index];
                massiv[index] = massiv[index2];
                massiv[index2] = temp;
            }
        }
    }

}


