namespace EntitiyCodeFirstMY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteUrunKategoriColumnInUrunlers : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Urunlers", "UrunKategori");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunlers", "UrunKategori", c => c.String());
        }
    }
}
