using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class updatedTblGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Gendres_GenderIdId",
                table: "MovieGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gendres",
                table: "Gendres");

            migrationBuilder.RenameTable(
                name: "Gendres",
                newName: "Genres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_GenderIdId",
                table: "MovieGenres",
                column: "GenderIdId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_GenderIdId",
                table: "MovieGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Gendres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gendres",
                table: "Gendres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Gendres_GenderIdId",
                table: "MovieGenres",
                column: "GenderIdId",
                principalTable: "Gendres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
