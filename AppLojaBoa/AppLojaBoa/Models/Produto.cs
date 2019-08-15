using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLojaBoa.Models
{
    public class Produto
    {
        public int prodId
        {
            get;set;
        }
        public string prodNome
        {
            get;set;
        }
        public double prodValor
        {
            get;set;
        }
        public int prodQtd
        {
            get;set;
        }
        public DateTime vencimento
        {
            get;set;
        }
    }
}