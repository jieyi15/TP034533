namespace ML_TP034533.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBookModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemWeight = c.Int(nullable: false),
                        ContainerAmount = c.Int(nullable: false),
                        customerModelId = c.Int(nullable: false),
                        scheduleModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerModels", t => t.customerModelId, cascadeDelete: true)
                .ForeignKey("dbo.ScheduleModels", t => t.scheduleModelId, cascadeDelete: true)
                .Index(t => t.customerModelId)
                .Index(t => t.scheduleModelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookingModels", "scheduleModelId", "dbo.ScheduleModels");
            DropForeignKey("dbo.BookingModels", "customerModelId", "dbo.CustomerModels");
            DropIndex("dbo.BookingModels", new[] { "scheduleModelId" });
            DropIndex("dbo.BookingModels", new[] { "customerModelId" });
            DropTable("dbo.BookingModels");
        }
    }
}
