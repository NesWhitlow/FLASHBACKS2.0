namespace FLASHBACKS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exercise4Migration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Description", c => c.String());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.Int(nullable: false));
        }
    }
}
