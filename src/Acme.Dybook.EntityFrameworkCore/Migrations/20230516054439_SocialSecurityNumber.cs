using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Dybook.Migrations
{
    /// <inheritdoc />
    public partial class SocialSecurityNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SocialSecurityNumber",
                table: "AbpUsers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialSecurityNumber",
                table: "AbpUsers");
        }
    }
}
