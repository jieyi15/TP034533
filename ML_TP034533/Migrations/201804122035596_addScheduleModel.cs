namespace ML_TP034533.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addScheduleModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScheduleModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureCity = c.String(nullable: false, maxLength: 50),
                        ArrivalCity = c.String(nullable: false, maxLength: 50),
                        DepartureDate = c.DateTime(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ScheduleModels");
        }
    }
}
