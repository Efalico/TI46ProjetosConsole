using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            decimal nota1, nota2, nota3, nota4, resultado;

            Console.WriteLine("Digite seu Nome, " );
            Nome=Console.ReadLine();
            Console.WriteLine("Seja Bem Vindo ",Nome);

            //Entre com notas


            Console.WriteLine("Digite as Notas do aluno ",Nome);
            nota1= decimal.Parse(Console.ReadLine());
            nota2 = decimal.Parse(Console.ReadLine());
            nota3 = decimal.Parse(Console.ReadLine());  
            nota4 = decimal.Parse(Console.ReadLine());  
            
            //processmento

            resultado =(nota1 + nota2+nota3+nota4)/4;

            //saida

            Console.WriteLine("O Aluno teve media final " + resultado);

            Console.ReadKey();

        }
    }
}
