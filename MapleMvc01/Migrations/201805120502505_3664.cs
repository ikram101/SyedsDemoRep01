namespace MapleMvc01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3664 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "AuthorId", c => c.Int(nullable: true));

        }

        public override void Down()
        {
        }
    }
}
