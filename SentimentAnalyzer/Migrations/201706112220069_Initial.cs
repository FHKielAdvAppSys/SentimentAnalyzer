namespace SentimentAnalyzer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Searches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Topic = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SearchResults",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SearchID = c.Int(nullable: false),
                        BingID = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Searches", t => t.SearchID, cascadeDelete: true)
                .Index(t => t.SearchID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SearchResults", "SearchID", "dbo.Searches");
            DropIndex("dbo.SearchResults", new[] { "SearchID" });
            DropTable("dbo.SearchResults");
            DropTable("dbo.Searches");
        }
    }
}
