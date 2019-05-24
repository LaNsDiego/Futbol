using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaID { get; set; }
        public int PagoID { get; set; }
        public int UsuarioID { get; set; }
        public int CampoDeportivoID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public EstadoReserva Estado { get; set; } //Pagada , Pendiente , Anulada , Reservado

        #region Relaciones
        public virtual Usuario Usuario { get; set; }
        public virtual CampoDeportivo CampoDeportivo { get; set; }
        public virtual Pago Pago { get; set; }
        #endregion
    }
}