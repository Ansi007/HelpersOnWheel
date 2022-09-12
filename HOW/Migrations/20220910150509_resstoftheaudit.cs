using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HOW.Migrations
{
    public partial class resstoftheaudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Question",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Question",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Question",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedDate",
                table: "Question",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Helper",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Helper",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Helper",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedDate",
                table: "Helper",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Answer",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Answer",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Answer",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedDate",
                table: "Answer",
                type: "varchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Helper");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Helper");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Helper");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Helper");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Answer");
        }
    }
}
