using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class RealizacionPartido
    {
        public int RealizacionPartidoID { get; set; }
        public int ReservaID { get; set; }
        public int PartidoID { get; set; }

        #region Relaciones

        public virtual Reserva Reserva { get; set; }
        public virtual Partido Partido { get; set; }

        #endregion
    }
}