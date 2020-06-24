namespace KitapEviDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMyProCompanypertyColumnInProductListModelsTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductListModels", "MyProCompanyperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductListModels", "MyProCompanyperty", c => c.String());
        }
    }
}
