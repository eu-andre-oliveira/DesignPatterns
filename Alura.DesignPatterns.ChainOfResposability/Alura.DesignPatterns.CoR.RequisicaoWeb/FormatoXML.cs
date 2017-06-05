using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.CoR.RequisicaoWeb
{
    public class FormatoXML : IFormato
    {
        public Formato proximo { get; set; }

        public void Formata(Conta conta, Requisicao requisicao)
        {
            string.Concat("Retorno formatado XML: Conta:{0}, saldo:{1}  ", conta.Nome, conta.Saldo);
        }
    }
}
