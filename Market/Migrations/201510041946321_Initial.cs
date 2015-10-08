namespace Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        ISBN = c.Int(nullable: false),
                        Name = c.String(),
                        Author = c.String(),
                        Published = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
