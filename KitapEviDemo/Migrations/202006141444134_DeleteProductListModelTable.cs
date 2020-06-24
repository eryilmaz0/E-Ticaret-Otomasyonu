namespace KitapEviDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteProductListModelTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ProductListModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductListModels",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Category = c.String(),
                        Company = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantityPerUnit = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
    }
}
