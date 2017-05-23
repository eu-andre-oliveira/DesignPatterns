using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estrategias
{
    public class CalculadorDeFretePadrao : ICalculadorDeFrete
    {
        public double CalculoFrete(double distancia)
        {
            return distancia * 1.1;
        }

    }
}
