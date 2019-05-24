using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    //[Table("Deportes")]
    public class Deporte
    {
        [Key]
        public int DeporteID { get; set; }
        public int Nombre { get; set; }
    }
}