namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groomers",
                c => new
                    {
                        GroomerId = c.Int(nullable: false, identity: true),
                        GroomerFName = c.String(),
                        GroomerLName = c.String(),
                        GroomerDob = c.String(),
                        GroomerPhone = c.String(),
                    })
                .PrimaryKey(t => t.GroomerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groomers");
        }
    }
}
