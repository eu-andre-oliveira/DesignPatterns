using System;

namespace Alura.DesignPatterns.ChainOfResposability
{
    public class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }

        public Double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}