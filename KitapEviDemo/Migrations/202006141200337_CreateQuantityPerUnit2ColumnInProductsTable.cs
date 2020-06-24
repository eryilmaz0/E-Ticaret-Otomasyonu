namespace KitapEviDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateQuantityPerUnit2ColumnInProductsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "QuantityPerUnit2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "QuantityPerUnit2");
        }
    }
}
