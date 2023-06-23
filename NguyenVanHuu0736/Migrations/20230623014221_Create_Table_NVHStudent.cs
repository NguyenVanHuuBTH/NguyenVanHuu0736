using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenVanHuu0736.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_NVHStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NVHStudent",
                columns: table => new
                {
                    NVHStudentId = table.Column<string>(type: "TEXT", nullable: false),
                    NVHStudentName = table.Column<string>(type: "TEXT", nullable: true),
                    NVHStudentDIACHI = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVHStudent", x => x.NVHStudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NVHStudent");
        }
    }
}
