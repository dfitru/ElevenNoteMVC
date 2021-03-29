namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Content = c.String(nullable: false),
                        CreateUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.NoteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Note");
        }
    }
}
