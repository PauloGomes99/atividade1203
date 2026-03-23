using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {


        static void Main(string[] args)
        {
            double dolar;
            double cotacao = 5.30;
            double reais;


            Console.WriteLine("US$");
            dolar = double.Parse(Console.ReadLine());


            reais = dolar * cotacao;

            Console.WriteLine("R$:" +reais);

            Console.ReadKey();




        }
    }
}
