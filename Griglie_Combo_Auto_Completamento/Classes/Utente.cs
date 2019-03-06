using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Griglie_Combo_Auto_Completamento.Classes
{
    [MetadataType(typeof(UtenteMetadata))]
    public class Utente
    {

        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class UtenteMetadata
    {

        public int id { get; set; }
        [Required (AllowEmptyStrings =false,ErrorMessage="Plaese insrt first name")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Plaese insrt last name")]
        public string LastName { get; set; }
      
    }
}