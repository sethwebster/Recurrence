namespace Recurrence.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Jobs",
                c => new
                    {
                        JobId = c.Int(nullable: false, identity: true),
                        When = c.DateTimeOffset(nullable: false),
                        Method = c.String(),
                        Endpoint = c.String(),
                        Attempts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobId);
            
        }
        
        public override void Down()
        {
            DropTable("Jobs");
        }
    }
}
