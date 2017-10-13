namespace imageform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newformTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Forms", "Image", c => c.String());
            AlterColumn("dbo.Forms", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Forms", "DOB", c => c.String());
            DropColumn("dbo.Forms", "Image");
        }
    }
}
