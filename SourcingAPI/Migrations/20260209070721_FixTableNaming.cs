using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SourcingAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixTableNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MasterRoles",
                table: "MasterRoles");

            migrationBuilder.RenameTable(
                name: "MasterRoles",
                newName: "MasterRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MasterRole",
                table: "MasterRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MasterRole",
                table: "MasterRole");

            migrationBuilder.RenameTable(
                name: "MasterRole",
                newName: "MasterRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MasterRoles",
                table: "MasterRoles",
                column: "RoleId");
        }
    }
}
