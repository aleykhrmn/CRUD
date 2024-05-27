namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fakultes",
                c => new
                    {
                        FakulteId = c.Int(nullable: false, identity: true),
                        FakulteAd = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FakulteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fakultes");
        }
    }
}
