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
        public abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
        public abstract double TaxacaoMaxima(Orcamento orcamento);
        public abstract double TaxacaoMinima(Orcamento orcamento);

    }
}
