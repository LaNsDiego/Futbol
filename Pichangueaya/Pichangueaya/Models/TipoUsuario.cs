﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class TipoUsuario
    {
        [Key]
        public int TipoUsuarioID { get; set; }
        public string Descripcion { get; set; }


    }
}