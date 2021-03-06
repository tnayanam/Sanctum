namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kj : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pickles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Pickle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pickles", t => t.Pickle_Id)
                .Index(t => t.Pickle_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Types", "Pickle_Id", "dbo.Pickles");
            DropIndex("dbo.Types", new[] { "Pickle_Id" });
            DropTable("dbo.Types");
            DropTable("dbo.Pickles");
        }
    }
}
