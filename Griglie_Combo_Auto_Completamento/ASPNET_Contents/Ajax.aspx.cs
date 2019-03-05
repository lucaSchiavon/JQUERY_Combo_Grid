using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Runtime.Serialization;


namespace RemoteAssistantAdmin
{
    public partial class Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public class GetNazioneResult
        {
            public string Capitale = "";
            public int Abitanti = 0;
        }

        [WebMethod]
        public static GetNazioneResult getCapitale(string Nazione)
        {

            var res = new GetNazioneResult();
            // System.Data.DataTable dt = DBMapper.select("SELECT * FROM [TabUtenti] where nominativo like'%" + NomeUtente + "%'");
            //res.Nome = dt.Rows[0]["userid"].ToString();
            if (Nazione == "Italia")
            {
                res.Capitale = "Roma";
                res.Abitanti = 6000000;
            }
            else
            {
                res.Capitale = "---";
                res.Abitanti = 0;
            }
            return res;
        }

        //[WebMethod]
        //public static GetNazioneResult getStato(string Stato)
        //{

        //    var res = new GetNazioneResult();
        //    // System.Data.DataTable dt = DBMapper.select("SELECT * FROM [TabUtenti] where nominativo like'%" + NomeUtente + "%'");
        //    //res.Nome = dt.Rows[0]["userid"].ToString();
        //    if (Stato == "Italia")
        //    {
        //        res.Capitale = "Roma";
        //        res.Abitanti = 6000000;
        //    }
        //    else
        //    {
        //        res.Capitale = "---";
        //        res.Abitanti = 0;
        //    }
        //    return res;
        //}


        #region codice vecchio
        //[WebMethod]
        //public static JsonVerifyIdentity GetStates(string titolo)
        //{
        //    JsonVerifyIdentity ObjJsonVerifyIdentity = new JsonVerifyIdentity();
        //    var state = HttpContext.Current.Request.Form["tit"];
        //    ObjJsonVerifyIdentity.dettaglio = "prova dettaglio";
        //    ObjJsonVerifyIdentity.destUrl = "url";
        //    return ObjJsonVerifyIdentity;
        //}

        //[WebMethod]
        //public static JsonVerifyIdentity VerifyIdentity(string email, string pwd)
        //{
        //    JsonVerifyIdentity ObjJsonVerifyIdentity = new JsonVerifyIdentity();

        //    if (email != "lully" || pwd != "lully")
        //    {
        //        ObjJsonVerifyIdentity.errore = 1;
        //        ObjJsonVerifyIdentity.dettaglio="Errore di autenticazione";



        //    }
        //    else
        //    {
        //        ObjJsonVerifyIdentity.errore = 0;
        //        ObjJsonVerifyIdentity.destUrl = "/default.aspx";
        //        //ObjJsonVerifyIdentity.dettaglio = "";
        //    }
        //    return ObjJsonVerifyIdentity;
        //}



        //[DataContract]
        //public class JsonVerifyIdentity
        //{
        //    [DataMember]
        //    public int errore;
        //    [DataMember]
        //    public string dettaglio;
        //    [DataMember]
        //    public string destUrl;
        //}
        #endregion


    }
}