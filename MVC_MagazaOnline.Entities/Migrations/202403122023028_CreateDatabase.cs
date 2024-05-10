namespace MVC_MagazaOnline.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Duyurulars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Duyuru = c.String(),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hakkimizdas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sirket = c.String(),
                        Adres = c.String(),
                        Aciklama = c.String(),
                        KurucuBilgileri = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Iletisims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TelNumara = c.Int(nullable: false),
                        SirketIsmi = c.String(),
                        Adres = c.String(),
                        Mesaj = c.String(),
                        GonderenIsim = c.String(),
                        GonderenMail = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            
            
            CreateTable(
                "dbo.Kategorilers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KiyafetKategori = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kiyafetlers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndirimId = c.Int(nullable: false),
                        BarkodNo = c.String(),
                        KiyafetKategoriId = c.Int(nullable: false),
                        KiyafetAdi = c.String(),
                        Marka = c.String(),
                        Stok = c.Int(nullable: false),
                        Fiyat = c.Int(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        SilindiMi = c.Boolean(nullable: false),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KullaniciHareketleris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanicilars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        AdSoyad = c.String(),
                        Telefon = c.String(),
                        Adres = c.String(),
                        Email = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KullaniciRolleris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rollers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Satislars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        KiyafetId = c.Int(nullable: false),
                        IndirimId = c.Int(nullable: false),
                        Aciklama = c.String(),
                        SatinAldigiTarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Satislars");
            DropTable("dbo.Rollers");
            DropTable("dbo.KullaniciRolleris");
            DropTable("dbo.Kullanicilars");
            DropTable("dbo.KullaniciHareketleris");
            DropTable("dbo.Kiyafetlers");
            DropTable("dbo.Kategorilers");
            
            DropTable("dbo.Iletisims");
            DropTable("dbo.Hakkimizdas");
            DropTable("dbo.Duyurulars");
        }
    }
}
