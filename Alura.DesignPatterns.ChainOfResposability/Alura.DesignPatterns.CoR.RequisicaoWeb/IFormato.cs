using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.CoR.RequisicaoWeb
{
    public interface IFormato
    {
        void Formata(Conta conta, Requisicao requisicao);
        Formato proximo { get; set; }
    }
}
