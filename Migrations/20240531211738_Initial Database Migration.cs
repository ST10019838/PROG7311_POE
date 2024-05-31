using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10019838_DamianDare_PROG7311_POE.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO Products (Name, Type, Category, Description, Price, Quantity, ProductionDate, DateCreated, User_Id )" +
                "VALUES ('Beef', 'Food', 'Meat', 'Just some consumable food', 18, 200, GETDATE(), GETDATE(), 'auth0|665a3b6b0d4f202d25d6b45a');");

            migrationBuilder.Sql("INSERT INTO Products (Name, Type, Category, Description, Price, Quantity, ProductionDate, DateCreated, User_Id )" +
                "VALUES ('Corn', 'Food', 'Vegetable', 'Just some more consumable food', 10, 500, GETDATE(), GETDATE(), 'auth0|665a3b6b0d4f202d25d6b45a');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
