using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.CoR.RequisicaoWeb
{
    class RespostaEmXml : IResposta
    {
        public IResposta Proxima { get; set; }

        public RespostaEmXml(IResposta requisicao)
        {
            this.Proxima = requisicao;
        }
        public RespostaEmXml()
        {
            this.Proxima = null;
        }
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                Proxima.Responde(req, conta);
            }
        }
    }
}
