using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaintenancePortal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMISNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipalFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipalLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipalEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
