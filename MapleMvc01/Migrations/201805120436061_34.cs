namespace MapleMvc01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _34 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthorBiographies",
                c => new
                    {
                        AuthorBiographyId = c.Int(nullable: false, identity: true),
                        Biography = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        PlaceOfBirth = c.String(),
                        Nationality = c.String(),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorBiographyId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            AddColumn("dbo.Books", "Biography_AuthorBiographyId", c => c.Int());
            CreateIndex("dbo.Books", "Biography_AuthorBiographyId");
            AddForeignKey("dbo.Books", "Biography_AuthorBiographyId", "dbo.AuthorBiographies", "AuthorBiographyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Biography_AuthorBiographyId", "dbo.AuthorBiographies");
            DropForeignKey("dbo.AuthorBiographies", "AuthorId", "dbo.Authors");
            DropIndex("dbo.AuthorBiographies", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "Biography_AuthorBiographyId" });
            DropColumn("dbo.Books", "Biography_AuthorBiographyId");
            DropTable("dbo.AuthorBiographies");
        }
    }
}
