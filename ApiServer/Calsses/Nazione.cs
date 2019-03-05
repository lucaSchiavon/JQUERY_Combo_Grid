using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiServer.Calsses
{
    public class Nazione
    {
        public Nazione(int id, string title)
        {
            this.id = id;
            this.title = title;
        }
        public int id { get; set; }
        public string title { get; set; }
    }
}