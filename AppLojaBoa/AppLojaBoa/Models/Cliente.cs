using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLojaBoa.Models
{
    public class Cliente
    {
        public int cliId
        {
            get;set;
        }
        public string  cliNome
        {
            get;set;
        }
            public string cliEnd
        {
            get;set;
        }
        //Utilizando DateTime para Data e Hora -> VendaData = Convert.ToDateTime("28/02/2019")
        public DateTime cliNasc
        {
            get;set;
        }
    }
}