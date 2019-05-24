using App.Pichanguea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Pichangea
{
    public class CapaDatos
    {
        readonly DbContextoDominio ioContexto;

        public CapaDatos()
        {
            ioContexto = new DbContextoDominio();
        }

        public void Agregar<T>(T aoEntidad) where T : class
        {
            ioContexto.Set<T>().Add(aoEntidad);
        }

        public void Guardar()
        {
            ioContexto.SaveChanges();
        }

        public IQueryable Listar<T>(string asPropiedades = "") where T : class
        {
            return ioContexto.Set<T>();
        }

        public T ObtenerPorCodigo<T>(params object[] aoLlaves) where T : class
        {
            return ioContexto.Set<T>().Find(aoLlaves);
        }

        public T Borrar<T>(T aoEntidad) where T : class
        {

            return ioContexto.Set<T>().Remove(aoEntidad);
        }
    }
}