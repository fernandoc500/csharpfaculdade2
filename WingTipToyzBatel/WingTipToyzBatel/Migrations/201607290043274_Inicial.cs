namespace WingTipToyzBatel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        CategoriaNome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        ProdutoNome = c.String(nullable: false),
                        ProdutoPreco = c.Double(nullable: false),
                        ProdutoDescricao = c.String(nullable: false, maxLength: 1000),
                        ProdutoQuantidade = c.Int(nullable: false),
                        ProdutoImagem = c.String(),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "CategoriaId" });
            DropTable("dbo.Produtos");
            DropTable("dbo.Categorias");
        }
    }
}
