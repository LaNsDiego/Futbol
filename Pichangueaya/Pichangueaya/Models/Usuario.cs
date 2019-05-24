using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Pichanguea.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string Celular { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }


        //public ResponseModel Validar(string correo, string contrasena)
        //{
        //    ResponseModel response = new ResponseModel();
        //    try
        //    {
        //        DbContextoDominio Db = new DbContextoDominio();
        //        Clave = HashHelper.SHA1(contrasena);
        //        Usuario usuario = Db.Usuarios.Where(u => u.Clave == Clave).Where(u => u.CorreoElectronico == correo).SingleOrDefault();
        //        if (usuario != null)
        //        {
        //            SessionHelper.AddUserToSession(usuario.UsuarioID.ToString());
        //            response.SetResponse(true);
        //        }
        //        else
        //        {
        //            response.SetResponse(false, "Usuario o password incorrectos... ");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    return response;
        //}
    }
}