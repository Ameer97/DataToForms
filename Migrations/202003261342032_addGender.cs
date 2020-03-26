namespace IssaForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Colons", "Gender", c => c.String());
            AddColumn("dbo.Stomaches", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stomaches", "Gender");
            DropColumn("dbo.Colons", "Gender");
        }
    }
}
