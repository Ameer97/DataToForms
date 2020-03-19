namespace IssaForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preparation = c.String(),
                        AnalInspection = c.String(),
                        PRExam = c.String(),
                        Ileum = c.String(),
                        Cecum = c.String(),
                        ColonDetails = c.String(),
                        Sigmoid = c.String(),
                        RectumRetroflexion = c.String(),
                        Name = c.String(),
                        Age = c.String(),
                        FileNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        Premedication = c.String(),
                        Scope = c.String(),
                        Olympus = c.String(),
                        ReferredDoctor = c.String(),
                        Medazolam = c.String(),
                        Pentax = c.String(),
                        Others = c.String(),
                        Others1 = c.String(),
                        ClinicalData = c.String(),
                        Conclusion = c.String(),
                        Endoscopist = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stomaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EsophagusGEJ = c.String(),
                        StomachDetails = c.String(),
                        DuodenumD1 = c.String(),
                        D2 = c.String(),
                        Name = c.String(),
                        Age = c.String(),
                        FileNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        Premedication = c.String(),
                        Scope = c.String(),
                        Olympus = c.String(),
                        ReferredDoctor = c.String(),
                        Medazolam = c.String(),
                        Pentax = c.String(),
                        Others = c.String(),
                        Others1 = c.String(),
                        ClinicalData = c.String(),
                        Conclusion = c.String(),
                        Endoscopist = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stomaches");
            DropTable("dbo.Colons");
        }
    }
}
