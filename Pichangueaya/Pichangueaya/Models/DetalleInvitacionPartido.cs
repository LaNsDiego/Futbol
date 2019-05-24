using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class DetalleInvitacionPartido
    {
        [Key]
        public int DetalleInvitacionPartidoID { get; set; }
        public int EquipoID { get; set; }
        public int PartidoID { get; set; }
        public bool Estado { get; set; }

        #region Relacion

        public virtual Equipo Equipo { get; set; }
        public virtual Partido Partido { get; set; }

        #endregion
    }
}