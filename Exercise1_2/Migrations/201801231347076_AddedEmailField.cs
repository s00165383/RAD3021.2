namespace Exercise1_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmailField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Email");
        }
    }
}
