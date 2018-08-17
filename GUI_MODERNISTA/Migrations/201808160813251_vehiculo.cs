namespace GUI_MODERNISTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vehiculo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehiculoes",
                c => new
                    {
                        IdVehiculo = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 10),
                        Marca = c.String(nullable: false, maxLength: 10),
                        Modelo = c.String(nullable: false, maxLength: 10),
                        CapPasajero = c.Int(nullable: false),
                        Transmision = c.String(nullable: false, maxLength: 15),
                        Combustible = c.String(nullable: false, maxLength: 15),
                        PrecioAlquiler = c.Double(nullable: false),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdVehiculo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehiculoes");
        }
    }
}
