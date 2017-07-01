namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.area_atuacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.banco",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.consulta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicoResponsavel_Id = c.Int(nullable: false),
                        PacienteAtendido_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.medico", t => t.MedicoResponsavel_Id, cascadeDelete: true)
                .ForeignKey("dbo.paciente", t => t.PacienteAtendido_Id, cascadeDelete: true)
                .Index(t => t.MedicoResponsavel_Id)
                .Index(t => t.PacienteAtendido_Id);
            
            CreateTable(
                "dbo.medico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaDeAtuacao_Id = c.Int(nullable: false),
                        TurnoTrabalho_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.area_atuacao", t => t.AreaDeAtuacao_Id, cascadeDelete: true)
                .ForeignKey("dbo.turno", t => t.TurnoTrabalho_Id, cascadeDelete: true)
                .Index(t => t.AreaDeAtuacao_Id)
                .Index(t => t.TurnoTrabalho_Id);
            
            CreateTable(
                "dbo.turno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlanoDeSaude_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.plano_saude", t => t.PlanoDeSaude_Id, cascadeDelete: true)
                .Index(t => t.PlanoDeSaude_Id);
            
            CreateTable(
                "dbo.plano_saude",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpresaConvenio_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.convenio_saude", t => t.EmpresaConvenio_Id, cascadeDelete: true)
                .Index(t => t.EmpresaConvenio_Id);
            
            CreateTable(
                "dbo.convenio_saude",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.funcionario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BancoConta_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.banco", t => t.BancoConta_Id, cascadeDelete: true)
                .Index(t => t.BancoConta_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.funcionario", "BancoConta_Id", "dbo.banco");
            DropForeignKey("dbo.consulta", "PacienteAtendido_Id", "dbo.paciente");
            DropForeignKey("dbo.paciente", "PlanoDeSaude_Id", "dbo.plano_saude");
            DropForeignKey("dbo.plano_saude", "EmpresaConvenio_Id", "dbo.convenio_saude");
            DropForeignKey("dbo.consulta", "MedicoResponsavel_Id", "dbo.medico");
            DropForeignKey("dbo.medico", "TurnoTrabalho_Id", "dbo.turno");
            DropForeignKey("dbo.medico", "AreaDeAtuacao_Id", "dbo.area_atuacao");
            DropIndex("dbo.funcionario", new[] { "BancoConta_Id" });
            DropIndex("dbo.plano_saude", new[] { "EmpresaConvenio_Id" });
            DropIndex("dbo.paciente", new[] { "PlanoDeSaude_Id" });
            DropIndex("dbo.medico", new[] { "TurnoTrabalho_Id" });
            DropIndex("dbo.medico", new[] { "AreaDeAtuacao_Id" });
            DropIndex("dbo.consulta", new[] { "PacienteAtendido_Id" });
            DropIndex("dbo.consulta", new[] { "MedicoResponsavel_Id" });
            DropTable("dbo.funcionario");
            DropTable("dbo.convenio_saude");
            DropTable("dbo.plano_saude");
            DropTable("dbo.paciente");
            DropTable("dbo.turno");
            DropTable("dbo.medico");
            DropTable("dbo.consulta");
            DropTable("dbo.banco");
            DropTable("dbo.area_atuacao");
        }
    }
}
