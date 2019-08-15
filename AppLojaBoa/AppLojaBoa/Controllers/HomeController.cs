﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLojaBoa.Models;

namespace AppLojaBoa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Cliente()
        {
            Cliente cliente = new Cliente()
            {
                cliId = 23,
                cliNome = "Gizcreuza",
                cliNasc = Convert.ToDateTime("23/05/1996"),
                cliEnd = "Rua tá difícil, 00"
            };

            return View(cliente);
        }

        public ActionResult Produto()
        {
            Produto produto = new Produto()
            {
                prodId = 1,
                prodNome = "Bom",
                prodValor = 149.99,
                prodQtd = 100,
                vencimento = Convert.ToDateTime("07/03/2019")
            };
            

            return View(produto);
        }

        public ActionResult Venda()
        {
            Venda venda = new Venda()
            {
                vendaId = 100,
                vendaData = Convert.ToDateTime("28/02/2019"),
                vendaTotal = 500
            };


            return View(venda);
        }
        public ActionResult Inicio()
        {
            return View();
        }


    }
}