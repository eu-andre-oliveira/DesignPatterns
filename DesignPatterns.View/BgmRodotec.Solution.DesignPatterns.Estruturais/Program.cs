using BgmRodotec.Solution.DesignPatterns.Estruturais.Composite;
using BgmRodotec.Solution.DesignPatterns.Estruturais.Facade;
using Estruturais.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estruturais
{
    class Program
    {
        static void Main(string[] args)
        {
            #region COMPOSITE
            // montando estrutura do questionário com vários blocos aninhados e questões
            var blocoA = new Bloco("A) Formação Educacional");
            var questao1 = new Questao("Qual sua formação?");
            var questao2 = new Questao("Pretende fazer alguma pós-graduação?");

            blocoA.Adicionar(questao1);
            blocoA.Adicionar(questao2);

            var blocoB = new Bloco("B) Habilidades");
            var blocoB1 = new Bloco("B1) Habilidades Técnicas");
            var questao4 = new Questao("O que é SOLID?");

            blocoB1.Adicionar(questao4);
            blocoB.Adicionar(blocoB1);

            var blocoC = new Bloco("c) teste");
            var blocoC1 = new Bloco("c1) BLOCO C");
            var blocoC2 = new Bloco("C2 BLOCO C1");

            var questao5 = new Questao("bLOCO C2");
            var questao6 = new Questao("bLOCO C1");

            blocoC2.Adicionar(questao5);
            blocoC1.Adicionar(questao6);

            blocoC1.Adicionar(blocoC2);
            blocoC.Adicionar(blocoC1);


            var blocoRaiz = new Bloco("Inicio");
            blocoRaiz.Adicionar(blocoA);
            blocoRaiz.Adicionar(blocoB);
            blocoRaiz.Adicionar(blocoC);

            // exibindo toda a estrutura
            blocoRaiz.Exibir();
            Console.ReadLine();
            #endregion

            #region Facade

            var usuarioModel = new UsuarioModel();
            usuarioModel.Nome = "Fábio Prado";
            usuarioModel.Email = "fabio.prado@alfenas.com.br";

            var facadeUsuario = new FacadeUsuario();
            facadeUsuario.Cadastrar(usuarioModel);

            #endregion
        }
    }
}
