using ResidentEvil.Models.Listados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResidentEvil.Models.DAL.manejadora;
using ResidentEvil.Models.Entities;

namespace ResidentEvil.Controllers
{
    public class AncianosController : Controller
    {
        //
        // GET: /Ancianos/
        //MOSTRAR LISTA CON TOD@S L@S ANCIAN@S
        //muestra una página web con los ancianos existentes en la base de datos Resident Evil
        public ActionResult Lista()
        {
            clsListadoAncianosDAL ancianos = new clsListadoAncianosDAL(); 
            return View(ancianos.getListadoAncianosDAL());
        }

        //DETAILS
        //muestra anciano seleccionado de la lista de ancianos
        public ViewResult Details(int id)
        {
            clsManejadoraAnciano manejaViejas = new clsManejadoraAnciano();
            clsAnciano anciano = manejaViejas.detallesAnciano(id);
            return View(anciano);
        }

        //DELETE
        //primero obtengo anciano a eliminar
        public ViewResult Delete(int id)
        {
            clsManejadoraAnciano rip = new clsManejadoraAnciano();
            clsAnciano anciano = rip.detallesAnciano(id);
            return View(anciano);
        }
        //elimino el anciano y si todo va bien entonces va a la página de confirmación
        [HttpPost, ActionName("Delete")]
        public ActionResult RIP(int id)
        {
            clsManejadoraAnciano rip = new clsManejadoraAnciano();
            rip.eliminaAnciano(id);
            return RedirectToAction("ConfirmarEliminacion");
        }
        //confirmación de la eliminación de anciano seleccionado por usuario
        public ViewResult confirmarEliminacion()
        {
            return View("confirmarEliminacion");
        }

        //EDIT
        //obtengo anciano seleccionado de la lista de ancianos
        public ViewResult Edit(int id)
        {
            clsManejadoraAnciano celadora = new clsManejadoraAnciano();
            clsAnciano yayo = celadora.detallesAnciano(id);
            return View(yayo);
        }
        //edito anciano seleccionado
        [HttpPost, ActionName("Edit")]
        public ActionResult EdicionAnciano(clsAnciano abueloSimpson)
        {
            clsManejadoraAnciano residente = new clsManejadoraAnciano();
            residente.editaAnciano(abueloSimpson);
            return RedirectToAction("Lista");
        }

        //CREATE
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public ActionResult ponUnZombiEnTuVida(clsAnciano anciano)
        {
            //hace que no se permita crear ancianos sin nombre
            if (ModelState.IsValid == false)
            {
                return View(anciano);
            }
            else
            {
                clsManejadoraAnciano zombi = new clsManejadoraAnciano();
                zombi.creaAnciano(anciano);
                return RedirectToAction("Lista");
            }
            
        }

        
    }
}
