using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class Partido
    {
        [Key]
        public int PartidoID { get; set; }
        public string Titulo { get; set; }
        public EstadoPartido Estado { get; set; }//Pendiente , Terminado , Cancelado
        
    }
}