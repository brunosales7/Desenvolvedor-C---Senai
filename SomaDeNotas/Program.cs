using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repetir;
            string resposta;

            int[] notas = new int[4];
            notas[0] = 9;
            notas[1] = 21;
            notas[2] = 7;
            notas[3] = 15;
            Console.WriteLine("mostrar as notas");
            double soma = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(notas[i]);
                soma = soma + notas[i];
            }
            double media = soma / notas.Length;
            Console.WriteLine($"soma: {soma}");
            //Console.WriteLine($"media:{media}");
            Console.WriteLine("Sua media é: " + media);
            Console.ReadKey();



        }
    }
}
    
