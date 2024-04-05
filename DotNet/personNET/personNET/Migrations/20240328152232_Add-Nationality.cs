using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace personNET.Migrations
{
    public partial class AddNationality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_persons_NationalityId",
                table: "persons",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_Nationality_NationalityId",
                table: "persons",
                column: "NationalityId",
                principalTable: "Nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persons_Nationality_NationalityId",
                table: "persons");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropIndex(
                name: "IX_persons_NationalityId",
                table: "persons");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "persons");
        }
    }
}
