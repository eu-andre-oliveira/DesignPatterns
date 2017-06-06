using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.CoR.RequisicaoWeb
{
    class RespostaEmPorcento : IResposta
    {
        public IResposta Proxima { get; set; }
        public RespostaEmPorcento(IResposta requisicao)
        {
            this.Proxima = requisicao;
        }
        public RespostaEmPorcento()
        {
            this.Proxima = null;
        }
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else
            {
                Proxima.Responde(req, conta);
            }
        }
    }
}
