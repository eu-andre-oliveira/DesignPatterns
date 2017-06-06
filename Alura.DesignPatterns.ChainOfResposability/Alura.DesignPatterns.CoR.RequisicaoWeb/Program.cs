using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns.CoR.RequisicaoWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("Andre", 500.00);

            Requisicao req = new Requisicao(Formato.XML);

            CalculadorDeFormato calc = new CalculadorDeFormato();

            calc.RetornaFormato(req, conta);

            Console.ReadKey();
        }
    }
}
