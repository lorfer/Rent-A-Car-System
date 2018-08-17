namespace GUI_MODERNISTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        TipoDocumento = c.String(nullable: false, maxLength: 15),
                        NumDocumento = c.String(nullable: false, maxLength: 13),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        Apellido = c.String(maxLength: 30),
                        Edad = c.Int(nullable: false),
                        Telefono = c.String(maxLength: 12),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
