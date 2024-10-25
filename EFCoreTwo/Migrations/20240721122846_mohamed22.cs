using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTwoN.Migrations
{
    /// <inheritdoc />
    public partial class mohamed22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OnetoManyP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnetoManyP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnetoManyCh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnetoManyForignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnetoManyCh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnetoManyCh_OnetoManyP_OnetoManyForignKey",
                        column: x => x.OnetoManyForignKey,
                        principalTable: "OnetoManyP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OnetoManyCh_OnetoManyForignKey",
                table: "OnetoManyCh",
                column: "OnetoManyForignKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnetoManyCh");

            migrationBuilder.DropTable(
                name: "OnetoManyP");
        }
    }
}
