using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estrategias
{
    public interface ICalculadorDeFrete
    {
        double CalculoFrete(double distancia);
    }
}
