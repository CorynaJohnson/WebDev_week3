namespace lab_2_web_design.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userandyarn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YarnUsers",
                c => new
                    {
                        Yarn_YarnId = c.Int(nullable: false),
                        User_UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Yarn_YarnId, t.User_UserId })
                .ForeignKey("dbo.Yarns", t => t.Yarn_YarnId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .Index(t => t.Yarn_YarnId)
                .Index(t => t.User_UserId);
            
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.YarnUsers", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.YarnUsers", "Yarn_YarnId", "dbo.Yarns");
            DropIndex("dbo.YarnUsers", new[] { "User_UserId" });
            DropIndex("dbo.YarnUsers", new[] { "Yarn_YarnId" });
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            DropTable("dbo.YarnUsers");
        }
    }
}
