using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SourcingAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sourcinghandover",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SAPCode = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DrawingRevision = table.Column<string>(type: "text", nullable: true),
                    Commodity = table.Column<string>(type: "text", nullable: true),
                    Supplier = table.Column<string>(type: "text", nullable: true),
                    BuyerCST = table.Column<string>(type: "text", nullable: true),
                    ApplicationProduct = table.Column<string>(type: "text", nullable: true),
                    CustomerCode = table.Column<string>(type: "text", nullable: true),
                    IsirDocuments = table.Column<bool>(type: "boolean", nullable: false),
                    PpapDocument = table.Column<bool>(type: "boolean", nullable: false),
                    CostingSheet = table.Column<bool>(type: "boolean", nullable: false),
                    ToolCostStatus = table.Column<string>(type: "text", nullable: true),
                    DualSource = table.Column<bool>(type: "boolean", nullable: false),
                    SaReleasedNumber = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sourcinghandover", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sourcinghandover");
        }
    }
}
