using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class TipoCampo
    {
        public int TipoCampoID { get; set; }
        public string Descripcion { get; set; }
        public string CampoMaterialID { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public double Area()
        {
            return Largo * Ancho;
        }


        #region Relaciones

        public virtual CampoMaterial CampoMaterial { get; set; }
        #endregion
    }
}