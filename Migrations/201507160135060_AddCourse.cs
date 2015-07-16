namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Course", c => c.String());
            Sql("UPDATE dbo.Students SET Course = 'FIT-1001' WHERE Course IS NULL");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Course");
        }
    }
}
