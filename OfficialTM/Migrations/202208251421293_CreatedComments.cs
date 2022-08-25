namespace OfficialTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedComments : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TicketModels", "Priority", c => c.String(nullable: false));
            AlterColumn("dbo.TicketModels", "Type", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TicketModels", "Type", c => c.String());
            AlterColumn("dbo.TicketModels", "Priority", c => c.String());
        }
    }
}
