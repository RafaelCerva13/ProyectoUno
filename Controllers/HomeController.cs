using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoUno.Models;

namespace ProyectoUno.Controllers
{
    public class HomeController : Controller
    {

        CRUDREntities1 BD = new CRUDREntities1();

        public ActionResult Index()
        {
            ViewData["Message"] = "Rafael";
            ViewData["apellido"] = "Cervantes";
            return View(BD.PROCED_SELEC().ToList());

           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(PROCED_SELEC_Result model)
        {
            using (CRUDREntities1 db = new CRUDREntities1())
            {
                var oTabla = new PERSONAL();
                oTabla.NOMBRE = model.NOMBRE;
                oTabla.APELLIDO_P = model.APELLIDO_P;
                oTabla.APELLIDO_M = model.APELLIDO_M;
                oTabla.EDAD = model.EDAD;
                oTabla.IsActive = model.IsActive;

              

                db.PERSONAL.Add(oTabla);
                db.SaveChanges();
            }

         
            return View();
        }


        public ActionResult Actualizar()
        {
            ViewBag.NOMBRE = "Eduard Tomàs";
            ViewBag.APELLIDO_P = "eiximenis";
            ViewBag.APELLIDO_M = "eiximenis";
            ViewBag.EDAD = 23;
            ViewBag.EDAD = 1;
       

            return View();
        }
    }
}