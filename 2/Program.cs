using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(int [] args)
        {
            int valor1, valor2;

            double total;

            Console.WriteLine("Digite o primeiro numero:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            valor2 = int.Parse(Console.ReadLine());

            total = valor1 + valor2;

            total = double.Parse(Console.ReadLine());

            Console.WriteLine("o resultado é:" + total);

        }
    }
}
