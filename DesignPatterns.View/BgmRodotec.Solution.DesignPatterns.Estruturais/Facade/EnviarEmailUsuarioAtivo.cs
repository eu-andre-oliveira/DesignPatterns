using BgmRodotec.Solution.DesignPatterns.Estruturais.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturais.Facade
{
    public class EnviarEmailUsuarioAtivo : IEnviarEmailUsuario
    {
        private IEnviarEmailUsuario _enviarEmailUsuario;

        public EnviarEmailUsuarioAtivo(IEnviarEmailUsuario enviarEmailUsuario)
        {
            _enviarEmailUsuario = enviarEmailUsuario;
        }
        public void EnviarEmail(UsuarioModel usuario)
        {
            ///aqui envia o email;
        }
    }
}
