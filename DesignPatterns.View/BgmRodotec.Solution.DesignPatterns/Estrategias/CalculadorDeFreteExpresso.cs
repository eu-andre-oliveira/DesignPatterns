using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estrategias
{
    public class CalculadorDeFreteExpresso : ICalculadorDeFrete
    {
        public double CalculoFrete(double distancia)
        {
            return distancia * 2;
        }
    }
}
