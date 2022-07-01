namespace WebTestServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.newSymbols",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sym = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.oldSymbols",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sym = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.requestSymbols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        requestSym = c.String(),
                        date = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.requestSymbols");
            DropTable("dbo.oldSymbols");
            DropTable("dbo.newSymbols");
        }
    }
}
