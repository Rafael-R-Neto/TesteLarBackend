using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteLar.Infra.Migrations
{
    /// <inheritdoc />
    public partial class DeletedCollunmCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IActive",
                table: "PhoneType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PhoneType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IActive",
                table: "Phone",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Phone",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IActive",
                table: "Person",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Person",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IActive",
                table: "PhoneType");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PhoneType");

            migrationBuilder.DropColumn(
                name: "IActive",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "IActive",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Person");
        }
    }
}
