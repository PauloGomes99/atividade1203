using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int n1;
            int r;

            



            Console.WriteLine("Digite um numero");
            n1 = int.Parse(Console.ReadLine());

            r = n1 + n1 * 2;

            Console.WriteLine("O nuemro é:"+r);

        }
    }
}
