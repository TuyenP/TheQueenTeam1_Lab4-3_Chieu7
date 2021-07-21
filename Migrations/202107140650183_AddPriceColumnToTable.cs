namespace Lab4_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPriceColumnToTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Price");
        }
    }
}
