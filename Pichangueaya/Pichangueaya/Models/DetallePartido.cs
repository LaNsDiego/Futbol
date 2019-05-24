using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class DetallePartido
    {
        [Key]
        public int DetallePartidoID { get; set; }
        public int PartidoID { get; set; }
        public int EquipoID { get; set; }


        #region Relaciones

        public virtual Partido Partido { get; set; }
        public virtual Equipo Equipo { get; set; }
        #endregion
    }
}