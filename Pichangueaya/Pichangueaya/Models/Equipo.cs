using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class Equipo
    {
        [Key]
        public int EquipoID { get; set; }
        public int Nombre { get; set; }
        public string Logo { get; set; }
        public int UsuarioID { get; set; }
        public int UbigeoID { get; set; }
        public NivelEquipo Nivel { get; set; }

        #region Relaciones

        public virtual Usuario Usuario { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
        #endregion
    }
}