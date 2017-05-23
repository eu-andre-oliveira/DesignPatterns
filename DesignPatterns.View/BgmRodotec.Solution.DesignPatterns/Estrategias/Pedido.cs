using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estrategias
{
    public class Pedido
    {
        public double distancia { get; set; }
        private ICalculadorDeFrete _calculadorDeFrete;

        public Pedido(ICalculadorDeFrete calculadorDeFrete)
        {
            _calculadorDeFrete = calculadorDeFrete;
        }

        public double CalcularFrete()
        {
            return _calculadorDeFrete.CalculoFrete(distancia);
        }
    }
}
