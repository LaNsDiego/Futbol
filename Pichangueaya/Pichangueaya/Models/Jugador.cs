using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class Jugador
    {
        public int JugadorID { get; set; }
        public int EquipoID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaFichaje { get; set; }
        public DateTime FechaSalida { get; set; }

        #region Relaciones
        public virtual Usuario Usuario { get; set; }
        public virtual Equipo Equipo { get; set; }
        #endregion
    }
}