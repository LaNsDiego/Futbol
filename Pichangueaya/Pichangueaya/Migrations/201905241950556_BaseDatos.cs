namespace Pichangueaya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CampoDeportivo",
                c => new
                    {
                        CampoDeportivoID = c.Int(nullable: false, identity: true),
                        CentroDeportivoID = c.Int(nullable: false),
                        TipoCampoID = c.Int(nullable: false),
                        Nombre = c.String(),
                        Precio = c.Double(nullable: false),
                        Estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CampoDeportivoID)
                .ForeignKey("dbo.CentroDeportivo", t => t.CentroDeportivoID, cascadeDelete: false)
                .ForeignKey("dbo.TipoCampo", t => t.TipoCampoID, cascadeDelete: false)
                .Index(t => t.CentroDeportivoID)
                .Index(t => t.TipoCampoID);
            
            CreateTable(
                "dbo.CentroDeportivo",
                c => new
                    {
                        CentroDeportivoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        UsuarioID = c.Int(nullable: false),
                        CorreoElectronico = c.Int(nullable: false),
                        Telefono = c.Int(nullable: false),
                        Altitud = c.Double(nullable: false),
                        Longitud = c.Double(nullable: false),
                        Imagen = c.String(),
                        UbigeoID = c.Int(nullable: false),
                        Direccion = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CentroDeportivoID)
                .ForeignKey("dbo.Ubigeo", t => t.UbigeoID, cascadeDelete: false)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.UsuarioID)
                .Index(t => t.UbigeoID);
            
            CreateTable(
                "dbo.Ubigeo",
                c => new
                    {
                        UbigeoID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Departamento = c.String(),
                        Provincia = c.String(),
                        Distrito = c.String(),
                    })
                .PrimaryKey(t => t.UbigeoID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        CorreoElectronico = c.String(),
                        Celular = c.String(),
                        Clave = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
            CreateTable(
                "dbo.TipoCampo",
                c => new
                    {
                        TipoCampoID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        CampoMaterialID = c.String(),
                        Largo = c.Double(nullable: false),
                        Ancho = c.Double(nullable: false),
                        CampoMaterial_CampoMaterialID = c.Int(),
                    })
                .PrimaryKey(t => t.TipoCampoID)
                .ForeignKey("dbo.CampoMaterial", t => t.CampoMaterial_CampoMaterialID)
                .Index(t => t.CampoMaterial_CampoMaterialID);
            
            CreateTable(
                "dbo.CampoMaterial",
                c => new
                    {
                        CampoMaterialID = c.Int(nullable: false, identity: true),
                        Descripcion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CampoMaterialID);
            
            CreateTable(
                "dbo.Deporte",
                c => new
                    {
                        DeporteID = c.Int(nullable: false, identity: true),
                        Nombre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeporteID);
            
            CreateTable(
                "dbo.DetalleEquipo",
                c => new
                    {
                        DetalleEquipoID = c.Int(nullable: false, identity: true),
                        EquipoID = c.Int(nullable: false),
                        DeporteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleEquipoID)
                .ForeignKey("dbo.Deporte", t => t.DeporteID, cascadeDelete: false)
                .ForeignKey("dbo.Equipo", t => t.EquipoID, cascadeDelete: false)
                .Index(t => t.EquipoID)
                .Index(t => t.DeporteID);
            
            CreateTable(
                "dbo.Equipo",
                c => new
                    {
                        EquipoID = c.Int(nullable: false, identity: true),
                        Nombre = c.Int(nullable: false),
                        Logo = c.String(),
                        UsuarioID = c.Int(nullable: false),
                        UbigeoID = c.Int(nullable: false),
                        Nivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EquipoID)
                .ForeignKey("dbo.Ubigeo", t => t.UbigeoID, cascadeDelete: false)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.UsuarioID)
                .Index(t => t.UbigeoID);
            
            CreateTable(
                "dbo.DetalleInvitacionPartido",
                c => new
                    {
                        DetalleInvitacionPartidoID = c.Int(nullable: false, identity: true),
                        EquipoID = c.Int(nullable: false),
                        PartidoID = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleInvitacionPartidoID)
                .ForeignKey("dbo.Equipo", t => t.EquipoID, cascadeDelete: false)
                .ForeignKey("dbo.Partido", t => t.PartidoID, cascadeDelete: false)
                .Index(t => t.EquipoID)
                .Index(t => t.PartidoID);
            
            CreateTable(
                "dbo.Partido",
                c => new
                    {
                        PartidoID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartidoID);
            
            CreateTable(
                "dbo.DetalleInvitacionUsuario",
                c => new
                    {
                        DetalleInvitacionUsuarioID = c.Int(nullable: false, identity: true),
                        EquipoID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleInvitacionUsuarioID)
                .ForeignKey("dbo.Equipo", t => t.EquipoID, cascadeDelete: false)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.EquipoID)
                .Index(t => t.UsuarioID);
            
            CreateTable(
                "dbo.Jugador",
                c => new
                    {
                        JugadorID = c.Int(nullable: false, identity: true),
                        EquipoID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                        FechaFichaje = c.DateTime(nullable: false),
                        FechaSalida = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.JugadorID)
                .ForeignKey("dbo.Equipo", t => t.EquipoID, cascadeDelete: false)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.EquipoID)
                .Index(t => t.UsuarioID);
            
            CreateTable(
                "dbo.MetodoPago",
                c => new
                    {
                        MetodoPagoID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.MetodoPagoID);
            
            CreateTable(
                "dbo.Pago",
                c => new
                    {
                        PagoID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Monto = c.Double(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Descripcion = c.String(),
                        MetodoPagoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PagoID)
                .ForeignKey("dbo.MetodoPago", t => t.MetodoPagoID, cascadeDelete: false)
                .Index(t => t.MetodoPagoID);
            
            CreateTable(
                "dbo.RealizacionPartido",
                c => new
                    {
                        RealizacionPartidoID = c.Int(nullable: false, identity: true),
                        ReservaID = c.Int(nullable: false),
                        PartidoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RealizacionPartidoID)
                .ForeignKey("dbo.Partido", t => t.PartidoID, cascadeDelete: false)
                .ForeignKey("dbo.Reserva", t => t.ReservaID, cascadeDelete: false)
                .Index(t => t.ReservaID)
                .Index(t => t.PartidoID);
            
            CreateTable(
                "dbo.Reserva",
                c => new
                    {
                        ReservaID = c.Int(nullable: false, identity: true),
                        PagoID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                        CampoDeportivoID = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaEntrada = c.DateTime(nullable: false),
                        FechaSalida = c.DateTime(nullable: false),
                        Estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservaID)
                .ForeignKey("dbo.CampoDeportivo", t => t.CampoDeportivoID, cascadeDelete: false)
                .ForeignKey("dbo.Pago", t => t.PagoID, cascadeDelete: false)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.PagoID)
                .Index(t => t.UsuarioID)
                .Index(t => t.CampoDeportivoID);
            
            CreateTable(
                "dbo.RecomendacionCentroDeportivo",
                c => new
                    {
                        RecomendacionCentroDeportivoID = c.Int(nullable: false, identity: true),
                        UsuarioID = c.Int(nullable: false),
                        CentroDeportivoID = c.Int(nullable: false),
                        FechaRecomendacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecomendacionCentroDeportivoID)
                .ForeignKey("dbo.CentroDeportivo", t => t.CentroDeportivoID, cascadeDelete: false)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.UsuarioID)
                .Index(t => t.CentroDeportivoID);
            
            CreateTable(
                "dbo.RecomendacionUsuario",
                c => new
                    {
                        RecomendacionUsuarioID = c.Int(nullable: false, identity: true),
                        UsuarioRecomendadoID = c.Int(nullable: false),
                        UsuarioRecomendadorID = c.Int(nullable: false),
                        FechaRecomendacion = c.DateTime(nullable: false),
                        UsuarioRecomendado_UsuarioID = c.Int(),
                        UsuarioRecomendador_UsuarioID = c.Int(),
                    })
                .PrimaryKey(t => t.RecomendacionUsuarioID)
                .ForeignKey("dbo.Usuario", t => t.UsuarioRecomendado_UsuarioID)
                .ForeignKey("dbo.Usuario", t => t.UsuarioRecomendador_UsuarioID)
                .Index(t => t.UsuarioRecomendado_UsuarioID)
                .Index(t => t.UsuarioRecomendador_UsuarioID);
            
            CreateTable(
                "dbo.RolUsuario",
                c => new
                    {
                        RolUsuarioID = c.Int(nullable: false, identity: true),
                        TipoUsuarioID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RolUsuarioID)
                .ForeignKey("dbo.TipoUsuario", t => t.TipoUsuarioID, cascadeDelete: false)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.TipoUsuarioID)
                .Index(t => t.UsuarioID);
            
            CreateTable(
                "dbo.TipoUsuario",
                c => new
                    {
                        TipoUsuarioID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TipoUsuarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolUsuario", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.RolUsuario", "TipoUsuarioID", "dbo.TipoUsuario");
            DropForeignKey("dbo.RecomendacionUsuario", "UsuarioRecomendador_UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.RecomendacionUsuario", "UsuarioRecomendado_UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.RecomendacionCentroDeportivo", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.RecomendacionCentroDeportivo", "CentroDeportivoID", "dbo.CentroDeportivo");
            DropForeignKey("dbo.RealizacionPartido", "ReservaID", "dbo.Reserva");
            DropForeignKey("dbo.Reserva", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.Reserva", "PagoID", "dbo.Pago");
            DropForeignKey("dbo.Reserva", "CampoDeportivoID", "dbo.CampoDeportivo");
            DropForeignKey("dbo.RealizacionPartido", "PartidoID", "dbo.Partido");
            DropForeignKey("dbo.Pago", "MetodoPagoID", "dbo.MetodoPago");
            DropForeignKey("dbo.Jugador", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.Jugador", "EquipoID", "dbo.Equipo");
            DropForeignKey("dbo.DetalleInvitacionUsuario", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.DetalleInvitacionUsuario", "EquipoID", "dbo.Equipo");
            DropForeignKey("dbo.DetalleInvitacionPartido", "PartidoID", "dbo.Partido");
            DropForeignKey("dbo.DetalleInvitacionPartido", "EquipoID", "dbo.Equipo");
            DropForeignKey("dbo.DetalleEquipo", "EquipoID", "dbo.Equipo");
            DropForeignKey("dbo.Equipo", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.Equipo", "UbigeoID", "dbo.Ubigeo");
            DropForeignKey("dbo.DetalleEquipo", "DeporteID", "dbo.Deporte");
            DropForeignKey("dbo.CampoDeportivo", "TipoCampoID", "dbo.TipoCampo");
            DropForeignKey("dbo.TipoCampo", "CampoMaterial_CampoMaterialID", "dbo.CampoMaterial");
            DropForeignKey("dbo.CentroDeportivo", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.CentroDeportivo", "UbigeoID", "dbo.Ubigeo");
            DropForeignKey("dbo.CampoDeportivo", "CentroDeportivoID", "dbo.CentroDeportivo");
            DropIndex("dbo.RolUsuario", new[] { "UsuarioID" });
            DropIndex("dbo.RolUsuario", new[] { "TipoUsuarioID" });
            DropIndex("dbo.RecomendacionUsuario", new[] { "UsuarioRecomendador_UsuarioID" });
            DropIndex("dbo.RecomendacionUsuario", new[] { "UsuarioRecomendado_UsuarioID" });
            DropIndex("dbo.RecomendacionCentroDeportivo", new[] { "CentroDeportivoID" });
            DropIndex("dbo.RecomendacionCentroDeportivo", new[] { "UsuarioID" });
            DropIndex("dbo.Reserva", new[] { "CampoDeportivoID" });
            DropIndex("dbo.Reserva", new[] { "UsuarioID" });
            DropIndex("dbo.Reserva", new[] { "PagoID" });
            DropIndex("dbo.RealizacionPartido", new[] { "PartidoID" });
            DropIndex("dbo.RealizacionPartido", new[] { "ReservaID" });
            DropIndex("dbo.Pago", new[] { "MetodoPagoID" });
            DropIndex("dbo.Jugador", new[] { "UsuarioID" });
            DropIndex("dbo.Jugador", new[] { "EquipoID" });
            DropIndex("dbo.DetalleInvitacionUsuario", new[] { "UsuarioID" });
            DropIndex("dbo.DetalleInvitacionUsuario", new[] { "EquipoID" });
            DropIndex("dbo.DetalleInvitacionPartido", new[] { "PartidoID" });
            DropIndex("dbo.DetalleInvitacionPartido", new[] { "EquipoID" });
            DropIndex("dbo.Equipo", new[] { "UbigeoID" });
            DropIndex("dbo.Equipo", new[] { "UsuarioID" });
            DropIndex("dbo.DetalleEquipo", new[] { "DeporteID" });
            DropIndex("dbo.DetalleEquipo", new[] { "EquipoID" });
            DropIndex("dbo.TipoCampo", new[] { "CampoMaterial_CampoMaterialID" });
            DropIndex("dbo.CentroDeportivo", new[] { "UbigeoID" });
            DropIndex("dbo.CentroDeportivo", new[] { "UsuarioID" });
            DropIndex("dbo.CampoDeportivo", new[] { "TipoCampoID" });
            DropIndex("dbo.CampoDeportivo", new[] { "CentroDeportivoID" });
            DropTable("dbo.TipoUsuario");
            DropTable("dbo.RolUsuario");
            DropTable("dbo.RecomendacionUsuario");
            DropTable("dbo.RecomendacionCentroDeportivo");
            DropTable("dbo.Reserva");
            DropTable("dbo.RealizacionPartido");
            DropTable("dbo.Pago");
            DropTable("dbo.MetodoPago");
            DropTable("dbo.Jugador");
            DropTable("dbo.DetalleInvitacionUsuario");
            DropTable("dbo.Partido");
            DropTable("dbo.DetalleInvitacionPartido");
            DropTable("dbo.Equipo");
            DropTable("dbo.DetalleEquipo");
            DropTable("dbo.Deporte");
            DropTable("dbo.CampoMaterial");
            DropTable("dbo.TipoCampo");
            DropTable("dbo.Usuario");
            DropTable("dbo.Ubigeo");
            DropTable("dbo.CentroDeportivo");
            DropTable("dbo.CampoDeportivo");
        }
    }
}
