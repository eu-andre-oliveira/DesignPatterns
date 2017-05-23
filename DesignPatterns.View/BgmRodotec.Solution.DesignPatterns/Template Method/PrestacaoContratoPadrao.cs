using Comportamentais.Template_Method.Solucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Template_Method
{
    class PrestacaoContratoPadrao : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            throw new NotImplementedException();
        }

        protected override void CalcularValorDoSeguro()
        {
            throw new NotImplementedException();
        }
    }
}
