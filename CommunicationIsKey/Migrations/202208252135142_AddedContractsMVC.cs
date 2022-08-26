namespace CommunicationIsKey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedContractsMVC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Company = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Plan = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContractModels");
        }
    }
}
