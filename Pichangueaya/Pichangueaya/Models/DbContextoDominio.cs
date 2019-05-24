using App.Pichanguea.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace App.Pichanguea
{
    public class DbContextoDominio : DbContext
    {
        public DbContextoDominio() : base("pichangueaya")
        {

        }

        public DbSet<CampoDeportivo> CampoDeportivos { get; set; }
        public DbSet<CampoMaterial> CampoMateriales { get; set; }
        public DbSet<CentroDeportivo> CentroDeportivos { get; set; }
        public DbSet<Deporte> Deportes { get; set; }
        public DbSet<DetalleEquipo> DetalleEquipos { get; set; }
        public DbSet<DetalleInvitacionPartido> DetalleInvitacionPartidos { get; set; }
        public DbSet<DetalleInvitacionUsuario> DetalleInvitacionUsuarios { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<MetodoPago> MetodoPagos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<RealizacionPartido> RealizacionPartidos { get; set; }
        public DbSet<RecomendacionCentroDeportivo> RecomendacionCentroDeportivos { get; set; }
        public DbSet<RecomendacionUsuario> RecomendacionUsuarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }
        public DbSet<TipoCampo> TipoCampos { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Ubigeo> Ubigeos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}