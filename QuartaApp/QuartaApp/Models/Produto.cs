using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuartaApp.Models
{
    public class Produto
    {
        public ushort Id
        {
            get;set;
        }
        public char Nome
        {
            get;set;
        }
        public decimal Valor
        {
            get;set;
        }
        public ushort Qtd
        {
            get;set;
        }

    }
}