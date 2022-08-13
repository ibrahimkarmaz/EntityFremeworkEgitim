namespace OrnekEF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBOlusturma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calismas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Konu = c.String(),
                        icerik = c.String(),
                        PersonelVerenId = c.Int(),
                        PersonelAlanId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Personels", t => t.PersonelVerenId)
                .ForeignKey("dbo.Personels", t => t.PersonelAlanId)
                .Index(t => t.PersonelVerenId)
                .Index(t => t.PersonelAlanId);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Cinsiyet = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calismas", "PersonelAlanId", "dbo.Personels");
            DropForeignKey("dbo.Calismas", "PersonelVerenId", "dbo.Personels");
            DropIndex("dbo.Calismas", new[] { "PersonelAlanId" });
            DropIndex("dbo.Calismas", new[] { "PersonelVerenId" });
            DropTable("dbo.Personels");
            DropTable("dbo.Calismas");
        }
    }
}
