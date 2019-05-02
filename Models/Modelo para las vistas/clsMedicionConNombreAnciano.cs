using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ResidentEvil.Models.Modelo_para_las_vistas
{
    public class clsMedicionConNombreAnciano
    {
        
        //atributos
        public int idAnciano { get; set; }


        [Range(0,50,ErrorMessage="Con esa temperatura no eres un miembro de Resident Evil")]
        public float temperatura { get; set; }
        [Required]
        public String nombre { get; set; }
     //   public DateTime fecha { get; set; }
        //public char tramo { get; set; }

        //constructor sin parámetros
        public clsMedicionConNombreAnciano()
        {
            
            //fecha = System.DateTime.Now;
            idAnciano = 0;
            temperatura = 0.0F;
            nombre = "";
            //tramo=' ';
        }
        //constructor con parámetros
        public clsMedicionConNombreAnciano(int idAnciano, float temperatura,String nombre)
        {
          //  this.fecha = System.DateTime.Now;
            this.idAnciano = idAnciano;
            this.temperatura = temperatura;
            this.nombre = nombre;
          //  this.tramo = tramo;
        }
    }
}