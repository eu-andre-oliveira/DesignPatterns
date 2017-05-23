using BgmRodotec.Solution.DesignPatterns.Estruturais.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturais.Facade
{
    public class ValidarUsuario : IValidarUsuario
    {
        private IValidarUsuario _validarUsuario;
        public ValidarUsuario(IValidarUsuario validarUsuario) {
            _validarUsuario = validarUsuario;
        }
        public bool ValidarUsuarioIn(UsuarioModel usuario)
        {
            return !string.IsNullOrEmpty(usuario.Nome);
        }
    }
}
