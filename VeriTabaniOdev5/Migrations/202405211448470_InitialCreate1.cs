namespace VeriTabaniOdev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bolums",
                c => new
                    {
                        BolumId = c.Int(nullable: false, identity: true),
                        BolumAd = c.String(),
                        FakulteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BolumId)
                .ForeignKey("dbo.Fakultes", t => t.FakulteId, cascadeDelete: true)
                .Index(t => t.FakulteId);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        OgrenciId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        BolumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgrenciId)
                .ForeignKey("dbo.Bolums", t => t.BolumId, cascadeDelete: true)
                .Index(t => t.BolumId);
            
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        OgrenciDersId = c.Int(nullable: false, identity: true),
                        OgrenciId = c.Int(nullable: false),
                        DersId = c.Int(nullable: false),
                        Yil = c.Int(nullable: false),
                        YariYil = c.Int(nullable: false),
                        Vize = c.Int(nullable: false),
                        Final = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgrenciDersId)
                .ForeignKey("dbo.Ders", t => t.DersId, cascadeDelete: true)
                .ForeignKey("dbo.Ogrencis", t => t.OgrenciId, cascadeDelete: true)
                .Index(t => t.OgrenciId)
                .Index(t => t.DersId);
            
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        DersId = c.Int(nullable: false, identity: true),
                        DersAd = c.String(),
                    })
                .PrimaryKey(t => t.DersId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciDers", "OgrenciId", "dbo.Ogrencis");
            DropForeignKey("dbo.OgrenciDers", "DersId", "dbo.Ders");
            DropForeignKey("dbo.Ogrencis", "BolumId", "dbo.Bolums");
            DropForeignKey("dbo.Bolums", "FakulteId", "dbo.Fakultes");
            DropIndex("dbo.OgrenciDers", new[] { "DersId" });
            DropIndex("dbo.OgrenciDers", new[] { "OgrenciId" });
            DropIndex("dbo.Ogrencis", new[] { "BolumId" });
            DropIndex("dbo.Bolums", new[] { "FakulteId" });
            DropTable("dbo.Ders");
            DropTable("dbo.OgrenciDers");
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Bolums");
        }
    }
}
