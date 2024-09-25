namespace VeriTabaniOdev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ders", "BolumId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ders", "BolumId");
            AddForeignKey("dbo.Ders", "BolumId", "dbo.Bolums", "BolumId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ders", "BolumId", "dbo.Bolums");
            DropIndex("dbo.Ders", new[] { "BolumId" });
           // DropColumn("dbo.Ders");
        }
    }
}
