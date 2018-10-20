namespace MapleMvc01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _35 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.AuthorBiographies", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.AuthorBiographies", new[] { "AuthorId" });
            AlterColumn("dbo.Books", "AuthorId", c => c.Int());
            AlterColumn("dbo.AuthorBiographies", "AuthorId", c => c.Int());
            CreateIndex("dbo.Books", "AuthorId");
            CreateIndex("dbo.AuthorBiographies", "AuthorId");
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "AuthorId");
            AddForeignKey("dbo.AuthorBiographies", "AuthorId", "dbo.Authors", "AuthorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AuthorBiographies", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.AuthorBiographies", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            AlterColumn("dbo.AuthorBiographies", "AuthorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.AuthorBiographies", "AuthorId");
            CreateIndex("dbo.Books", "AuthorId");
            AddForeignKey("dbo.AuthorBiographies", "AuthorId", "dbo.Authors", "AuthorId", cascadeDelete: true);
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "AuthorId", cascadeDelete: true);
        }
    }
}
