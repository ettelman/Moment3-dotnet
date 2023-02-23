using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moment3_dotnet.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CdId",
                table: "Cd");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CdId",
                table: "Cd",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
