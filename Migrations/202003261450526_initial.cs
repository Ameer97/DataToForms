namespace IssaForms.Migrations
{
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
                    Name = c.String(),
                    Age = c.String(),
                    Gender = c.String(),
                    FileNo = c.String(),
                    Date = c.DateTime(nullable: false),
                    Premedication = c.String(),
                    Scope = c.String(),
                    ReferredDoctor = c.String(),
                    ClinicalData = c.String(),
                    Preparation = c.String(),
                    AnalInspection = c.String(),
                    PRExam = c.String(),
                    Ileum = c.String(),
                    ColonDetails = c.String(),
                    Rectum = c.String(),
                    Conclusion = c.String(),
                    Assistant = c.String(),
                    Endoscopist = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Stomaches",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Age = c.String(),
                    Gender = c.String(),
                    FileNo = c.String(),
                    Date = c.DateTime(nullable: false),
                    Premedication = c.String(),
                    Scope = c.String(),
                    ReferredDoctor = c.String(),
                    ClinicalData = c.String(),
                    GEJ = c.String(),
                    Esophagus = c.String(),
                    StomachDetails = c.String(),
                    D1 = c.String(),
                    D2 = c.String(),
                    Conclusion = c.String(),
                    Assistant = c.String(),
                    Endoscopist = c.String(),
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
