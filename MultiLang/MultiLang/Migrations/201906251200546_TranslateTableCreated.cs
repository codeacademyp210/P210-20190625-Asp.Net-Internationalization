namespace MultiLang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TranslateTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Translates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Keyword = c.String(),
                        En = c.String(),
                        Az = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Translates");
        }
    }
}
