namespace HC_SB.Modelos.HC_SBMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tbl_Aseguradoras",
                c => new
                    {
                        AseguradoraKey = c.Int(nullable: false, identity: true),
                        AseguradoraName = c.String(),
                    })
                .PrimaryKey(t => t.AseguradoraKey);
            
            CreateTable(
                "dbo.Tbl_CiudadesResidencia",
                c => new
                    {
                        CiudadResidenciaKey = c.Int(nullable: false, identity: true),
                        CiudadName = c.String(),
                    })
                .PrimaryKey(t => t.CiudadResidenciaKey);
            
            CreateTable(
                "dbo.Tbl_Contactos",
                c => new
                    {
                        ContactoKey = c.Int(nullable: false, identity: true),
                        ContactoName = c.String(),
                        ContactoPacienteKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactoKey)
                .ForeignKey("dbo.Tbl_Pacientes", t => t.ContactoPacienteKey, cascadeDelete: true)
                .Index(t => t.ContactoPacienteKey);
            
            CreateTable(
                "dbo.Tbl_Pacientes",
                c => new
                    {
                        PacienteKey = c.Int(nullable: false, identity: true),
                        PacienteNombre = c.String(),
                        PacienteIdentificacion = c.String(),
                        PacienteEdad = c.Int(nullable: false),
                        PacienteRH = c.String(),
                        PacienteFechaNacimiento = c.DateTime(nullable: false),
                        PacienteTelefono = c.String(),
                        PacienteAseguradoraKey = c.Int(nullable: false),
                        PacienteTipoVincualacion = c.String(),
                        PacienteCiudadResidenciaKey = c.Int(nullable: false),
                        PacienteDireccion = c.String(),
                        PacienteGeneroKey = c.Int(nullable: false),
                        PacienteEstadoCivilKey = c.Int(nullable: false),
                        PacienteNivelEducativo = c.String(),
                        PacienteOcupacionKey = c.Int(nullable: false),
                        PacienteMotivoIngreso = c.String(),
                        PacienteMotivoConsulta = c.String(),
                    })
                .PrimaryKey(t => t.PacienteKey)
                .ForeignKey("dbo.Tbl_Aseguradoras", t => t.PacienteAseguradoraKey, cascadeDelete: true)
                .ForeignKey("dbo.Tbl_CiudadesResidencia", t => t.PacienteCiudadResidenciaKey, cascadeDelete: true)
                .ForeignKey("dbo.Tbl_EstadosCivil", t => t.PacienteEstadoCivilKey, cascadeDelete: true)
                .ForeignKey("dbo.Tbl_Generos", t => t.PacienteGeneroKey, cascadeDelete: true)
                .ForeignKey("dbo.Tbl_Ocupaciones", t => t.PacienteOcupacionKey, cascadeDelete: true)
                .Index(t => t.PacienteAseguradoraKey)
                .Index(t => t.PacienteCiudadResidenciaKey)
                .Index(t => t.PacienteGeneroKey)
                .Index(t => t.PacienteEstadoCivilKey)
                .Index(t => t.PacienteOcupacionKey);
            
            CreateTable(
                "dbo.Tbl_EstadosCivil",
                c => new
                    {
                        EstadoCivilKey = c.Int(nullable: false, identity: true),
                        EstadoCivilName = c.String(),
                    })
                .PrimaryKey(t => t.EstadoCivilKey);
            
            CreateTable(
                "dbo.Tbl_Generos",
                c => new
                    {
                        GeneroKey = c.Int(nullable: false, identity: true),
                        GeneroName = c.String(),
                    })
                .PrimaryKey(t => t.GeneroKey);
            
            CreateTable(
                "dbo.Tbl_Ocupaciones",
                c => new
                    {
                        OcupacionKey = c.Int(nullable: false, identity: true),
                        OcupacionName = c.String(),
                    })
                .PrimaryKey(t => t.OcupacionKey);
            
            CreateTable(
                "dbo.Tbl_FormatosHistoriaClinica",
                c => new
                    {
                        FormatoHistoriaClinicaKey = c.Int(nullable: false, identity: true),
                        FormatoHistoriaClinicaName = c.String(),
                    })
                .PrimaryKey(t => t.FormatoHistoriaClinicaKey);
            
            CreateTable(
                "dbo.Tbl_HistoriasClinicas",
                c => new
                    {
                        HistoriaClinicaKey = c.Int(nullable: false, identity: true),
                        HistoriaClinicaPacienteKey = c.Int(nullable: false),
                        HistoriaClinicaFormatoHistoriaClinicaKey = c.Int(nullable: false),
                        HistoriaClinicaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HistoriaClinicaKey)
                .ForeignKey("dbo.Tbl_FormatosHistoriaClinica", t => t.HistoriaClinicaFormatoHistoriaClinicaKey, cascadeDelete: true)
                .ForeignKey("dbo.Tbl_Pacientes", t => t.HistoriaClinicaPacienteKey, cascadeDelete: true)
                .Index(t => t.HistoriaClinicaPacienteKey)
                .Index(t => t.HistoriaClinicaFormatoHistoriaClinicaKey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tbl_HistoriasClinicas", "HistoriaClinicaPacienteKey", "dbo.Tbl_Pacientes");
            DropForeignKey("dbo.Tbl_HistoriasClinicas", "HistoriaClinicaFormatoHistoriaClinicaKey", "dbo.Tbl_FormatosHistoriaClinica");
            DropForeignKey("dbo.Tbl_Contactos", "ContactoPacienteKey", "dbo.Tbl_Pacientes");
            DropForeignKey("dbo.Tbl_Pacientes", "PacienteOcupacionKey", "dbo.Tbl_Ocupaciones");
            DropForeignKey("dbo.Tbl_Pacientes", "PacienteGeneroKey", "dbo.Tbl_Generos");
            DropForeignKey("dbo.Tbl_Pacientes", "PacienteEstadoCivilKey", "dbo.Tbl_EstadosCivil");
            DropForeignKey("dbo.Tbl_Pacientes", "PacienteCiudadResidenciaKey", "dbo.Tbl_CiudadesResidencia");
            DropForeignKey("dbo.Tbl_Pacientes", "PacienteAseguradoraKey", "dbo.Tbl_Aseguradoras");
            DropIndex("dbo.Tbl_HistoriasClinicas", new[] { "HistoriaClinicaFormatoHistoriaClinicaKey" });
            DropIndex("dbo.Tbl_HistoriasClinicas", new[] { "HistoriaClinicaPacienteKey" });
            DropIndex("dbo.Tbl_Pacientes", new[] { "PacienteOcupacionKey" });
            DropIndex("dbo.Tbl_Pacientes", new[] { "PacienteEstadoCivilKey" });
            DropIndex("dbo.Tbl_Pacientes", new[] { "PacienteGeneroKey" });
            DropIndex("dbo.Tbl_Pacientes", new[] { "PacienteCiudadResidenciaKey" });
            DropIndex("dbo.Tbl_Pacientes", new[] { "PacienteAseguradoraKey" });
            DropIndex("dbo.Tbl_Contactos", new[] { "ContactoPacienteKey" });
            DropTable("dbo.Tbl_HistoriasClinicas");
            DropTable("dbo.Tbl_FormatosHistoriaClinica");
            DropTable("dbo.Tbl_Ocupaciones");
            DropTable("dbo.Tbl_Generos");
            DropTable("dbo.Tbl_EstadosCivil");
            DropTable("dbo.Tbl_Pacientes");
            DropTable("dbo.Tbl_Contactos");
            DropTable("dbo.Tbl_CiudadesResidencia");
            DropTable("dbo.Tbl_Aseguradoras");
        }
    }
}
