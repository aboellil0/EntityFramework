using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTwoN.Migrations
{
    /// <inheritdoc />
    public partial class mohamed77 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataToSends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataToSends", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DataToSends",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "aboellil", "mohamed" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataToSends");
        }
    }
}
