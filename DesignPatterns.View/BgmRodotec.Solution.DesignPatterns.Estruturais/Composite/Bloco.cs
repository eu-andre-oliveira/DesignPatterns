using BgmRodotec.Solution.DesignPatterns.Estruturais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estruturais
{
    // bloco (o composto)
    public class Bloco : ElementoDoQuestionario
    {
        private IList<ElementoDoQuestionario> _elementos = new List<ElementoDoQuestionario>();
        public IEnumerable<ElementoDoQuestionario> Elementos { get { return _elementos; } }

        public Bloco(string descricao) : base(descricao) { }

        public override void Exibir()
        {
            Console.WriteLine("Bloco: {0}", Descricao);
            foreach (var elemento in _elementos)
                elemento.Exibir();
        }

        public void Adicionar(ElementoDoQuestionario elemento)
        {
            _elementos.Add(elemento);
        }

        public void Remover(ElementoDoQuestionario elemento)
        {
            _elementos.Remove(elemento);
        }
    }
}
