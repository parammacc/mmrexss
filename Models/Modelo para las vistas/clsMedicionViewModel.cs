using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResidentEvil.Models.Modelo_para_las_vistas;
using ResidentEvil.Models.Entities;
using System.ComponentModel.DataAnnotations;
using ResidentEvil.Models.Listados;
using ResidentEvil.Models.DAL;

namespace ResidentEvil.Models.Modelo_para_las_vistas
{
    public class clsMedicionViewModel
    {
        [Display(Name="FECHA")]
        public DateTime fecha { get; set; }

        [Display(Name="TRAMO")]
        public char tramo { get; set; }

        public List<clsMedicionConNombreAnciano> listadoMediciones { get; set; }
     //   public List<clsListadoMedicionesDAL> listadoMedicionesDAL { get; set; }
    //    public List<clsMedicion> listadoMedicionesDAL { get; set; }
        
        public clsMedicionViewModel()
        {
            this.fecha = System.DateTime.Now;
            this.listadoMediciones = _lstMedicion();
        //    this.listadoMedicionesDAL = _lstListaMedicionNombre();
        //    this.listadoMediciones=_lst
        }


        /// <summary>
        /// lstListaMedicionNombre
        /// 
        /// descripción: devuelve una lista de objetos tipo clsMediciónConNombreAnciano que servirá como modelo para la vista
        /// entradas: nada
        /// precondiciones: nada
        /// salidas: una lista de clsMedicionConNombreAnciano
        /// Postcondiciones: asociado al nombre de la función devuelve una lista de objetos tipo clsMediciónConNombreAnciano
        /// </summary>
        /// <returns></returns>
    //    private List<clsMedicionConNombreAnciano> _lstListaMedicionNombre()
     //   private List<clsListadoMedicionesDAL> _lstListaMedicionNombre()
    //    private clsListadoMedicionesDAL _lstListaMedicionNombre()
        private List<clsMedicionConNombreAnciano> _lstMedicion()
        {
      /*      List<clsMedicionConNombreAnciano> miLista = new List<clsMedicionConNombreAnciano>();

            miLista.Add(new clsMedicionConNombreAnciano( 0, 0,"antonio"));
            miLista.Add(new clsMedicionConNombreAnciano(1, 0,"carlos"));
            miLista.Add(new clsMedicionConNombreAnciano(2, 0,"fernando"));
            miLista.Add(new clsMedicionConNombreAnciano(3, 0,"jonathan"));
            miLista.Add(new clsMedicionConNombreAnciano(4, 0,"unai"));          */

         //   clsListadoMedicionesDAL miLista = new clsListadoMedicionesDAL();
         //   List<clsMedicionConNombreAnciano> aux = miLista.getListadoMedicionesDAL();
         //   clsListadoAncianosDAL listaAncianos = new clsListadoAncianosDAL();
            clsListadoAncianosDAL listaAncianosDAL = new clsListadoAncianosDAL();
            List<clsMedicionConNombreAnciano> miLista = new List<clsMedicionConNombreAnciano>();

            foreach (clsAnciano oAnciano in listaAncianosDAL.getListadoAncianosDAL())
            {
                //clsMedicionConNombreAnciano tiene como atributos id, temperatura, nombre
                //anciano tienen como atributos idAnciano y nombreAnciano
                //DAL debe dar listados de las clases a las que referencia...es decir, aquí en esta clase hacemos el "tuneo"
                //el 0 es para que incluir la temperatura
                //crea una lista de clsMedicionConNombreAnciano vacía, recorre 
                miLista.Add(new clsMedicionConNombreAnciano(oAnciano.idAnciano, 0, oAnciano.nombreAnciano));
            }
        
            return miLista;
        }
    }
}