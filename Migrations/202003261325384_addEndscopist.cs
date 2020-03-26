namespace IssaForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEndscopist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Colons", "Endoscopist", c => c.String());
            AddColumn("dbo.Stomaches", "Endoscopist", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stomaches", "Endoscopist");
            DropColumn("dbo.Colons", "Endoscopist");
        }
    }
}
