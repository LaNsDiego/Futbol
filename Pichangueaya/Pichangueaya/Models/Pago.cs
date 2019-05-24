using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class Pago
    {
        [Key]
        public int PagoID { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
        public int MetodoPagoID { get; set; }

        #region Relaciones
        public virtual MetodoPago MetodoPago { get; set; }
        #endregion
    }
}