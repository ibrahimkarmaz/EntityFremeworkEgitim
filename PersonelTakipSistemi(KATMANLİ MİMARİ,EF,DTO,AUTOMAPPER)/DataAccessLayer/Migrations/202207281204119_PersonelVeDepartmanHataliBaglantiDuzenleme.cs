namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonelVeDepartmanHataliBaglantiDuzenleme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Personels", "Departmans_ID", "dbo.Departmen");
            DropIndex("dbo.Personels", new[] { "Departmans_ID" });
            RenameColumn(table: "dbo.Personels", name: "Departmans_ID", newName: "DepartmanID");
            AlterColumn("dbo.Personels", "DepartmanID", c => c.Int(nullable: false));
            CreateIndex("dbo.Personels", "DepartmanID");
            AddForeignKey("dbo.Personels", "DepartmanID", "dbo.Departmen", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "DepartmanID", "dbo.Departmen");
            DropIndex("dbo.Personels", new[] { "DepartmanID" });
            AlterColumn("dbo.Personels", "DepartmanID", c => c.Int());
            RenameColumn(table: "dbo.Personels", name: "DepartmanID", newName: "Departmans_ID");
            CreateIndex("dbo.Personels", "Departmans_ID");
            AddForeignKey("dbo.Personels", "Departmans_ID", "dbo.Departmen", "ID");
        }
    }
}
