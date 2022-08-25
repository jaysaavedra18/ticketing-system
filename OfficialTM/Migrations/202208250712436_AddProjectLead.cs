namespace OfficialTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectLead : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectModels", "ProjectLead", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectModels", "ProjectLead");
        }
    }
}
