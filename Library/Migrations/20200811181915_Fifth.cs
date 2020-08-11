using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Copy_Books_BookId",
                table: "Copy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Copy",
                table: "Copy");

            migrationBuilder.RenameTable(
                name: "Copy",
                newName: "Copies");

            migrationBuilder.RenameIndex(
                name: "IX_Copy_BookId",
                table: "Copies",
                newName: "IX_Copies_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Copies",
                table: "Copies",
                column: "CopyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Copies_Books_BookId",
                table: "Copies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Copies_Books_BookId",
                table: "Copies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Copies",
                table: "Copies");

            migrationBuilder.RenameTable(
                name: "Copies",
                newName: "Copy");

            migrationBuilder.RenameIndex(
                name: "IX_Copies_BookId",
                table: "Copy",
                newName: "IX_Copy_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Copy",
                table: "Copy",
                column: "CopyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Copy_Books_BookId",
                table: "Copy",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
