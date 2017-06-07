using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.TemplateMethod
{
    public abstract class TemplateImposto
    {
        public Double Calcula(Orcamento orcamento)
        {
            if (DeveUsarTaxacaoMaxima(orcamento))
                return TaxacaoMaxima(orcamento);
            return TaxacaoMinima(orcamento);        
        }
        protected abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMinima(Orcamento orcamento);

    }
}
