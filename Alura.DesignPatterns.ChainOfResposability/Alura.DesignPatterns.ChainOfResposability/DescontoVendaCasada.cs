using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.ChainOfResposability
{
    public class DescontoVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("Lapis", orcamento) && (Existe("Caneta", orcamento)))
            {
                return orcamento.Valor * 0.05;
            }
            else
                return Proximo.Desconta(orcamento);
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
