namespace Recurrence.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Jobs", "Method", c => c.String(nullable: false));
            AlterColumn("Jobs", "Endpoint", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("Jobs", "Endpoint", c => c.String());
            AlterColumn("Jobs", "Method", c => c.String());
        }
    }
}
