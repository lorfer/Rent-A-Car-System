namespace GUI_MODERNISTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Cedula = c.String(nullable: false, maxLength: 13),
                        Cuenta = c.String(nullable: false, maxLength: 20),
                        TipoCuenta = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 16),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        Apellido = c.String(maxLength: 30),
                        Edad = c.Int(nullable: false),
                        Telefono = c.String(maxLength: 12),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
