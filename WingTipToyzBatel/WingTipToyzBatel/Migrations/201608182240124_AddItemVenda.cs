namespace WingTipToyzBatel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemVenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItensVenda",
                c => new
                    {
                        ItemVendaId = c.Int(nullable: false, identity: true),
                        ItemVendaProdutoId = c.Int(nullable: false),
                        ItemVendaQuantidade = c.Int(nullable: false),
                        ItemVendaData = c.DateTime(nullable: false),
                        ItemVendaCarrinhoId = c.String(),
                        Produto_ProdutoId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemVendaId)
                .ForeignKey("dbo.Produtos", t => t.Produto_ProdutoId)
                .Index(t => t.Produto_ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItensVenda", "Produto_ProdutoId", "dbo.Produtos");
            DropIndex("dbo.ItensVenda", new[] { "Produto_ProdutoId" });
            DropTable("dbo.ItensVenda");
        }
    }
}
