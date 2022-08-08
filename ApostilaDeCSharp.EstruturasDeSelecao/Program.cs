using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.EstruturasDeSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //if - estrutura de seleção simples

            double x = 43.5;
            if(x >= 43.5)
            {
                Console.WriteLine("Mandaloriano");
            }


            //if else - estrutura de seleção composta
            //quem define o tipo é o compilador
            var idade = 26;
            if(idade >= 43.1)
            {
                Console.WriteLine("Mandaloriano");

            }else
            {
                Console.WriteLine("Grande Jovem");
            }



            //if else if - estrutura de seleção composta encadeada

            if (idade >= 43.1)
            {
                Console.WriteLine("Mandaloriano");
            }
            else if (idade >= 18 && idade < 43.1)
            {
                Console.WriteLine("Jovem Jovem");
            }
            else
            {
                Console.WriteLine("Menino(a)");
            }
           // Console.ReadKey();




            //switch - estrutura de seleção múltipla

            var dia = 3;

            switch (dia)
            {
               
                case 2: Console.WriteLine("Segunda");break;
                case 3: Console.WriteLine("Terça");break;
                case 4: Console.WriteLine("Quarta");break;
                case 5: Console.WriteLine("Quinta");break;
                case 6: Console.WriteLine("Sexta");break;
                default: Console.WriteLine("Final de semana chegou"); break;
            }

            string mensagem;
            var salario = 0.0;
            mensagem = salario >= 50000.36 ? "tá rico hein" : "tá complicado em!"; // ? = se . : = se não . a mesma coisa q o if
            Console.WriteLine(mensagem);






           //  decimal d = 1;
           // d /= 2;
           // d *= 2;

           double a = 3;
            double b = 3;
            

            if( a % b !=0)
            {
                Console.WriteLine("Numero fracionario");
            }
            else {
                Console.WriteLine("Numero não fracionario");
                    }

            


            Console.ReadKey();




            //Console.WriteLine(d);
            // Os tipos de referência podem armazenar grandes valores, e uma nova instância de um tipo de referência é criada usando o operador new.
        }
    }
}
