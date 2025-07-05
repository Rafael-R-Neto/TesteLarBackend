using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteLar.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CPFCollunmCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Person");
        }
    }
}
