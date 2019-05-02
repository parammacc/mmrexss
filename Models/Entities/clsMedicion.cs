using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResidentEvil.Models.Entities
{
    public class clsMedicion
    {
        //atributos
        public DateTime fecha { get; set; }
        public int idAnciano { get; set; }
        public float temperatura { get; set; }
        public char tramo { get; set; }

        //constructor sin parámetros
        public clsMedicion()
        {
            fecha = System.DateTime.Now;
            //idAnciano = 0;
            //temperatura = 0.0F;
            //tramo=' ';
        }
        //constructor con parámetros
        //public clsMedicion(DateTime fecha, int idAnciano, float temperatura, char tramo) { 
        //{
        //    this.fecha = fecha;
        //    this.idAnciano = idAnciano;
        //    this.temperatura = temperatura;
        //    this.tramo = tramo;
        //}
    }
}