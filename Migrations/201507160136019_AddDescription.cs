namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Description", c => c.String());
            Sql("UPDATE dbo.Students SET Description = 'None' WHERE Description IS NULL");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Description");
        }

    }
}
