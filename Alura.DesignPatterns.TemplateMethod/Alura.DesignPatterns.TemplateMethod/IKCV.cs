using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.TemplateMethod
{
    public class IKCV : TemplateImposto
    {
        public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemComValorMaiorQue100(orcamento);
        }

        private bool TemItemComValorMaiorQue100(Orcamento orcamento)
        {
            foreach (Item i in orcamento.Itens)
            {
                return true;
            }
            return false;
        }

        public override double TaxacaoMaxima(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public override double TaxacaoMinima(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

    }
}
