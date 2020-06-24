namespace KitapEviDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteQuantityPerUnitColumnInProductsTable1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "QuantityPerUnit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "QuantityPerUnit", c => c.Int(nullable: false));
        }
    }
}
