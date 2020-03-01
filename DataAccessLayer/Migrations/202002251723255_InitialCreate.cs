namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Color = c.String(),
                        Name = c.String(),
                        ManufactoryId = c.Int(nullable: false),
                        CarTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufactories", t => t.ManufactoryId, cascadeDelete: true)
                .Index(t => t.ManufactoryId);
            
            CreateTable(
                "dbo.Detals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Price = c.Int(nullable: false),
                        Name = c.String(),
                        DetalTypeId = c.Int(nullable: false),
                        Car_Id = c.Int(),
                        Manufactory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetalTypes", t => t.DetalTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .ForeignKey("dbo.Manufactories", t => t.Manufactory_Id)
                .Index(t => t.DetalTypeId)
                .Index(t => t.Car_Id)
                .Index(t => t.Manufactory_Id);
            
            CreateTable(
                "dbo.DetalTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manufactories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LicenseNumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ManufactoryId", "dbo.Manufactories");
            DropForeignKey("dbo.Detals", "Manufactory_Id", "dbo.Manufactories");
            DropForeignKey("dbo.Detals", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Detals", "DetalTypeId", "dbo.DetalTypes");
            DropIndex("dbo.Detals", new[] { "Manufactory_Id" });
            DropIndex("dbo.Detals", new[] { "Car_Id" });
            DropIndex("dbo.Detals", new[] { "DetalTypeId" });
            DropIndex("dbo.Cars", new[] { "ManufactoryId" });
            DropTable("dbo.Manufactories");
            DropTable("dbo.DetalTypes");
            DropTable("dbo.Detals");
            DropTable("dbo.Cars");
        }
    }
}
