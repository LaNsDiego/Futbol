using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    //[Table("CampoDeportivos")]
    public class CampoDeportivo
    {
        public int CampoDeportivoID { get; set; }
        public int CentroDeportivoID { get; set; }
        public int TipoCampoID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Estado { get; set; } //A(1) e I(0)

        #region Relacion
        public virtual TipoCampo TipoCampo { get; set; }
        public virtual CentroDeportivo CentroDeportivo { get; set; }
        #endregion

    }
}