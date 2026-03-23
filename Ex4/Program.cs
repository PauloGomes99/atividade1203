using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int c;

            int f;



            Console.WriteLine("Cº:");
            c = int.Parse(Console.ReadLine());

            f = c *9/5 + 32;

            Console.WriteLine("Fº:" + c);
            
        }
    }
}
