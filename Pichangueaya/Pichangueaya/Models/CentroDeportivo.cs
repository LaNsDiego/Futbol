using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    //[Table("CentroDeportivos")]
    public class CentroDeportivo
    {
        public int CentroDeportivoID { get; set; }
        public string Nombre { get; set; }
        public int UsuarioID { get; set; }  //Encargado
        public int CorreoElectronico { get; set; }
        public int Telefono { get; set; }
        public double Altitud { get; set; }
        public double Longitud { get; set; }
        public string Imagen { get; set; }
        public int UbigeoID { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; } //Activo(1) e Inactivo(0)

        #region Relacion

        public virtual Ubigeo Ubigeo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<CampoDeportivo> Campos { get; set; }
        #endregion

        #region Constructor
        public CentroDeportivo()
        {
            Campos = new HashSet<CampoDeportivo>();
        }
        #endregion
    }
}