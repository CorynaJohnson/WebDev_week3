namespace lab_2_web_design.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Yarn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yarns",
                c => new
                    {
                        YarnId = c.Int(nullable: false, identity: true),
                        ColorName = c.String(nullable: false),
                        BrandName = c.String(),
                        Skeins = c.Double(nullable: false),
                        YarnType = c.String(),
                    })
                .PrimaryKey(t => t.YarnId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Yarns");
        }
    }
}
