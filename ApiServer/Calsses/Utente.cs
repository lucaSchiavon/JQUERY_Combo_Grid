using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiServer.Calsses
{
    public class Utente
    {
       
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}