using Estruturais.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estruturais.Facade
{
    public class FacadeUsuario
    {

        //var usuarioModel = new UsuarioModel();
        //usuarioModel.Nome = "Fábio Prado";
        //usuarioModel.Email = "fabio.prado@alfenas.com.br";

        //var facadeUsuario = new FacadeUsuario();
        //facadeUsuario.SalvarUsuario(usuarioModel);

        public void Cadastrar(UsuarioModel usuario)
        {
            var validar = new ValidarUsuario();
            var retorno = validar.ValidarUsuarioIn(usuario);

            var salvo = new SalvarUsuario();
            var retornoSalvar = salvo.Salvar(usuario);

            var enviarEmail = new EnviarEmailUsuarioAtivo();
            enviarEmail.EnviarEmail(usuario);

        }
    }
}
