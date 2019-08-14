//Chamando bibliotecas
//Chamando a classe Pessoa que foi criado no Modelo com nome Pessoa
using QuartaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuartaApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Outra forma de instanciar e atribuir valores
            //Pessoa Cliente = new Pessoa();
            //Cliente.PessoaId = 2;
           
            //Comandos escritos após o retorno da View, NUNCA são executados
            return View();
            


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            Fornecedor fornecedor = new Fornecedor()
            {
                fornecedorId = 1,
                nome = "Associação 171",
                endereco = "Rua Falsa, 157",
                tel = 24241234

            };
                
                ViewBag.ID = fornecedor.fornecedorId;
                ViewBag.nome = fornecedor.nome;
                ViewBag.end = fornecedor.endereco;
                ViewBag.tel = fornecedor.tel;


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contato()
        {

            Pessoa pessoa = new Pessoa()
            {
                //Atributos para o objeto Pessoa
                PessoaId = 1,
                Nome = "Astrogildo",
                Tipo = "Administrador"
            };

            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;
            //Resultado da ação do método logo abaixo, onde é retornado uma view e uma mensagem
            //Views e ActionResult devem ter o mesmo nome para se associarem
            //Criar uma View com layout traz um padrão de estilo para ela como o resto do projeto
            return View();
       

        }

        //Alteração em Actionlinks estão na pasta View > Shared > _Layout.cshtml
    }
}