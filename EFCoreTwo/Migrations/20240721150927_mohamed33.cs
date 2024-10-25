using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTwoN.Migrations
{
    /// <inheritdoc />
    public partial class mohamed33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnetoManyCh_OnetoManyP_OnetoManyForignKey",
                table: "OnetoManyCh");

            migrationBuilder.AddColumn<int>(
                name: "PrKey",
                table: "OnetoManyP",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OnetoManyP_PrKey",
                table: "OnetoManyP",
                column: "PrKey");

            migrationBuilder.AddForeignKey(
                name: "FK_OnetoManyCh_OnetoManyP_OnetoManyForignKey",
                table: "OnetoManyCh",
                column: "OnetoManyForignKey",
                principalTable: "OnetoManyP",
                principalColumn: "PrKey",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnetoManyCh_OnetoManyP_OnetoManyForignKey",
                table: "OnetoManyCh");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OnetoManyP_PrKey",
                table: "OnetoManyP");

            migrationBuilder.DropColumn(
                name: "PrKey",
                table: "OnetoManyP");

            migrationBuilder.AddForeignKey(
                name: "FK_OnetoManyCh_OnetoManyP_OnetoManyForignKey",
                table: "OnetoManyCh",
                column: "OnetoManyForignKey",
                principalTable: "OnetoManyP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
