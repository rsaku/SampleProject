namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mGenres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Genre = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.mGenres");
        }
    }
}
