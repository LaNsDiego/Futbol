using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    //[Table("DetalleEquipos")]
    public class DetalleEquipo
    {
        public int DetalleEquipoID { get; set; }
        public int EquipoID { get; set; }
        public int DeporteID { get; set; }

        #region Relaciones
        public virtual Deporte Deporte { get; set; }
        public virtual Equipo Equipo { get; set; }
        #endregion
    }
}