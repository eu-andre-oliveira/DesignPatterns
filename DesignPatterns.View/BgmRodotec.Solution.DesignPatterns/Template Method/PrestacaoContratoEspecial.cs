using Comportamentais.Template_Method.Solucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Template_Method
{
    public class PrestacaoContratoEspecial : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            _valorDaTaxaAdministrativa = (_valorPrincipal * 0.01m) + 1.5m;
        }

        protected override void CalcularValorDoSeguro()
        {
            _valorDoSeguro = 0.015m / _valorPrincipal + 1;
        }
    }
}
