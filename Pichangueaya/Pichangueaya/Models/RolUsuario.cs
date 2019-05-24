using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class RolUsuario
    {
        [Key]
        public int RolUsuarioID { get; set; }
        public int TipoUsuarioID { get; set; }
        public int UsuarioID { get; set; }

        #region Relaciones

        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        #endregion
    }
}