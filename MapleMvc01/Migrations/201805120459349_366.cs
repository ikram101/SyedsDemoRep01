namespace MapleMvc01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _366 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "AuthorId", c => c.Int(nullable: false));

            AlterColumn("dbo.Books", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Price", c => c.Single(nullable: false));
            AlterColumn("dbo.Books", "AuthorId", c => c.Single(nullable: false));

        }
    }
}
