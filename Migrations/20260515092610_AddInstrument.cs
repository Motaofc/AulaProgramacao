using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace a14468_employes_management.Migrations
{
    /// <inheritdoc />
    public partial class AddInstrument : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoInstrumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeInstrumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsaCordas = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instruments");
        }
    }
}
