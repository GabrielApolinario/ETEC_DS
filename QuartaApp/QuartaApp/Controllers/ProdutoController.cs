//Bibliotecas que estão sendo usadas pela aplicação
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*Para usar uma biblioteca, neste exemplo os Models da QuartaApp, 
 *vc deve utilizar o comando using seguido do nome da APP e da pasta que você quer utilizar
 */
using QuartaApp.Models;

namespace QuartaApp.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            //Instanciação de objeto
            Produto produto = new Produto()
            {
                //Declaração de atributos
                Id = 1,
                //Conversao de Char para String
                Nome = char.Parse("Carro"),
                //Sufixo 'M' adicionado no final para o numero representar um decimal
                Valor = 200.66M,
                Qtd = 2
            };
            //ViewBag.Nome Desejado para identificação = Nome do Objeto. Nome do Atributo;
            ViewBag.ID = produto.Id;
            ViewBag.Nome = produto.Nome;
            ViewBag.Valor = produto.Valor;
            ViewBag.Qtd = produto.Qtd;
            return View();
        }
    }
}