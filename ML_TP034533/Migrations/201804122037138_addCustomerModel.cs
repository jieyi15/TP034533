namespace ML_TP034533.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomerModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        ContactNum = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerModels");
        }
    }
}
