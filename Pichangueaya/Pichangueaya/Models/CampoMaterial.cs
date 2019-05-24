using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    //[Table("CampoMateriales")]
    public class CampoMaterial
    {
        public int CampoMaterialID { get; set; }
        public int Descripcion { get; set; }


    }
}