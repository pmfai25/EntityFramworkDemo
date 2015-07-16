namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutomaticMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Standards", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Students", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Students", "Phone", c => c.String(maxLength: 20));
            AlterColumn("dbo.Students", "Address", c => c.String(maxLength: 50));
            AlterColumn("dbo.Students", "Course", c => c.String(maxLength: 60));
            AlterColumn("dbo.Students", "Description", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Description", c => c.String());
            AlterColumn("dbo.Students", "Course", c => c.String());
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "Phone", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Standards", "Name", c => c.String());
        }
    }
}
