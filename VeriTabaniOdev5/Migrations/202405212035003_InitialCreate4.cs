namespace VeriTabaniOdev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bolums", "BolumAd", c => c.String(nullable: false));
            AlterColumn("dbo.Ogrencis", "Ad", c => c.String(nullable: false));
            AlterColumn("dbo.Ders", "DersAd", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ders", "DersAd", c => c.String());
            AlterColumn("dbo.Ogrencis", "Ad", c => c.String());
            AlterColumn("dbo.Bolums", "BolumAd", c => c.String());
        }
    }
}
