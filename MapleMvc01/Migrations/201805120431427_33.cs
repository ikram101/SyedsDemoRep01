namespace MapleMvc01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _33 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.CategoryBooks",
                c => new
                    {
                        Category_CategoryId = c.Int(nullable: false),
                        Book_BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_CategoryId, t.Book_BookId })
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_BookId, cascadeDelete: true)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Book_BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryBooks", "Book_BookId", "dbo.Books");
            DropForeignKey("dbo.CategoryBooks", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.CategoryBooks", new[] { "Book_BookId" });
            DropIndex("dbo.CategoryBooks", new[] { "Category_CategoryId" });
            DropTable("dbo.CategoryBooks");
            DropTable("dbo.Categories");
        }
    }
}
