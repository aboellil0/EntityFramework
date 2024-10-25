using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTwoN.Migrations
{
    /// <inheritdoc />
    public partial class mohamed66 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "MohamedSeq");

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seq",
                columns: table => new
                {
                    SeqID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeqName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeqNumber = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR MohamedSeq")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seq", x => x.SeqID);
                });

            migrationBuilder.CreateIndex(
                name: "Mohamed_Index",
                table: "Blog",
                column: "Url",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Seq");

            migrationBuilder.DropSequence(
                name: "MohamedSeq");
        }
    }
}
