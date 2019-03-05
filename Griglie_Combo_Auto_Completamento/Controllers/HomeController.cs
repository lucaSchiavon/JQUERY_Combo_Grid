using Griglie_Combo_Auto_Completamento.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Griglie_Combo_Auto_Completamento.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetUtenti()
        {
            Utente ObjUtente1 = new Utente();
            ObjUtente1.FirstName = "Marco";
            ObjUtente1.LastName = "Bazzoni";
            ObjUtente1.Country = "Italia";
            ObjUtente1.City = "Verona";
            ObjUtente1.EmailID = "mbaruba.it";
           // ObjUtente1.id = 1;
            Utente ObjUtente2 = new Utente();
            ObjUtente2.FirstName = "Carlo";
            ObjUtente2.LastName = "Cattaneo";
            ObjUtente2.Country = "Italia";
            ObjUtente2.City = "Mantova";
            ObjUtente2.EmailID = "mb2aruba.it";
           // ObjUtente2.id =2;
            Utente ObjUtente3 = new Utente();
            ObjUtente3.FirstName = "Cristian";
            ObjUtente3.LastName = "Piazente";
            ObjUtente3.Country = "Italia";
            ObjUtente3.City = "Catania";
            ObjUtente3.EmailID = "caruba.it";
           // ObjUtente3.id = 3;
            var LstUtente = new List<Utente>();
            LstUtente.Add(ObjUtente1);
            LstUtente.Add(ObjUtente2);
            LstUtente.Add(ObjUtente3);
            //return Json(new {  LstUtente }, JsonRequestBehavior.AllowGet);
            return Json(new { data = LstUtente }, JsonRequestBehavior.AllowGet);
        }
    }
}