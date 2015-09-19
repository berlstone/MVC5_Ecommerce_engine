namespace Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Books");
            DropColumn("dbo.Books","ISBN");
            AddColumn("dbo.Books", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Books", "ISBN", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Books", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "ISBN", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Books", "ID");
            AddPrimaryKey("dbo.Books", "ISBN"); 
        }
    }
}
