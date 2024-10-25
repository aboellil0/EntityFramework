using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTwoN.Migrations
{
    /// <inheritdoc />
    public partial class mohamed11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OneToOneP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneToOneP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OneToOneCh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentForignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneToOneCh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OneToOneCh_OneToOneP_ParentForignKey",
                        column: x => x.ParentForignKey,
                        principalTable: "OneToOneP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OneToOneCh_ParentForignKey",
                table: "OneToOneCh",
                column: "ParentForignKey",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OneToOneCh");

            migrationBuilder.DropTable(
                name: "OneToOneP");
        }
    }
}
