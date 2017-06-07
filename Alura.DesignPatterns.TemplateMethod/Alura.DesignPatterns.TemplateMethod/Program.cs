using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(501);
            orcamento.Itens.Add(new Item() { Valor = 100, Nome = "Cadeira" });
            orcamento.Itens.Add(new Item() { Valor = 10, Nome = "caneta" });
            orcamento.Itens.Add(new Item() { Valor = 50, Nome = "panela" });

            ICPP icpp = new ICPP();
            IKCV ikcv = new IKCV();
            IHIT ihit = new IHIT();
            Console.WriteLine("Impostos: IKCV = {0} , ICPP = {1} e IHIT = {2}", 
                ikcv.Calcula(orcamento), icpp.Calcula(orcamento), ihit.Calcula(orcamento));
            Console.ReadKey();
            


        }
    }
}
