using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.CoR.RequisicaoWeb
{
    public class CalculadorDeFormato
    {
        public void RetornaFormato(Requisicao req, Conta conta)
        {
            
            IResposta csv = new RespostaEmCsv();
            IResposta porcento = new RespostaEmPorcento(csv);
            IResposta xml = new RespostaEmXml(porcento);

            xml.Responde(req, conta);
        }
    }
}
