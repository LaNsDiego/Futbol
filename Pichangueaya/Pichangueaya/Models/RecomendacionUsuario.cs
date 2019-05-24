using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class RecomendacionUsuario
    {
        public int RecomendacionUsuarioID { get; set; }
        public int UsuarioRecomendadoID { get; set; }
        public int UsuarioRecomendadorID { get; set; }
        public DateTime FechaRecomendacion { get; set; }

        #region Relaciones
        public virtual Usuario UsuarioRecomendador { get; set; }
        public virtual Usuario UsuarioRecomendado { get; set; }
        #endregion
    }
}