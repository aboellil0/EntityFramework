using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTwoN.Migrations
{
    /// <inheritdoc />
    public partial class mohamed44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManytoManyCh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManytoManyCh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManytoManyP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManytoManyP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManytoMany",
                columns: table => new
                {
                    manytoManyChesId = table.Column<int>(type: "int", nullable: false),
                    manytoManyPsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManytoMany", x => new { x.manytoManyChesId, x.manytoManyPsId });
                    table.ForeignKey(
                        name: "FK_ManytoMany_ManytoManyCh_manytoManyChesId",
                        column: x => x.manytoManyChesId,
                        principalTable: "ManytoManyCh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManytoMany_ManytoManyP_manytoManyPsId",
                        column: x => x.manytoManyPsId,
                        principalTable: "ManytoManyP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManytoMany_manytoManyPsId",
                table: "ManytoMany",
                column: "manytoManyPsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManytoMany");

            migrationBuilder.DropTable(
                name: "ManytoManyCh");

            migrationBuilder.DropTable(
                name: "ManytoManyP");
        }
    }
}
