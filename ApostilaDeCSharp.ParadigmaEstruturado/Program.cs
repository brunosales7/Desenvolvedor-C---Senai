using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Sequêncial - TopDown
             * 
             * passo 1
             * passo 2
             * passo 3
             * passo 4
             * 
             */
            //Passo 1 -Entrada de Dados

            string repetir;
            do
            {
                Console.WriteLine("Qual o aluno? ");
                string nome = Console.ReadLine().ToUpper();
                //Passo 2 - Processamento
                string resposta;
                if (nome.Equals("REGYS"))
                {
                    resposta = "Nosso Representante";
                }
                else
                {
                    resposta = ("Chame o Representante! ");
                }
                //Passo 3 -Saida

                Console.WriteLine(resposta);

                //PASSO 4 - MONTAR UMA ITERAÇÃO (REPETIÇÃO)-LOOPING
                Console.WriteLine("Deseja sair? SIM OU NÃO");
                repetir = Console.ReadLine().ToUpper();


            } while (!repetir.Equals("SIM"));  

            Console.ReadKey();


        }
    }
}
