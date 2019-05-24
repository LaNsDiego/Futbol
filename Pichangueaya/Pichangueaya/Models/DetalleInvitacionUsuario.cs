using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class DetalleInvitacionUsuario
    {
        public int DetalleInvitacionUsuarioID { get; set; }
        public int EquipoID { get; set; }
        public int UsuarioID { get; set; }

        #region Relaciones
        public virtual Usuario Usuario { get; set; }
        public virtual Equipo Equipo { get; set; }
        #endregion
    }
}