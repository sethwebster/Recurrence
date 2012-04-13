namespace Recurrence.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedEnumWorkAround : DbMigration
    {
        public override void Up()
        {
            AddColumn("Jobs", "StatusValue", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Jobs", "StatusValue");
        }
    }
}
