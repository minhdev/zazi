namespace zazi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_require_name : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NoteEntries", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NoteEntries", "Name", c => c.String());
        }
    }
}
