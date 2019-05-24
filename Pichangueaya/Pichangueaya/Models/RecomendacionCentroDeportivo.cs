using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class RecomendacionCentroDeportivo
    {

        public int RecomendacionCentroDeportivoID { get; set; }
        public int UsuarioID { get; set; }
        public int CentroDeportivoID { get; set; }
        public DateTime FechaRecomendacion { get; set; }

        #region Relaciones
        public virtual CentroDeportivo CentroDeportivo { get; set; }
        public virtual Usuario Usuario { get; set; }
        #endregion


    }
}