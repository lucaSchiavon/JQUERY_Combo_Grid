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
        List<Utente> LstUtente = new List<Utente>();
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
            ObjUtente1.id = 1;
            Utente ObjUtente2 = new Utente();
            ObjUtente2.FirstName = "Carlo";
            ObjUtente2.LastName = "Cattaneo";
            ObjUtente2.Country = "Italia";
            ObjUtente2.City = "Mantova";
            ObjUtente2.EmailID = "mb2aruba.it";
            ObjUtente2.id = 2;
            Utente ObjUtente3 = new Utente();
            ObjUtente3.FirstName = "Cristian";
            ObjUtente3.LastName = "Piazente";
            ObjUtente3.Country = "Italia";
            ObjUtente3.City = "Catania";
            ObjUtente3.EmailID = "caruba.it";
            ObjUtente3.id = 3;

            LstUtente.Add(ObjUtente1);
            LstUtente.Add(ObjUtente2);
            LstUtente.Add(ObjUtente3);
            //return Json(new {  LstUtente }, JsonRequestBehavior.AllowGet);
            return Json(new { data = LstUtente }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Save(int id)
        {
            var v = LstUtente.Where(a => a.id == id).FirstOrDefault();
            return View(v);
        }
        [HttpPost]
        public ActionResult Save(Utente u)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                if (u.id > 0)
                {
                    //edit
                    Utente v1 = LstUtente.Where(a => a.id == u.id).FirstOrDefault();
                    v1.FirstName = u.FirstName;
                    v1.FirstName = u.LastName;
                    v1.FirstName = u.Country;
                    v1.FirstName = u.City;
                    v1.EmailID = u.EmailID;
                    v1.id = LstUtente.Count + 1;
                }
                else
                {
                    //save
                    LstUtente.Add(u);
                }
                status = true;
            }
            return new JsonResult { Data = new { status = status } };
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var v = LstUtente.Where(a => a.id == id).FirstOrDefault();
            if (v != null)
            {
                return View(v);
            }
            else
            {
                return HttpNotFound();
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteUtente(int id)
        {
            bool status = false;
            var v = LstUtente.Where(a => a.id == id).FirstOrDefault();
            if (v != null)
            {
                LstUtente.Remove(v);
                status = true;
            }
            return new JsonResult { Data = new { status = status } };

        }
    }
}