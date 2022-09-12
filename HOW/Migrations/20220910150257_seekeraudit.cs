using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HOW.Migrations
{
    public partial class seekeraudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Seeker",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Seeker",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Seeker",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedDate",
                table: "Seeker",
                type: "varchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Seeker");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Seeker");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Seeker");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Seeker");
        }
    }
}
