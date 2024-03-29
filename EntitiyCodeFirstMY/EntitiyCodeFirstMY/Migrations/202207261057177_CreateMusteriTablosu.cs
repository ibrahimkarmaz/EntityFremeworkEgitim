﻿namespace EntitiyCodeFirstMY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteriTablosu : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Musteris");
        }
        
        public override void Down()
        {
            CreateTable(
                 "dbo.Musteris",
                 c => new
                 {
                     MusteriID = c.Int(nullable: false, identity: true),
                     MusteriAd = c.String(),
                     MusteriSoyad = c.String(),
                 })
                 .PrimaryKey(t => t.MusteriID);
        }
    }
}
