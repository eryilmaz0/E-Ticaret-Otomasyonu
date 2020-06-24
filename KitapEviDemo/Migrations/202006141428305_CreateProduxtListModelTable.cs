namespace KitapEviDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProduxtListModelTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductListModels",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Category = c.String(),
                        Company = c.String(),
                        MyProCompanyperty = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantityPerUnit = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductListModels");
        }
    }
}
