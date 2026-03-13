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
        int nota1, nota2, nota3;

        double soma, media;


        Console.WriteLine("Digite a primeira nota:");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota");
        nota3 = int.Parse(Console.ReadLine());
        soma = nota1 + nota2 + nota3;

        media = soma /3;

            if (media >=7)
            {
                Console.WriteLine("Aprovado" +media);

            }
            else (media <=7){

            Console.WriteLine("Reprovado" +media);

        }


           











    }
}
}
