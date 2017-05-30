using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.ChainOfResposability
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(501);
            orcamento.AdicionaItem(new Item("Lapis", 149.01));
            orcamento.AdicionaItem(new Item("Caneta", 349.01));

            


            Console.WriteLine(calculador.Calcula(orcamento));
            Console.ReadKey();


        }
    }
}
