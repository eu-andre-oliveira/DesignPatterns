using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.TemplateMethod
{
    public class IHIT : TemplateImposto
    {
        protected override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            if (Tem2ItensComMesmoNome(orcamento))
                return true;
            return false;

        }

        private bool Tem2ItensComMesmoNome(Orcamento orcamento)
        {
            IList<string> Nomes = new List<string>();

            foreach (Item item in orcamento.Itens)
                if (Nomes.Contains(item.Nome))
                    return true;
                else
                    Nomes.Add(item.Nome);
            return false;
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return 0.01 * orcamento.Itens.Count();
        }
    }
}
