using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.CoR.RequisicaoWeb
{
    public interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
        IResposta Proxima { get; set; }
    }
}
