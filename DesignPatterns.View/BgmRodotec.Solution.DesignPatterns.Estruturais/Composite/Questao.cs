using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estruturais.Composite
{
    public class Questao : ElementoDoQuestionario
    {
        public Questao(string descricao) : base(descricao)
        {

        }

        public override void Exibir()
        {
            Console.WriteLine("Questão: {0}", Descricao);
        }
    }
}
