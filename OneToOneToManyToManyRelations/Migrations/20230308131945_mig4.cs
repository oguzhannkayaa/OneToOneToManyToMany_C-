using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OneToOneToManyToManyRelations.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeesDA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeName = table.Column<string>(type: "text", nullable: false),
                    EmployeeAddressId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesDA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesDA_EmployeeAddresses_EmployeeAddressId",
                        column: x => x.EmployeeAddressId,
                        principalTable: "EmployeeAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAddressesDA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAddressesDA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAddressesDA_EmployeesDA_Id",
                        column: x => x.Id,
                        principalTable: "EmployeesDA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesDA_EmployeeAddressId",
                table: "EmployeesDA",
                column: "EmployeeAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAddressesDA");

            migrationBuilder.DropTable(
                name: "EmployeesDA");
        }
    }
}
