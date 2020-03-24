namespace IssaForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManyChangesAtAll : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Colons", "Rectum", c => c.String());
            AddColumn("dbo.Colons", "Assistant", c => c.String());
            AddColumn("dbo.Stomaches", "GEJ", c => c.String());
            AddColumn("dbo.Stomaches", "Esophagus", c => c.String());
            AddColumn("dbo.Stomaches", "D1", c => c.String());
            AddColumn("dbo.Stomaches", "Assistant", c => c.String());
            DropColumn("dbo.Colons", "Cecum");
            DropColumn("dbo.Colons", "Sigmoid");
            DropColumn("dbo.Colons", "RectumRetroflexion");
            DropColumn("dbo.Colons", "Olympus");
            DropColumn("dbo.Colons", "Medazolam");
            DropColumn("dbo.Colons", "Pentax");
            DropColumn("dbo.Colons", "Others");
            DropColumn("dbo.Colons", "Others1");
            DropColumn("dbo.Colons", "Endoscopist");
            DropColumn("dbo.Stomaches", "EsophagusGEJ");
            DropColumn("dbo.Stomaches", "DuodenumD1");
            DropColumn("dbo.Stomaches", "Olympus");
            DropColumn("dbo.Stomaches", "Medazolam");
            DropColumn("dbo.Stomaches", "Pentax");
            DropColumn("dbo.Stomaches", "Others");
            DropColumn("dbo.Stomaches", "Others1");
            DropColumn("dbo.Stomaches", "Endoscopist");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stomaches", "Endoscopist", c => c.DateTime(nullable: false));
            AddColumn("dbo.Stomaches", "Others1", c => c.String());
            AddColumn("dbo.Stomaches", "Others", c => c.String());
            AddColumn("dbo.Stomaches", "Pentax", c => c.String());
            AddColumn("dbo.Stomaches", "Medazolam", c => c.String());
            AddColumn("dbo.Stomaches", "Olympus", c => c.String());
            AddColumn("dbo.Stomaches", "DuodenumD1", c => c.String());
            AddColumn("dbo.Stomaches", "EsophagusGEJ", c => c.String());
            AddColumn("dbo.Colons", "Endoscopist", c => c.DateTime(nullable: false));
            AddColumn("dbo.Colons", "Others1", c => c.String());
            AddColumn("dbo.Colons", "Others", c => c.String());
            AddColumn("dbo.Colons", "Pentax", c => c.String());
            AddColumn("dbo.Colons", "Medazolam", c => c.String());
            AddColumn("dbo.Colons", "Olympus", c => c.String());
            AddColumn("dbo.Colons", "RectumRetroflexion", c => c.String());
            AddColumn("dbo.Colons", "Sigmoid", c => c.String());
            AddColumn("dbo.Colons", "Cecum", c => c.String());
            DropColumn("dbo.Stomaches", "Assistant");
            DropColumn("dbo.Stomaches", "D1");
            DropColumn("dbo.Stomaches", "Esophagus");
            DropColumn("dbo.Stomaches", "GEJ");
            DropColumn("dbo.Colons", "Assistant");
            DropColumn("dbo.Colons", "Rectum");
        }
    }
}
