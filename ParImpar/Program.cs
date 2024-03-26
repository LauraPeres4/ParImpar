using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 0 para pares e 1 para impares: ");
            int num = int.Parse(Console.ReadLine());

            int cont = num;

            while (cont <= 20)
            {
                Console.WriteLine(cont);
                cont += 2;
            }

            Console.ReadKey();





        }
    }
}
