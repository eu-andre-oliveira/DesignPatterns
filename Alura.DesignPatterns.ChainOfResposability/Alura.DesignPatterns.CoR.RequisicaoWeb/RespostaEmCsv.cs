using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.CoR.RequisicaoWeb
{
    class RespostaEmCsv : IResposta
    {
        public IResposta Proxima { get; set; }

        public RespostaEmCsv(IResposta requisicao)
        {
            this.Proxima = requisicao;
        }
        public RespostaEmCsv()
        {
            this.Proxima = null;
        }
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                Proxima.Responde(req, conta);
            }
        }
    }
}
