namespace OfficialTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectModels", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProjectModels", "UpdatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectModels", "UpdatedDate");
            DropColumn("dbo.ProjectModels", "CreatedDate");
        }
    }
}
