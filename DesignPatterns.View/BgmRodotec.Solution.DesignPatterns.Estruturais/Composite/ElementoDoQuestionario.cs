using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estruturais
{
    public abstract class ElementoDoQuestionario
    {
        protected String Descricao;

        protected ElementoDoQuestionario(string descricao)
        {
            Descricao = descricao;
        }

        public abstract void Exibir();
            
        
    }
}
