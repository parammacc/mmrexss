using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResidentEvil.Models.Modelo_para_las_vistas;
using ResidentEvil.Models.Listados;

namespace ResidentEvil.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new clsMedicionViewModel());
        }

        [HttpPost]
        public ActionResult Index(clsMedicionViewModel medicionvm){
            if(ModelState.IsValid==false){
                return View(medicionvm);
            }
            else{
                return View("Imprimir",medicionvm);
            }
        }
    }
}
