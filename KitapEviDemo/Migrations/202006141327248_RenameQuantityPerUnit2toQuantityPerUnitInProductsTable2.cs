namespace KitapEviDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameQuantityPerUnit2toQuantityPerUnitInProductsTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "QuantityPerUnit", c => c.String());
            DropColumn("dbo.Products", "QuantityPerUnit2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "QuantityPerUnit2", c => c.String());
            DropColumn("dbo.Products", "QuantityPerUnit");
        }
    }
}
